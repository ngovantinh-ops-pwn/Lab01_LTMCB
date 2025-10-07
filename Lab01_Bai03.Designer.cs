namespace Lab01
{
    partial class Lab01_Bai03
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
            lblSo = new Label();
            txtSo = new TextBox();
            btnDoc = new Button();
            txtKetQua = new TextBox();
            btnXoa = new Button();
            btnThoat = new Button();
            SuspendLayout();
            // 
            // lblSo
            // 
            lblSo.AutoSize = true;
            lblSo.Location = new Point(30, 30);
            lblSo.Text = "Nhập số (tối đa 12 chữ số):";
            // 
            // txtSo
            // 
            txtSo.Location = new Point(250, 27);
            txtSo.Size = new Size(200, 27);
            // 
            // btnDoc
            // 
            btnDoc.Location = new Point(470, 25);
            btnDoc.Size = new Size(90, 30);
            btnDoc.Text = "Đọc số";
            btnDoc.Click += btnDoc_Click;
            // 
            // txtKetQua
            // 
            txtKetQua.Location = new Point(30, 80);
            txtKetQua.Multiline = true;
            txtKetQua.ReadOnly = true;
            txtKetQua.ScrollBars = ScrollBars.Vertical;
            txtKetQua.Size = new Size(530, 120);
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(350, 220);
            btnXoa.Size = new Size(90, 35);
            btnXoa.Text = "Xóa";
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(470, 220);
            btnThoat.Size = new Size(90, 35);
            btnThoat.Text = "Thoát";
            btnThoat.Click += btnThoat_Click;
            // 
            // Lab01_Bai03_1
            // 
            ClientSize = new Size(600, 280);
            Controls.Add(lblSo);
            Controls.Add(txtSo);
            Controls.Add(btnDoc);
            Controls.Add(txtKetQua);
            Controls.Add(btnXoa);
            Controls.Add(btnThoat);
            Text = "Bài 03.1 - Đọc số nâng cao";
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblSo;
        private TextBox txtSo;
        private Button btnDoc;
        private TextBox txtKetQua;
        private Button btnXoa;
        private Button btnThoat;


    }
}