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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void hệThốngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void helloWorldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new;
            f.Show();    
        }

        private void táchTênNgườiViệtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form a = new Maytinhcamtay();
            a.ShowDialog();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Form f = new Form1();
            f.ShowDialog();
        }

        private void kếtThúcChươngTrìnhToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
