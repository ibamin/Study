using Cshap_group_project;
using Csharp_gruop_project;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pr0731
{
    public partial class Form4 : Form


    {
        private int clickCount = 0; // pictureBox2 -> 귀신사진
        int time = 0;

        inventory Inventory = new inventory();
        Item Item_list;

        

        public Form4(inventory inventory)
        {
            InitializeComponent();
            this.Inventory = inventory;
            Item_list = new Item();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox1_Click(object sender, EventArgs e) // 사진 클릭
        {
            clickCount++;
            if (clickCount % 10 == 0)
            {
                pictureBox2.BringToFront();
                MessageBox.Show("밧줄을 획득했다.");
                DialogResult = DialogResult.OK;
                this.Close();


                PictureBox pb1 = new PictureBox();
                pb1.Name = "rope";
                pb1.Image= Imagelist1.Images[0];
                Inventory.New_Item(pb1, e);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}







