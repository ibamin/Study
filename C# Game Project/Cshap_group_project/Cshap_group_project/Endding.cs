using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class Endding : Form
    {
        const int Step_Sliding = 1; //panel 올라오는속도
        int height; //판넬1의 Y값
        int cnt;
        public Endding()
        {
            InitializeComponent();

            this.BackColor = Color.Black;
            height = 500;
            cnt = 0;
            timer1.Start();
        }

        private async void timer1_Tick(object sender, EventArgs e)
        {
            if (height <= 80)
            {
                timer1.Stop();
                await Task.Delay(500);
                label1.Visible = false;
                label2.Visible = false;
                timer2.Start();
            }

            height = height - Step_Sliding;
            panel1.ForeColor = Color.White;

            panel1.Location = new Point(154, height);

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            cnt += 1;
            if (cnt % 2 == 1)
            {
                label1.Visible = true;
                label2.Visible = true;
            }
            else
            {
                label1.Visible = false;
                label2.Visible = false;
            }

            if (cnt >= 5)
            {
                panel1.Visible = false;
                timer2.Stop();
                Last();
            }
        }
        private async void Last()
        {
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.BackgroundImage = Cshap_group_project.Properties.Resources.ending; // 임의로 넣은 사진
            await Task.Delay(1000); // 딜레이 
            this.BackgroundImage = null; // 이미지 초기화
            this.BackColor = this.ForeColor = Color.Black;
            panel1.ForeColor = Color.Red;
            panel1.Visible = true;
        }
    }
}
