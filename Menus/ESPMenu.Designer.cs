
namespace _7DaysToCheat.Menus
{
    partial class ESPMenu
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
            this.HeaderLabel = new System.Windows.Forms.Label();
            this.HeadPanel = new System.Windows.Forms.Panel();
            this.CloseButton = new System.Windows.Forms.Label();
            this.ColorEditorDialog = new System.Windows.Forms.ColorDialog();
            this.ChooseColorButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DisabledEntitiesListView = new System.Windows.Forms.ListView();
            this.AddEntityButton = new System.Windows.Forms.Button();
            this.DisabledEntitiesHeaderLabel = new System.Windows.Forms.Label();
            this.EnableChamsCheckBox = new System.Windows.Forms.CheckBox();
            this.EnableEspOptionCheckBox = new System.Windows.Forms.CheckBox();
            this.EspColorPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.EnabledEntitesListView = new System.Windows.Forms.ListView();
            this.RemoveEntityButton = new System.Windows.Forms.Button();
            this.EnabledEntitiesHeaderLabel = new System.Windows.Forms.Label();
            this.EntityComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ApproachingPlayerEspColorPanel = new System.Windows.Forms.Panel();
            this.ApproachingPlayerEspColorButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.EspOptionsCheckListBox = new System.Windows.Forms.CheckedListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.EnableRadarCheckBox = new System.Windows.Forms.CheckBox();
            this.HeadPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.AutoSize = true;
            this.HeaderLabel.ForeColor = System.Drawing.Color.White;
            this.HeaderLabel.Location = new System.Drawing.Point(4, 7);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(79, 13);
            this.HeaderLabel.TabIndex = 19;
            this.HeaderLabel.Text = "Customize ESP";
            this.HeaderLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HeaderLabel_MouseDown);
            // 
            // HeadPanel
            // 
            this.HeadPanel.BackColor = System.Drawing.SystemColors.WindowText;
            this.HeadPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.HeadPanel.Controls.Add(this.HeaderLabel);
            this.HeadPanel.Controls.Add(this.CloseButton);
            this.HeadPanel.Location = new System.Drawing.Point(-2, -3);
            this.HeadPanel.Name = "HeadPanel";
            this.HeadPanel.Size = new System.Drawing.Size(583, 30);
            this.HeadPanel.TabIndex = 19;
            this.HeadPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HeadPanel_MouseDown);
            // 
            // CloseButton
            // 
            this.CloseButton.AutoSize = true;
            this.CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseButton.ForeColor = System.Drawing.Color.White;
            this.CloseButton.Location = new System.Drawing.Point(559, 5);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(15, 15);
            this.CloseButton.TabIndex = 0;
            this.CloseButton.Text = "X";
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // ColorEditorDialog
            // 
            this.ColorEditorDialog.AnyColor = true;
            this.ColorEditorDialog.FullOpen = true;
            this.ColorEditorDialog.SolidColorOnly = true;
            // 
            // ChooseColorButton
            // 
            this.ChooseColorButton.BackColor = System.Drawing.Color.Black;
            this.ChooseColorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChooseColorButton.ForeColor = System.Drawing.Color.White;
            this.ChooseColorButton.Location = new System.Drawing.Point(430, 102);
            this.ChooseColorButton.Name = "ChooseColorButton";
            this.ChooseColorButton.Size = new System.Drawing.Size(103, 23);
            this.ChooseColorButton.TabIndex = 20;
            this.ChooseColorButton.Text = "Set Color";
            this.ChooseColorButton.UseVisualStyleBackColor = false;
            this.ChooseColorButton.Click += new System.EventHandler(this.ChooseColorButton_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.DisabledEntitiesListView);
            this.panel1.Controls.Add(this.AddEntityButton);
            this.panel1.Controls.Add(this.DisabledEntitiesHeaderLabel);
            this.panel1.Controls.Add(this.EnableChamsCheckBox);
            this.panel1.Controls.Add(this.EnableEspOptionCheckBox);
            this.panel1.Location = new System.Drawing.Point(7, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(205, 214);
            this.panel1.TabIndex = 21;
            // 
            // DisabledEntitiesListView
            // 
            this.DisabledEntitiesListView.HideSelection = false;
            this.DisabledEntitiesListView.LabelWrap = false;
            this.DisabledEntitiesListView.Location = new System.Drawing.Point(3, 22);
            this.DisabledEntitiesListView.MultiSelect = false;
            this.DisabledEntitiesListView.Name = "DisabledEntitiesListView";
            this.DisabledEntitiesListView.Size = new System.Drawing.Size(193, 157);
            this.DisabledEntitiesListView.TabIndex = 21;
            this.DisabledEntitiesListView.UseCompatibleStateImageBehavior = false;
            // 
            // AddEntityButton
            // 
            this.AddEntityButton.BackColor = System.Drawing.Color.Black;
            this.AddEntityButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddEntityButton.ForeColor = System.Drawing.Color.White;
            this.AddEntityButton.Location = new System.Drawing.Point(92, 183);
            this.AddEntityButton.Name = "AddEntityButton";
            this.AddEntityButton.Size = new System.Drawing.Size(103, 23);
            this.AddEntityButton.TabIndex = 24;
            this.AddEntityButton.Text = "Add Entity ->";
            this.AddEntityButton.UseVisualStyleBackColor = false;
            this.AddEntityButton.Click += new System.EventHandler(this.AddEntityButton_Click);
            // 
            // DisabledEntitiesHeaderLabel
            // 
            this.DisabledEntitiesHeaderLabel.AutoSize = true;
            this.DisabledEntitiesHeaderLabel.ForeColor = System.Drawing.Color.White;
            this.DisabledEntitiesHeaderLabel.Location = new System.Drawing.Point(54, 4);
            this.DisabledEntitiesHeaderLabel.Name = "DisabledEntitiesHeaderLabel";
            this.DisabledEntitiesHeaderLabel.Size = new System.Drawing.Size(88, 13);
            this.DisabledEntitiesHeaderLabel.TabIndex = 20;
            this.DisabledEntitiesHeaderLabel.Text = "Disabled Entities:";
            // 
            // EnableChamsCheckBox
            // 
            this.EnableChamsCheckBox.AutoSize = true;
            this.EnableChamsCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.EnableChamsCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.99F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnableChamsCheckBox.ForeColor = System.Drawing.Color.White;
            this.EnableChamsCheckBox.Location = new System.Drawing.Point(3, 193);
            this.EnableChamsCheckBox.Name = "EnableChamsCheckBox";
            this.EnableChamsCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.EnableChamsCheckBox.Size = new System.Drawing.Size(94, 17);
            this.EnableChamsCheckBox.TabIndex = 37;
            this.EnableChamsCheckBox.Text = "Enable Chams";
            this.EnableChamsCheckBox.UseVisualStyleBackColor = false;
            // 
            // EnableEspOptionCheckBox
            // 
            this.EnableEspOptionCheckBox.AutoSize = true;
            this.EnableEspOptionCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.EnableEspOptionCheckBox.ForeColor = System.Drawing.Color.White;
            this.EnableEspOptionCheckBox.Location = new System.Drawing.Point(3, 179);
            this.EnableEspOptionCheckBox.Name = "EnableEspOptionCheckBox";
            this.EnableEspOptionCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.EnableEspOptionCheckBox.Size = new System.Drawing.Size(83, 17);
            this.EnableEspOptionCheckBox.TabIndex = 36;
            this.EnableEspOptionCheckBox.Text = "Enable ESP";
            this.EnableEspOptionCheckBox.UseVisualStyleBackColor = false;
            // 
            // EspColorPanel
            // 
            this.EspColorPanel.BackColor = System.Drawing.Color.Green;
            this.EspColorPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.EspColorPanel.Location = new System.Drawing.Point(541, 102);
            this.EspColorPanel.Name = "EspColorPanel";
            this.EspColorPanel.Size = new System.Drawing.Size(23, 23);
            this.EspColorPanel.TabIndex = 21;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.EnabledEntitesListView);
            this.panel2.Controls.Add(this.EnableRadarCheckBox);
            this.panel2.Controls.Add(this.RemoveEntityButton);
            this.panel2.Controls.Add(this.EnabledEntitiesHeaderLabel);
            this.panel2.Location = new System.Drawing.Point(218, 45);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(203, 214);
            this.panel2.TabIndex = 22;
            // 
            // EnabledEntitesListView
            // 
            this.EnabledEntitesListView.HideSelection = false;
            this.EnabledEntitesListView.LabelWrap = false;
            this.EnabledEntitesListView.Location = new System.Drawing.Point(4, 22);
            this.EnabledEntitesListView.MultiSelect = false;
            this.EnabledEntitesListView.Name = "EnabledEntitesListView";
            this.EnabledEntitesListView.Size = new System.Drawing.Size(190, 157);
            this.EnabledEntitesListView.TabIndex = 22;
            this.EnabledEntitesListView.UseCompatibleStateImageBehavior = false;
            // 
            // RemoveEntityButton
            // 
            this.RemoveEntityButton.BackColor = System.Drawing.Color.Black;
            this.RemoveEntityButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveEntityButton.ForeColor = System.Drawing.Color.White;
            this.RemoveEntityButton.Location = new System.Drawing.Point(5, 183);
            this.RemoveEntityButton.Name = "RemoveEntityButton";
            this.RemoveEntityButton.Size = new System.Drawing.Size(103, 23);
            this.RemoveEntityButton.TabIndex = 23;
            this.RemoveEntityButton.Text = "<- Remove Entity";
            this.RemoveEntityButton.UseVisualStyleBackColor = false;
            this.RemoveEntityButton.Click += new System.EventHandler(this.RemoveEntityButton_Click);
            // 
            // EnabledEntitiesHeaderLabel
            // 
            this.EnabledEntitiesHeaderLabel.AutoSize = true;
            this.EnabledEntitiesHeaderLabel.ForeColor = System.Drawing.Color.White;
            this.EnabledEntitiesHeaderLabel.Location = new System.Drawing.Point(54, 4);
            this.EnabledEntitiesHeaderLabel.Name = "EnabledEntitiesHeaderLabel";
            this.EnabledEntitiesHeaderLabel.Size = new System.Drawing.Size(89, 13);
            this.EnabledEntitiesHeaderLabel.TabIndex = 20;
            this.EnabledEntitiesHeaderLabel.Text = "Enabled Entitites:";
            // 
            // EntityComboBox
            // 
            this.EntityComboBox.FormattingEnabled = true;
            this.EntityComboBox.Location = new System.Drawing.Point(430, 61);
            this.EntityComboBox.Name = "EntityComboBox";
            this.EntityComboBox.Size = new System.Drawing.Size(134, 21);
            this.EntityComboBox.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(427, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Selected Entity:";
            // 
            // ApproachingPlayerEspColorPanel
            // 
            this.ApproachingPlayerEspColorPanel.BackColor = System.Drawing.Color.Red;
            this.ApproachingPlayerEspColorPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ApproachingPlayerEspColorPanel.Location = new System.Drawing.Point(541, 144);
            this.ApproachingPlayerEspColorPanel.Name = "ApproachingPlayerEspColorPanel";
            this.ApproachingPlayerEspColorPanel.Size = new System.Drawing.Size(23, 23);
            this.ApproachingPlayerEspColorPanel.TabIndex = 26;
            // 
            // ApproachingPlayerEspColorButton
            // 
            this.ApproachingPlayerEspColorButton.BackColor = System.Drawing.Color.Black;
            this.ApproachingPlayerEspColorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ApproachingPlayerEspColorButton.ForeColor = System.Drawing.Color.White;
            this.ApproachingPlayerEspColorButton.Location = new System.Drawing.Point(430, 144);
            this.ApproachingPlayerEspColorButton.Name = "ApproachingPlayerEspColorButton";
            this.ApproachingPlayerEspColorButton.Size = new System.Drawing.Size(103, 23);
            this.ApproachingPlayerEspColorButton.TabIndex = 25;
            this.ApproachingPlayerEspColorButton.Text = "Set Color";
            this.ApproachingPlayerEspColorButton.UseVisualStyleBackColor = false;
            this.ApproachingPlayerEspColorButton.Click += new System.EventHandler(this.ApproachingPlayerEspButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(427, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Entity Approaching Color:\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(427, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Entity Color:";
            // 
            // EspOptionsCheckListBox
            // 
            this.EspOptionsCheckListBox.BackColor = System.Drawing.Color.Maroon;
            this.EspOptionsCheckListBox.ForeColor = System.Drawing.Color.White;
            this.EspOptionsCheckListBox.FormattingEnabled = true;
            this.EspOptionsCheckListBox.HorizontalScrollbar = true;
            this.EspOptionsCheckListBox.Location = new System.Drawing.Point(430, 185);
            this.EspOptionsCheckListBox.MultiColumn = true;
            this.EspOptionsCheckListBox.Name = "EspOptionsCheckListBox";
            this.EspOptionsCheckListBox.Size = new System.Drawing.Size(134, 79);
            this.EspOptionsCheckListBox.TabIndex = 34;
            this.EspOptionsCheckListBox.ThreeDCheckBoxes = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(428, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "ESP Options:";
            // 
            // EnableRadarCheckBox
            // 
            this.EnableRadarCheckBox.AutoSize = true;
            this.EnableRadarCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.EnableRadarCheckBox.ForeColor = System.Drawing.Color.White;
            this.EnableRadarCheckBox.Location = new System.Drawing.Point(111, 181);
            this.EnableRadarCheckBox.Name = "EnableRadarCheckBox";
            this.EnableRadarCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.EnableRadarCheckBox.Size = new System.Drawing.Size(91, 17);
            this.EnableRadarCheckBox.TabIndex = 38;
            this.EnableRadarCheckBox.Text = "Enable Radar";
            this.EnableRadarCheckBox.UseVisualStyleBackColor = false;
            // 
            // ESPMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(576, 271);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.EspOptionsCheckListBox);
            this.Controls.Add(this.EspColorPanel);
            this.Controls.Add(this.ApproachingPlayerEspColorPanel);
            this.Controls.Add(this.ApproachingPlayerEspColorButton);
            this.Controls.Add(this.ChooseColorButton);
            this.Controls.Add(this.EntityComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.HeadPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ESPMenu";
            this.Text = "ESPMenu";
            this.Load += new System.EventHandler(this.ESPMenu_Load);
            this.HeadPanel.ResumeLayout(false);
            this.HeadPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HeaderLabel;
        private System.Windows.Forms.Panel HeadPanel;
        private System.Windows.Forms.Label CloseButton;
        private System.Windows.Forms.Button ChooseColorButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label DisabledEntitiesHeaderLabel;
        public System.Windows.Forms.Panel EspColorPanel;
        public System.Windows.Forms.ColorDialog ColorEditorDialog;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label EnabledEntitiesHeaderLabel;
        private System.Windows.Forms.Button AddEntityButton;
        private System.Windows.Forms.Button RemoveEntityButton;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Panel ApproachingPlayerEspColorPanel;
        private System.Windows.Forms.Button ApproachingPlayerEspColorButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.ListView DisabledEntitiesListView;
        public System.Windows.Forms.ListView EnabledEntitesListView;
        public System.Windows.Forms.CheckedListBox EspOptionsCheckListBox;
        public System.Windows.Forms.ComboBox EntityComboBox;
        public System.Windows.Forms.CheckBox EnableEspOptionCheckBox;
        public System.Windows.Forms.CheckBox EnableChamsCheckBox;
        public System.Windows.Forms.CheckBox EnableRadarCheckBox;
    }
}