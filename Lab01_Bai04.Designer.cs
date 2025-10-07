namespace Lab01
{
    partial class Lab01_Bai04
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
            lblNgaySinh = new Label();
            dtpNgaySinh = new DateTimePicker();
            btnXem = new Button();
            txtKetQua = new TextBox();
            SuspendLayout();
            // 
            // lblNgaySinh
            // 
            lblNgaySinh.AutoSize = true;
            lblNgaySinh.Location = new Point(20, 20);
            lblNgaySinh.Name = "lblNgaySinh";
            lblNgaySinh.Size = new Size(77, 20);
            lblNgaySinh.TabIndex = 0;
            lblNgaySinh.Text = "Ngày sinh:";
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            dtpNgaySinh.Format = DateTimePickerFormat.Custom;
            dtpNgaySinh.Location = new Point(120, 17);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(183, 27);
            dtpNgaySinh.TabIndex = 1;
            // 
            // btnXem
            // 
            btnXem.Location = new Point(341, 15);
            btnXem.Name = "btnXem";
            btnXem.Size = new Size(149, 30);
            btnXem.TabIndex = 2;
            btnXem.Text = "Xem cung";
            btnXem.Click += btnXem_Click;
            // 
            // txtKetQua
            // 
            txtKetQua.Location = new Point(120, 102);
            txtKetQua.Multiline = true;
            txtKetQua.Name = "txtKetQua";
            txtKetQua.ReadOnly = true;
            txtKetQua.Size = new Size(370, 131);
            txtKetQua.TabIndex = 3;
            // 
            // Lab01_Bai04
            // 
            ClientSize = new Size(574, 308);
            Controls.Add(lblNgaySinh);
            Controls.Add(dtpNgaySinh);
            Controls.Add(btnXem);
            Controls.Add(txtKetQua);
            Name = "Lab01_Bai04";
            Text = "Bài 06 - Xem cung hoàng đạo";
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblNgaySinh;
        private DateTimePicker dtpNgaySinh;
        private Button btnXem;
        private TextBox txtKetQua;

    }
}