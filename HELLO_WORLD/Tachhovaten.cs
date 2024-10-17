using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HELLO_WORLD
{
    public partial class Tách_họ_và_tên : Form
    {
        public Tách_họ_và_tên()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ht, ho, dem, ten;
            int vtd, vtc, ddai;  //gán biến vị trí đầu của dấu cách vtd, vị trí cuối của dấu cách vtc, độ dài họ và tên ddai
            ht = txtHoTen.Text.Trim(); 
            vtd=ht.IndexOf(" "); //index vị trí dấu cách đầu tiên trong chuỗi họ tên
            vtc = ht.LastIndexOf(" "); // Tìm vị trí dấu cách cuối cùng
            ddai = ht.Length; // Lấy độ dài của chuỗi họ tên
            ho = ht.Substring(0, vtd); // Họ đứng trước vị trí dấu cách đầu tiên
            dem = ht.Substring(vtd + 1, vtc - vtd - 1); // Đệm nằm giữa Họ và tên
            ten = ht.Substring(vtc + 1); // Tên nằm sau vị trí cuối cùng
            textBoxHo.Text = ho;
            textBoxDem.Text = dem;
            textBoxTen.Text = ten;
        }
        

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
