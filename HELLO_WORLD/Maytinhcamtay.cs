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
    public partial class Maytinhcamtay : Form
    {
        public Maytinhcamtay()
        {
            InitializeComponent();
            add_Click();
            list = new List<string>();
        }

        List<Button> buttons;
        List<string> list;
        private void add_Click()
        {
            buttons = new List<Button>() { btn0, btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9 };
            foreach (var item in buttons)
            {
                item.Click += new EventHandler(button_Click);
            }    
        }
        private void button_Click(object sender, EventArgs e)
        {
                string textButton = (sender as Button).Text;
                textBox1.Text += textButton;
        }
        private void sum()
        {
            if (list.Contains("+")) // 12 + 3
            {
                list.Remove("+"); //12 3
                double s = Convert.ToDouble(list[0]) + Convert.ToDouble(list[1]);
                textBox1.Text = s.ToString();
            }
        }
        private void btn_Cong_Click(object sender, EventArgs e)
        {
            if(textBox1.Text!=" ")
            {
                list.Add(textBox1.Text);
                list.Add(btnCong.Text);
                textBox1.Text = " ";
                      
            }    
        }

        private void btn_Bang_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                list.Add(textBox1.Text); //12 + 3
                sum();
                list.Clear();
            }
        }
    }
}
