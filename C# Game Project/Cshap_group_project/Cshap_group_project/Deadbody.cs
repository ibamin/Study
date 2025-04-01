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
    public partial class Deadbody : Form
    {
        public DialogResult dialogResult = DialogResult.Cancel;


        public Deadbody()
        {
            InitializeComponent();
        }



        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

            if (vScrollBar1.Value == 15)
            {
                pictureBox1.Location = new Point(0, 60);

            }
            if (vScrollBar1.Value == 20)
            {
                pictureBox1.Location = new Point(0, 100);
            }
            if (vScrollBar1.Value == 30)
            {
                pictureBox1.Location = new Point(0, 200);
            }
            if (vScrollBar1.Value == 40)
            {
                pictureBox1.Location = new Point(0, 300);
            }
            if(vScrollBar1.Value ==60)
            {
                pictureBox1.Location = new Point(0,450);
            }
            if (vScrollBar1.Value == 89)
            {
                pictureBox1.Location = new Point(0, 600);
                vScrollBar1.Value = 0;
                MessageBox.Show("시체에 무언가 적혀있다.");
                dialogResult = DialogResult.OK;

                if (dialogResult == DialogResult.OK)
                {
                    this.Close();
                    BodyString body = new BodyString();
                    body.ShowDialog();
                    body.DialogResult = DialogResult.OK;
                }







            }

            if (dialogResult == DialogResult.OK)
            {

            }
        }
    }
}
