using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_1
{
    public partial class Menu_lab : Form
    {
        public Menu_lab()
        {
            InitializeComponent();
        }

        private void btn_Bai1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Lab1_Bai1 lab1_Bai1 = new Lab1_Bai1();
            lab1_Bai1.ShowDialog();
            lab1_Bai1 = null;
            this.Show();
        }

        private void btn_Bai2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Lab1_Bai2 lab1_Bai2 = new Lab1_Bai2();
            lab1_Bai2.ShowDialog();
            lab1_Bai2 = null;
            this.Show();
        }

        private void btn_Bai3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Lab1_Bai3 lab1_Bai3 = new Lab1_Bai3();
            lab1_Bai3.ShowDialog();
            lab1_Bai3 = null;
            this.Show();
        }

        private void btn_Bai3_1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Lab1_Bai3_1 lab1_Bai3_1 = new Lab1_Bai3_1();
            lab1_Bai3_1.ShowDialog();
            lab1_Bai3_1 = null;
            this.Show();
        }
        private void btn_Bai4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Lab1_Bai4 lab1_Bai4 = new Lab1_Bai4();
            lab1_Bai4.ShowDialog();
            lab1_Bai4 = null;
            this.Show();
        }

        private void btn_Bai5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Lab1_Bai5 lab1_Bai5 = new Lab1_Bai5();
            lab1_Bai5.ShowDialog();
            lab1_Bai5 = null;
            this.Show();
        }

        private void btn_Bai6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Lab1_Bai8 lab1_Bai8 = new Lab1_Bai8();
            lab1_Bai8.ShowDialog();
            lab1_Bai8 = null;
            this.Show();
        }
    }
}
