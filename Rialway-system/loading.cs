using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rialway_system
{
    public partial class loading : Form
    {
        public loading()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar2.Increment(1);
            if (progressBar2.Value == 100)
                timer1.Stop();
        }
    }
}
