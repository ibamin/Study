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
    public partial class Inspace : Form
    {
        inventory inven;
        public Inspace(inventory inven)
        {
            InitializeComponent();
            this.inven = inven;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Finalspace finalspace = new Finalspace(inven);
            finalspace.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
