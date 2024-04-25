namespace GUI
{
    partial class FormChiTietSP
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
            this.panel12 = new System.Windows.Forms.Panel();
            this.btXoa = new FontAwesome.Sharp.IconButton();
            this.btSua = new RJCodeAdvance.RJControls.RJButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbHeader = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.btQuayLai = new FontAwesome.Sharp.IconButton();
            this.panel12.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel11.SuspendLayout();
            this.SuspendLayout();
            // 
            // btClose
            // 
            this.btClose.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btClose.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.btClose.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btClose.BorderRadius = 12;
            this.btClose.BorderSize = 0;
            this.btClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btClose.FlatAppearance.BorderSize = 0;
            this.btClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btClose.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btClose.ForeColor = System.Drawing.Color.MediumPurple;
            this.btClose.Location = new System.Drawing.Point(1254, 5);
            this.btClose.Margin = new System.Windows.Forms.Padding(4, 4, 20, 4);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(41, 40);
            this.btClose.TabIndex = 13;
            this.btClose.Text = "X";
            this.btClose.TextColor = System.Drawing.Color.MediumPurple;
            this.btClose.UseVisualStyleBackColor = false;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.btXoa);
            this.panel12.Controls.Add(this.panel1);
            this.panel12.Controls.Add(this.btSua);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel12.Location = new System.Drawing.Point(0, 50);
            this.panel12.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(1300, 628);
            this.panel12.TabIndex = 14;
            // 
            // btXoa
            // 
            this.btXoa.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btXoa.IconColor = System.Drawing.Color.Black;
            this.btXoa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btXoa.IconSize = 35;
            this.btXoa.Location = new System.Drawing.Point(753, 549);
            this.btXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(51, 50);
            this.btXoa.TabIndex = 14;
            this.btXoa.UseVisualStyleBackColor = true;
            // 
            // btSua
            // 
            this.btSua.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btSua.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btSua.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btSua.BorderRadius = 12;
            this.btSua.BorderSize = 0;
            this.btSua.FlatAppearance.BorderSize = 0;
            this.btSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSua.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btSua.ForeColor = System.Drawing.Color.White;
            this.btSua.Location = new System.Drawing.Point(809, 549);
            this.btSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(469, 50);
            this.btSua.TabIndex = 13;
            this.btSua.Text = "Sửa";
            this.btSua.TextColor = System.Drawing.Color.White;
            this.btSua.UseVisualStyleBackColor = false;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbHeader);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1300, 71);
            this.panel1.TabIndex = 0;
            // 
            // lbHeader
            // 
            this.lbHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbHeader.Font = new System.Drawing.Font("Segoe UI Black", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbHeader.Location = new System.Drawing.Point(0, 0);
            this.lbHeader.Margin = new System.Windows.Forms.Padding(0);
            this.lbHeader.Name = "lbHeader";
            this.lbHeader.Size = new System.Drawing.Size(1300, 71);
            this.lbHeader.TabIndex = 0;
            this.lbHeader.Text = "Thông tin sản phẩm";
            this.lbHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.btQuayLai);
            this.panel11.Controls.Add(this.btClose);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel11.Location = new System.Drawing.Point(0, 0);
            this.panel11.Margin = new System.Windows.Forms.Padding(0);
            this.panel11.Name = "panel11";
            this.panel11.Padding = new System.Windows.Forms.Padding(5);
            this.panel11.Size = new System.Drawing.Size(1300, 50);
            this.panel11.TabIndex = 15;
            // 
            // btQuayLai
            // 
            this.btQuayLai.BackColor = System.Drawing.Color.Transparent;
            this.btQuayLai.Dock = System.Windows.Forms.DockStyle.Left;
            this.btQuayLai.FlatAppearance.BorderSize = 0;
            this.btQuayLai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btQuayLai.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            this.btQuayLai.IconColor = System.Drawing.Color.Black;
            this.btQuayLai.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btQuayLai.IconSize = 25;
            this.btQuayLai.Location = new System.Drawing.Point(5, 5);
            this.btQuayLai.Margin = new System.Windows.Forms.Padding(4);
            this.btQuayLai.Name = "btQuayLai";
            this.btQuayLai.Size = new System.Drawing.Size(53, 40);
            this.btQuayLai.TabIndex = 15;
            this.btQuayLai.UseVisualStyleBackColor = false;
            this.btQuayLai.Click += new System.EventHandler(this.btQuayLai_Click);
            // 
            // FormChiTietSP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1300, 684);
            this.Controls.Add(this.panel12);
            this.Controls.Add(this.panel11);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormChiTietSP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormChiTietSP";
            this.panel12.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private RJCodeAdvance.RJControls.RJButton btClose;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbHeader;
        private System.Windows.Forms.Panel panel11;
        private FontAwesome.Sharp.IconButton btXoa;
        private RJCodeAdvance.RJControls.RJButton btSua;
        private FontAwesome.Sharp.IconButton btQuayLai;
    }
}