using Cshap_group_project;
using Csharp_gruop_project;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pr0731
{
    public partial class Form6 : Form
    {
        inventory inventory; //초기화
        Item Item_list;
        public Form6(inventory inventory) //매개변수를 갖는 생성자
        {
            InitializeComponent();
            this.inventory = inventory;
            Item_list = new Item();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // 문제의 정답 링을 맞췄을 경우
            if (textBox1.Text == "링")
            {
                MessageBox.Show("정답");
                this.Close();

                PictureBox pb = new PictureBox();
                pb.Name = "hint3";
                pb.Image = imageList1.Images[0];
                inventory.New_Item(pb, e);

            }






        }

        private void btn2_Click(object sender, EventArgs e)
        {
            lbhint5.Text = "숫자를 세는 방법에는 십,열 두가지가 있습니다.";
        }
    }
}
