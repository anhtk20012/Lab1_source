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
    public partial class Lab1_Bai5 : Form
    {
        public Lab1_Bai5()
        {
            InitializeComponent();
        }

        private void Lab1_Bai5_Load(object sender, EventArgs e)
        {
            l_A.Text = l_B.Text = l_S1.Text = l_S2.Text = l_S3.Text = tb_A.Text = tb_B.Text = "";
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            l_A.Text = l_B.Text = l_S1.Text = l_S2.Text = l_S3.Text = tb_A.Text = tb_B.Text = "";
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_tcgt_Click(object sender, EventArgs e)
        {
            try
            {
                int num1 = Int32.Parse(tb_A.Text.Trim());
                int num2 = Int32.Parse(tb_B.Text.Trim());
                double tmp1 = 1, tmp2 = 1;
                for (int i = 1; i <= num1; i++)
                {
                    tmp1 *= i;
                }
                for (int i = 1; i <= num2; i++)
                {
                    tmp2 *= i;
                }
                l_A.Text = "A! = " + (tmp1).ToString();
                l_B.Text = "B! = " + (tmp2).ToString();
                l_S1.Text = "S1 = 1 + 2 + 3 + 4 + … + A = " + (((num1 + 1) * num1) / 2).ToString();
                l_S2.Text = "S2 = 1 + 2 + 3 + 4 + … + B = " + (((num2 + 1) * num2) / 2).ToString();
                double tmp = 0;
                for (int i = 1; i <= num2; i++)
                {
                    tmp += Math.Pow(num1, i);
                }    
                l_S3.Text = "S3 = A^1 + A^2 + A^3 + A^4 + … + A^B = " + (tmp).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(e.ToString(), "Dữ liệu nhập bị lỗi !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
