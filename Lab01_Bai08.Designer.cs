namespace Lab01
{
    partial class Lab01_Bai08
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
            lblNhapMon = new Label();
            txtMonMoi = new TextBox();
            btnThem = new Button();
            lstMonAn = new ListBox();
            btnAnGi = new Button();
            lblKetQua = new Label();
            SuspendLayout();
            // 
            // lblNhapMon
            // 
            lblNhapMon.AutoSize = true;
            lblNhapMon.Location = new Point(61, 19);
            lblNhapMon.Name = "lblNhapMon";
            lblNhapMon.Size = new Size(92, 20);
            lblNhapMon.TabIndex = 0;
            lblNhapMon.Text = "Món ăn mới:";
            // 
            // txtMonMoi
            // 
            txtMonMoi.Location = new Point(161, 16);
            txtMonMoi.Name = "txtMonMoi";
            txtMonMoi.Size = new Size(200, 27);
            txtMonMoi.TabIndex = 1;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(381, 14);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(80, 30);
            btnThem.TabIndex = 2;
            btnThem.Text = "Thêm";
            btnThem.Click += btnThem_Click;
            // 
            // lstMonAn
            // 
            lstMonAn.Location = new Point(61, 59);
            lstMonAn.Name = "lstMonAn";
            lstMonAn.Size = new Size(400, 144);
            lstMonAn.TabIndex = 3;
            // 
            // btnAnGi
            // 
            btnAnGi.Location = new Point(61, 229);
            btnAnGi.Name = "btnAnGi";
            btnAnGi.Size = new Size(120, 40);
            btnAnGi.TabIndex = 4;
            btnAnGi.Text = "Hôm nay ăn gì?";
            btnAnGi.Click += btnAnGi_Click;
            // 
            // lblKetQua
            // 
            lblKetQua.AutoSize = true;
            lblKetQua.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblKetQua.Location = new Point(61, 289);
            lblKetQua.Name = "lblKetQua";
            lblKetQua.Size = new Size(96, 28);
            lblKetQua.TabIndex = 5;
            lblKetQua.Text = "Kết quả: ";
            // 
            // Lab01_Bai08
            // 
            ClientSize = new Size(572, 423);
            Controls.Add(lblNhapMon);
            Controls.Add(txtMonMoi);
            Controls.Add(btnThem);
            Controls.Add(lstMonAn);
            Controls.Add(btnAnGi);
            Controls.Add(lblKetQua);
            Name = "Lab01_Bai08";
            Text = "Bài 08 - Hôm nay ăn gì?";
            Load += Lab01_Bai08_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblNhapMon;
        private TextBox txtMonMoi;
        private Button btnThem;
        private ListBox lstMonAn;
        private Button btnAnGi;
        private Label lblKetQua;

    }
}