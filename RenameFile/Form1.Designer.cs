namespace RenameFile
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.folderPath = new System.Windows.Forms.TextBox();
            this.selectFolder = new System.Windows.Forms.Button();
            this.searchFor = new System.Windows.Forms.TextBox();
            this.replaceWith = new System.Windows.Forms.TextBox();
            this.replace = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // folderPath
            // 
            this.folderPath.Location = new System.Drawing.Point(13, 13);
            this.folderPath.Name = "folderPath";
            this.folderPath.Size = new System.Drawing.Size(220, 20);
            this.folderPath.TabIndex = 0;
            this.folderPath.Text = "Enter folder path";
            // 
            // selectFolder
            // 
            this.selectFolder.Location = new System.Drawing.Point(252, 11);
            this.selectFolder.Name = "selectFolder";
            this.selectFolder.Size = new System.Drawing.Size(75, 23);
            this.selectFolder.TabIndex = 1;
            this.selectFolder.Text = "Select folder";
            this.selectFolder.UseVisualStyleBackColor = true;
            this.selectFolder.Click += new System.EventHandler(this.selectFolder_Click);
            // 
            // searchFor
            // 
            this.searchFor.Location = new System.Drawing.Point(13, 62);
            this.searchFor.Name = "searchFor";
            this.searchFor.Size = new System.Drawing.Size(100, 20);
            this.searchFor.TabIndex = 2;
            this.searchFor.Text = "Search for";
            // 
            // replaceWith
            // 
            this.replaceWith.Location = new System.Drawing.Point(13, 99);
            this.replaceWith.Name = "replaceWith";
            this.replaceWith.Size = new System.Drawing.Size(100, 20);
            this.replaceWith.TabIndex = 3;
            this.replaceWith.Text = "Replace with";
            // 
            // replace
            // 
            this.replace.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.replace.Location = new System.Drawing.Point(13, 226);
            this.replace.Name = "replace";
            this.replace.Size = new System.Drawing.Size(314, 23);
            this.replace.TabIndex = 4;
            this.replace.Text = "Replace";
            this.replace.UseVisualStyleBackColor = true;
            this.replace.Click += new System.EventHandler(this.replace_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(12, 178);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(314, 23);
            this.progressBar.TabIndex = 5;
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.WorkerReportsProgress = true;
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            this.backgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_ProgressChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 261);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.replace);
            this.Controls.Add(this.replaceWith);
            this.Controls.Add(this.searchFor);
            this.Controls.Add(this.selectFolder);
            this.Controls.Add(this.folderPath);
            this.Name = "Form1";
            this.Text = "Rename files";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox folderPath;
        private System.Windows.Forms.Button selectFolder;
        private System.Windows.Forms.TextBox searchFor;
        private System.Windows.Forms.TextBox replaceWith;
        private System.Windows.Forms.Button replace;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
    }
}

