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
    public partial class Form5 : Form
    {
        inventory inventory; //초기화
        Item Item_list;
        public Form5()
        {
            InitializeComponent();
            
            item7.BackColor = Color.Transparent;

        }

        public Form5(inventory inventory) //매개변수를 갖는 생성자
        {
            InitializeComponent();
            this.inventory = inventory;
            Item_list = new Item();
        }

        private void lb6_Click(object sender, EventArgs e)
        {
            Form6 window6 = new Form6(inventory);
            window6.ShowDialog();
            DialogResult = DialogResult.OK;
        }
    }
}
