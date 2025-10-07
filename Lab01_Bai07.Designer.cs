namespace Lab01
{
    partial class Lab01_Bai07
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
            lblInput = new Label();
            txtInput = new TextBox();
            btnXuLy = new Button();
            txtKetQua = new TextBox();
            SuspendLayout();
            // 
            // lblInput
            // 
            lblInput.AutoSize = true;
            lblInput.Location = new Point(20, 20);
            lblInput.Name = "lblInput";
            lblInput.Size = new Size(177, 20);
            lblInput.TabIndex = 0;
            lblInput.Text = "Nhập chuỗi (Tên, Điểm...):";
            // 
            // txtInput
            // 
            txtInput.Location = new Point(20, 50);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(400, 27);
            txtInput.TabIndex = 1;
            // 
            // btnXuLy
            // 
            btnXuLy.Location = new Point(430, 47);
            btnXuLy.Name = "btnXuLy";
            btnXuLy.Size = new Size(100, 30);
            btnXuLy.TabIndex = 2;
            btnXuLy.Text = "Xử lý";
            btnXuLy.Click += btnXuLy_Click;
            // 
            // txtKetQua
            // 
            txtKetQua.Location = new Point(20, 100);
            txtKetQua.Multiline = true;
            txtKetQua.Name = "txtKetQua";
            txtKetQua.ReadOnly = true;
            txtKetQua.ScrollBars = ScrollBars.Vertical;
            txtKetQua.Size = new Size(510, 250);
            txtKetQua.TabIndex = 3;
            // 
            // Lab01_Bai07
            // 
            ClientSize = new Size(602, 380);
            Controls.Add(lblInput);
            Controls.Add(txtInput);
            Controls.Add(btnXuLy);
            Controls.Add(txtKetQua);
            Name = "Lab01_Bai07";
            Text = "Bài 07 - Xử lý mảng";
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblInput;
        private TextBox txtInput;
        private Button btnXuLy;
        private TextBox txtKetQua;

    }
}