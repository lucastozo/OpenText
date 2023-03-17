namespace OpenText
{
    partial class OpenText
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OpenText));
            this.txtDocument = new System.Windows.Forms.RichTextBox();
            this.tsTopMenu = new System.Windows.Forms.ToolStrip();
            this.btFile = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsbSave = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbFileInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.btTextStyle = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsbChangeFont = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbShowLineNumber = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btAbout = new System.Windows.Forms.ToolStripButton();
            this.tsBottomMenu = new System.Windows.Forms.ToolStrip();
            this.tslCurrentFile = new System.Windows.Forms.ToolStripLabel();
            this.feedbackLabel = new System.Windows.Forms.ToolStripLabel();
            this.feedbackTimer = new System.Windows.Forms.Timer(this.components);
            this.LineNumberTextBox = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tsbDarkMode = new System.Windows.Forms.ToolStripMenuItem();
            this.tsTopMenu.SuspendLayout();
            this.tsBottomMenu.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDocument
            // 
            this.txtDocument.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDocument.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDocument.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDocument.Location = new System.Drawing.Point(38, 3);
            this.txtDocument.Name = "txtDocument";
            this.txtDocument.Size = new System.Drawing.Size(1143, 580);
            this.txtDocument.TabIndex = 0;
            this.txtDocument.Text = "";
            this.txtDocument.SelectionChanged += new System.EventHandler(this.txtDocument_SelectionChanged);
            this.txtDocument.VScroll += new System.EventHandler(this.txtDocument_VScroll);
            this.txtDocument.FontChanged += new System.EventHandler(this.txtDocument_FontChanged);
            this.txtDocument.TextChanged += new System.EventHandler(this.txtDocument_TextChanged);
            this.txtDocument.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDocument_KeyDown);
            // 
            // tsTopMenu
            // 
            this.tsTopMenu.BackColor = System.Drawing.SystemColors.Control;
            this.tsTopMenu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsTopMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btFile,
            this.btTextStyle,
            this.toolStripSeparator1,
            this.btAbout});
            this.tsTopMenu.Location = new System.Drawing.Point(0, 0);
            this.tsTopMenu.Name = "tsTopMenu";
            this.tsTopMenu.Size = new System.Drawing.Size(1184, 25);
            this.tsTopMenu.TabIndex = 1;
            this.tsTopMenu.Text = "toolStrip1";
            // 
            // btFile
            // 
            this.btFile.BackColor = System.Drawing.SystemColors.Control;
            this.btFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbSave,
            this.tsbSaveAs,
            this.tsbOpen,
            this.tsbFileInfo});
            this.btFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btFile.Name = "btFile";
            this.btFile.Size = new System.Drawing.Size(38, 22);
            this.btFile.Text = "File";
            this.btFile.ToolTipText = "Actions about your file";
            // 
            // tsbSave
            // 
            this.tsbSave.Name = "tsbSave";
            this.tsbSave.Size = new System.Drawing.Size(180, 22);
            this.tsbSave.Text = "Save";
            this.tsbSave.Click += new System.EventHandler(this.tsbSave_Click);
            // 
            // tsbSaveAs
            // 
            this.tsbSaveAs.Name = "tsbSaveAs";
            this.tsbSaveAs.Size = new System.Drawing.Size(180, 22);
            this.tsbSaveAs.Text = "Save as...";
            this.tsbSaveAs.Click += new System.EventHandler(this.tsbSaveAs_Click);
            // 
            // tsbOpen
            // 
            this.tsbOpen.Name = "tsbOpen";
            this.tsbOpen.Size = new System.Drawing.Size(180, 22);
            this.tsbOpen.Text = "Open...";
            this.tsbOpen.Click += new System.EventHandler(this.tsbOpen_Click);
            // 
            // tsbFileInfo
            // 
            this.tsbFileInfo.Name = "tsbFileInfo";
            this.tsbFileInfo.Size = new System.Drawing.Size(180, 22);
            this.tsbFileInfo.Text = "File info";
            this.tsbFileInfo.Click += new System.EventHandler(this.tsbFileInfo_Click);
            // 
            // btTextStyle
            // 
            this.btTextStyle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btTextStyle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btTextStyle.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbChangeFont,
            this.tsbShowLineNumber,
            this.tsbDarkMode});
            this.btTextStyle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btTextStyle.Name = "btTextStyle";
            this.btTextStyle.Size = new System.Drawing.Size(40, 22);
            this.btTextStyle.Text = "Edit";
            this.btTextStyle.ToolTipText = "Change the style of your text";
            // 
            // tsbChangeFont
            // 
            this.tsbChangeFont.Name = "tsbChangeFont";
            this.tsbChangeFont.Size = new System.Drawing.Size(180, 22);
            this.tsbChangeFont.Text = "Change font...";
            this.tsbChangeFont.Click += new System.EventHandler(this.tsbChangeFont_Click);
            // 
            // tsbShowLineNumber
            // 
            this.tsbShowLineNumber.Checked = true;
            this.tsbShowLineNumber.CheckOnClick = true;
            this.tsbShowLineNumber.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsbShowLineNumber.Name = "tsbShowLineNumber";
            this.tsbShowLineNumber.Size = new System.Drawing.Size(180, 22);
            this.tsbShowLineNumber.Text = "Show line number";
            this.tsbShowLineNumber.CheckedChanged += new System.EventHandler(this.tsbShowLineNumber_CheckedChanged);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btAbout
            // 
            this.btAbout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btAbout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btAbout.Name = "btAbout";
            this.btAbout.Size = new System.Drawing.Size(44, 22);
            this.btAbout.Text = "About";
            this.btAbout.ToolTipText = "About OpenText";
            this.btAbout.Click += new System.EventHandler(this.btAbout_Click);
            // 
            // tsBottomMenu
            // 
            this.tsBottomMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tsBottomMenu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsBottomMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslCurrentFile,
            this.feedbackLabel});
            this.tsBottomMenu.Location = new System.Drawing.Point(0, 611);
            this.tsBottomMenu.Name = "tsBottomMenu";
            this.tsBottomMenu.Size = new System.Drawing.Size(1184, 25);
            this.tsBottomMenu.TabIndex = 2;
            this.tsBottomMenu.Text = "toolStrip1";
            // 
            // tslCurrentFile
            // 
            this.tslCurrentFile.Name = "tslCurrentFile";
            this.tslCurrentFile.Size = new System.Drawing.Size(69, 22);
            this.tslCurrentFile.Text = "Current file:";
            // 
            // feedbackLabel
            // 
            this.feedbackLabel.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.feedbackLabel.Name = "feedbackLabel";
            this.feedbackLabel.Size = new System.Drawing.Size(88, 22);
            this.feedbackLabel.Text = "Feedback Label";
            this.feedbackLabel.Visible = false;
            // 
            // LineNumberTextBox
            // 
            this.LineNumberTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LineNumberTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.LineNumberTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LineNumberTextBox.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LineNumberTextBox.Location = new System.Drawing.Point(3, 3);
            this.LineNumberTextBox.Name = "LineNumberTextBox";
            this.LineNumberTextBox.ReadOnly = true;
            this.LineNumberTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.LineNumberTextBox.Size = new System.Drawing.Size(29, 580);
            this.LineNumberTextBox.TabIndex = 3;
            this.LineNumberTextBox.Text = "";
            this.LineNumberTextBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LineNumberTextBox_MouseDown);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 97F));
            this.tableLayoutPanel1.Controls.Add(this.txtDocument, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.LineNumberTextBox, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 25);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1184, 586);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // tsbDarkMode
            // 
            this.tsbDarkMode.CheckOnClick = true;
            this.tsbDarkMode.Name = "tsbDarkMode";
            this.tsbDarkMode.Size = new System.Drawing.Size(180, 22);
            this.tsbDarkMode.Text = "Dark mode";
            this.tsbDarkMode.CheckedChanged += new System.EventHandler(this.tsbDarkMode_CheckedChanged);
            // 
            // OpenText
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 636);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tsBottomMenu);
            this.Controls.Add(this.tsTopMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OpenText";
            this.Text = "OpenText";
            this.Load += new System.EventHandler(this.OpenText_Load);
            this.Resize += new System.EventHandler(this.OpenText_Resize);
            this.tsTopMenu.ResumeLayout(false);
            this.tsTopMenu.PerformLayout();
            this.tsBottomMenu.ResumeLayout(false);
            this.tsBottomMenu.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip tsTopMenu;
        private System.Windows.Forms.ToolStripDropDownButton btFile;
        private System.Windows.Forms.ToolStripMenuItem tsbSave;
        private System.Windows.Forms.ToolStripMenuItem tsbOpen;
        private System.Windows.Forms.ToolStripMenuItem tsbFileInfo;
        private System.Windows.Forms.ToolStripDropDownButton btTextStyle;
        private System.Windows.Forms.ToolStripMenuItem tsbChangeFont;
        private System.Windows.Forms.ToolStripButton btAbout;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStrip tsBottomMenu;
        private System.Windows.Forms.ToolStripLabel tslCurrentFile;
        private System.Windows.Forms.ToolStripMenuItem tsbSaveAs;
        private System.Windows.Forms.Timer feedbackTimer;
        private System.Windows.Forms.ToolStripLabel feedbackLabel;
        private System.Windows.Forms.RichTextBox txtDocument;
        private System.Windows.Forms.RichTextBox LineNumberTextBox;
        private System.Windows.Forms.ToolStripMenuItem tsbShowLineNumber;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolStripMenuItem tsbDarkMode;
    }
}

