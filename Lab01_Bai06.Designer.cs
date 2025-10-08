namespace Lab01
{
    partial class Lab01_Bai06
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

        private void InitializeComponent()
        {
            lblTen = new Label();
            txtTenKH = new TextBox();
            lblPhim = new Label();
            cboPhim = new ComboBox();
            lblPhong = new Label();
            cboPhong = new ComboBox();
            pnlGhe = new FlowLayoutPanel();
            txtThongTin = new TextBox();
            btnThoat = new Button();
            SuspendLayout();
            // 
            // lblTen
            // 
            lblTen.AutoSize = true;
            lblTen.Location = new Point(20, 20);
            lblTen.Text = "Tên khách hàng:";
            // 
            // txtTenKH
            // 
            txtTenKH.Location = new Point(150, 17);
            txtTenKH.Size = new Size(250, 27);
            // 
            // lblPhim
            // 
            lblPhim.AutoSize = true;
            lblPhim.Location = new Point(20, 60);
            lblPhim.Text = "Chọn phim:";
            // 
            // cboPhim
            // 
            cboPhim.Location = new Point(150, 57);
            cboPhim.Size = new Size(250, 28);
            cboPhim.SelectedIndexChanged += cboPhim_SelectedIndexChanged;
            // 
            // lblPhong
            // 
            lblPhong.AutoSize = true;
            lblPhong.Location = new Point(20, 100);
            lblPhong.Text = "Chọn phòng:";
            // 
            // cboPhong
            // 
            cboPhong.Location = new Point(150, 97);
            cboPhong.Size = new Size(250, 28);
            cboPhong.SelectedIndexChanged += cboPhong_SelectedIndexChanged;
            // 
            // pnlGhe
            // 
            pnlGhe.Location = new Point(20, 150);
            pnlGhe.Size = new Size(380, 200);
            pnlGhe.BorderStyle = BorderStyle.FixedSingle;
            // 
            // txtThongTin
            // 
            txtThongTin.Location = new Point(420, 20);
            txtThongTin.Multiline = true;
            txtThongTin.ReadOnly = true;
            txtThongTin.Size = new Size(300, 330);
            txtThongTin.ScrollBars = ScrollBars.Vertical;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(630, 360);
            btnThoat.Size = new Size(90, 35);
            btnThoat.Text = "Thoát";
            btnThoat.Click += btnThoat_Click;
            // 
            // Lab01_Bai04
            // 
            ClientSize = new Size(750, 420);
            Controls.Add(lblTen);
            Controls.Add(txtTenKH);
            Controls.Add(lblPhim);
            Controls.Add(cboPhim);
            Controls.Add(lblPhong);
            Controls.Add(cboPhong);
            Controls.Add(pnlGhe);
            Controls.Add(txtThongTin);
            Controls.Add(btnThoat);
            Text = "Bài 04 - Quản lý phòng vé";
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblTen;
        private TextBox txtTenKH;
        private Label lblPhim;
        private ComboBox cboPhim;
        private Label lblPhong;
        private ComboBox cboPhong;
        private FlowLayoutPanel pnlGhe;
        private TextBox txtThongTin;
        private Button btnThoat;



    }
}