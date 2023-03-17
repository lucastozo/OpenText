using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace OpenText.LineCounter
{
    internal class LineCounter
    {
        //CODE FROM: https://www.c-sharpcorner.com/blogs/creating-line-numbers-for-richtextbox-in-c-sharp

        public static bool showLineCounter = true;

        public static void ShowLineCounter(RichTextBox LineNumberTextBox, TableLayoutPanel tableLayoutPanel1)
        {
            LineNumberTextBox.Visible = !LineNumberTextBox.Visible;
            showLineCounter = !showLineCounter;
            if(showLineCounter == false)
            {
                tableLayoutPanel1.ColumnStyles[1].SizeType = SizeType.Percent;
                tableLayoutPanel1.ColumnStyles[1].Width = 100;
                tableLayoutPanel1.ColumnStyles[0].SizeType = SizeType.AutoSize;
            }
        }

        public static int getWidth(RichTextBox txtDocument)
        {
            int w = 25;
            // get total lines of txtDocument  
            int line = txtDocument.Lines.Length;

            if (line <= 99)
            {
                w = 20 + (int)txtDocument.Font.Size;
            }
            else if (line <= 999)
            {
                w = 30 + (int)txtDocument.Font.Size;
            }
            else
            {
                w = 50 + (int)txtDocument.Font.Size;
            }

            return w;
        }

        public static void AddLineNumbers(RichTextBox txtDocument, RichTextBox LineNumberTextBox, OpenText form)
        {
            if(showLineCounter == true)
            {
                // create & set Point pt to (0,0)    
                Point pt = new Point(0, 0);
                // get First Index & First Line from txtDocument    
                int First_Index = txtDocument.GetCharIndexFromPosition(pt);
                int First_Line = txtDocument.GetLineFromCharIndex(First_Index);
                // set X & Y coordinates of Point pt to ClientRectangle Width & Height respectively    
                pt.X = form.ClientRectangle.Width;
                pt.Y = form.ClientRectangle.Height;
                // get Last Index & Last Line from txtDocument
                int Last_Index = txtDocument.GetCharIndexFromPosition(pt);
                int Last_Line = txtDocument.GetLineFromCharIndex(Last_Index);
                // set Center alignment to LineNumberTextBox    
                LineNumberTextBox.SelectionAlignment = HorizontalAlignment.Center;
                // set LineNumberTextBox text to null & width to getWidth() function value    
                LineNumberTextBox.Text = "";
                LineNumberTextBox.Width = getWidth(txtDocument);
                // now add each line number to LineNumberTextBox upto last line    
                for (int i = First_Line; i <= Last_Line + 2; i++)
                {
                    LineNumberTextBox.Text += i + 1 + "\n";
                }
            }

        }

        public static void OpenText_Load(RichTextBox txtDocument, RichTextBox LineNumberTextBox, OpenText form)
        {
            LineNumberTextBox.Font = txtDocument.Font;
            txtDocument.Select();
            AddLineNumbers(txtDocument, LineNumberTextBox, form);
        }

        public static void OpenText_Resize(RichTextBox txtDocument, RichTextBox LineNumberTextBox, OpenText form)
        {
            AddLineNumbers(txtDocument, LineNumberTextBox, form);
        }

        public static void txtDocument_SelectionChanged(RichTextBox txtDocument, RichTextBox LineNumberTextBox, OpenText form)
        {
            Point pt = txtDocument.GetPositionFromCharIndex(txtDocument.SelectionStart);
            if (pt.X == 1)
            {
                AddLineNumbers(txtDocument, LineNumberTextBox, form);
            }
        }

        public static void txtDocument_VScroll(RichTextBox txtDocument, RichTextBox LineNumberTextBox, OpenText form)
        {
            LineNumberTextBox.Text = "";
            AddLineNumbers(txtDocument, LineNumberTextBox, form);
            LineNumberTextBox.Invalidate();
        }

        public static void txtDocument_TextChanged(RichTextBox txtDocument, RichTextBox LineNumberTextBox, OpenText form)
        {
            if (txtDocument.Text == "")
            {
                AddLineNumbers(txtDocument, LineNumberTextBox, form);
            }
        }

        public static void txtDocument_FontChanged(RichTextBox txtDocument, RichTextBox LineNumberTextBox, OpenText form)
        {
            LineNumberTextBox.Font = txtDocument.Font;
            txtDocument.Select();
            AddLineNumbers(txtDocument, LineNumberTextBox, form);
        }

        public static void LineNumberTextBox_MouseDown(RichTextBox txtDocument, RichTextBox LineNumberTextBox)
        {
            txtDocument.Select();
            LineNumberTextBox.DeselectAll();
        }
    }
}
