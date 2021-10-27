using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rialway_system
{
    public partial class main : Form
    {
        public main()
        {
            Thread t = new Thread(new ThreadStart(startform));
            t.Start();
            Thread.Sleep(5000);
            InitializeComponent();
            t.Abort();
          picstart.Visible = true;
            picstart.BringToFront();
            IPIC.Visible = false;
            dpic.Visible = false;
            upic.Visible = false;
            spic.Visible = false;
            fpic.Visible = false;
            pictureBox2.Visible = false;
        }
        public void startform ()
        {
            Application.Run(new loading());
        }

       

        private void deletebott_Click(object sender, EventArgs e)
        {
            delete1.Visible = true;
            delete1.BringToFront();
            dpic.Visible = true;
            dpic.BringToFront();
            upic.Visible = false;
            spic.Visible = false;
            IPIC.Visible = false;
            picstart.Visible = false;
            fpic.Visible = false;
            pictureBox2.Visible = true;



        }

        private void updatebott_Click(object sender, EventArgs e)
        {
            update1.Visible = true;
            update1.BringToFront();
            dpic.Visible = false;
            upic.Visible = true;
            upic.BringToFront();
            spic.Visible = false;
            IPIC.Visible = false;
           picstart.Visible = false;
            fpic.Visible = false;
            pictureBox2.Visible = false;
        }

        private void searchbott_Click(object sender, EventArgs e)
        {
            search1.Visible = true;
            search1.BringToFront();
            dpic.Visible = false;
            upic.Visible = false;
            IPIC.Visible = false;
            spic.Visible = true;
            spic.BringToFront();
            picstart.Visible = false;
            fpic.Visible = false;
            pictureBox2.Visible = false;

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void main_Load(object sender, EventArgs e)
        {
            update1.Visible = false;
            delete1.Visible = false;
            search1.Visible = false;
            insert1.Visible = false;
            feedback1.Visible = false;

            
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            insert1.Visible = true;
            insert1.BringToFront();
            IPIC.Visible = true;
            IPIC.BringToFront();
            dpic.Visible = false;
            upic.Visible = false;
            spic.Visible = false;
            picstart.Visible = false;
            fpic.Visible = false;
            pictureBox2.Visible = false;
        }
        private void feedback_Click(object sender, EventArgs e)
        {
            feedback1.Visible = true;
            feedback1.BringToFront();
            fpic.Visible = true;
            fpic.BringToFront();
            dpic.Visible = false;
            IPIC.Visible = false;
            upic.Visible = false;
            spic.Visible = false;
            picstart.Visible = false;
            pictureBox2.Visible = false;

        }
        Bunifu.Framework.UI.Drag dr = new Bunifu.Framework.UI.Drag();  // fore move app 

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            dr.Grab(this);
        }

        private void panel3_MouseUp(object sender, MouseEventArgs e)
        {
            dr.Release();
        }

        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
            dr.MoveObject();
        }

       
    }
}
