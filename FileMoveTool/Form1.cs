using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileMoveTool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ConcurrentBag<System.IO.FileInfo> TargetFileInfos { get; set; }

        int copyFileCountSuccess { get; set; }
        int copyFileCountFail { get; set; }

        int deleteFileCountSuccess { get; set; }
        int deleteFileCountFail { get; set; }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSourceFrom_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK)
                {
                    lblSource.Text = fbd.SelectedPath;
                }

            }
        }



        private void btnPreScan_Click(object sender, EventArgs e)
        {
            listTargetFilesInfo.Items.Clear();
            TargetFileInfos = new ConcurrentBag<System.IO.FileInfo>();

            GC.Collect();

            if (lblSource.Text.Length <= 1)
            {
                MessageBox.Show("Please Select Soruce Directory", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            try
            {
                System.IO.DirectoryInfo SourceDI = new System.IO.DirectoryInfo(lblSource.Text);

                var files = SourceDI.GetFiles();

                var baseDate = dateTimePickerBase.Value.AddDays(1).AddMilliseconds(-1);

                var i = 0;

                Parallel.ForEach(files, (fileInfo) =>
                {
                    var lastWriteDate = System.IO.File.GetLastWriteTime(fileInfo.FullName);
                    if (lastWriteDate <= baseDate)
                    {
                        i++;
                        listTargetFilesInfo.Items.Add(fileInfo.FullName);
                        TargetFileInfos.Add(fileInfo);
                    }
                   
                });


                lblPreview.Text = TargetFileInfos.Count.ToString() + " Files Matches";


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK)
                {
                    lblTargetDirectory.Text = fbd.SelectedPath;
                }

            }
        }

        private void btnExcute_Click(object sender, EventArgs e)
        {

            lblStatus.Text = "-";
            lblStatus2.Text = "-";
            if (cbCopy.Checked)
            {
                if (lblTargetDirectory.Text.Length <= 1)
                {
                    MessageBox.Show("Please Select Target Directory", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            if (listTargetFilesInfo.Items.Count <= 0)
            {
                MessageBox.Show("Please Scan Soruce Directory", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if (lblSource.Text == lblTargetDirectory.Text)
            {
                MessageBox.Show("Souce and Target could not be the same.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }

            if (!cbCopy.Checked && !cbDelete.Checked)
            {
                MessageBox.Show("Please Select Copy or Delete Action", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            this.btnExcute.Enabled = false;

            if (cbCopy.Checked)
            {
                backgroundWorkerCopy.RunWorkerAsync();
            }
            else if (!cbCopy.Checked && cbDelete.Checked)
            {
                backgroundWorkerDelete.RunWorkerAsync();
            }


        }



        private void backgroundWorkerCopy_DoWork(object sender, DoWorkEventArgs e)
        {

            copyFileCountSuccess = 0;
            copyFileCountFail = 0;
            BackgroundWorker worker = sender as BackgroundWorker;

            Parallel.ForEach(TargetFileInfos, (fileInfo) =>
            {
                try
                {
                    System.IO.File.Copy(fileInfo.FullName, lblTargetDirectory.Text + System.IO.Path.DirectorySeparatorChar + fileInfo.Name, true);
                    copyFileCountSuccess++;
                    worker.ReportProgress(copyFileCountSuccess);
                }
                catch
                {
                    copyFileCountFail++;
                }
            });

            MessageBox.Show("Success Copy " + copyFileCountSuccess + " files, " + copyFileCountFail + " files fail .", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);


            if (!cbDelete.Checked)
            {
                this.btnExcute.Enabled = true;

                return;
            }




            backgroundWorkerDelete.RunWorkerAsync();


        }

        private void backgroundWorkerCopy_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

            lblStatus.Text = "Copy Files: " + e.ProgressPercentage.ToString() + "/" + TargetFileInfos.Count;
        }

        private void backgroundWorkerDelete_DoWork(object sender, DoWorkEventArgs e)
        {
            deleteFileCountSuccess = 0;
            deleteFileCountFail = 0;
            BackgroundWorker worker = sender as BackgroundWorker;

            Parallel.ForEach(TargetFileInfos, (fileInfo) =>
            {
                try
                {
                    System.IO.File.Delete(fileInfo.FullName);
                    deleteFileCountSuccess++;
                    worker.ReportProgress(deleteFileCountSuccess);
                }
                catch
                {
                    deleteFileCountFail++;
                }
            });

            this.btnExcute.Enabled = true;

            MessageBox.Show("Success Delete " + deleteFileCountSuccess + " files, " + deleteFileCountFail + " files fail .", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);


            listTargetFilesInfo.Items.Clear();

        }

        private void backgroundWorkerDelete_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            lblStatus2.Text = "Deleted Files: " + e.ProgressPercentage.ToString() + "/" + TargetFileInfos.Count;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
