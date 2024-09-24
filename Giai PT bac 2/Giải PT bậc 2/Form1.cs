using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Giải_PT_bậc_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // Đây là nơi bạn có thể thực hiện các hành động khi form được tải.
            // Ví dụ: Thiết lập các giá trị mặc định cho các điều khiển trên form
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy giá trị từ TextBox
                float a = float.Parse(textBox1.Text);
                float b = float.Parse(textBox2.Text);
                float c = float.Parse(textBox3.Text);

                // Tính delta
                float delta = b * b - 4 * a * c;

                if (a == 0)
                {
                    if (b == 0)
                    {
                        if (c == 0)
                            labelResult.Text = "Phương trình có vô số nghiệm!";
                        else
                            labelResult.Text = "Phương trình vô nghiệm!";
                    }
                    else
                    {
                        labelResult.Text = $"Phương trình có nghiệm duy nhất: {-c / b}";
                    }
                }
                else
                {
                    if (delta < 0)
                    {
                        labelResult.Text = "Phương trình vô nghiệm!";
                    }
                    else if (delta == 0)
                    {
                        labelResult.Text = $"Phương trình có nghiệm kép: {-b / (2 * a)}";
                    }
                    else
                    {
                        float x1 = (float)((-b + Math.Sqrt(delta)) / (2 * a));
                        float x2 = (float)((-b - Math.Sqrt(delta)) / (2 * a));
                        labelResult.Text = $"Phương trình có 2 nghiệm phân biệt: x1 = {x1}, x2 = {x2}";
                    }
                }
            }
            catch (Exception ) // Khối catch xử lý các lỗi
            {
                // Nếu có lỗi trong quá trình nhập liệu
                MessageBox.Show("Vui lòng nhập đúng các hệ số của phương trình.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}