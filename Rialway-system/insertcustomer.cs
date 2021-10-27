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
    public partial class insertcustomer : UserControl
    {
        string ID;
        public insertcustomer()
        {
            InitializeComponent();
        }

        private void addbutton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=MR_IBRAHEM;Initial Catalog=Our_Project;Integrated Security=True");
            con.Open();
            string InsertData = @"insert into Customer values(@First,@Last,@Phone,@Email,@Address,@Emp_ID)";
            SqlCommand cmd = new SqlCommand(InsertData, con);
            SqlParameter First = new SqlParameter("@First", t1.Text);
            cmd.Parameters.Add(First);
            SqlParameter Last = new SqlParameter("@Last", t2.Text);
            cmd.Parameters.Add(Last);
            SqlParameter Phone = new SqlParameter("@Phone", t3.Text);
            cmd.Parameters.Add(Phone);
            SqlParameter Email = new SqlParameter("@Email", t4.Text);
            cmd.Parameters.Add(Email);
            SqlParameter address = new SqlParameter("@Address", t5.Text);
            cmd.Parameters.Add(address);
            //SqlParameter Uname = new SqlParameter("@Uname", t6.Text);
            //cmd.Parameters.Add(Uname);
            //SqlParameter Pass = new SqlParameter("@Pass", t7.Text);
            //cmd.Parameters.Add(Pass);
            if (t5.Text == null)
            {
                Email = null;
                cmd.Parameters.Add(Email);
            }

            SqlParameter Emp_ID = new SqlParameter("@Emp_ID", t8.Text);
            cmd.Parameters.Add(Emp_ID);
            cmd.ExecuteNonQuery();

            t1.Clear();
            t2.Clear();
            t3.Clear();
            t4.Clear();
            t5.Clear();
            //t6.Clear();
            //t7.Clear();
            t8.Clear();
            
            SqlCommand com = new SqlCommand("SELECT TOP 1 ID FROM Customer ORDER BY ID DESC", con);
            SqlDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                 
              ID= reader[0].ToString();

            }
             MessageBox.Show("Data Of Customer Has Been Submited successfully \n \t the Customer ID is    "+ ID);
          

        }
    }
    }

