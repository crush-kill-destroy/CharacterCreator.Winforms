namespace CharacterCreator.Winforms
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this._msMenu = new System.Windows.Forms.MenuStrip();
            this._miFile = new System.Windows.Forms.ToolStripMenuItem();
            this._miExit = new System.Windows.Forms.ToolStripMenuItem();
            this._miCharacter = new System.Windows.Forms.ToolStripMenuItem();
            this._miNewCharacter = new System.Windows.Forms.ToolStripMenuItem();
            this._miEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this._miDelete = new System.Windows.Forms.ToolStripMenuItem();
            this._miHelp = new System.Windows.Forms.ToolStripMenuItem();
            this._miAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.lab1 = new System.Windows.Forms.Label();
            this.ds = new System.Windows.Forms.Label();
            this.df34 = new System.Windows.Forms.Label();
            this.csd = new System.Windows.Forms.Label();
            this.f3 = new System.Windows.Forms.Label();
            this.fsdjkl = new System.Windows.Forms.Label();
            this.sfdlhk = new System.Windows.Forms.Label();
            this.lsdklf = new System.Windows.Forms.Label();
            this._lab3 = new System.Windows.Forms.Label();
            this._labBrawn = new System.Windows.Forms.Label();
            this._labMoxie = new System.Windows.Forms.Label();
            this._labLuck = new System.Windows.Forms.Label();
            this._labSanity = new System.Windows.Forms.Label();
            this._labBrains = new System.Windows.Forms.Label();
            this._labRace = new System.Windows.Forms.Label();
            this._labProfession = new System.Windows.Forms.Label();
            this._richDescription = new System.Windows.Forms.RichTextBox();
            this._lbRoster = new System.Windows.Forms.ListBox();
            this._msMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // _msMenu
            // 
            this._msMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this._msMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._miFile,
            this._miCharacter,
            this._miHelp});
            this._msMenu.Location = new System.Drawing.Point(0, 0);
            this._msMenu.Name = "_msMenu";
            this._msMenu.Size = new System.Drawing.Size(278, 33);
            this._msMenu.TabIndex = 0;
            this._msMenu.Text = "Menu";
            this._msMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // _miFile
            // 
            this._miFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._miExit});
            this._miFile.Name = "_miFile";
            this._miFile.Size = new System.Drawing.Size(54, 29);
            this._miFile.Text = "&File";
            // 
            // _miExit
            // 
            this._miExit.Name = "_miExit";
            this._miExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this._miExit.Size = new System.Drawing.Size(206, 34);
            this._miExit.Text = "Exit";
            // 
            // _miCharacter
            // 
            this._miCharacter.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._miNewCharacter,
            this._miEdit,
            this.toolStripSeparator1,
            this._miDelete});
            this._miCharacter.Name = "_miCharacter";
            this._miCharacter.Size = new System.Drawing.Size(110, 29);
            this._miCharacter.Text = "&Charcacter";
            // 
            // _miNewCharacter
            // 
            this._miNewCharacter.Name = "_miNewCharacter";
            this._miNewCharacter.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this._miNewCharacter.Size = new System.Drawing.Size(213, 34);
            this._miNewCharacter.Text = "New";
            // 
            // _miEdit
            // 
            this._miEdit.Name = "_miEdit";
            this._miEdit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this._miEdit.Size = new System.Drawing.Size(213, 34);
            this._miEdit.Text = "Edit";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(210, 6);
            // 
            // _miDelete
            // 
            this._miDelete.Name = "_miDelete";
            this._miDelete.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this._miDelete.Size = new System.Drawing.Size(213, 34);
            this._miDelete.Text = "Delete";
            // 
            // _miHelp
            // 
            this._miHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._miAbout});
            this._miHelp.Name = "_miHelp";
            this._miHelp.Size = new System.Drawing.Size(65, 29);
            this._miHelp.Text = "&Help";
            // 
            // _miAbout
            // 
            this._miAbout.Name = "_miAbout";
            this._miAbout.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this._miAbout.Size = new System.Drawing.Size(182, 34);
            this._miAbout.Text = "Help";
            // 
            // lab1
            // 
            this.lab1.AutoSize = true;
            this.lab1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lab1.Location = new System.Drawing.Point(12, 145);
            this.lab1.Name = "lab1";
            this.lab1.Size = new System.Drawing.Size(66, 25);
            this.lab1.TabIndex = 3;
            this.lab1.Text = "Brawn";
            this.lab1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // ds
            // 
            this.ds.AutoSize = true;
            this.ds.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ds.Location = new System.Drawing.Point(144, 145);
            this.ds.Name = "ds";
            this.ds.Size = new System.Drawing.Size(51, 25);
            this.ds.TabIndex = 3;
            this.ds.Text = "Luck";
            // 
            // df34
            // 
            this.df34.AutoSize = true;
            this.df34.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.df34.Location = new System.Drawing.Point(78, 145);
            this.df34.Name = "df34";
            this.df34.Size = new System.Drawing.Size(65, 25);
            this.df34.TabIndex = 3;
            this.df34.Text = "Moxie";
            // 
            // csd
            // 
            this.csd.AutoSize = true;
            this.csd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.csd.Location = new System.Drawing.Point(195, 145);
            this.csd.Name = "csd";
            this.csd.Size = new System.Drawing.Size(65, 25);
            this.csd.TabIndex = 3;
            this.csd.Text = "Sanity";
            // 
            // f3
            // 
            this.f3.AutoSize = true;
            this.f3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.f3.Location = new System.Drawing.Point(13, 215);
            this.f3.Name = "f3";
            this.f3.Size = new System.Drawing.Size(65, 25);
            this.f3.TabIndex = 3;
            this.f3.Text = "Brains";
            // 
            // fsdjkl
            // 
            this.fsdjkl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.fsdjkl.AutoSize = true;
            this.fsdjkl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.fsdjkl.Location = new System.Drawing.Point(12, 71);
            this.fsdjkl.Name = "fsdjkl";
            this.fsdjkl.Size = new System.Drawing.Size(52, 25);
            this.fsdjkl.TabIndex = 3;
            this.fsdjkl.Text = "Prof.";
            // 
            // sfdlhk
            // 
            this.sfdlhk.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.sfdlhk.AutoSize = true;
            this.sfdlhk.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sfdlhk.Location = new System.Drawing.Point(12, 106);
            this.sfdlhk.Name = "sfdlhk";
            this.sfdlhk.Size = new System.Drawing.Size(53, 25);
            this.sfdlhk.TabIndex = 3;
            this.sfdlhk.Text = "Race";
            // 
            // lsdklf
            // 
            this.lsdklf.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lsdklf.AutoSize = true;
            this.lsdklf.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lsdklf.Location = new System.Drawing.Point(13, 39);
            this.lsdklf.Name = "lsdklf";
            this.lsdklf.Size = new System.Drawing.Size(62, 25);
            this.lsdklf.TabIndex = 6;
            this.lsdklf.Text = "Name";
            this.lsdklf.Click += new System.EventHandler(this.lsdklf_Click);
            // 
            // _lab3
            // 
            this._lab3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._lab3.AutoSize = true;
            this._lab3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this._lab3.Location = new System.Drawing.Point(12, 244);
            this._lab3.Name = "_lab3";
            this._lab3.Size = new System.Drawing.Size(109, 25);
            this._lab3.TabIndex = 6;
            this._lab3.Text = "Description";
            this._lab3.Click += new System.EventHandler(this.rtrtrtrt);
            // 
            // _labBrawn
            // 
            this._labBrawn.AutoSize = true;
            this._labBrawn.Location = new System.Drawing.Point(15, 178);
            this._labBrawn.Name = "_labBrawn";
            this._labBrawn.Size = new System.Drawing.Size(17, 25);
            this._labBrawn.TabIndex = 7;
            this._labBrawn.Text = " ";
            // 
            // _labMoxie
            // 
            this._labMoxie.AutoSize = true;
            this._labMoxie.Location = new System.Drawing.Point(78, 178);
            this._labMoxie.Name = "_labMoxie";
            this._labMoxie.Size = new System.Drawing.Size(17, 25);
            this._labMoxie.TabIndex = 7;
            this._labMoxie.Text = " ";
            // 
            // _labLuck
            // 
            this._labLuck.AutoSize = true;
            this._labLuck.Location = new System.Drawing.Point(144, 178);
            this._labLuck.Name = "_labLuck";
            this._labLuck.Size = new System.Drawing.Size(17, 25);
            this._labLuck.TabIndex = 7;
            this._labLuck.Text = " ";
            // 
            // _labSanity
            // 
            this._labSanity.AutoSize = true;
            this._labSanity.Location = new System.Drawing.Point(204, 178);
            this._labSanity.Name = "_labSanity";
            this._labSanity.Size = new System.Drawing.Size(17, 25);
            this._labSanity.TabIndex = 7;
            this._labSanity.Text = " ";
            // 
            // _labBrains
            // 
            this._labBrains.AutoSize = true;
            this._labBrains.Location = new System.Drawing.Point(78, 215);
            this._labBrains.Name = "_labBrains";
            this._labBrains.Size = new System.Drawing.Size(17, 25);
            this._labBrains.TabIndex = 7;
            this._labBrains.Text = " ";
            // 
            // _labRace
            // 
            this._labRace.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._labRace.AutoSize = true;
            this._labRace.Location = new System.Drawing.Point(78, 106);
            this._labRace.Name = "_labRace";
            this._labRace.Size = new System.Drawing.Size(17, 25);
            this._labRace.TabIndex = 7;
            this._labRace.Text = " ";
            // 
            // _labProfession
            // 
            this._labProfession.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._labProfession.AutoSize = true;
            this._labProfession.Location = new System.Drawing.Point(78, 71);
            this._labProfession.Name = "_labProfession";
            this._labProfession.Size = new System.Drawing.Size(17, 25);
            this._labProfession.TabIndex = 7;
            this._labProfession.Text = " ";
            // 
            // _richDescription
            // 
            this._richDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._richDescription.Location = new System.Drawing.Point(15, 285);
            this._richDescription.Name = "_richDescription";
            this._richDescription.ReadOnly = true;
            this._richDescription.Size = new System.Drawing.Size(245, 97);
            this._richDescription.TabIndex = 8;
            this._richDescription.Text = " ";
            // 
            // _lbRoster
            // 
            this._lbRoster.FormattingEnabled = true;
            this._lbRoster.ItemHeight = 25;
            this._lbRoster.Location = new System.Drawing.Point(78, 39);
            this._lbRoster.Name = "_lbRoster";
            this._lbRoster.Size = new System.Drawing.Size(182, 29);
            this._lbRoster.TabIndex = 9;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 394);
            this.Controls.Add(this._lbRoster);
            this.Controls.Add(this._richDescription);
            this.Controls.Add(this._labProfession);
            this.Controls.Add(this._labRace);
            this.Controls.Add(this._labBrains);
            this.Controls.Add(this._labSanity);
            this.Controls.Add(this._labLuck);
            this.Controls.Add(this._labMoxie);
            this.Controls.Add(this._labBrawn);
            this.Controls.Add(this._lab3);
            this.Controls.Add(this.lsdklf);
            this.Controls.Add(this.sfdlhk);
            this.Controls.Add(this.fsdjkl);
            this.Controls.Add(this.f3);
            this.Controls.Add(this.csd);
            this.Controls.Add(this.df34);
            this.Controls.Add(this.ds);
            this.Controls.Add(this.lab1);
            this.Controls.Add(this._msMenu);
            this.MainMenuStrip = this._msMenu;
            this.MinimumSize = new System.Drawing.Size(260, 420);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Character Creator";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this._msMenu.ResumeLayout(false);
            this._msMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip _msMenu;
        private System.Windows.Forms.ToolStripMenuItem _miFile;
        private System.Windows.Forms.ToolStripMenuItem _miExit;
        private System.Windows.Forms.Label lab1;
        private System.Windows.Forms.Label ds;
        private System.Windows.Forms.Label df34;
        private System.Windows.Forms.Label csd;
        private System.Windows.Forms.Label f3;
        private System.Windows.Forms.Label fsdjkl;
        private System.Windows.Forms.Label sfdlhk;
        private System.Windows.Forms.Label lsdklf;
        private System.Windows.Forms.Label _lab3;
        private System.Windows.Forms.ToolStripMenuItem _miCharacter;
        private System.Windows.Forms.ToolStripMenuItem _miNewCharacter;
        private System.Windows.Forms.Label _labBrawn;
        private System.Windows.Forms.Label _labMoxie;
        private System.Windows.Forms.Label _labLuck;
        private System.Windows.Forms.Label _labSanity;
        private System.Windows.Forms.Label _labBrains;
        private System.Windows.Forms.Label _labRace;
        private System.Windows.Forms.Label _labProfession;
        private System.Windows.Forms.RichTextBox _richDescription;
        private System.Windows.Forms.ToolStripMenuItem _miHelp;
        private System.Windows.Forms.ToolStripMenuItem _miAbout;
        private System.Windows.Forms.ToolStripMenuItem _miEdit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem _miDelete;
        private System.Windows.Forms.ListBox _lbRoster;
    }
}

