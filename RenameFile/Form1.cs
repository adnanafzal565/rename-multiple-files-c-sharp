using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace RenameFile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            folderPath.Text = "E:\\Photos\\Other photos\\agamotto_eye";
            searchFor.Text = "agamotto_eye_00";
            replaceWith.Text = "agamotto_eye_";
        }

        private void selectFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog FolderBrowserDialog = new FolderBrowserDialog();
            if (FolderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                folderPath.Text = FolderBrowserDialog.SelectedPath;
            }
        }

        private void replace_Click(object sender, EventArgs e)
        {
            backgroundWorker.RunWorkerAsync();
        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            String SearchFor = searchFor.Text.ToString();
            String ReplaceWith = replaceWith.Text.ToString();
            String directory = folderPath.Text.ToString();

            DirectoryInfo d = new DirectoryInfo(directory);
            FileInfo[] Files = d.GetFiles("*");

            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo
            {
                WorkingDirectory = directory,
                WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal,
                FileName = "cmd.exe"
            };

            string str = "";
            double counter = 1;
            foreach (FileInfo file in Files)
            {
                double value = (counter / Files.Length) * 100;
                //MessageBox.Show("(" + counter + " / " + Files.Length + ") * " + 100 + " = " + value);
                backgroundWorker.ReportProgress((int) value);
                String newFileName = file.Name.Replace(SearchFor, ReplaceWith);
                String command = "ren " + file.Name + " " + newFileName;

                startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                startInfo.Arguments = "/C " + command;
                process.StartInfo = startInfo;
                process.Start();

                str = str + ", " + newFileName;
                counter++;
            }
            MessageBox.Show("Files has been renamed", "Operation completed");
        }

        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar.Value = e.ProgressPercentage;
            this.Text = e.ProgressPercentage.ToString();

            if (e.ProgressPercentage >= 100)
            {
                this.Text = "Rename files";
            }
        }
    }
}
