﻿namespace QuanLySinhVien
{
    partial class FormMenu
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
            this.label1 = new System.Windows.Forms.Label();
            this.GunaExitbtn = new Guna.UI2.WinForms.Guna2CircleButton();
            this.c = new Guna.UI2.WinForms.Guna2Button();
            this.gunA2AverageBtn = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(148, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "MENU";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // GunaExitbtn
            // 
            this.GunaExitbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.GunaExitbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GunaExitbtn.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.GunaExitbtn.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GunaExitbtn.ForeColor = System.Drawing.Color.Black;
            this.GunaExitbtn.Location = new System.Drawing.Point(371, 2);
            this.GunaExitbtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GunaExitbtn.Name = "GunaExitbtn";
            this.GunaExitbtn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.GunaExitbtn.Size = new System.Drawing.Size(32, 31);
            this.GunaExitbtn.TabIndex = 3;
            this.GunaExitbtn.Text = "X";
            this.GunaExitbtn.Click += new System.EventHandler(this.GunaExitbtn_Click);
            // 
            // c
            // 
            this.c.FillColor = System.Drawing.Color.Azure;
            this.c.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.c.ForeColor = System.Drawing.Color.Black;
            this.c.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.c.Location = new System.Drawing.Point(26, 245);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(356, 63);
            this.c.TabIndex = 33;
            this.c.Text = "ADD STUDENT\'S SCORES";
            this.c.Click += new System.EventHandler(this.c_Click);
            // 
            // gunA2AverageBtn
            // 
            this.gunA2AverageBtn.FillColor = System.Drawing.Color.Azure;
            this.gunA2AverageBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.gunA2AverageBtn.ForeColor = System.Drawing.Color.Black;
            this.gunA2AverageBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.gunA2AverageBtn.Location = new System.Drawing.Point(26, 144);
            this.gunA2AverageBtn.Name = "gunA2AverageBtn";
            this.gunA2AverageBtn.Size = new System.Drawing.Size(356, 63);
            this.gunA2AverageBtn.TabIndex = 34;
            this.gunA2AverageBtn.Text = "COURSE STATISTICS REPORT";
            this.gunA2AverageBtn.Click += new System.EventHandler(this.gunA2AverageBtn_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(407, 450);
            this.Controls.Add(this.gunA2AverageBtn);
            this.Controls.Add(this.c);
            this.Controls.Add(this.GunaExitbtn);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2CircleButton GunaExitbtn;
        private Guna.UI2.WinForms.Guna2Button c;
        private Guna.UI2.WinForms.Guna2Button gunA2AverageBtn;
    }
}