using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenText.Helpers
{
    internal class FileManagement
    {
        public static string currentFile = "no file is open.";
        public static string currentFilePath = null;

        public static void LoadFile(ToolStripLabel tslCurrentFile)
        {
            tslCurrentFile.Text = $"Current file: {currentFile}";
        }

        public static void SaveFile(SaveFileDialog saveFileDialog, RichTextBox txtDocument, ToolStripLabel feedbackLabel, Timer feedbackTimer, ToolStripLabel tslCurrentFile)
        {
            if (string.IsNullOrEmpty(currentFilePath))
            {
                SaveAsFile(saveFileDialog, txtDocument, feedbackLabel, feedbackTimer, tslCurrentFile);
            }
            else
            {
                File.WriteAllText(currentFilePath, txtDocument.Text);
                FeedbackResponse.ShowFeedbackMessage(feedbackLabel, feedbackTimer, $"{Path.GetFileNameWithoutExtension(currentFilePath)} was saved.");
            }
        }

        public static void SaveAsFile(SaveFileDialog saveFileDialog, RichTextBox txtDocument, ToolStripLabel feedbackLabel, Timer feedbackTimer, ToolStripLabel tslCurrentFile)
        {
            saveFileDialog.Filter = "Text files (*.txt)|*.txt";
            saveFileDialog.Title = "Save document as...";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                currentFilePath = saveFileDialog.FileName;
                File.WriteAllText(currentFilePath, txtDocument.Text);

                currentFile = Path.GetFileNameWithoutExtension(currentFilePath);
                FeedbackResponse.ShowFeedbackMessage(feedbackLabel, feedbackTimer, $"{currentFile} was saved.");
                LoadFile(tslCurrentFile);
            }

        }

        public static void OpenFile(OpenFileDialog openFileDialog, RichTextBox txtDocument, ToolStripLabel feedbackLabel, Timer feedbackTimer, ToolStripLabel tslCurrentFile)
        {

            openFileDialog.Filter = "Text files (*.txt)|*.txt";
            openFileDialog.Title = "Open document";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                currentFilePath = openFileDialog.FileName;
                txtDocument.Text = File.ReadAllText(currentFilePath);

                //PROVISIONAL TO AVOID THE LINE COUNT BUGGING
                // Move the cursor to the end of the text
                txtDocument.SelectionStart = txtDocument.Text.Length;
                txtDocument.SelectionLength = 0;

                //PROVISIONAL TO AVOID THE LINE COUNT BUGGING
                // Add a newline character to the end of the text
                txtDocument.SelectedText = Environment.NewLine;

                currentFile = Path.GetFileNameWithoutExtension(currentFilePath);
                FeedbackResponse.ShowFeedbackMessage(feedbackLabel, feedbackTimer, $"{currentFile} was loaded.");
                LoadFile(tslCurrentFile);
            }
        }

        public static string GetFileInfo(string filePath)
        {
            if (string.IsNullOrEmpty(filePath))
            {
                return "File not loaded! Please load a file before checking file info.";
            }

            FileInfo fileInfo = new FileInfo(filePath);
            string[] lines = File.ReadAllLines(filePath);

            int wordCount = lines.SelectMany(line => line.Split(new char[] { ' ', '.', ',', ';', ':', '-', '_', '/', '\\', '[', ']', '(', ')', '{', '}', '<', '>', '*', '+', '=', '|', '!', '?', '@', '#', '$', '%', '^', '&', '*', '"', '\'', '`', '~', '\t' }, StringSplitOptions.RemoveEmptyEntries)).Count();
            int lineCount = lines.Length;
            int charCount = lines.Sum(line => line.Length);

            return $"File name: {fileInfo.Name}\nWords: {wordCount}\nLines: {lineCount}\nCharacters: {charCount}\nFile size: {fileInfo.Length} bytes";
        }
    }
}
