using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using OpenText.Helpers;

namespace OpenText.Helpers
{
    internal class Shortcuts
    {
        //CTRL+S (SAVE)
        public static void SaveShortcut(KeyEventArgs e, SaveFileDialog saveFileDialog, RichTextBox txtDocument, ToolStripLabel feedbackLabel, Timer feedbackTimer, ToolStripLabel tslCurrentFile)
        {
            FileManagement.SaveFile(saveFileDialog, txtDocument, feedbackLabel, feedbackTimer, tslCurrentFile);
        }

        public static void LoremGenerate(KeyEventArgs e, RichTextBox txtDocument)
        {
            txtDocument.Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed interdum tellus ut libero suscipit dignissim. Nulla ac arcu nec turpis tristique sagittis vel vel eros. Nam bibendum magna vitae elit venenatis ultricies. Nam sit amet leo nibh. Integer sodales luctus ante, et volutpat urna malesuada et. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Etiam pulvinar, velit non bibendum luctus, magna nibh fringilla nisl, ac sagittis risus urna euismod risus. Suspendisse gravida euismod libero sed posuere. Aenean placerat, est eget consequat blandit, nisl metus ultricies odio, quis volutpat sapien nulla quis odio. Pellentesque laoreet erat quis ante lacinia, ac pulvinar odio auctor. Proin nec eros iaculis, laoreet justo at, posuere nunc.";

            // Move the cursor to the end of the text
            txtDocument.SelectionStart = txtDocument.Text.Length;
            txtDocument.ScrollToCaret();
        }
    }
}
