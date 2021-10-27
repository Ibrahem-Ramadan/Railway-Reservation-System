using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rialway_system
{
    public partial class insert : UserControl
    {
        public insert()
        {
            InitializeComponent();
            insertcustomer1.Visible = true;
            insertticket1.Visible = false;
            pic1.Visible = true;
            pic2.Visible = false;
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            insertcustomer1.Visible = true;
            insertcustomer1.BringToFront();
            pic1.Visible = true;
            pic2.Visible = false;
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            insertticket1.Visible = true;
            insertticket1.BringToFront();
            pic1.Visible = false;
            pic2.Visible = true;
        }

        private void insertcustomer1_Load(object sender, EventArgs e)
        {

        }
    }
}
