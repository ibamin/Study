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
    public partial class Explain : Form
    {
        public Explain(Button buttons)
        {
            /*InitializeComponent();

            if (buttons.Name == "key1")// 열쇠
            {
              label2.Text = "어딘가를 열수있는 열쇠.";       
            }
            else if (buttons.Text == "ladder")//사다리
            {
                label2.Text = "어딘가 높이 있는 물건을 찾을때 쓸수 있을거 같다.";
            }
            else if (buttons.Text == "Code")//단서
            {
                label2.Text = "이 단서는 ~ 이다..";
            }*/
        }

        public Explain(string _name, string _ex, int idx)
        {
            InitializeComponent();
            label1.Text = _name;
            label2.Text = _ex;
            pictureBox1.Image = imageList1.Images[idx];
        }
        private void Explain_Load(object sender, EventArgs e)
        {

        }
    }
}
