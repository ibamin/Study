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

namespace Pr0731
{
    public partial class Form7 : Form
    {
        inventory inventory; //초기화
        Item Item_list;
        public Form7()
        {
            InitializeComponent();       
            item8.BackColor = Color.Transparent;

            //orm12 form12 = new Form12();

        }

        public Form7(inventory inventory) //매개변수를 갖는 생성자
        {
            InitializeComponent();
            this.inventory = inventory;
            Item_list = new Item();
        }

        private void item8_Click(object sender, EventArgs e)
        {
            Form8 window8 = new Form8(inventory);
            window8.ShowDialog();

        }
    }
}
