using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace foto_select
{
    public partial class Form1 : Form
    {


        const string fileTypes = "*.jpg,*.jpe,*.jpeg";

        string originFolder;
        string destinationFolder1;
        string destinationFolder2;

        List<string> lstFiles;
        List<string>.Enumerator fileEnumerator;

        public Form1()
        {
            InitializeComponent();
            //Register Handler for key presses
            this.KeyDown += new KeyEventHandler(Form1_KeyDown);
        }

        #region Behaviour
        //Handler for key presses
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            bool result;
            switch (e.KeyData)
            {
                case Keys.Space:
                    LoadNextImage();
                    break;
                case Keys.D1:
                    result = CopyImage(destinationFolder1);
                    UpdateLabelColor(result, statusLabelDestFolder1);
                    break;
                case Keys.D2:
                    result = CopyImage(destinationFolder2);
                    UpdateLabelColor(result, statusLabelDestFolder2);
                    break;
                default:
                    break;
            }
        }

        private void SelectOriginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    originFolder = fbd.SelectedPath;
                    statusLabelOriginFolder.Text = "O:" + originFolder;

                    var nfiles = FindFiles(originFolder, fileTypes);
                    statusLabelFileCounter.Text = $"1/{nfiles}";

                    LoadNextImage();
                }
            }
        }

        private void LoadNextImage()
        {
            if (fileEnumerator.MoveNext())
            {
                pictureBox1.ImageLocation = fileEnumerator.Current;
                statusLabelCurFile.Text = fileEnumerator.Current;
                ResetLabelColor();
            }
            else
            {
                MessageBox.Show("No more images");
            }
        }

        private void selectDest1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    destinationFolder1 = fbd.SelectedPath;
                    statusLabelDestFolder1.Text = "D1:" + destinationFolder1;
                }
            }
        }

        private void selectDest2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    destinationFolder2 = fbd.SelectedPath;
                    statusLabelDestFolder2.Text = "D2:" + destinationFolder2;
                }
            }
        }

        #endregion behaviour
        #region File Handling

        private bool CopyImage(string destFolder)
        {
            if (String.IsNullOrEmpty(destFolder)) return false;


            var sourceFile = fileEnumerator.Current;
            var fileName = Path.GetFileName(sourceFile);
            var destFile = Path.Combine(destFolder, fileName);
            try
            {
                File.Copy(sourceFile, destFile);
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show($"Error:{e.Message}");
                return false;
            }
        }

        private int FindFiles(string folder, string fileTypes)
        {
            // find all files in folder
            var dirInfo = new DirectoryInfo(path: folder);

            lstFiles = dirInfo.EnumerateFiles("*.*", SearchOption.AllDirectories).
                Where(s => !String.IsNullOrEmpty(Path.GetExtension(s.Name)) && fileTypes.Contains(Path.GetExtension(s.Name).ToLower())).Select(i => i.FullName).ToList();

            fileEnumerator = lstFiles.GetEnumerator();
            return lstFiles.Count;
        }

        #endregion File Handling
        #region UI methods

        private void UpdateLabelColor(bool success, ToolStripStatusLabel toolStripStatusLabel3)
        {
            if (success)
            {
                toolStripStatusLabel3.BackColor = Color.Green;
            }
            else
            {
                toolStripStatusLabel3.BackColor = Color.Red;
            }

        }

        private void ResetLabelColor()
        {
            statusLabelDestFolder1.BackColor = System.Drawing.SystemColors.Control;
            statusLabelDestFolder2.BackColor = System.Drawing.SystemColors.Control;
        }


        #endregion UI methods
    }
}
