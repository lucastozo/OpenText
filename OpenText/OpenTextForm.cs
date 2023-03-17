using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace OpenText
{
    public partial class OpenText : Form
    {
        public OpenText()
        {
            InitializeComponent();
            LoadFile();
            feedbackTimer = new Timer();
            feedbackTimer.Interval = 3000;
            feedbackTimer.Tick += feedbackTimer_Tick;
        }

        private string currentFilePath = null, currentFile = "no file is open.";

        private void LoadFile()
        {
            tslCurrentFile.Text = $"Current file: {currentFile}";
        }

        private void tsbSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(currentFilePath))
            {
                File.WriteAllText(currentFilePath, txtDocument.Text);
                ShowFeedbackMessage($"{currentFile} was saved.");
            }
            else
            {
                tsbSaveAs_Click(sender, e);
            }
        }

        private void tsbSaveAs_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Text files (*.txt)|*.txt";
                saveFileDialog.Title = "Save document as...";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    currentFilePath = saveFileDialog.FileName;
                    File.WriteAllText(currentFilePath, txtDocument.Text);
                }
            }

            currentFile = Path.GetFileNameWithoutExtension(currentFilePath);
            ShowFeedbackMessage($"{currentFile} was saved.");
            LoadFile();
        }

        private void tsbOpen_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Text files (*.txt)|*.txt";
                openFileDialog.Title = "Open document";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    currentFilePath = openFileDialog.FileName;
                    txtDocument.Text = File.ReadAllText(currentFilePath);
                }
            }

            currentFile = Path.GetFileNameWithoutExtension(currentFilePath);
            ShowFeedbackMessage($"{currentFile} was opened.");
            LoadFile();
        }

        private void tsbFileInfo_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(currentFilePath))
            {
                MessageBox.Show("File not loaded! Please load a file before checking file info.", "Error");
                return;
            }

            FileInfo fileInfo = new FileInfo(currentFilePath);
            string[] lines = File.ReadAllLines(currentFilePath);

            int wordCount = lines.SelectMany(line => line.Split(new char[] { ' ', '.', ',', ';', ':', '-', '_', '/', '\\', '[', ']', '(', ')', '{', '}', '<', '>', '*', '+', '=', '|', '!', '?', '@', '#', '$', '%', '^', '&', '*', '"', '\'', '`', '~', '\t' }, StringSplitOptions.RemoveEmptyEntries)).Count();
            int lineCount = lines.Length;
            int charCount = lines.Sum(line => line.Length);

            string message = String.Format("File name: {0}\nWords: {1}\nLines: {2}\nCharacters: {3}\nFile size: {4} bytes", fileInfo.Name, wordCount, lineCount, charCount, fileInfo.Length);
            MessageBox.Show(message, "File info", MessageBoxButtons.OK);
        }

        private void tsbChangeFont_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();

            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                txtDocument.Font = fontDialog.Font;
                txtDocument.ForeColor = fontDialog.Color;
            }
        }

        private void btAbout_Click(object sender, EventArgs e)
        {
            AboutBox aboutBox = new AboutBox();
            aboutBox.ShowDialog();
        }

        private void txtDocument_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtDocument.Text == "+lorem")
                {
                    txtDocument.Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed interdum tellus ut libero suscipit dignissim. Nulla ac arcu nec turpis tristique sagittis vel vel eros. Nam bibendum magna vitae elit venenatis ultricies. Nam sit amet leo nibh. Integer sodales luctus ante, et volutpat urna malesuada et. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Etiam pulvinar, velit non bibendum luctus, magna nibh fringilla nisl, ac sagittis risus urna euismod risus. Suspendisse gravida euismod libero sed posuere. Aenean placerat, est eget consequat blandit, nisl metus ultricies odio, quis volutpat sapien nulla quis odio. Pellentesque laoreet erat quis ante lacinia, ac pulvinar odio auctor. Proin nec eros iaculis, laoreet justo at, posuere nunc.";

                    // Move the cursor to the end of the text
                    txtDocument.SelectionStart = txtDocument.Text.Length;
                    txtDocument.ScrollToCaret();

                    // Prevent a new line from being added
                    e.SuppressKeyPress = true;
                }
            }
        }

        private void feedbackTimer_Tick(object sender, EventArgs e)
        {
            feedbackLabel.Text = "";
            feedbackLabel.Visible = false;
            feedbackTimer.Stop();
        }

        private void ShowFeedbackMessage(string message)
        {
            feedbackLabel.Text = message;
            feedbackLabel.Visible = true;
            feedbackTimer.Start();
        }

    }
}
