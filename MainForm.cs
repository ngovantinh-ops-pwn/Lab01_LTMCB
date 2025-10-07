using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab01
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnBai01_Click(object sender, EventArgs e)
        {
            Lab01_Bai01 f = new Lab01_Bai01();
            f.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Lab01_Bai04 f = new Lab01_Bai04();
            f.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Lab01_Bai07 f = new Lab01_Bai07();
            f.ShowDialog();
        }

        private void btnBai02_Click(object sender, EventArgs e)
        {
            Lab01_Bai02 f = new Lab01_Bai02();
            f.ShowDialog();
        }

        private void btnBai03_Click(object sender, EventArgs e)
        {
            Lab01_Bai03 f = new Lab01_Bai03();
            f.ShowDialog();
        }

        private void btnBai05_Click(object sender, EventArgs e)
        {
            Lab01_Bai05 f = new Lab01_Bai05();
            f.ShowDialog();
        }

        private void btnBai06_Click(object sender, EventArgs e)
        {
            Lab01_Bai06 f = new Lab01_Bai06();
            f.ShowDialog();
        }

        private void btnBai08_Click(object sender, EventArgs e)
        {
            Lab01_Bai08 f = new Lab01_Bai08();
            f.ShowDialog();
        }


    }
}
