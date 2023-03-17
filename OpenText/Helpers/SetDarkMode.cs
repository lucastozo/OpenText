using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenText.Helpers
{
    internal class SetDarkMode
    {
        private static bool darkModeChecked = false;
        public static void DarkMode(RichTextBox txtDocument, RichTextBox LineNumberTextBox, ToolStrip tsBottomMenu)
        {
            darkModeChecked = !darkModeChecked;
            if(darkModeChecked == true)
            {
                txtDocument.BackColor = Color.FromArgb(36, 41, 46);
                txtDocument.ForeColor = Color.White;

                LineNumberTextBox.BackColor = Color.FromArgb(29, 33, 37);
                LineNumberTextBox.ForeColor = Color.FromArgb(209, 213, 218);

                tsBottomMenu.BackColor = Color.FromArgb(29, 33, 37);
                tsBottomMenu.ForeColor = Color.White;
            }
            else
            {
                txtDocument.BackColor = Color.FromKnownColor(KnownColor.Window);
                txtDocument.ForeColor = Color.FromKnownColor(KnownColor.WindowText);

                LineNumberTextBox.BackColor = Color.FromKnownColor(KnownColor.Control);
                LineNumberTextBox.ForeColor = Color.FromKnownColor(KnownColor.WindowText);

                tsBottomMenu.BackColor = Color.FromKnownColor(KnownColor.Control);
                tsBottomMenu.ForeColor = Color.FromKnownColor(KnownColor.WindowText);
            }
        }
    }
}
