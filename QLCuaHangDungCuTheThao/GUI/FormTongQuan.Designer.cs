﻿namespace GUI
{
    partial class FormTongQuan
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
            this.panelPageTongQuan = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelPageTongQuan.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPageTongQuan
            // 
            this.panelPageTongQuan.Controls.Add(this.label1);
            this.panelPageTongQuan.Location = new System.Drawing.Point(8, 8);
            this.panelPageTongQuan.Name = "panelPageTongQuan";
            this.panelPageTongQuan.Size = new System.Drawing.Size(1188, 698);
            this.panelPageTongQuan.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1064, 672);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "panelTongQuan";
            // 
            // FormTongQuan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1215, 769);
            this.Controls.Add(this.panelPageTongQuan);
            this.Name = "FormTongQuan";
            this.Text = "FormTongQuan";
            this.panelPageTongQuan.ResumeLayout(false);
            this.panelPageTongQuan.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPageTongQuan;
        private System.Windows.Forms.Label label1;
    }
}