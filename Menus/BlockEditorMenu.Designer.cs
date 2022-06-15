
namespace _7DaysToCheat.Menus
{
    partial class BlockEditorMenu
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
            this.BlockListPanel = new System.Windows.Forms.Panel();
            this.BlockListLabel = new System.Windows.Forms.Label();
            this.BlockListBox = new System.Windows.Forms.ListBox();
            this.OptionsPanel = new System.Windows.Forms.Panel();
            this.GetCurrentHeldBlockButton = new System.Windows.Forms.Button();
            this.BlockCraftComponentExpLabel = new System.Windows.Forms.Label();
            this.BlockCraftComponentExpValue = new System.Windows.Forms.NumericUpDown();
            this.ResetBlockButton = new System.Windows.Forms.Button();
            this.UpdateBlockButton = new System.Windows.Forms.Button();
            this.BlockCraftComponentTimeLabel = new System.Windows.Forms.Label();
            this.BlockCraftTimeValue = new System.Windows.Forms.NumericUpDown();
            this.BlockUpgradeHealthLabel = new System.Windows.Forms.Label();
            this.BlockHealthUpgradeValue = new System.Windows.Forms.NumericUpDown();
            this.BlockHealthLabel = new System.Windows.Forms.Label();
            this.Divider1 = new System.Windows.Forms.Panel();
            this.BlockHealthValue = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.HeadPanel.SuspendLayout();
            this.BlockListPanel.SuspendLayout();
            this.OptionsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BlockCraftComponentExpValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlockCraftTimeValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlockHealthUpgradeValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlockHealthValue)).BeginInit();
            this.SuspendLayout();
            // 
            // CloseButton
            // 
            this.CloseButton.AutoSize = true;
            this.CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseButton.ForeColor = System.Drawing.Color.White;
            this.CloseButton.Location = new System.Drawing.Point(474, 4);
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
            this.HeadPanel.Size = new System.Drawing.Size(518, 30);
            this.HeadPanel.TabIndex = 20;
            this.HeadPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HeadPanel_MouseDown);
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.AutoSize = true;
            this.HeaderLabel.ForeColor = System.Drawing.Color.White;
            this.HeaderLabel.Location = new System.Drawing.Point(4, 6);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(64, 13);
            this.HeaderLabel.TabIndex = 19;
            this.HeaderLabel.Text = "Block Editor";
            this.HeaderLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HeaderLabel_MouseDown);
            // 
            // BlockListPanel
            // 
            this.BlockListPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.BlockListPanel.Controls.Add(this.BlockListLabel);
            this.BlockListPanel.Controls.Add(this.BlockListBox);
            this.BlockListPanel.Location = new System.Drawing.Point(11, 41);
            this.BlockListPanel.Name = "BlockListPanel";
            this.BlockListPanel.Size = new System.Drawing.Size(233, 221);
            this.BlockListPanel.TabIndex = 21;
            // 
            // BlockListLabel
            // 
            this.BlockListLabel.AutoSize = true;
            this.BlockListLabel.ForeColor = System.Drawing.Color.White;
            this.BlockListLabel.Location = new System.Drawing.Point(86, 6);
            this.BlockListLabel.Name = "BlockListLabel";
            this.BlockListLabel.Size = new System.Drawing.Size(53, 13);
            this.BlockListLabel.TabIndex = 20;
            this.BlockListLabel.Text = "Block List";
            // 
            // BlockListBox
            // 
            this.BlockListBox.FormattingEnabled = true;
            this.BlockListBox.Location = new System.Drawing.Point(1, 25);
            this.BlockListBox.Name = "BlockListBox";
            this.BlockListBox.ScrollAlwaysVisible = true;
            this.BlockListBox.Size = new System.Drawing.Size(227, 186);
            this.BlockListBox.TabIndex = 22;
            this.BlockListBox.SelectedIndexChanged += new System.EventHandler(this.BlockListBox_SelectedIndexChanged);
            // 
            // OptionsPanel
            // 
            this.OptionsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OptionsPanel.Controls.Add(this.GetCurrentHeldBlockButton);
            this.OptionsPanel.Controls.Add(this.BlockCraftComponentExpLabel);
            this.OptionsPanel.Controls.Add(this.BlockCraftComponentExpValue);
            this.OptionsPanel.Controls.Add(this.ResetBlockButton);
            this.OptionsPanel.Controls.Add(this.UpdateBlockButton);
            this.OptionsPanel.Controls.Add(this.BlockCraftComponentTimeLabel);
            this.OptionsPanel.Controls.Add(this.BlockCraftTimeValue);
            this.OptionsPanel.Controls.Add(this.BlockUpgradeHealthLabel);
            this.OptionsPanel.Controls.Add(this.BlockHealthUpgradeValue);
            this.OptionsPanel.Controls.Add(this.BlockHealthLabel);
            this.OptionsPanel.Controls.Add(this.Divider1);
            this.OptionsPanel.Controls.Add(this.BlockHealthValue);
            this.OptionsPanel.Controls.Add(this.label1);
            this.OptionsPanel.Location = new System.Drawing.Point(260, 41);
            this.OptionsPanel.Name = "OptionsPanel";
            this.OptionsPanel.Size = new System.Drawing.Size(228, 221);
            this.OptionsPanel.TabIndex = 22;
            // 
            // GetCurrentHeldBlockButton
            // 
            this.GetCurrentHeldBlockButton.BackColor = System.Drawing.Color.Black;
            this.GetCurrentHeldBlockButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GetCurrentHeldBlockButton.ForeColor = System.Drawing.Color.White;
            this.GetCurrentHeldBlockButton.Location = new System.Drawing.Point(8, 186);
            this.GetCurrentHeldBlockButton.Name = "GetCurrentHeldBlockButton";
            this.GetCurrentHeldBlockButton.Size = new System.Drawing.Size(207, 23);
            this.GetCurrentHeldBlockButton.TabIndex = 37;
            this.GetCurrentHeldBlockButton.Text = "Get Current Held Block";
            this.GetCurrentHeldBlockButton.UseVisualStyleBackColor = false;
            this.GetCurrentHeldBlockButton.Click += new System.EventHandler(this.GetCurrentHeldBlockButton_Click);
            // 
            // BlockCraftComponentExpLabel
            // 
            this.BlockCraftComponentExpLabel.AutoSize = true;
            this.BlockCraftComponentExpLabel.ForeColor = System.Drawing.Color.White;
            this.BlockCraftComponentExpLabel.Location = new System.Drawing.Point(3, 127);
            this.BlockCraftComponentExpLabel.Name = "BlockCraftComponentExpLabel";
            this.BlockCraftComponentExpLabel.Size = new System.Drawing.Size(110, 13);
            this.BlockCraftComponentExpLabel.TabIndex = 34;
            this.BlockCraftComponentExpLabel.Text = "Craft Component Exp:";
            // 
            // BlockCraftComponentExpValue
            // 
            this.BlockCraftComponentExpValue.Location = new System.Drawing.Point(133, 124);
            this.BlockCraftComponentExpValue.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.BlockCraftComponentExpValue.Name = "BlockCraftComponentExpValue";
            this.BlockCraftComponentExpValue.Size = new System.Drawing.Size(85, 20);
            this.BlockCraftComponentExpValue.TabIndex = 33;
            // 
            // ResetBlockButton
            // 
            this.ResetBlockButton.BackColor = System.Drawing.Color.Black;
            this.ResetBlockButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResetBlockButton.ForeColor = System.Drawing.Color.White;
            this.ResetBlockButton.Location = new System.Drawing.Point(117, 158);
            this.ResetBlockButton.Name = "ResetBlockButton";
            this.ResetBlockButton.Size = new System.Drawing.Size(98, 23);
            this.ResetBlockButton.TabIndex = 32;
            this.ResetBlockButton.Text = "Reset Block";
            this.ResetBlockButton.UseVisualStyleBackColor = false;
            this.ResetBlockButton.Click += new System.EventHandler(this.ResetBlockButton_Click);
            // 
            // UpdateBlockButton
            // 
            this.UpdateBlockButton.BackColor = System.Drawing.Color.Black;
            this.UpdateBlockButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateBlockButton.ForeColor = System.Drawing.Color.White;
            this.UpdateBlockButton.Location = new System.Drawing.Point(8, 158);
            this.UpdateBlockButton.Name = "UpdateBlockButton";
            this.UpdateBlockButton.Size = new System.Drawing.Size(100, 23);
            this.UpdateBlockButton.TabIndex = 31;
            this.UpdateBlockButton.Text = "Update Block";
            this.UpdateBlockButton.UseVisualStyleBackColor = false;
            this.UpdateBlockButton.Click += new System.EventHandler(this.UpdateBlockButton_Click);
            // 
            // BlockCraftComponentTimeLabel
            // 
            this.BlockCraftComponentTimeLabel.AutoSize = true;
            this.BlockCraftComponentTimeLabel.ForeColor = System.Drawing.Color.White;
            this.BlockCraftComponentTimeLabel.Location = new System.Drawing.Point(3, 98);
            this.BlockCraftComponentTimeLabel.Name = "BlockCraftComponentTimeLabel";
            this.BlockCraftComponentTimeLabel.Size = new System.Drawing.Size(115, 13);
            this.BlockCraftComponentTimeLabel.TabIndex = 30;
            this.BlockCraftComponentTimeLabel.Text = "Craft Component Time:";
            // 
            // BlockCraftTimeValue
            // 
            this.BlockCraftTimeValue.Location = new System.Drawing.Point(133, 95);
            this.BlockCraftTimeValue.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.BlockCraftTimeValue.Name = "BlockCraftTimeValue";
            this.BlockCraftTimeValue.Size = new System.Drawing.Size(85, 20);
            this.BlockCraftTimeValue.TabIndex = 29;
            // 
            // BlockUpgradeHealthLabel
            // 
            this.BlockUpgradeHealthLabel.AutoSize = true;
            this.BlockUpgradeHealthLabel.ForeColor = System.Drawing.Color.White;
            this.BlockUpgradeHealthLabel.Location = new System.Drawing.Point(3, 69);
            this.BlockUpgradeHealthLabel.Name = "BlockUpgradeHealthLabel";
            this.BlockUpgradeHealthLabel.Size = new System.Drawing.Size(120, 13);
            this.BlockUpgradeHealthLabel.TabIndex = 28;
            this.BlockUpgradeHealthLabel.Text = "Block Upgrades Health:";
            // 
            // BlockHealthUpgradeValue
            // 
            this.BlockHealthUpgradeValue.Location = new System.Drawing.Point(133, 66);
            this.BlockHealthUpgradeValue.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.BlockHealthUpgradeValue.Name = "BlockHealthUpgradeValue";
            this.BlockHealthUpgradeValue.Size = new System.Drawing.Size(85, 20);
            this.BlockHealthUpgradeValue.TabIndex = 27;
            // 
            // BlockHealthLabel
            // 
            this.BlockHealthLabel.AutoSize = true;
            this.BlockHealthLabel.ForeColor = System.Drawing.Color.White;
            this.BlockHealthLabel.Location = new System.Drawing.Point(3, 40);
            this.BlockHealthLabel.Name = "BlockHealthLabel";
            this.BlockHealthLabel.Size = new System.Drawing.Size(71, 13);
            this.BlockHealthLabel.TabIndex = 26;
            this.BlockHealthLabel.Text = "Block Health:";
            // 
            // Divider1
            // 
            this.Divider1.BackColor = System.Drawing.Color.White;
            this.Divider1.Location = new System.Drawing.Point(0, 25);
            this.Divider1.Name = "Divider1";
            this.Divider1.Size = new System.Drawing.Size(230, 2);
            this.Divider1.TabIndex = 25;
            // 
            // BlockHealthValue
            // 
            this.BlockHealthValue.Location = new System.Drawing.Point(133, 37);
            this.BlockHealthValue.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.BlockHealthValue.Name = "BlockHealthValue";
            this.BlockHealthValue.Size = new System.Drawing.Size(85, 20);
            this.BlockHealthValue.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(72, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Block Properties";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Turquoise;
            this.label2.Location = new System.Drawing.Point(8, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(476, 26);
            this.label2.TabIndex = 38;
            this.label2.Text = "Warning: This only edits values locally, ive tried to get it to edit it globally " +
    "but cannot find a way right \r\nnow";
            // 
            // BlockEditorMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(498, 303);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.OptionsPanel);
            this.Controls.Add(this.BlockListPanel);
            this.Controls.Add(this.HeadPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BlockEditorMenu";
            this.Text = "Block Editor";
            this.Load += new System.EventHandler(this.BlockEditorMenu_Load);
            this.HeadPanel.ResumeLayout(false);
            this.HeadPanel.PerformLayout();
            this.BlockListPanel.ResumeLayout(false);
            this.BlockListPanel.PerformLayout();
            this.OptionsPanel.ResumeLayout(false);
            this.OptionsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BlockCraftComponentExpValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlockCraftTimeValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlockHealthUpgradeValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlockHealthValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CloseButton;
        private System.Windows.Forms.Panel HeadPanel;
        private System.Windows.Forms.Label HeaderLabel;
        private System.Windows.Forms.Panel BlockListPanel;
        private System.Windows.Forms.Label BlockListLabel;
        private System.Windows.Forms.ListBox BlockListBox;
        private System.Windows.Forms.Panel OptionsPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label BlockHealthLabel;
        private System.Windows.Forms.Panel Divider1;
        private System.Windows.Forms.Label BlockUpgradeHealthLabel;
        private System.Windows.Forms.Label BlockCraftComponentTimeLabel;
        public System.Windows.Forms.Button ResetBlockButton;
        public System.Windows.Forms.Button UpdateBlockButton;
        private System.Windows.Forms.Label BlockCraftComponentExpLabel;
        public System.Windows.Forms.NumericUpDown BlockHealthValue;
        public System.Windows.Forms.NumericUpDown BlockHealthUpgradeValue;
        public System.Windows.Forms.NumericUpDown BlockCraftTimeValue;
        public System.Windows.Forms.NumericUpDown BlockCraftComponentExpValue;
        public System.Windows.Forms.Button GetCurrentHeldBlockButton;
        private System.Windows.Forms.Label label2;
    }
}