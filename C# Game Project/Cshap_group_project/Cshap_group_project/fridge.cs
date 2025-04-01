using Cshap_group_project;
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
    public partial class fridge : Form
    {
        public int timerNum = 0;
        public int timerNum2 = 0;

        inventory inven;
        int KnifeItem;
        public fridge(inventory inven, int KnifeItem)
        {
            InitializeComponent();
            this.inven = inven;
            this.KnifeItem = KnifeItem;
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timerNum++;

            if (timerNum % 2 == 0)
            {
                btn_frg.ForeColor = Color.Red;
            }
            else
                btn_frg.ForeColor = Color.Yellow;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timerNum2++;

            if (timerNum2 == 1)
            {
                lb_fg1.Text = "오";

            }
            else if (timerNum2 == 2)
            {
                lb_fg1.Text = "오래";
            }
            else if (timerNum2 == 3)
            {
                lb_fg1.Text = "오래된";
            }
            else if (timerNum2 == 4)
            {
                lb_fg1.Text = "오래된 냉";
            }
            else if (timerNum2 == 5)
            {
                lb_fg1.Text = "오래된 냉장";
            }
            else if (timerNum2 == 6)
            {
                lb_fg1.Text = "오래된 냉장고";
            }
            else if (timerNum2 == 7)
            {
                lb_fg1.Text = "오래된 냉장고라";
            }
            else if (timerNum2 == 8)
            {
                lb_fg1.Text = "오래된 냉장고라 그";
            }
            else if (timerNum2 == 9)
            {
                lb_fg1.Text = "오래된 냉장고라 그런지";
            }
            else if (timerNum2 == 10)
            {
                lb_fg1.Text = "오래된 냉장고라 그런지\n 서";
            }
            else if (timerNum2 == 11)
            {
                lb_fg1.Text = "오래된 냉장고라 그런지\n 서랍";
            }
            else if (timerNum2 == 12)
            {
                lb_fg1.Text = "오래된 냉장고라 그런지\n 서랍이";
            }
            else if (timerNum2 == 13)
            {
                lb_fg1.Text = "오래된 냉장고라 그런지\n 서랍이 안";
            }
            else if (timerNum2 == 14)
            {
                lb_fg1.Text = "오래된 냉장고라 그런지\n서랍이 안열";
            }
            else if (timerNum2 == 15)
            {
                lb_fg1.Text = "오래된 냉장고라 그런지\n서랍이 안열린";
            }
            else if (timerNum2 == 16)
            {
                lb_fg1.Text = "오래된 냉장고라 그런지\n서랍이 안열린다";
            }
            else if (timerNum2 == 20)
            {
                lb_fg1.Text = "오래된 냉장고라 그런지\n서랍이 안열린다 \n서랍을";
            }
            else if (timerNum2 == 23)
            {
                lb_fg1.Text = "오래된 냉장고라 그런지\n서랍이 안열린다 \n서랍을 부수고 안의 칼을";
            }
            else if (timerNum2 >= 26)
            {
                lb_fg1.Text = "오래된 냉장고라 그런지\n서랍이 안열린다 \n서랍을 부수고 안의 칼을\n가져가자.";

                ////   btn_frg1 = new Button();
                //btn_frg1.BackColor = Color.Red;
                //btn_frg1.Text = "유리를 부순다.";

                //// btn_frg2 = new Button();
                //btn_frg2.BackColor = Color.Blue;
                //btn_frg2.Text = "냉장고를 닫는다.";


                btn_frg1.Location = new Point(460, 219);
                btn_frg2.Location = new Point(460, 258);

            }
            if (timerNum2 >= 30)
            {
                timer2.Stop();
                timerNum2 = 0;
            }
        }

        private void btn_frg_MouseHover(object sender, EventArgs e)
        {

        }

        private void lb_frg2_Load(object sender, EventArgs e)
        {

        }

        private void btn_frg_MouseHover_1(object sender, EventArgs e)
        {
            lb_fg2.Text = "냉장고 서랍 안에 주방용 칼이 들어있다.";
        }

        private void btn_frg_MouseLeave(object sender, EventArgs e)
        {
            lb_fg2.Text = "";
        }

        private void btn_frg1_Click(object sender, EventArgs e)
        {
            miniGame mnG = new miniGame(inven, KnifeItem);
            mnG.ShowDialog();
        }

        private void btn_frg2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /*
private void button1_MouseHover(object sender, EventArgs e)
{

}
*/
    }
}
