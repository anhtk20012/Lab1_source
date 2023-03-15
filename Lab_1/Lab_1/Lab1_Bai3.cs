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
    public partial class Lab1_Bai3 : Form
    {
        public Lab1_Bai3()
        {
            InitializeComponent();
        }

        private void btn_doc_Click(object sender, EventArgs e)
        {
            try
            {
                int num1 = Int32.Parse(tb_number.Text.Trim());
                string[] a = {"Một", "Hai", "Ba", "Bốn", "Năm", "Sáu", "Bảy", "Tám", "Chín"};
                if (num1 != 0) tb_kq.Text = a[num1 - 1]; else tb_kq.Text = "Không";
            }
            catch (Exception ex)
            {
                MessageBox.Show(e.ToString(), "Dữ liệu nhập bị lỗi !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            tb_number.Text = "";
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
