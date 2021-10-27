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
    public partial class delete : UserControl
    {
        int count = 0;

        SqlConnection connection = new SqlConnection("Data Source=MR_IBRAHEM;Initial Catalog=Our_Project;Integrated Security=True");
        public delete()
        {
            InitializeComponent();
        }

        private void deletebott_Click(object sender, EventArgs e)
        {
            SqlCommand command_delete;
            try
            {
                connection.Open();
                 command_delete = new SqlCommand("D", connection);
                command_delete.Parameters.Add(new SqlParameter("@ID", textBox.Text));
                command_delete.CommandType = CommandType.StoredProcedure;
                command_delete.ExecuteNonQuery();
                MessageBox.Show("Customer was Deleted sucessfully");
                textBox.Clear();

            }
            catch (Exception exep)
            {
                count++;
                textBox.Clear();
                if (count==1|| count ==2)
                MessageBox.Show(string.Format("An error occurred while deleting try again:", exep.Message));
                else
                    MessageBox.Show(string.Format(" da anta 7omar b2a :", exep.Message));


            }

        }
    }
}
