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
    public partial class Lab1_Bai3_1 : Form
    {
        public Lab1_Bai3_1()
        {
            InitializeComponent();
        }
        private void btn_doc_Click(object sender, EventArgs e)
        {
            try
            {
                tb_kq.Text = "";
                int[] arrdl = tb_number.Text.Reverse().Select(t => Convert.ToInt32(t.ToString())).ToArray();
                if (arrdl.Length > 12)
                {
                    MessageBox.Show(e.ToString(), "Dữ liệu nhập bị lỗi !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string[] a = { "Một", "Hai", "Ba", "Bốn", "Năm", "Sáu", "Bảy", "Tám", "Chín" };
                    string[] b = { "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín" };
                    int i = 0, tam = 0;
                    while (arrdl[i] == 0 && i < arrdl.Length && arrdl.Length != 1)
                    {
                        i++;
                        tam = 1;
                    }
                    /*if ( tam == 1)
                    {
                        if (i > 2) tb_kq.Text = "tỷ";
                        else
                        if (i > 2) tb_kq.Text = "triệu";
                        else
                        if (i > 2) tb_kq.Text = "ngàn";
                    }*/
                    if (i == 0)
                    {
                        if (arrdl[i] == 0) tb_kq.Text = "Không";
                        else
                        if (arrdl.Length == 1) tb_kq.Text = a[arrdl[i] - 1];
                        else tb_kq.Text = b[arrdl[i] - 1];
                        i++;
                    }
                    if (i != arrdl.Length)
                        if (i == 1)
                        {
                            if (i == arrdl.Length - 1)
                                tb_kq.Text = a[arrdl[i] - 1] + " mươi " + tb_kq.Text;
                            else
                                tb_kq.Text = b[arrdl[i] - 1] + " mươi " + tb_kq.Text;
                            i++;
                        }
                    if (i != arrdl.Length)
                        if (i == 2)
                        {
                            if (i == arrdl.Length - 1)
                                tb_kq.Text = a[arrdl[i] - 1] + " trăm " + tb_kq.Text;
                            else
                                tb_kq.Text = b[arrdl[i] - 1] + " trăm " + tb_kq.Text;
                            i++;
                        }
                    if (i != arrdl.Length)
                        if (i == 3)
                        {
                            if (i == arrdl.Length - 1)
                                tb_kq.Text = a[arrdl[i] - 1] + " ngàn, " + tb_kq.Text;

                            else
                                tb_kq.Text = b[arrdl[i] - 1] + " ngàn, " + tb_kq.Text;
                            i++;
                        }
                    if (i != arrdl.Length)
                        if (i == 4)
                        {
                            if (i == arrdl.Length - 1)
                                tb_kq.Text = a[arrdl[i] - 1] + " mươi " + tb_kq.Text;
                            else
                                tb_kq.Text = b[arrdl[i] - 1] + " mươi " + tb_kq.Text;
                            i++;
                        }
                    if (i != arrdl.Length)
                        if (i == 5)
                        {
                            if (i == arrdl.Length - 1)
                                tb_kq.Text = a[arrdl[i] - 1] + " trăm " + tb_kq.Text;
                            else
                                tb_kq.Text = b[arrdl[i] - 1] + " trăm " + tb_kq.Text;
                            i++;
                        }
                    if (i != arrdl.Length)
                        if (i == 6)
                        {
                            if (i == arrdl.Length - 1)
                                tb_kq.Text = a[arrdl[i] - 1] + " triệu, " + tb_kq.Text;
                            else
                                tb_kq.Text = b[arrdl[i] - 1] + " triệu, " + tb_kq.Text;
                            i++;
                        }
                    if (i != arrdl.Length)
                        if (i == 7)
                        {
                            if (i == arrdl.Length - 1)
                                tb_kq.Text = a[arrdl[i] - 1] + " mươi " + tb_kq.Text;
                            else
                                tb_kq.Text = b[arrdl[i] - 1] + " mươi " + tb_kq.Text;
                            i++;
                        }
                    if (i != arrdl.Length)
                        if (i == 8)
                        {
                            if (i == arrdl.Length - 1)
                                tb_kq.Text = a[arrdl[i] - 1] + " trăm " + tb_kq.Text;
                            else
                                tb_kq.Text = b[arrdl[i] - 1] + " trăm " + tb_kq.Text;
                            i++;
                        }
                    if (i != arrdl.Length)
                        if (i == 9)
                        {
                            if (i == arrdl.Length - 1)
                                tb_kq.Text = a[arrdl[i] - 1] + " tỷ, " + tb_kq.Text;
                            else
                                tb_kq.Text = b[arrdl[i] - 1] + " tỷ, " + tb_kq.Text;
                            i++;
                        }
                    if (i != arrdl.Length)
                        if (i == 10)
                        {
                            if (i == arrdl.Length - 1)
                                tb_kq.Text = a[arrdl[i] - 1] + " mươi " + tb_kq.Text;
                            else
                                tb_kq.Text = b[arrdl[i] - 1] + " mươi " + tb_kq.Text;
                            i++;
                        }
                    if (i != arrdl.Length)
                        if (i == 11)
                        {
                            tb_kq.Text = a[arrdl[i] - 1] + " trăm " + tb_kq.Text;
                            i++;
                        }
                }    

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
