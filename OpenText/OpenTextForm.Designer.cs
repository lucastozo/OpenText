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
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btAbout = new System.Windows.Forms.ToolStripButton();
            this.tsBottomMenu = new System.Windows.Forms.ToolStrip();
            this.tslCurrentFile = new System.Windows.Forms.ToolStripLabel();
            this.feedbackTimer = new System.Windows.Forms.Timer(this.components);
            this.feedbackLabel = new System.Windows.Forms.ToolStripLabel();
            this.tsTopMenu.SuspendLayout();
            this.tsBottomMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDocument
            // 
            this.txtDocument.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDocument.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDocument.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDocument.Location = new System.Drawing.Point(0, 31);
            this.txtDocument.Name = "txtDocument";
            this.txtDocument.Size = new System.Drawing.Size(1184, 573);
            this.txtDocument.TabIndex = 0;
            this.txtDocument.Text = "";
            this.txtDocument.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDocument_KeyDown);
            // 
            // tsTopMenu
            // 
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
            this.btTextStyle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btTextStyle.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbChangeFont});
            this.btTextStyle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btTextStyle.Name = "btTextStyle";
            this.btTextStyle.Size = new System.Drawing.Size(69, 22);
            this.btTextStyle.Text = "Text Style";
            this.btTextStyle.ToolTipText = "Change the style of your text";
            // 
            // tsbChangeFont
            // 
            this.tsbChangeFont.Name = "tsbChangeFont";
            this.tsbChangeFont.Size = new System.Drawing.Size(180, 22);
            this.tsbChangeFont.Text = "Change font...";
            this.tsbChangeFont.Click += new System.EventHandler(this.tsbChangeFont_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btAbout
            // 
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
            // feedbackTimer
            // 
            this.feedbackTimer.Tick += new System.EventHandler(this.feedbackTimer_Tick);
            // 
            // feedbackLabel
            // 
            this.feedbackLabel.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.feedbackLabel.Name = "feedbackLabel";
            this.feedbackLabel.Size = new System.Drawing.Size(88, 22);
            this.feedbackLabel.Text = "Feedback Label";
            this.feedbackLabel.Visible = false;
            // 
            // OpenText
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 636);
            this.Controls.Add(this.tsBottomMenu);
            this.Controls.Add(this.tsTopMenu);
            this.Controls.Add(this.txtDocument);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OpenText";
            this.Text = "OpenText";
            this.tsTopMenu.ResumeLayout(false);
            this.tsTopMenu.PerformLayout();
            this.tsBottomMenu.ResumeLayout(false);
            this.tsBottomMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtDocument;
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
    }
}

