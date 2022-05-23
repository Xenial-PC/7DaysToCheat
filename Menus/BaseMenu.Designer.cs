
namespace _7DaysToCheat.Menus
{
    partial class BaseMenu
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
            this.HeadPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // CloseButton
            // 
            this.CloseButton.AutoSize = true;
            this.CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseButton.ForeColor = System.Drawing.Color.White;
            this.CloseButton.Location = new System.Drawing.Point(391, 6);
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
            this.HeadPanel.Size = new System.Drawing.Size(415, 30);
            this.HeadPanel.TabIndex = 20;
            this.HeadPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HeadPanel_MouseDown);
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.AutoSize = true;
            this.HeaderLabel.ForeColor = System.Drawing.Color.White;
            this.HeaderLabel.Location = new System.Drawing.Point(4, 7);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(34, 13);
            this.HeaderLabel.TabIndex = 19;
            this.HeaderLabel.Text = "Menu";
            this.HeaderLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HeaderLabel_MouseDown);
            // 
            // BaseMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(408, 271);
            this.Controls.Add(this.HeadPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BaseMenu";
            this.Text = "BaseMenu";
            this.HeadPanel.ResumeLayout(false);
            this.HeadPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label CloseButton;
        private System.Windows.Forms.Panel HeadPanel;
        private System.Windows.Forms.Label HeaderLabel;
    }
}