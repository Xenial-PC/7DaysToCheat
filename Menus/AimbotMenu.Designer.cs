
namespace _7DaysToCheat.Menus
{
    partial class AimbotMenu
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.DisabledEntitiesListView = new System.Windows.Forms.ListView();
            this.AddEntityButton = new System.Windows.Forms.Button();
            this.DisabledEntitiesHeaderLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.EnabledEntitesListView = new System.Windows.Forms.ListView();
            this.RemoveEntityButton = new System.Windows.Forms.Button();
            this.EnabledEntitiesHeaderLabel = new System.Windows.Forms.Label();
            this.AimbotSettingsCheckBoxList = new System.Windows.Forms.CheckedListBox();
            this.FOVSlider = new System.Windows.Forms.TrackBar();
            this.FOVLabel = new System.Windows.Forms.Label();
            this.DistanceSlider = new System.Windows.Forms.TrackBar();
            this.DistanceLabel = new System.Windows.Forms.Label();
            this.CurrentDistanceLabel = new System.Windows.Forms.Label();
            this.CurrentFOVSizeLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.HeadPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FOVSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DistanceSlider)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // CloseButton
            // 
            this.CloseButton.AutoSize = true;
            this.CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseButton.ForeColor = System.Drawing.Color.White;
            this.CloseButton.Location = new System.Drawing.Point(529, 5);
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
            this.HeadPanel.Size = new System.Drawing.Size(561, 30);
            this.HeadPanel.TabIndex = 20;
            this.HeadPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HeadPanel_MouseDown);
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.AutoSize = true;
            this.HeaderLabel.ForeColor = System.Drawing.Color.White;
            this.HeaderLabel.Location = new System.Drawing.Point(4, 7);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(90, 13);
            this.HeaderLabel.TabIndex = 19;
            this.HeaderLabel.Text = "Customize Aimbot";
            this.HeaderLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HeaderLabel_MouseDown);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.DisabledEntitiesListView);
            this.panel1.Controls.Add(this.AddEntityButton);
            this.panel1.Controls.Add(this.DisabledEntitiesHeaderLabel);
            this.panel1.Location = new System.Drawing.Point(8, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(205, 214);
            this.panel1.TabIndex = 23;
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
            this.DisabledEntitiesListView.View = System.Windows.Forms.View.List;
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
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.EnabledEntitesListView);
            this.panel2.Controls.Add(this.RemoveEntityButton);
            this.panel2.Controls.Add(this.EnabledEntitiesHeaderLabel);
            this.panel2.Location = new System.Drawing.Point(219, 42);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(203, 214);
            this.panel2.TabIndex = 24;
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
            this.EnabledEntitesListView.View = System.Windows.Forms.View.List;
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
            // AimbotSettingsCheckBoxList
            // 
            this.AimbotSettingsCheckBoxList.BackColor = System.Drawing.Color.Maroon;
            this.AimbotSettingsCheckBoxList.ForeColor = System.Drawing.Color.White;
            this.AimbotSettingsCheckBoxList.FormattingEnabled = true;
            this.AimbotSettingsCheckBoxList.Items.AddRange(new object[] {
            "Enable Aimbot",
            "FOV Aimbot",
            "FOV Circle(Overlay)",
            "Toggle FOV"});
            this.AimbotSettingsCheckBoxList.Location = new System.Drawing.Point(428, 59);
            this.AimbotSettingsCheckBoxList.Name = "AimbotSettingsCheckBoxList";
            this.AimbotSettingsCheckBoxList.Size = new System.Drawing.Size(115, 199);
            this.AimbotSettingsCheckBoxList.TabIndex = 28;
            this.AimbotSettingsCheckBoxList.ThreeDCheckBoxes = true;
            // 
            // FOVSlider
            // 
            this.FOVSlider.Location = new System.Drawing.Point(360, 259);
            this.FOVSlider.Maximum = 5;
            this.FOVSlider.Minimum = 1;
            this.FOVSlider.Name = "FOVSlider";
            this.FOVSlider.Size = new System.Drawing.Size(191, 45);
            this.FOVSlider.TabIndex = 29;
            this.FOVSlider.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.FOVSlider.Value = 1;
            this.FOVSlider.ValueChanged += new System.EventHandler(this.FOVSlider_ValueChanged);
            // 
            // FOVLabel
            // 
            this.FOVLabel.AutoSize = true;
            this.FOVLabel.ForeColor = System.Drawing.Color.White;
            this.FOVLabel.Location = new System.Drawing.Point(330, 259);
            this.FOVLabel.Name = "FOVLabel";
            this.FOVLabel.Size = new System.Drawing.Size(31, 13);
            this.FOVLabel.TabIndex = 25;
            this.FOVLabel.Text = "FOV:";
            // 
            // DistanceSlider
            // 
            this.DistanceSlider.AutoSize = false;
            this.DistanceSlider.Location = new System.Drawing.Point(69, 259);
            this.DistanceSlider.Maximum = 500;
            this.DistanceSlider.Minimum = 25;
            this.DistanceSlider.Name = "DistanceSlider";
            this.DistanceSlider.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DistanceSlider.Size = new System.Drawing.Size(201, 45);
            this.DistanceSlider.TabIndex = 30;
            this.DistanceSlider.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.DistanceSlider.Value = 100;
            this.DistanceSlider.ValueChanged += new System.EventHandler(this.DistanceSlider_ValueChanged);
            // 
            // DistanceLabel
            // 
            this.DistanceLabel.AutoSize = true;
            this.DistanceLabel.ForeColor = System.Drawing.Color.White;
            this.DistanceLabel.Location = new System.Drawing.Point(18, 259);
            this.DistanceLabel.Name = "DistanceLabel";
            this.DistanceLabel.Size = new System.Drawing.Size(52, 13);
            this.DistanceLabel.TabIndex = 31;
            this.DistanceLabel.Text = "Distance:";
            // 
            // CurrentDistanceLabel
            // 
            this.CurrentDistanceLabel.AutoSize = true;
            this.CurrentDistanceLabel.ForeColor = System.Drawing.Color.White;
            this.CurrentDistanceLabel.Location = new System.Drawing.Point(5, 275);
            this.CurrentDistanceLabel.Name = "CurrentDistanceLabel";
            this.CurrentDistanceLabel.Size = new System.Drawing.Size(65, 13);
            this.CurrentDistanceLabel.TabIndex = 32;
            this.CurrentDistanceLabel.Text = "Current: 100";
            // 
            // CurrentFOVSizeLabel
            // 
            this.CurrentFOVSizeLabel.AutoSize = true;
            this.CurrentFOVSizeLabel.ForeColor = System.Drawing.Color.White;
            this.CurrentFOVSizeLabel.Location = new System.Drawing.Point(308, 275);
            this.CurrentFOVSizeLabel.Name = "CurrentFOVSizeLabel";
            this.CurrentFOVSizeLabel.Size = new System.Drawing.Size(53, 13);
            this.CurrentFOVSizeLabel.TabIndex = 33;
            this.CurrentFOVSizeLabel.Text = "Current: 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(14, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Aimbot Settings:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(428, 42);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(115, 19);
            this.panel3.TabIndex = 21;
            // 
            // AimbotMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(552, 292);
            this.Controls.Add(this.FOVSlider);
            this.Controls.Add(this.DistanceSlider);
            this.Controls.Add(this.CurrentFOVSizeLabel);
            this.Controls.Add(this.FOVLabel);
            this.Controls.Add(this.CurrentDistanceLabel);
            this.Controls.Add(this.DistanceLabel);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.AimbotSettingsCheckBoxList);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.HeadPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AimbotMenu";
            this.Text = "BaseMenu";
            this.Load += new System.EventHandler(this.AimbotMenu_Load);
            this.HeadPanel.ResumeLayout(false);
            this.HeadPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FOVSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DistanceSlider)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CloseButton;
        private System.Windows.Forms.Panel HeadPanel;
        private System.Windows.Forms.Label HeaderLabel;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.ListView DisabledEntitiesListView;
        private System.Windows.Forms.Button AddEntityButton;
        private System.Windows.Forms.Label DisabledEntitiesHeaderLabel;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.ListView EnabledEntitesListView;
        private System.Windows.Forms.Button RemoveEntityButton;
        private System.Windows.Forms.Label EnabledEntitiesHeaderLabel;
        public System.Windows.Forms.CheckedListBox AimbotSettingsCheckBoxList;
        public System.Windows.Forms.TrackBar FOVSlider;
        private System.Windows.Forms.Label FOVLabel;
        public System.Windows.Forms.TrackBar DistanceSlider;
        private System.Windows.Forms.Label DistanceLabel;
        private System.Windows.Forms.Label CurrentDistanceLabel;
        private System.Windows.Forms.Label CurrentFOVSizeLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
    }
}