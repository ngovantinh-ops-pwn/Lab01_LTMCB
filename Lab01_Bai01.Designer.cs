namespace Lab01
{
    partial class Lab01_Bai01
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
            A = new Label();
            B = new Label();
            txtSo1 = new TextBox();
            txtSo2 = new TextBox();
            C = new Label();
            txtKetQua = new TextBox();
            btnTinh = new Button();
            btnThoat = new Button();
            SuspendLayout();
            // 
            // A
            // 
            A.AutoSize = true;
            A.Location = new Point(65, 93);
            A.Name = "A";
            A.Size = new Size(131, 20);
            A.TabIndex = 0;
            A.Text = "Nhập Số Thứ Nhất";
            // 
            // B
            // 
            B.AutoSize = true;
            B.Location = new Point(65, 157);
            B.Name = "B";
            B.Size = new Size(122, 20);
            B.TabIndex = 1;
            B.Text = "Nhập Số Thứ Hai";
            // 
            // txtSo1
            // 
            txtSo1.Location = new Point(419, 86);
            txtSo1.Name = "txtSo1";
            txtSo1.Size = new Size(226, 27);
            txtSo1.TabIndex = 2;
            // 
            // txtSo2
            // 
            txtSo2.Location = new Point(419, 154);
            txtSo2.Name = "txtSo2";
            txtSo2.Size = new Size(226, 27);
            txtSo2.TabIndex = 3;
            // 
            // C
            // 
            C.AutoSize = true;
            C.Location = new Point(65, 282);
            C.Name = "C";
            C.Size = new Size(62, 20);
            C.TabIndex = 4;
            C.Text = "Kết Quả";
            // 
            // txtKetQua
            // 
            txtKetQua.Location = new Point(471, 275);
            txtKetQua.Name = "txtKetQua";
            txtKetQua.ReadOnly = true;
            txtKetQua.Size = new Size(143, 27);
            txtKetQua.TabIndex = 5;
            txtKetQua.TextChanged += txtKetQua_TextChanged;
            // 
            // btnTinh
            // 
            btnTinh.Location = new Point(254, 185);
            btnTinh.Name = "btnTinh";
            btnTinh.Size = new Size(87, 80);
            btnTinh.TabIndex = 6;
            btnTinh.Text = "Tính toán";
            btnTinh.UseVisualStyleBackColor = true;
            btnTinh.Click += btnTinh_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(725, 23);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(63, 69);
            btnThoat.TabIndex = 7;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // Lab01_Bai01
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnThoat);
            Controls.Add(btnTinh);
            Controls.Add(txtKetQua);
            Controls.Add(C);
            Controls.Add(txtSo2);
            Controls.Add(txtSo1);
            Controls.Add(B);
            Controls.Add(A);
            Name = "Lab01_Bai01";
            Text = "Lab01_Bai01";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label A;
        private Label B;
        private TextBox txtSo1;
        private TextBox txtSo2;
        private Label C;
        private TextBox txtKetQua;
        private Button btnTinh;
        private Button btnThoat;
    }
}