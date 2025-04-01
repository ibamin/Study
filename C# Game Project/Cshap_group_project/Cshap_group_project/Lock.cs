using Cshap_group_project;
using Pr0731;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hello0731
{
    public partial class Lock : Form
    {
        public DialogResult Locker = DialogResult.Cancel;
        public Lock()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((comboBox1.Text == "9") & (comboBox2.Text == "4") & (comboBox3.Text == "4") & (comboBox4.Text == "5"))
            {
                Locker = DialogResult.OK;
                this.Close();
            }
            else
            {
                paper newpaper = new paper("딸각 딸각 소리는 들렸지만 열리지는 않았다.");
                newpaper.ShowDialog();
            }
        }

        private void comboBox1_MouseHover(object sender, EventArgs e)
        {
            label1.Text = "1층의 박스";
        }

        private void comboBox2_MouseHover(object sender, EventArgs e)
        {
            label1.Text = "지하실의 시체";
        }

        private void comboBox3_MouseHover(object sender, EventArgs e)
        {
            label1.Text = "2층 서재";
        }

        private void comboBox4_MouseHover(object sender, EventArgs e)
        {
            label1.Text = "2층 서재";
        }
    }
}
