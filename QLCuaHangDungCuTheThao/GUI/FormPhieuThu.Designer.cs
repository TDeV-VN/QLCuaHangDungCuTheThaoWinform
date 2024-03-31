namespace GUI
{
    partial class FormPhieuThu
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
            this.panelPagePhieuThu = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelPagePhieuThu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPagePhieuThu
            // 
            this.panelPagePhieuThu.Controls.Add(this.label1);
            this.panelPagePhieuThu.Location = new System.Drawing.Point(6, 56);
            this.panelPagePhieuThu.Name = "panelPagePhieuThu";
            this.panelPagePhieuThu.Size = new System.Drawing.Size(1188, 698);
            this.panelPagePhieuThu.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1038, 650);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "panelPhieuThu";
            // 
            // FormPhieuThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1201, 810);
            this.Controls.Add(this.panelPagePhieuThu);
            this.Name = "FormPhieuThu";
            this.Text = "FormPhieuThu";
            this.panelPagePhieuThu.ResumeLayout(false);
            this.panelPagePhieuThu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPagePhieuThu;
        private System.Windows.Forms.Label label1;
    }
}