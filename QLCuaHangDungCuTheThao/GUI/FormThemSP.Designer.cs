namespace GUI
{
    partial class FormThemSP
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
            this.btClose = new RJCodeAdvance.RJControls.RJButton();
            this.panelThemSP = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btClose
            // 
            this.btClose.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btClose.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.btClose.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btClose.BorderRadius = 12;
            this.btClose.BorderSize = 0;
            this.btClose.FlatAppearance.BorderSize = 0;
            this.btClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btClose.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btClose.ForeColor = System.Drawing.Color.MediumPurple;
            this.btClose.Location = new System.Drawing.Point(1337, 13);
            this.btClose.Margin = new System.Windows.Forms.Padding(4);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(50, 50);
            this.btClose.TabIndex = 13;
            this.btClose.Text = "X";
            this.btClose.TextColor = System.Drawing.Color.MediumPurple;
            this.btClose.UseVisualStyleBackColor = false;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // panelThemSP
            // 
            this.panelThemSP.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelThemSP.Location = new System.Drawing.Point(0, 70);
            this.panelThemSP.Name = "panelThemSP";
            this.panelThemSP.Size = new System.Drawing.Size(1400, 830);
            this.panelThemSP.TabIndex = 14;
            // 
            // FormThemSP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1400, 900);
            this.Controls.Add(this.panelThemSP);
            this.Controls.Add(this.btClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormThemSP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormChiTietSP";
            this.ResumeLayout(false);

        }

        #endregion

        private RJCodeAdvance.RJControls.RJButton btClose;
        private System.Windows.Forms.Panel panelThemSP;
    }
}