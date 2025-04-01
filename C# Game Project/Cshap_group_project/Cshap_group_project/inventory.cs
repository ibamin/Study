using Csharp_gruop_project;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cshap_group_project
{
    public partial class inventory : Form
    {
        //버튼 둥글게
        /*[DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect,
            int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);*/
        public List<Button> buttons = new List<Button>();
        public ImageList items = new ImageList();
        //체크버튼 이미지 리스트
        public List<PictureBox> pictureBoxes = new List<PictureBox>();
        Button focus_button = new Button();
        //아이템 개수를 위한 변수
        private int ICnt_Item;
        //선택된 버튼의 인덱스값을 위한 변수
        private int btn_idx;
        Item item_list;
        bool Check; // 중복체크
        public inventory(ImageList items)
        {
            InitializeComponent();                 // 폼 초기화
            KeyPreview = true;                     //키 다운 이벤트 추가
            this.KeyDown += Close_Inven;
            this.items = items;                    // 이미지리스트 받아오기
            item_list = new Item();                // 아이템 정보 초기화
            btn_Observe.Click += Explain_Item;     // 버튼이벤트 추가 (설명)
            this.FormClosed += Clear_btn_idx;      // 인벤토리 닫힐때 이벤트
            Check = false;

        }
        public inventory()
        {
            InitializeComponent();
            KeyPreview = true;
            item_list = new Item();                // 아이템 정보 초기화
            this.KeyDown += Close_Inven;
            btn_Observe.Click += Explain_Item;     // 버튼이벤트 추가 (설명)
            ICnt_Item = 0;
            btn_idx = -1;
        }

        //inventory open시 Item들 배치
        void inven_open(ImageList items)
        {
            for (int i = 0; i < items.Images.Count; i++)
            {
                buttons[i].Image = items.Images[i];
            }
        }
        public void New_Item(object sender, EventArgs e)
        {
            //아이템이 최대 개수(18칸)
            if (ICnt_Item / 6 > 2)
            {
                MessageBox.Show("아이템을 더이상 획득할 수 없습니다", "알림");
                return;
            }

            PictureBox pictureBox = new PictureBox();
            pictureBox = sender as PictureBox;
            //중복검사
            for (int i = 0; i < buttons.Count; i++)
            {
                if (buttons[i].Name == pictureBox.Name)
                {
                    MessageBox.Show("이미 인벤토리에 있습니다.");
                    return;
                }
            }
            //버튼 생성 및 테두리, 모서리 둥글게
            Button btn = new Button();
            btn.Size = new Size(100, 105);
            btn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn.Width, btn.Height, 40, 40));
            btn.Location = new Point((73 + ICnt_Item % 6 * 106), 46 + ICnt_Item / 6 * 110);
            btn.TabStop = false;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;

            //체크박스 이미지
            PictureBox pb = new PictureBox();
            pb.Name = string.Format($"check{ICnt_Item}");
            pb.Image = Properties.Resources.check2;
            pb.SizeMode = PictureBoxSizeMode.StretchImage;
            pb.Size = new Size(20, 20);

            pb.Location = new Point(btn.Location.X + 80, btn.Location.Y);

            //리스트에 추가
            pictureBoxes.Add(pb);
            //아이템 이름
            btn.Name = string.Format(pictureBox.Name);
            
            
            //아이템 이미지
            btn.BackgroundImageLayout = ImageLayout.Stretch;
            btn.BackgroundImage = pictureBox.Image;
            //버튼 리스트에 버튼추가
            buttons.Add(btn);
            //아이템 클릭 이벤트 추가
            btn.Click += item_Click;
            //아이템 수량 증가
            ICnt_Item += 1;
            //화면에 아이템 추가(버튼, 체크이미지)
            this.Controls.Add(btn);
            this.Controls.Add(pb);

            //체크이미지 맨 앞으로 가져온 뒤 안 보이게 해결
            pb.BringToFront();
            pb.Visible = false;

            //사용할 이미지
        }

        private void Close_Inven(object sender, KeyEventArgs e) // 인벤토리 닫기(키보드 I)
        {
            if (e.KeyCode == Keys.I)
            {
                this.Close();
            }
        }

        private void item_Click(object sender, EventArgs e)
        {
            //클릭된 버튼의 인덱스값을 위한 변수선언
            Button btn = sender as Button;
            btn_idx = buttons.IndexOf(btn);

            for (int i = 0; i < buttons.Count; i++)
            {
                if (i == btn_idx)
                {
                    btn_idx = i;
                    pictureBoxes[i].Visible = true;
                }
                else
                    pictureBoxes[i].Visible = false;
            }
        }
        private void Explain_Item(object sender, EventArgs e)
        {
            // 버튼의 인덱스가 있다면 설명창 띄우고, 선택된 버튼이 없다면 메세지박스 
            if (btn_idx < 0)
            {
                MessageBox.Show("아이템을 선택해주세요", "알림");
                return;
            }
            // 해당 버튼의 이름
            string send_name = buttons[btn_idx].Name;

            string item_name = item_list.Return_Name(send_name);
            string item_ex = item_list.Return_Ex(send_name);
            int item_number = item_list.Return_num(send_name);

            if (send_name == "Briefcase") //서류봉투 수정
            {
                dancedollhint dancedollhint = new dancedollhint();
                dancedollhint.Show();
                dancedollhint.Location = new Point(0, 0);
            }
            else
            {
                Explain explain = new Explain(item_name, item_ex, item_number);
                explain.ShowDialog();
            }

        }
        private void Clear_btn_idx(object sender, EventArgs e) // 인벤토리 폼 닫힐때 인덱스 초기화 및 체크이미지 초기화
        {
            btn_idx = -1;
            for (int i = 0; i < buttons.Count; i++)
            {
                pictureBoxes[i].Visible = false;
            }
        }

        private void inventory_FormClosing(object sender, FormClosingEventArgs e)
        {
            for (int i = 0; i < buttons.Count; i++)
            {
                btn_idx = -1;
                pictureBoxes[i].Visible = false;
            }
        }
    }
}
