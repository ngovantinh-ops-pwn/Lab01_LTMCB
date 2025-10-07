namespace Lab01
{
    partial class Lab01_Bai05
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
            lblA = new Label();
            lblB = new Label();
            txtA = new TextBox();
            txtB = new TextBox();
            btnTinh = new Button();
            txtKetQua = new TextBox();
            SuspendLayout();
            // 
            // lblA
            // 
            lblA.AutoSize = true;
            lblA.Location = new Point(20, 20);
            lblA.Name = "lblA";
            lblA.Size = new Size(62, 20);
            lblA.TabIndex = 0;
            lblA.Text = "Nhập A:";
            // 
            // lblB
            // 
            lblB.AutoSize = true;
            lblB.Location = new Point(20, 60);
            lblB.Name = "lblB";
            lblB.Size = new Size(61, 20);
            lblB.TabIndex = 2;
            lblB.Text = "Nhập B:";
            // 
            // txtA
            // 
            txtA.Location = new Point(100, 20);
            txtA.Name = "txtA";
            txtA.Size = new Size(150, 27);
            txtA.TabIndex = 1;
            // 
            // txtB
            // 
            txtB.Location = new Point(100, 60);
            txtB.Name = "txtB";
            txtB.Size = new Size(150, 27);
            txtB.TabIndex = 3;
            // 
            // btnTinh
            // 
            btnTinh.Location = new Point(270, 35);
            btnTinh.Name = "btnTinh";
            btnTinh.Size = new Size(100, 40);
            btnTinh.TabIndex = 4;
            btnTinh.Text = "Tính toán";
            btnTinh.Click += btnTinh_Click;
            // 
            // txtKetQua
            // 
            txtKetQua.Location = new Point(20, 110);
            txtKetQua.Multiline = true;
            txtKetQua.Name = "txtKetQua";
            txtKetQua.ReadOnly = true;
            txtKetQua.ScrollBars = ScrollBars.Vertical;
            txtKetQua.Size = new Size(350, 250);
            txtKetQua.TabIndex = 5;
            // 
            // Lab01_Bai05
            // 
            ClientSize = new Size(418, 400);
            Controls.Add(lblA);
            Controls.Add(txtA);
            Controls.Add(lblB);
            Controls.Add(txtB);
            Controls.Add(btnTinh);
            Controls.Add(txtKetQua);
            Name = "Lab01_Bai05";
            Text = "Bài 05 - Tính toán A, B";
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblA;
        private Label lblB;
        private TextBox txtA;
        private TextBox txtB;
        private Button btnTinh;
        private TextBox txtKetQua;

    }
}