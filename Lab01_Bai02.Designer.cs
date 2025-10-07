namespace Lab01
{
    partial class Lab01_Bai02
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
            txtSo1 = new TextBox();
            txtSo3 = new TextBox();
            txtSo2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnTinh = new Button();
            btnThoat = new Button();
            txtMax = new TextBox();
            txtMin = new TextBox();
            btnXoa_Click = new Button();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // txtSo1
            // 
            txtSo1.Location = new Point(109, 110);
            txtSo1.Name = "txtSo1";
            txtSo1.Size = new Size(153, 27);
            txtSo1.TabIndex = 0;
            txtSo1.TextChanged += txtSo1_TextChanged;
            // 
            // txtSo3
            // 
            txtSo3.Location = new Point(626, 113);
            txtSo3.Name = "txtSo3";
            txtSo3.Size = new Size(153, 27);
            txtSo3.TabIndex = 1;
            // 
            // txtSo2
            // 
            txtSo2.Location = new Point(375, 110);
            txtSo2.Name = "txtSo2";
            txtSo2.Size = new Size(153, 27);
            txtSo2.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 110);
            label1.Name = "label1";
            label1.Size = new Size(91, 20);
            label1.TabIndex = 3;
            label1.Text = "Số Thứ Nhất";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(544, 113);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 4;
            label2.Text = "Số Thứ Ba";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(287, 113);
            label3.Name = "label3";
            label3.Size = new Size(82, 20);
            label3.TabIndex = 5;
            label3.Text = "Số Thứ Hai";
            // 
            // btnTinh
            // 
            btnTinh.Location = new Point(109, 237);
            btnTinh.Name = "btnTinh";
            btnTinh.Size = new Size(106, 55);
            btnTinh.TabIndex = 6;
            btnTinh.Text = "Tìm";
            btnTinh.UseVisualStyleBackColor = true;
            btnTinh.Click += btnTinh_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(626, 237);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(106, 55);
            btnThoat.TabIndex = 8;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // txtMax
            // 
            txtMax.Location = new Point(167, 350);
            txtMax.Name = "txtMax";
            txtMax.ReadOnly = true;
            txtMax.Size = new Size(95, 27);
            txtMax.TabIndex = 9;
            // 
            // txtMin
            // 
            txtMin.Location = new Point(576, 350);
            txtMin.Name = "txtMin";
            txtMin.ReadOnly = true;
            txtMin.Size = new Size(95, 27);
            txtMin.TabIndex = 10;
            // 
            // btnXoa_Click
            // 
            btnXoa_Click.Location = new Point(375, 237);
            btnXoa_Click.Name = "btnXoa_Click";
            btnXoa_Click.Size = new Size(106, 55);
            btnXoa_Click.TabIndex = 11;
            btnXoa_Click.Text = "Xóa";
            btnXoa_Click.UseVisualStyleBackColor = true;
            btnXoa_Click.Click += btnXoa_Click_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 357);
            label4.Name = "label4";
            label4.Size = new Size(107, 20);
            label4.TabIndex = 12;
            label4.Text = "Số lớn nhất là :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(438, 357);
            label5.Name = "label5";
            label5.Size = new Size(103, 20);
            label5.TabIndex = 13;
            label5.Text = "Số bé nhất là :";
            // 
            // Lab01_Bai02
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(btnXoa_Click);
            Controls.Add(txtMin);
            Controls.Add(txtMax);
            Controls.Add(btnThoat);
            Controls.Add(btnTinh);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtSo2);
            Controls.Add(txtSo3);
            Controls.Add(txtSo1);
            Name = "Lab01_Bai02";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSo1;
        private TextBox txtSo3;
        private TextBox txtSo2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnTinh;
        private Button btnThoat;
        private TextBox txtMax;
        private TextBox txtMin;
        private Button btnXoa_Click;
        private Label label4;
        private Label label5;
    }
}