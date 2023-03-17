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
using OpenText.LineCounter;
using OpenText.Helpers;

namespace OpenText
{
    public partial class OpenText : Form
    {
        public OpenText()
        {
            InitializeComponent();
            FileManagement.LoadFile(tslCurrentFile);
        }

        private void tsbSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            FileManagement.SaveFile(saveFileDialog, txtDocument, feedbackLabel, feedbackTimer, tslCurrentFile);
        }

        private void tsbSaveAs_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            FileManagement.SaveAsFile(saveFileDialog, txtDocument, feedbackLabel, feedbackTimer, tslCurrentFile);
        }

        private void tsbOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            FileManagement.OpenFile(openFileDialog, txtDocument, feedbackLabel, feedbackTimer, tslCurrentFile);
        }

        private void tsbFileInfo_Click(object sender, EventArgs e)
        {
            string fileInfoMessage = FileManagement.GetFileInfo(FileManagement.currentFilePath);
            MessageBox.Show(fileInfoMessage, "File info", MessageBoxButtons.OK);
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

        //SHORTCUTS
        private void txtDocument_KeyDown(object sender, KeyEventArgs e)
        {
            //CTRL+S
            if (e.Control && e.KeyCode == Keys.S)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                Shortcuts.SaveShortcut(e, saveFileDialog, txtDocument, feedbackLabel, feedbackTimer, tslCurrentFile);
            }

            if((e.KeyCode == Keys.Enter) && (txtDocument.Text == "+lorem"))
            {
                Shortcuts.LoremGenerate(e, txtDocument);
            }
        }

        //CODE BELOW IS ABOUT LINE NUMBER COUNTER (Helpers/LineCounter.cs)
        public int getWidth()
        {
            return LineCounter.LineCounter.getWidth(txtDocument);
        }

        public void AddLineNumbers()
        {
            LineCounter.LineCounter.AddLineNumbers(txtDocument, LineNumberTextBox, this);
        }

        private void OpenText_Load(object sender, EventArgs e)
        {
            LineCounter.LineCounter.OpenText_Load(txtDocument, LineNumberTextBox, this);
        }

        private void OpenText_Resize(object sender, EventArgs e)
        {
            LineCounter.LineCounter.OpenText_Resize(txtDocument, LineNumberTextBox, this);
        }

        private void txtDocument_SelectionChanged(object sender, EventArgs e)
        {
            LineCounter.LineCounter.txtDocument_SelectionChanged(txtDocument, LineNumberTextBox, this);
        }
        
        private void txtDocument_VScroll(object sender, EventArgs e)
        {
            LineCounter.LineCounter.txtDocument_VScroll(txtDocument, LineNumberTextBox, this);
        }

        private void txtDocument_TextChanged(object sender, EventArgs e)
        {
            LineCounter.LineCounter.txtDocument_TextChanged(txtDocument, LineNumberTextBox, this);
        }

        private void txtDocument_FontChanged(object sender, EventArgs e)
        {
            LineCounter.LineCounter.txtDocument_FontChanged(txtDocument, LineNumberTextBox, this);
        }

        private void LineNumberTextBox_MouseDown(object sender, MouseEventArgs e)
        {
            LineCounter.LineCounter.LineNumberTextBox_MouseDown(txtDocument, LineNumberTextBox);
        }

        private void tsbShowLineNumber_CheckedChanged(object sender, EventArgs e)
        {
            LineCounter.LineCounter.ShowLineCounter(LineNumberTextBox, tableLayoutPanel1);
        }
        //CODE ABOVE IS ABOUT LINE NUMBER COUNTER (Helpers/LineCounter.cs)

        private void tsbDarkMode_CheckedChanged(object sender, EventArgs e)
        {
            SetDarkMode.DarkMode(txtDocument, LineNumberTextBox, tsBottomMenu);
        }


    }
}
