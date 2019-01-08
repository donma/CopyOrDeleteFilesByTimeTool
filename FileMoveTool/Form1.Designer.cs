namespace FileMoveTool
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSourceFrom = new System.Windows.Forms.Button();
            this.lblSource = new System.Windows.Forms.Label();
            this.btnPreScan = new System.Windows.Forms.Button();
            this.lblPreview = new System.Windows.Forms.Label();
            this.dateTimePickerBase = new System.Windows.Forms.DateTimePicker();
            this.listTargetFilesInfo = new System.Windows.Forms.ListBox();
            this.cbCopy = new System.Windows.Forms.CheckBox();
            this.cbDelete = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblTargetDirectory = new System.Windows.Forms.Label();
            this.btnExcute = new System.Windows.Forms.Button();
            this.backgroundWorkerCopy = new System.ComponentModel.BackgroundWorker();
            this.lblStatus = new System.Windows.Forms.Label();
            this.backgroundWorkerDelete = new System.ComponentModel.BackgroundWorker();
            this.lblStatus2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSourceFrom
            // 
            this.btnSourceFrom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSourceFrom.Location = new System.Drawing.Point(6, 6);
            this.btnSourceFrom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSourceFrom.Name = "btnSourceFrom";
            this.btnSourceFrom.Size = new System.Drawing.Size(294, 24);
            this.btnSourceFrom.TabIndex = 0;
            this.btnSourceFrom.Text = "1. Select Souce From Directory";
            this.btnSourceFrom.UseVisualStyleBackColor = true;
            this.btnSourceFrom.Click += new System.EventHandler(this.btnSourceFrom_Click);
            // 
            // lblSource
            // 
            this.lblSource.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSource.AutoSize = true;
            this.lblSource.Location = new System.Drawing.Point(6, 36);
            this.lblSource.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSource.Name = "lblSource";
            this.lblSource.Size = new System.Drawing.Size(165, 16);
            this.lblSource.TabIndex = 1;
            this.lblSource.Text = "\\\\Mac\\Home\\Pictures\\Snap";
            // 
            // btnPreScan
            // 
            this.btnPreScan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPreScan.Location = new System.Drawing.Point(190, 62);
            this.btnPreScan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPreScan.Name = "btnPreScan";
            this.btnPreScan.Size = new System.Drawing.Size(109, 26);
            this.btnPreScan.TabIndex = 2;
            this.btnPreScan.Text = "2. Scan";
            this.btnPreScan.UseVisualStyleBackColor = true;
            this.btnPreScan.Click += new System.EventHandler(this.btnPreScan_Click);
            // 
            // lblPreview
            // 
            this.lblPreview.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPreview.AutoSize = true;
            this.lblPreview.Location = new System.Drawing.Point(6, 94);
            this.lblPreview.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPreview.Name = "lblPreview";
            this.lblPreview.Size = new System.Drawing.Size(13, 16);
            this.lblPreview.TabIndex = 3;
            this.lblPreview.Text = "-";
            // 
            // dateTimePickerBase
            // 
            this.dateTimePickerBase.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerBase.Location = new System.Drawing.Point(6, 62);
            this.dateTimePickerBase.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePickerBase.Name = "dateTimePickerBase";
            this.dateTimePickerBase.Size = new System.Drawing.Size(178, 23);
            this.dateTimePickerBase.TabIndex = 4;
            // 
            // listTargetFilesInfo
            // 
            this.listTargetFilesInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listTargetFilesInfo.FormattingEnabled = true;
            this.listTargetFilesInfo.ItemHeight = 16;
            this.listTargetFilesInfo.Location = new System.Drawing.Point(302, 6);
            this.listTargetFilesInfo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listTargetFilesInfo.Name = "listTargetFilesInfo";
            this.listTargetFilesInfo.Size = new System.Drawing.Size(380, 388);
            this.listTargetFilesInfo.TabIndex = 5;
            // 
            // cbCopy
            // 
            this.cbCopy.AutoSize = true;
            this.cbCopy.Location = new System.Drawing.Point(9, 215);
            this.cbCopy.Name = "cbCopy";
            this.cbCopy.Size = new System.Drawing.Size(57, 20);
            this.cbCopy.TabIndex = 6;
            this.cbCopy.Text = "Copy";
            this.cbCopy.UseVisualStyleBackColor = true;
            // 
            // cbDelete
            // 
            this.cbDelete.AutoSize = true;
            this.cbDelete.Location = new System.Drawing.Point(9, 241);
            this.cbDelete.Name = "cbDelete";
            this.cbDelete.Size = new System.Drawing.Size(106, 20);
            this.cbDelete.TabIndex = 6;
            this.cbDelete.Text = "Delete Source";
            this.cbDelete.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 143);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(288, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "3. Select Copy Target Directory ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblTargetDirectory
            // 
            this.lblTargetDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTargetDirectory.AutoSize = true;
            this.lblTargetDirectory.Location = new System.Drawing.Point(6, 173);
            this.lblTargetDirectory.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTargetDirectory.Name = "lblTargetDirectory";
            this.lblTargetDirectory.Size = new System.Drawing.Size(13, 16);
            this.lblTargetDirectory.TabIndex = 8;
            this.lblTargetDirectory.Text = "-";
            // 
            // btnExcute
            // 
            this.btnExcute.Location = new System.Drawing.Point(6, 278);
            this.btnExcute.Name = "btnExcute";
            this.btnExcute.Size = new System.Drawing.Size(288, 23);
            this.btnExcute.TabIndex = 7;
            this.btnExcute.Text = "4. Excute Action";
            this.btnExcute.UseVisualStyleBackColor = true;
            this.btnExcute.Click += new System.EventHandler(this.btnExcute_Click);
            // 
            // backgroundWorkerCopy
            // 
            this.backgroundWorkerCopy.WorkerReportsProgress = true;
            this.backgroundWorkerCopy.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerCopy_DoWork);
            this.backgroundWorkerCopy.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorkerCopy_ProgressChanged);
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(6, 304);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(13, 16);
            this.lblStatus.TabIndex = 9;
            this.lblStatus.Text = "-";
            // 
            // backgroundWorkerDelete
            // 
            this.backgroundWorkerDelete.WorkerReportsProgress = true;
            this.backgroundWorkerDelete.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerDelete_DoWork);
            this.backgroundWorkerDelete.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorkerDelete_ProgressChanged);
            // 
            // lblStatus2
            // 
            this.lblStatus2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStatus2.AutoSize = true;
            this.lblStatus2.Location = new System.Drawing.Point(6, 325);
            this.lblStatus2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStatus2.Name = "lblStatus2";
            this.lblStatus2.Size = new System.Drawing.Size(13, 16);
            this.lblStatus2.TabIndex = 10;
            this.lblStatus2.Text = "-";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(686, 400);
            this.Controls.Add(this.lblStatus2);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblTargetDirectory);
            this.Controls.Add(this.btnExcute);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbDelete);
            this.Controls.Add(this.cbCopy);
            this.Controls.Add(this.listTargetFilesInfo);
            this.Controls.Add(this.dateTimePickerBase);
            this.Controls.Add(this.lblPreview);
            this.Controls.Add(this.btnPreScan);
            this.Controls.Add(this.lblSource);
            this.Controls.Add(this.btnSourceFrom);
            this.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FileMoveTool";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSourceFrom;
        private System.Windows.Forms.Label lblSource;
        private System.Windows.Forms.Button btnPreScan;
        private System.Windows.Forms.Label lblPreview;
        private System.Windows.Forms.DateTimePicker dateTimePickerBase;
        private System.Windows.Forms.ListBox listTargetFilesInfo;
        private System.Windows.Forms.CheckBox cbCopy;
        private System.Windows.Forms.CheckBox cbDelete;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblTargetDirectory;
        private System.Windows.Forms.Button btnExcute;
        private System.ComponentModel.BackgroundWorker backgroundWorkerCopy;
        private System.Windows.Forms.Label lblStatus;
        private System.ComponentModel.BackgroundWorker backgroundWorkerDelete;
        private System.Windows.Forms.Label lblStatus2;
    }
}

