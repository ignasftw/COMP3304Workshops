﻿namespace FishyNote
{
    partial class FishyNote
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
            this.EnterText = new System.Windows.Forms.TextBox();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.CollapseOpenButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EnterText
            // 
            this.EnterText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EnterText.Location = new System.Drawing.Point(0, 106);
            this.EnterText.Multiline = true;
            this.EnterText.Name = "EnterText";
            this.EnterText.Size = new System.Drawing.Size(800, 332);
            this.EnterText.TabIndex = 0;
            this.EnterText.Text = "Enter your note text here...";
            // 
            // DeleteButton
            // 
            this.DeleteButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DeleteButton.BackColor = System.Drawing.Color.Red;
            this.DeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteButton.Location = new System.Drawing.Point(750, 0);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Padding = new System.Windows.Forms.Padding(10);
            this.DeleteButton.Size = new System.Drawing.Size(50, 50);
            this.DeleteButton.TabIndex = 1;
            this.DeleteButton.Text = "X";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // CollapseOpenButton
            // 
            this.CollapseOpenButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CollapseOpenButton.BackColor = System.Drawing.Color.Blue;
            this.CollapseOpenButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.CollapseOpenButton.ForeColor = System.Drawing.Color.White;
            this.CollapseOpenButton.Location = new System.Drawing.Point(0, 0);
            this.CollapseOpenButton.Name = "CollapseOpenButton";
            this.CollapseOpenButton.Size = new System.Drawing.Size(100, 100);
            this.CollapseOpenButton.TabIndex = 2;
            this.CollapseOpenButton.Text = "Collapse or Open";
            this.CollapseOpenButton.UseVisualStyleBackColor = false;
            this.CollapseOpenButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // FishyNote
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.CollapseOpenButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.EnterText);
            this.Name = "FishyNote";
            this.Text = "FishyNote";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox EnterText;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button CollapseOpenButton;
    }
}

