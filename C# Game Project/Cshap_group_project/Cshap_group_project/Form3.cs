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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();

            lbpassword.Parent = pictureBox1;
            lbpassword.BackColor = Color.Transparent;
        }

       private void label1_Click(object sender, EventArgs e)
        {



        }

        private void lbpassword_Click(object sender, EventArgs e) // 라벨을 누르면 비밀번호 출력
        {            
          MessageBox.Show("비밀번호 : 사랑해");
            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
