using hello0731;
using Pr0731;
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
    //First Form
    public partial class mainscreen : Form
    {

        private int labelPosY;
        private Timer timer;
        private int x;
        private int y;
        inventory inven = new inventory();
        F2 f2; //서재
        LivingRoom f1;
        Underground under;
        Form2 Toilet;

        public mainscreen()
        {
            InitializeComponent();
            labelPosY = 0;
            InitializeTimer();
            f2 = new F2(inven);

            under = new Underground(inven);
            Toilet = new Form2(inven);
            f1 = new LivingRoom(inven, f2, under, Toilet);
        }

        Timer Timer_Tick = new Timer(); //?
        int cnt = 0;

        private void InitializeTimer()
        {
            timer = new Timer();
            timer.Interval = 100; // 라벨이 움직이는 간격(ms). 숫자가 작을수록 빠르게 움직임.
            timer.Tick += timer1_Tick;

        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            cnt++;
            if (labelPosY == 240)
            {
                labelPosY = 240;
                timer.Stop();
            }
            else
            {
                labelPosY += 3;
            }
            //
            lbTitle.Location = new Point(800, 5);
            lbTitle.Location = new Point(0, 5);
            lbTitle.Location = new Point(430, 5);
            //라벨 위치가 폼의 높이를 넘어가면 초기 위치로 재설정
            //  if (labelPosY > this.Height)
            //    labelPosY = 0;
            //라벨 위치 갱신
            lbTitle.Location = new System.Drawing.Point(lbTitle.Location.X, labelPosY);

            if (cnt % 4 == 0)
            {
                lbStart.ForeColor = Color.Red;
                lbTitle.Text = " ";
            }
            else
            {
                lbStart.ForeColor = Color.White;
                lbTitle.ForeColor = Color.DarkRed;
                lbTitle.Text = "Escape";
            }
            if (cnt == 1)
            {
                lbStart.BackColor = Color.Black;
                lbTitle.BackColor = Color.Black;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void lbStart_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            //f2.ShowDialog();   //인벤토리 공유 확인용 여기서 아이템 넣고 ex)사다리,열쇠
            f1.ShowDialog(); //여기서 인벤 열어서 확인
            //under.ShowDialog();
            this.Close();
        }
    }
}



