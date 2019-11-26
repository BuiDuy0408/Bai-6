namespace QuanLyBanHang
{
    partial class frmBanHang
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
            this.picSanPham = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picSanPham)).BeginInit();
            this.SuspendLayout();
            // 
            // picSanPham
            // 
            this.picSanPham.BackColor = System.Drawing.Color.Silver;
            this.picSanPham.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picSanPham.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picSanPham.Location = new System.Drawing.Point(269, 26);
            this.picSanPham.Name = "picSanPham";
            this.picSanPham.Size = new System.Drawing.Size(142, 164);
            this.picSanPham.TabIndex = 1;
            this.picSanPham.TabStop = false;
            // 
            // frmBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 291);
            this.Controls.Add(this.picSanPham);
            this.Name = "frmBanHang";
            this.Text = "frmBanHang";
            ((System.ComponentModel.ISupportInitialize)(this.picSanPham)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picSanPham;
    }
}