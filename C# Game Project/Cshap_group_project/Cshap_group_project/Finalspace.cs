using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cshap_group_project
{
    public partial class Finalspace : Form
    {


        inventory inventory_;
        Underground under;

        string answer = "3354";

        public Finalspace(inventory inven)
        {
            InitializeComponent();
            label1.Text = string.Empty;

            inventory_ = inven;
            under = new Underground(inven);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text += "1";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text += "2";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.Text += "3";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label1.Text += "4";
            Check(e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text += "5";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text += "6";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label1.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label1.Text += "8";
        }

        private void Check(EventArgs e)
        {
            if (label1.Text == answer)
            {
                MessageBox.Show("정답");
                label1.Text = "서재로 가는 열쇠를 획득했다.";
                PictureBox pb = new PictureBox();


                pb.Name = "Under_Paper";
                pb.Image = under.imageList1.Images[1];
                inventory_.New_Item(pb, e);
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {
            label1.Text = string.Empty;
        }
    }
}
