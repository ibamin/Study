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
    public partial class Form8 : Form
    {
        inventory Inventory;
        Item Item_list; //초기화

        public Form8(inventory inventory) //매개변수를 갖는 생성자
        {
            InitializeComponent();
            this.Inventory = inventory;
            Item_list = new Item();
        }


        private void lbhint2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e) // 텍스트 박스에 정답 입력
        {
            if (textBox1.Text == "스위스")
            {
                MessageBox.Show("정답");
                DialogResult = DialogResult.OK;
                this.Close();

                PictureBox pb = new PictureBox();
                pb.Name = "hint1";
                pb.Image = imageList1.Images[0];
                Inventory.New_Item(pb, e);

            }

            else
                lbhint2.Text = "";
        }

        private void button1_Click(object sender, EventArgs e) // 버튼 클릭했을때 힌트 나오게
        {
            lbhint4.Text = "힌트:색이 다른 단어들을 잘 살펴보세요.";

        }
    }
}
