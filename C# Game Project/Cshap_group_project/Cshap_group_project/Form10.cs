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
    public partial class Form10 : Form
    {
        inventory Inventory;
        Item Item_list; //초기화
        public Form10(inventory inventory) //매개변수를 갖는 생성자
        {
            InitializeComponent();
            this.Inventory = inventory;
            Item_list = new Item();
        }

        private void textBox1_TextChanged(object sender, EventArgs e) // 텍스트에 정답 입력
        {
            if (textBox1.Text == "rope")
            {
                MessageBox.Show("정답");
                DialogResult = DialogResult.OK;
                PictureBox pb = new PictureBox();
                pb.Name = "hint2";
                pb.Image = imageList1.Images[0];
                Inventory.New_Item(pb, e);
            }
            else
                lbhint3.Text = "";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            lbhint6.Text = "색이 다른 단어들을 한 글자로 만들어 보세요.";
        }
    }
}
