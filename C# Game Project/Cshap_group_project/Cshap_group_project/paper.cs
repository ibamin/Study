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
    public partial class paper : Form
    {
        public paper(string message)
        {
            InitializeComponent();
            label1.Text = message;
        }
    }
}
