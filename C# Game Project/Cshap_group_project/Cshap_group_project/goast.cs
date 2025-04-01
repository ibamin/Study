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
    public partial class goast : Form
    {
        int cnt = 0;
        public goast()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (cnt == 3)
            {
                timer1.Stop();
                Close();
            }
            cnt++;
        }
    }
}
