namespace C7D2C.Menus
{
    partial class WeaponModiferMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CloseButton = new System.Windows.Forms.Label();
            this.HeadPanel = new System.Windows.Forms.Panel();
            this.HeaderLabel = new System.Windows.Forms.Label();
            this.SettingsPanel = new System.Windows.Forms.Panel();
            this.DisabledEntitiesHeaderLabel = new System.Windows.Forms.Label();
            this.GunsCheckList = new System.Windows.Forms.CheckedListBox();
            this.OptionsCheckList = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ChooseColorButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.OptionsListBox = new System.Windows.Forms.CheckedListBox();
            this.WeaponListBox = new System.Windows.Forms.CheckedListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.HeadPanel.SuspendLayout();
            this.SettingsPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // CloseButton
            // 
            this.CloseButton.AutoSize = true;
            this.CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseButton.ForeColor = System.Drawing.Color.White;
            this.CloseButton.Location = new System.Drawing.Point(593, 5);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(15, 15);
            this.CloseButton.TabIndex = 0;
            this.CloseButton.Text = "X";
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // HeadPanel
            // 
            this.HeadPanel.BackColor = System.Drawing.SystemColors.WindowText;
            this.HeadPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.HeadPanel.Controls.Add(this.HeaderLabel);
            this.HeadPanel.Controls.Add(this.CloseButton);
            this.HeadPanel.Location = new System.Drawing.Point(-3, -3);
            this.HeadPanel.Name = "HeadPanel";
            this.HeadPanel.Size = new System.Drawing.Size(621, 30);
            this.HeadPanel.TabIndex = 20;
            this.HeadPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HeadPanel_MouseDown);
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.AutoSize = true;
            this.HeaderLabel.ForeColor = System.Drawing.Color.White;
            this.HeaderLabel.Location = new System.Drawing.Point(4, 7);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(86, 13);
            this.HeaderLabel.TabIndex = 19;
            this.HeaderLabel.Text = "Weapon Modifer";
            this.HeaderLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HeaderLabel_MouseDown);
            // 
            // SettingsPanel
            // 
            this.SettingsPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SettingsPanel.Controls.Add(this.panel1);
            this.SettingsPanel.Controls.Add(this.label1);
            this.SettingsPanel.Controls.Add(this.OptionsCheckList);
            this.SettingsPanel.Controls.Add(this.GunsCheckList);
            this.SettingsPanel.Controls.Add(this.DisabledEntitiesHeaderLabel);
            this.SettingsPanel.Location = new System.Drawing.Point(12, 45);
            this.SettingsPanel.Name = "SettingsPanel";
            this.SettingsPanel.Size = new System.Drawing.Size(399, 214);
            this.SettingsPanel.TabIndex = 22;
            // 
            // DisabledEntitiesHeaderLabel
            // 
            this.DisabledEntitiesHeaderLabel.AutoSize = true;
            this.DisabledEntitiesHeaderLabel.ForeColor = System.Drawing.Color.White;
            this.DisabledEntitiesHeaderLabel.Location = new System.Drawing.Point(64, 0);
            this.DisabledEntitiesHeaderLabel.Name = "DisabledEntitiesHeaderLabel";
            this.DisabledEntitiesHeaderLabel.Size = new System.Drawing.Size(56, 13);
            this.DisabledEntitiesHeaderLabel.TabIndex = 20;
            this.DisabledEntitiesHeaderLabel.Text = "Weapons:";
            // 
            // GunsCheckList
            // 
            this.GunsCheckList.BackColor = System.Drawing.Color.Maroon;
            this.GunsCheckList.ForeColor = System.Drawing.Color.White;
            this.GunsCheckList.FormattingEnabled = true;
            this.GunsCheckList.HorizontalScrollbar = true;
            this.GunsCheckList.Location = new System.Drawing.Point(6, 16);
            this.GunsCheckList.MultiColumn = true;
            this.GunsCheckList.Name = "GunsCheckList";
            this.GunsCheckList.Size = new System.Drawing.Size(183, 184);
            this.GunsCheckList.TabIndex = 35;
            this.GunsCheckList.ThreeDCheckBoxes = true;
            // 
            // OptionsCheckList
            // 
            this.OptionsCheckList.BackColor = System.Drawing.Color.Maroon;
            this.OptionsCheckList.ForeColor = System.Drawing.Color.White;
            this.OptionsCheckList.FormattingEnabled = true;
            this.OptionsCheckList.HorizontalScrollbar = true;
            this.OptionsCheckList.Location = new System.Drawing.Point(203, 16);
            this.OptionsCheckList.MultiColumn = true;
            this.OptionsCheckList.Name = "OptionsCheckList";
            this.OptionsCheckList.Size = new System.Drawing.Size(183, 184);
            this.OptionsCheckList.TabIndex = 36;
            this.OptionsCheckList.ThreeDCheckBoxes = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(275, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "Options:";
            // 
            // ChooseColorButton
            // 
            this.ChooseColorButton.BackColor = System.Drawing.Color.Black;
            this.ChooseColorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChooseColorButton.ForeColor = System.Drawing.Color.White;
            this.ChooseColorButton.Location = new System.Drawing.Point(12, 265);
            this.ChooseColorButton.Name = "ChooseColorButton";
            this.ChooseColorButton.Size = new System.Drawing.Size(122, 23);
            this.ChooseColorButton.TabIndex = 23;
            this.ChooseColorButton.Text = "Refresh List";
            this.ChooseColorButton.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(151, 265);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 23);
            this.button1.TabIndex = 24;
            this.button1.Text = "Add Current Held Gun";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(289, 265);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 23);
            this.button2.TabIndex = 25;
            this.button2.Text = "Reset All Weapons";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(4, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "Custom Presets:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.OptionsListBox);
            this.panel1.Controls.Add(this.WeaponListBox);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(-2, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(399, 214);
            this.panel1.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(275, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "Options:";
            // 
            // OptionsListBox
            // 
            this.OptionsListBox.BackColor = System.Drawing.Color.Maroon;
            this.OptionsListBox.ForeColor = System.Drawing.Color.White;
            this.OptionsListBox.FormattingEnabled = true;
            this.OptionsListBox.HorizontalScrollbar = true;
            this.OptionsListBox.Items.AddRange(new object[] {
            "No Spread",
            "No Recoil",
            "Faster Fire Rate",
            "Insane Fire Rate",
            "Unlimited Ammo",
            "Max Damage",
            "Max Durability",
            "No Damage Per Use",
            "Max Range",
            "Max Mag Size"});
            this.OptionsListBox.Location = new System.Drawing.Point(203, 16);
            this.OptionsListBox.MultiColumn = true;
            this.OptionsListBox.Name = "OptionsListBox";
            this.OptionsListBox.Size = new System.Drawing.Size(183, 184);
            this.OptionsListBox.TabIndex = 36;
            this.OptionsListBox.ThreeDCheckBoxes = true;
            // 
            // WeaponListBox
            // 
            this.WeaponListBox.BackColor = System.Drawing.Color.Maroon;
            this.WeaponListBox.ForeColor = System.Drawing.Color.White;
            this.WeaponListBox.FormattingEnabled = true;
            this.WeaponListBox.HorizontalScrollbar = true;
            this.WeaponListBox.Location = new System.Drawing.Point(6, 16);
            this.WeaponListBox.MultiColumn = true;
            this.WeaponListBox.Name = "WeaponListBox";
            this.WeaponListBox.Size = new System.Drawing.Size(183, 184);
            this.WeaponListBox.TabIndex = 35;
            this.WeaponListBox.ThreeDCheckBoxes = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(64, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Weapons:";
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(506, 47);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(96, 241);
            this.panel3.TabIndex = 38;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Black;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(420, 66);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(77, 23);
            this.button3.TabIndex = 26;
            this.button3.Text = "Default";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(415, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "Weapon Presets:";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Black;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(420, 95);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(77, 23);
            this.button4.TabIndex = 39;
            this.button4.Text = "Silent";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Black;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(420, 124);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(77, 23);
            this.button5.TabIndex = 40;
            this.button5.Text = "Pro";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Black;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(420, 153);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(77, 23);
            this.button6.TabIndex = 41;
            this.button6.Text = "Rage";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Black;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(420, 182);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(77, 23);
            this.button7.TabIndex = 42;
            this.button7.Text = "Cheater";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Black;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.ForeColor = System.Drawing.Color.White;
            this.button9.Location = new System.Drawing.Point(420, 211);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(77, 23);
            this.button9.TabIndex = 44;
            this.button9.Text = "UnHoly";
            this.button9.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Black;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Location = new System.Drawing.Point(420, 265);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(77, 23);
            this.button8.TabIndex = 43;
            this.button8.Text = "Custom";
            this.button8.UseVisualStyleBackColor = false;
            // 
            // WeaponModiferMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(614, 294);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ChooseColorButton);
            this.Controls.Add(this.SettingsPanel);
            this.Controls.Add(this.HeadPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WeaponModiferMenu";
            this.Text = "WeaponModifer";
            this.Load += new System.EventHandler(this.WeaponModiferMenu_Load);
            this.HeadPanel.ResumeLayout(false);
            this.HeadPanel.PerformLayout();
            this.SettingsPanel.ResumeLayout(false);
            this.SettingsPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CloseButton;
        private System.Windows.Forms.Panel HeadPanel;
        private System.Windows.Forms.Label HeaderLabel;
        private System.Windows.Forms.Panel SettingsPanel;
        private System.Windows.Forms.Label DisabledEntitiesHeaderLabel;
        public System.Windows.Forms.CheckedListBox GunsCheckList;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.CheckedListBox OptionsCheckList;
        private System.Windows.Forms.Button ChooseColorButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.CheckedListBox OptionsListBox;
        public System.Windows.Forms.CheckedListBox WeaponListBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
    }
}