namespace Lab01
{
    partial class MainForm
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
            btnBai01 = new Button();
            btnBai02 = new Button();
            btnBai03 = new Button();
            btnBai04 = new Button();
            btnBai08 = new Button();
            btnBai07 = new Button();
            btnBai06 = new Button();
            btnBai05 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnBai01
            // 
            btnBai01.Location = new Point(36, 158);
            btnBai01.Name = "btnBai01";
            btnBai01.Size = new Size(132, 99);
            btnBai01.TabIndex = 0;
            btnBai01.Text = "Bài 1";
            btnBai01.UseVisualStyleBackColor = true;
            btnBai01.Click += btnBai01_Click;
            // 
            // btnBai02
            // 
            btnBai02.Location = new Point(229, 158);
            btnBai02.Name = "btnBai02";
            btnBai02.Size = new Size(132, 99);
            btnBai02.TabIndex = 1;
            btnBai02.Text = "Bài 2";
            btnBai02.UseVisualStyleBackColor = true;
            btnBai02.Click += btnBai02_Click;
            // 
            // btnBai03
            // 
            btnBai03.Location = new Point(432, 158);
            btnBai03.Name = "btnBai03";
            btnBai03.Size = new Size(132, 99);
            btnBai03.TabIndex = 3;
            btnBai03.Text = "Bài 3";
            btnBai03.UseVisualStyleBackColor = true;
            btnBai03.Click += btnBai03_Click;
            // 
            // btnBai04
            // 
            btnBai04.Location = new Point(640, 158);
            btnBai04.Name = "btnBai04";
            btnBai04.Size = new Size(132, 99);
            btnBai04.TabIndex = 4;
            btnBai04.Text = "Bài 4";
            btnBai04.UseVisualStyleBackColor = true;
            btnBai04.Click += button4_Click;
            // 
            // btnBai08
            // 
            btnBai08.Location = new Point(640, 323);
            btnBai08.Name = "btnBai08";
            btnBai08.Size = new Size(132, 99);
            btnBai08.TabIndex = 8;
            btnBai08.Text = "Bài 8";
            btnBai08.UseVisualStyleBackColor = true;
            btnBai08.Click += btnBai08_Click;
            // 
            // btnBai07
            // 
            btnBai07.Location = new Point(432, 323);
            btnBai07.Name = "btnBai07";
            btnBai07.Size = new Size(132, 99);
            btnBai07.TabIndex = 7;
            btnBai07.Text = "Bài 7";
            btnBai07.UseVisualStyleBackColor = true;
            btnBai07.Click += button6_Click;
            // 
            // btnBai06
            // 
            btnBai06.Location = new Point(229, 323);
            btnBai06.Name = "btnBai06";
            btnBai06.Size = new Size(132, 99);
            btnBai06.TabIndex = 6;
            btnBai06.Text = "Bài6";
            btnBai06.UseVisualStyleBackColor = true;
            btnBai06.Click += btnBai06_Click;
            // 
            // btnBai05
            // 
            btnBai05.Location = new Point(36, 323);
            btnBai05.Name = "btnBai05";
            btnBai05.Size = new Size(132, 99);
            btnBai05.TabIndex = 5;
            btnBai05.Text = "Bài 5";
            btnBai05.UseVisualStyleBackColor = true;
            btnBai05.Click += btnBai05_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.ForeColor = Color.Red;
            label1.Location = new Point(308, 71);
            label1.Name = "label1";
            label1.Size = new Size(200, 20);
            label1.TabIndex = 9;
            label1.Text = "BÀI TẬP THỰC HÀNH 1";

            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(837, 507);
            Controls.Add(label1);
            Controls.Add(btnBai08);
            Controls.Add(btnBai07);
            Controls.Add(btnBai06);
            Controls.Add(btnBai05);
            Controls.Add(btnBai04);
            Controls.Add(btnBai03);
            Controls.Add(btnBai02);
            Controls.Add(btnBai01);
            Name = "MainForm";
            Text = "MainForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBai01;
        private Button btnBai02;
        private Button btnBai03;
        private Button btnBai04;
        private Button btnBai08;
        private Button btnBai07;
        private Button btnBai06;
        private Button btnBai05;
        private Label label1;
    }
}