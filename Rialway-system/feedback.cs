using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Rialway_system
{
    public partial class feedback : UserControl
    {
        SqlConnection connection = new SqlConnection("Data Source=MR_IBRAHEM;Initial Catalog=Our_Project;Integrated Security=True");
        string feedback_;

        public feedback()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            feedback_ = "Bad";
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            feedback_ = "Good";
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            feedback_ = "Very Good";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            feedback_ = "Excellent";
        }

        /// <summary>
        /// insert into table feedback
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            connection.Open();
            try
            {
             
                string order = "insert into Feedback values(@Review_syn,@Feedback,@date,@C_ID)";
                SqlCommand cmd = new SqlCommand(order, connection);
                SqlParameter review = cmd.Parameters.Add(new SqlParameter("@Review_syn", textBox1.Text));
                SqlParameter feedback = cmd.Parameters.Add(new SqlParameter("@Feedback", feedback_));
                SqlParameter date = cmd.Parameters.Add(new SqlParameter("@date", dateTimePicker1.Text));
                SqlParameter C_ID = cmd.Parameters.Add(new SqlParameter("@C_ID", t3.Text));
                cmd.ExecuteNonQuery();
                textBox1.Clear();
                t3.Clear();
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                radioButton3.Checked = false;
                radioButton4.Checked = false;
                dateTimePicker1.Text = "";
                MessageBox.Show("  thank you for your feedback ");
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Erorr 101 :", ex.Message));
                connection.Close();

            }



        }

     
        private void feedback_Load(object sender, EventArgs e)
        {

        }
    }
}
