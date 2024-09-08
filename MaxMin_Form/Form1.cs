using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using max_min;

namespace MaxMin_Form
{
    public partial class Form1 : Form
    {
        Class1 maxmin = new Class1();
        public Form1()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            int[] numbers = new int[5];
            try
            {
                // Lấy dữ liệu từ các TextBox và chuyển thành mảng số nguyên
                numbers[0] = int.Parse(txt_1.Text);
                numbers[1] = int.Parse(txt_2.Text);
                numbers[2] = int.Parse(txt_3.Text);
                numbers[3] = int.Parse(txt_4.Text);
                numbers[4] = int.Parse(txt_5.Text);

                // Gọi phương thức FindMax và FindMin từ DLL
                int max = maxmin.FindMax(numbers);
                int min = maxmin.FindMin(numbers);

                // Hiển thị kết quả trong các TextBox
                txt_max.Text = max.ToString();
                txt_min.Text = min.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng số nguyên.");
            }
        }
    }
}
