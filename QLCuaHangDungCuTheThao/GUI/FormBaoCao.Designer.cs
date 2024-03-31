namespace GUI
{
    partial class FormBaoCao
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
            this.panelPageBaoCao = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelPageBaoCao.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPageBaoCao
            // 
            this.panelPageBaoCao.Controls.Add(this.label1);
            this.panelPageBaoCao.Location = new System.Drawing.Point(10, 57);
            this.panelPageBaoCao.Name = "panelPageBaoCao";
            this.panelPageBaoCao.Size = new System.Drawing.Size(1188, 698);
            this.panelPageBaoCao.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1090, 665);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "panelBaoCao";
            // 
            // FormBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1209, 812);
            this.Controls.Add(this.panelPageBaoCao);
            this.Name = "FormBaoCao";
            this.Text = "FormBaoCao";
            this.panelPageBaoCao.ResumeLayout(false);
            this.panelPageBaoCao.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPageBaoCao;
        private System.Windows.Forms.Label label1;
    }
}