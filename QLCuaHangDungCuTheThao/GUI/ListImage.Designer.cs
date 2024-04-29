namespace GUI
{
    partial class ListImage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbFileName = new System.Windows.Forms.Label();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.btnDelete = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // lbFileName
            // 
            this.lbFileName.AutoSize = true;
            this.lbFileName.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lbFileName.Location = new System.Drawing.Point(56, 29);
            this.lbFileName.Name = "lbFileName";
            this.lbFileName.Size = new System.Drawing.Size(68, 19);
            this.lbFileName.TabIndex = 1;
            this.lbFileName.Text = "Hinh1.jpg";
            // 
            // picBox
            // 
            this.picBox.Location = new System.Drawing.Point(0, 13);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(50, 42);
            this.picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox.TabIndex = 0;
            this.picBox.TabStop = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDelete.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnDelete.IconColor = System.Drawing.SystemColors.WindowText;
            this.btnDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDelete.IconSize = 24;
            this.btnDelete.Location = new System.Drawing.Point(221, 20);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Padding = new System.Windows.Forms.Padding(3, 0, 1, 0);
            this.btnDelete.Size = new System.Drawing.Size(34, 37);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // ListImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lbFileName);
            this.Controls.Add(this.picBox);
            this.Name = "ListImage";
            this.Padding = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.Size = new System.Drawing.Size(259, 69);
            this.MouseEnter += new System.EventHandler(this.ListImage_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.ListImage_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.Label lbFileName;
        private FontAwesome.Sharp.IconButton btnDelete;
    }
}
