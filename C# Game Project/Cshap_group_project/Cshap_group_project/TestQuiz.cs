using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hello0731
{
    public partial class TestQuiz : Form
    {
        public string BROKEN = "";
        public int BrokenNum = 0;
        public TestQuiz()
        {
            InitializeComponent();


        }
        public void Clear(int x)
        {
            if (x >= 7)
            {
                BrokenNum = 0;
                button1.BackColor = Color.White;
                button2.BackColor = Color.White;
                button3.BackColor = Color.White;
                button4.BackColor = Color.White;
                button5.BackColor = Color.White;
                button6.BackColor = Color.White;
                button7.BackColor = Color.White;
                button8.BackColor = Color.White;
                button9.BackColor = Color.White;
                button10.BackColor = Color.White;
                button11.BackColor = Color.White;
                button12.BackColor = Color.White;
                button13.BackColor = Color.White;
                button14.BackColor = Color.White;
                button15.BackColor = Color.White;
                button16.BackColor = Color.White;
                button17.BackColor = Color.White;
                button18.BackColor = Color.White;
                button19.BackColor = Color.White;
                button20.BackColor = Color.White;
                button21.BackColor = Color.White;
                button22.BackColor = Color.White;
                button23.BackColor = Color.White;
                button24.BackColor = Color.White;
                button25.BackColor = Color.White;
                button26.BackColor = Color.White;

                BROKEN = "";
            }

        }
        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void TestQuiz_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            BROKEN += 'A';
            BrokenNum++;
            button1.BackColor = Color.Red;
            Clear(BrokenNum);
        }

        private void button26_Click(object sender, EventArgs e)
        {
            BROKEN += 'N';
            BrokenNum++;
            button26.BackColor = Color.Red;
            Clear(BrokenNum);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BROKEN += 'B';
            BrokenNum++;
            button2.BackColor = Color.Red;
            Clear(BrokenNum);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            BROKEN += 'G';
            BrokenNum++;
            button7.BackColor = Color.Red;
            Clear(BrokenNum);
        }

        private void button25_Click(object sender, EventArgs e)
        {
            BROKEN += 'O';
            BrokenNum++;
            button25.BackColor = Color.Red;
            Clear(BrokenNum);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            BROKEN += 'P';
            BrokenNum++;
            button24.BackColor = Color.Red;
            Clear(BrokenNum);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            BROKEN += 'D';
            BrokenNum++;
            button4.BackColor = Color.Red;
            Clear(BrokenNum);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            BROKEN += 'Q';
            BrokenNum++;
            button23.BackColor = Color.Red;
            Clear(BrokenNum);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            BROKEN += 'E';
            BrokenNum++;
            button5.BackColor = Color.Red;
            Clear(BrokenNum);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            BROKEN += 'R';
            BrokenNum++;
            button22.BackColor = Color.Red;
            Clear(BrokenNum);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            BROKEN += 'S';
            BrokenNum++;
            button21.BackColor = Color.Red;
            Clear(BrokenNum);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            BROKEN += 'F';
            BrokenNum++;
            button6.BackColor = Color.Red;
            Clear(BrokenNum);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            BROKEN += 'T';
            BrokenNum++;
            button20.BackColor = Color.Red;
            Clear(BrokenNum);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BROKEN += 'C';
            BrokenNum++;
            button3.BackColor = Color.Red;
            Clear(BrokenNum);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            BROKEN += 'U';
            BrokenNum++;
            button19.BackColor = Color.Red;
            Clear(BrokenNum);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            BROKEN += 'H';
            BrokenNum++;
            button8.BackColor = Color.Red;
            Clear(BrokenNum);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            BROKEN += 'V';
            BrokenNum++;
            button18.BackColor = Color.Red;
            Clear(BrokenNum);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            BROKEN += 'I';
            BrokenNum++;
            button9.BackColor = Color.Red;
            Clear(BrokenNum);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            BROKEN += 'W';
            BrokenNum++;
            button17.BackColor = Color.Red;
            Clear(BrokenNum);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            BROKEN += 'J';
            BrokenNum++;
            button10.BackColor = Color.Red;
            Clear(BrokenNum);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            BROKEN += 'K';
            BrokenNum++;
            button11.BackColor = Color.Red;
            Clear(BrokenNum);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            BROKEN += 'X';
            BrokenNum++;
            button16.BackColor = Color.Red;
            Clear(BrokenNum);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            BROKEN += 'L';
            BrokenNum++;
            button12.BackColor = Color.Red;
            Clear(BrokenNum);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            BROKEN += 'Y';
            BrokenNum++;
            button15.BackColor = Color.Red;
            Clear(BrokenNum);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            BROKEN += 'M';
            BrokenNum++;
            button13.BackColor = Color.Red;
            Clear(BrokenNum);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            BROKEN += 'Z';
            BrokenNum++;
            button14.BackColor = Color.Red;
            Clear(BrokenNum);
        }

        private void button27_Click(object sender, EventArgs e)
        {
            if (BROKEN == "BROKEN")
            {
                button27.Text = "정답";


                label15.Text = "Broken..? 관련된 단서가 있는지 다시 찾아봐보자.";

                LivingRoom.MirrorAc = 1;
            }
            else
            {

                BROKEN = "";
                BrokenNum = 0;
                button1.BackColor = Color.White;
                button2.BackColor = Color.White;
                button3.BackColor = Color.White;
                button4.BackColor = Color.White;
                button5.BackColor = Color.White;
                button6.BackColor = Color.White;
                button7.BackColor = Color.White;
                button8.BackColor = Color.White;
                button9.BackColor = Color.White;
                button10.BackColor = Color.White;
                button11.BackColor = Color.White;
                button12.BackColor = Color.White;
                button13.BackColor = Color.White;
                button14.BackColor = Color.White;
                button15.BackColor = Color.White;
                button16.BackColor = Color.White;
                button17.BackColor = Color.White;
                button18.BackColor = Color.White;
                button19.BackColor = Color.White;
                button20.BackColor = Color.White;
                button21.BackColor = Color.White;
                button22.BackColor = Color.White;
                button23.BackColor = Color.White;
                button24.BackColor = Color.White;
                button25.BackColor = Color.White;
                button26.BackColor = Color.White;
            }
        }

        private void button28_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
