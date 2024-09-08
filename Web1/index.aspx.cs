using System;
using max_min; // Thêm namespace từ file DLL mà bạn đã thêm

namespace Web1
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_timkiem_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy dữ liệu từ các TextBox
                int num1 = int.Parse(txt_1.Text);
                int num2 = int.Parse(txt_2.Text);
                int num3 = int.Parse(txt_3.Text);
                int num4 = int.Parse(txt_4.Text);
                int num5 = int.Parse(txt_5.Text);

                // Tạo một mảng để chứa các số đã nhập
                int[] numbers = { num1, num2, num3, num4, num5 };

                // Sử dụng các phương thức từ file DLL
                Class1 obj = new Class1();
                int max = obj.FindMax(numbers);
                int min = obj.FindMin(numbers);

                // Hiển thị kết quả lên Label
                Label6.Text = "Số lớn nhất là: " + max;
                Label7.Text = "Số nhỏ nhất là: " + min;
            }
            catch (Exception ex)
            {
                // Hiển thị thông báo lỗi nếu có
                Label6.Text = "Lỗi: " + ex.Message;
            }
        }
    }
}
