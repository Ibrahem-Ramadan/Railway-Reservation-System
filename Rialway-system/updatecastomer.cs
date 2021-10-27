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
    public partial class updatecastomer : UserControl
    {
        public updatecastomer()
        {
            InitializeComponent();
        }

        private void addbutton_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection("Data Source=MR_IBRAHEM;Initial Catalog=Our_Project;Integrated Security=True");
            con.Open();
            string UpdateSting = @"update Customer set FirstName = @firstname , LastName = @lastname , Email = @email , phone = @phone , addres = @address  where ID =@id_customer ";

            SqlCommand cmd = new SqlCommand(UpdateSting, con);

            SqlParameter paramfirstname = new SqlParameter("@firstname", t1.Text);
            cmd.Parameters.Add(paramfirstname);

            SqlParameter paramlastname = new SqlParameter("@lastname", t2.Text);
            cmd.Parameters.Add(paramlastname);
            SqlParameter paramphone = new SqlParameter("@phone", t3.Text);
            cmd.Parameters.Add(paramphone);

            SqlParameter paramemail = new SqlParameter("@email", t4.Text);
            cmd.Parameters.Add(paramemail);

         

            SqlParameter paramaddress = new SqlParameter("@address", t5.Text);
            cmd.Parameters.Add(paramaddress);



            SqlParameter paramid = new SqlParameter("@id_customer", t8.Text);
            cmd.Parameters.Add(paramid);

            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Updated");
            t1.Clear();
            t2.Clear();
            t3.Clear();
            t4.Clear();
            t5.Clear();
            t8.Clear();




        }
    }
    }

