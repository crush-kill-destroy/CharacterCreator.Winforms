namespace CharacterCreator
{
    partial class CreateCharacter
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this._richDescription = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this._txtName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this._txtBrains = new System.Windows.Forms.TextBox();
            this._txtBrawn = new System.Windows.Forms.TextBox();
            this._txtLuck = new System.Windows.Forms.TextBox();
            this._txtSanity = new System.Windows.Forms.TextBox();
            this._txtMoxie = new System.Windows.Forms.TextBox();
            this._comboRace = new System.Windows.Forms.ComboBox();
            this._comboProfession = new System.Windows.Forms.ComboBox();
            this._buttonSave = new System.Windows.Forms.Button();
            this._buttonCancel = new System.Windows.Forms.Button();
            this._errors = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this._errors)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(22, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(22, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Race";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(22, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Prof.";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(22, 302);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(373, 115);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.TabStop = false;
            this.richTextBox1.Text = "Stats can be between 1 and 100, except brains, which can be between -2,000,000 an" +
    "d 100. Genius has its limits, but stupidity is bottomless.";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // _richDescription
            // 
            this._richDescription.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this._richDescription.Location = new System.Drawing.Point(22, 193);
            this._richDescription.Name = "_richDescription";
            this._richDescription.Size = new System.Drawing.Size(373, 103);
            this._richDescription.TabIndex = 4;
            this._richDescription.Text = "";
            this._richDescription.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(22, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(202, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Description (Optional)";
            // 
            // _txtName
            // 
            this._txtName.Location = new System.Drawing.Point(87, 30);
            this._txtName.Name = "_txtName";
            this._txtName.Size = new System.Drawing.Size(308, 31);
            this._txtName.TabIndex = 1;
            this._txtName.Validating += new System.ComponentModel.CancelEventHandler(this.OnValidateName);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(22, 420);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Brawn";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(22, 493);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Brains";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(259, 420);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "Luck";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(182, 420);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 25);
            this.label8.TabIndex = 0;
            this.label8.Text = "Sanity";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(98, 420);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 25);
            this.label9.TabIndex = 0;
            this.label9.Text = "Moxie";
            // 
            // _txtBrains
            // 
            this._txtBrains.Location = new System.Drawing.Point(98, 493);
            this._txtBrains.Name = "_txtBrains";
            this._txtBrains.Size = new System.Drawing.Size(220, 31);
            this._txtBrains.TabIndex = 9;
            this._txtBrains.Text = "50";
            this._txtBrains.Validating += new System.ComponentModel.CancelEventHandler(this.OnValidatingBrains);
            // 
            // _txtBrawn
            // 
            this._txtBrawn.Location = new System.Drawing.Point(22, 456);
            this._txtBrawn.Name = "_txtBrawn";
            this._txtBrawn.Size = new System.Drawing.Size(59, 31);
            this._txtBrawn.TabIndex = 5;
            this._txtBrawn.Text = "50";
            this._txtBrawn.Validating += new System.ComponentModel.CancelEventHandler(this.OnValidatingStats);
            // 
            // _txtLuck
            // 
            this._txtLuck.Location = new System.Drawing.Point(259, 456);
            this._txtLuck.Name = "_txtLuck";
            this._txtLuck.Size = new System.Drawing.Size(59, 31);
            this._txtLuck.TabIndex = 8;
            this._txtLuck.Text = "50";
            this._txtLuck.Validating += new System.ComponentModel.CancelEventHandler(this.OnValidatingStats);
            // 
            // _txtSanity
            // 
            this._txtSanity.Location = new System.Drawing.Point(182, 456);
            this._txtSanity.Name = "_txtSanity";
            this._txtSanity.Size = new System.Drawing.Size(59, 31);
            this._txtSanity.TabIndex = 7;
            this._txtSanity.Text = "50";
            this._txtSanity.Validating += new System.ComponentModel.CancelEventHandler(this.OnValidatingStats);
            // 
            // _txtMoxie
            // 
            this._txtMoxie.Location = new System.Drawing.Point(98, 456);
            this._txtMoxie.Name = "_txtMoxie";
            this._txtMoxie.Size = new System.Drawing.Size(59, 31);
            this._txtMoxie.TabIndex = 6;
            this._txtMoxie.Text = "50";
            this._txtMoxie.Validating += new System.ComponentModel.CancelEventHandler(this.OnValidatingStats);
            // 
            // _comboRace
            // 
            this._comboRace.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._comboRace.FormattingEnabled = true;
            this._comboRace.Items.AddRange(new object[] {
            "A Compiler Error",
            "Mass Hallucination",
            "Killer Clown",
            "Stick With An Angry Face Scribbled On It",
            "Anthropomorphic Washing Machine",
            "Sentient Lollipop",
            "A Floating Orb Of Eyes",
            "A Wasp Made Of Bees"});
            this._comboRace.Location = new System.Drawing.Point(87, 115);
            this._comboRace.Name = "_comboRace";
            this._comboRace.Size = new System.Drawing.Size(308, 33);
            this._comboRace.TabIndex = 3;
            this._comboRace.Validating += new System.ComponentModel.CancelEventHandler(this.OnValidatingDropDown);
            // 
            // _comboProfession
            // 
            this._comboProfession.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._comboProfession.FormattingEnabled = true;
            this._comboProfession.Items.AddRange(new object[] {
            "Chainsaw Paladin",
            "Mime",
            "Philosophy Major",
            "Nineties Boy Band Backup Dancer",
            "Necromancerphiliac",
            "Merry Prankster",
            "Catholic Priest",
            "Murder Hobo",
            "Weaboo",
            "Rent Boy"});
            this._comboProfession.Location = new System.Drawing.Point(87, 73);
            this._comboProfession.Name = "_comboProfession";
            this._comboProfession.Size = new System.Drawing.Size(308, 33);
            this._comboProfession.TabIndex = 2;
            this._comboProfession.Validating += new System.ComponentModel.CancelEventHandler(this.OnValidatingDropDown);
            // 
            // _buttonSave
            // 
            this._buttonSave.Location = new System.Drawing.Point(37, 562);
            this._buttonSave.Name = "_buttonSave";
            this._buttonSave.Size = new System.Drawing.Size(121, 42);
            this._buttonSave.TabIndex = 10;
            this._buttonSave.Text = "Save";
            this._buttonSave.UseVisualStyleBackColor = true;
            this._buttonSave.Click += new System.EventHandler(this._buttonSave_Click);
            // 
            // _buttonCancel
            // 
            this._buttonCancel.Location = new System.Drawing.Point(243, 562);
            this._buttonCancel.Name = "_buttonCancel";
            this._buttonCancel.Size = new System.Drawing.Size(121, 42);
            this._buttonCancel.TabIndex = 11;
            this._buttonCancel.Text = "Cancel";
            this._buttonCancel.UseVisualStyleBackColor = true;
            this._buttonCancel.Click += new System.EventHandler(this._buttonCancel_Click);
            // 
            // _errors
            // 
            this._errors.ContainerControl = this;
            // 
            // CreateCharacter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(419, 628);
            this.Controls.Add(this._buttonCancel);
            this.Controls.Add(this._buttonSave);
            this.Controls.Add(this._comboProfession);
            this.Controls.Add(this._comboRace);
            this.Controls.Add(this._txtMoxie);
            this.Controls.Add(this._txtSanity);
            this.Controls.Add(this._txtLuck);
            this.Controls.Add(this._txtBrawn);
            this.Controls.Add(this._txtBrains);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this._txtName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this._richDescription);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CreateCharacter";
            this.ShowIcon = false;
            this.Text = "Create New Character";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this._errors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox _richDescription;
        public System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox _txtName;
        private System.Windows.Forms.ComboBox _comboRace;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox _txtBrains;
        private System.Windows.Forms.TextBox _txtBrawn;
        private System.Windows.Forms.TextBox _txtLuck;
        private System.Windows.Forms.TextBox _txtSanity;
        private System.Windows.Forms.TextBox _txtMoxie;
        private System.Windows.Forms.ComboBox _comboProfession;
        private System.Windows.Forms.Button _buttonSave;
        private System.Windows.Forms.Button _buttonCancel;
        private System.Windows.Forms.ErrorProvider _errors;
    }
}

