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
    public partial class update : UserControl
    {
        

        public update()
        {
            InitializeComponent();
            updatecastomer1.Visible = true;
            updateteckit1.Visible = false;
            cpic.Visible = true;
            tpic.Visible = false;
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            updatecastomer1.Visible = true;
            updatecastomer1.BringToFront();
            cpic.Visible = true;
            cpic.BringToFront();
            tpic.Visible = false;
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            updateteckit1.Visible = true;
            updateteckit1.BringToFront();
            tpic.Visible = true;
            tpic.BringToFront();
        }

        
    }
}
