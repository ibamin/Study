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

//욕조에서 힌트를 얻기 위해 비밀번호를 입력하는 폼
namespace Pr0731
{
    public partial class Form12 : Form

    {
        public DialogResult a = DialogResult.Cancel;
        public DialogResult last_quiz_check = DialogResult.Cancel;
        inventory inventory; //초기화
        Item Item_list;
        public Form12(inventory inventory) //매개변수를 갖는 생성자
        {
            InitializeComponent();
            this.inventory = inventory;
            Item_list = new Item();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (a == DialogResult.Cancel)
            {

                if (textBox1.Text == "486")
                {

                    /*
                    a = DialogResult.OK;
                    Close();
                    */
                    Form7 form7 = new Form7(inventory);
                    form7.ShowDialog();
                    DialogResult = DialogResult.OK;
                    a = DialogResult.OK;
                    return;
                }
            }
            if (textBox1.Text == "유이수")
            {
                last_quiz_check = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("비밀번호가 틀렸습니다.");
                textBox1.Text = "";

            }

        }
    }
}
