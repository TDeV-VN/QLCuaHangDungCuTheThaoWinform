namespace GUI
{
    partial class FormSoQuy
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
            this.panelPageSoQuy = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelPageSoQuy.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPageSoQuy
            // 
            this.panelPageSoQuy.Controls.Add(this.label1);
            this.panelPageSoQuy.Location = new System.Drawing.Point(8, 55);
            this.panelPageSoQuy.Name = "panelPageSoQuy";
            this.panelPageSoQuy.Size = new System.Drawing.Size(1188, 698);
            this.panelPageSoQuy.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1038, 657);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "panelSoQuy";
            // 
            // FormSoQuy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1205, 809);
            this.Controls.Add(this.panelPageSoQuy);
            this.Name = "FormSoQuy";
            this.Text = "FormSoQuy";
            this.panelPageSoQuy.ResumeLayout(false);
            this.panelPageSoQuy.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPageSoQuy;
        private System.Windows.Forms.Label label1;
    }
}