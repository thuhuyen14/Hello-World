using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tách_họ_và_tên
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy giá trị từ TextBox
                string fullName = textBox1.Text.Trim();

                if (string.IsNullOrEmpty(fullName))
                {
                    MessageBox.Show("Vui lòng nhập họ tên đầy đủ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Tách họ đệm và tên
                string[] parts = fullName.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                if (parts.Length < 2)
                {
                    MessageBox.Show("Vui lòng nhập họ và tên đầy đủ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Họ đệm là tất cả các phần trước phần cuối cùng
                string lastName = string.Join(" ", parts.Take(parts.Length - 1));
                // Tên là phần cuối cùng
                string firstName = parts.Last();

                // Hiển thị kết quả
                label2.Text = $"Họ đệm: {lastName}";
                label3.Text = $"Tên: {firstName}";
            }
            catch (Exception ex)
            {
                // Nếu có lỗi trong quá trình nhập liệu
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
