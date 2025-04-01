using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_gruop_project
{


    // 모든 아이템에 대한 정보를 기록
    internal class Item
    {
        public List<string> tem_list = new List<string>  //아이템들의 라벨,버튼,픽처박스의 이름
        {"ladder","Old_Key","Briefcase","Gold_Key","rope","screw","label5",
         "label2","깨진 거울","btn_knife","Under_Paper","지하실키",
         "hint1","hint2","hint3"};
        public string[] str_name = new string[]{          //아이템 이름(필요할때 추가)
            "사다리", "낡은 열쇠","서류봉투","황금 열쇠",
            "밧줄","나사","긴 막대","쪽지","깨진 거울조각","주방용 칼","서재로 가는 키","지하실 열쇠",
            "첫 번째 힌트","두 번째 힌트","세 번째 힌트" };
        public string[] str_ex = new string[] {          //아이템 설명(필요할때 추가)
                "높은곳의 물건을 사용하기위한 물건이다.", //0
                "아주옛날 무언가를 열기위한 용도로 사용한 열쇠인 것 같다.", //1
                "무언가를 형상화한 사람 그림들이 나열되어 있다.", //2
                "서랍장을 열 수 있는 열쇠처럼 보인다.", //3
                "세면대와 관련된 힌트를 얻을 수 있는 아이템\n(사진 10번 클릭시 획득 가능)", //4
                "욕조와 관련된 힌트를 얻을 수 있는 아이템\n(사진을 눌러 점수를 5점 이상 획득해야됨)", //5
                "긴 막대로 시체3을 끌어내려서 시체 몸에 적혀있는 번호를 알 수 있음", //6
                "서랍을 열수있는 힌트가 적혀있다.\n싫어 싫어 싫어: 3 \n주인공을 사랑하는 사람 수:\n냉장고 위 단서가 생기는 클릭수:\n시체 적혀있는 숫자:", //7
                "바닥에 떨어져 있던 깨진 거을의 날카로운 조각\n가지고 있으면 쓸 곳이 생기지 않을까?", //8
                "오래된 냉장고 서랍에 있던 주방용 칼", //9 
                "서재로 가는 키", //10 
                "지하실 문을 열 수 있는 열쇠", //11
                 "범인의 이름에는 2가 들어간다.", //12
                  "범인의 이름에는 Water가 들어간다.", //13
                  "범인의 이름은 '유'로 시작한다." //14
            };

        public Item() // 생성자
        {

        }
        //아이템 이름을 리턴
        public string Return_Name(string name)
        {
            int idx = tem_list.IndexOf(name);
            if (idx != -1)
                return str_name[idx];
            else
                return "아이템 정보 없음";
        }
        //아이템 설명을 리턴  
        public string Return_Ex(string name)
        {
            int idx = tem_list.IndexOf(name);
            if (idx != -1)
                return str_ex[idx];
            else
                return "아이템 정보 없음";
        }
        //이미지도 띄울지?
        public int Return_num(string name)
        {
            int idx = tem_list.IndexOf(name);
            return idx;
        }
    }
}
