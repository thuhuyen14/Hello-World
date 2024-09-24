using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
            int vtd, vtc, ddai;
            ht = txtHoTen.Text.Trim(); 
            vtd=ht.IndexOf(" "); //index vị trí dấu cách đầu tiên trong chuỗi họ tên
        }
    }
}
