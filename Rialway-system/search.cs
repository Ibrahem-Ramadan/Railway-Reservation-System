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
    public partial class search : UserControl
    {
        public search()
        {
            InitializeComponent();
        }

        private void search_Load(object sender, EventArgs e)
        { 
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {

            //This Button For Search in the Customer
            SqlConnection con = new SqlConnection("Data Source=MR_IBRAHEM;Initial Catalog=Our_Project;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("lastone", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@id", textBox1.Text));
            cmd.Parameters.Add(new SqlParameter("@first_name", textBox2.Text));

            SqlDataReader Readerr = cmd.ExecuteReader();
            DataTable Customer_Table = new DataTable();
            Customer_Table.Columns.Add("ID");
            Customer_Table.Columns.Add("First Name");
            Customer_Table.Columns.Add("Last Name");
            Customer_Table.Columns.Add("Phone");
            Customer_Table.Columns.Add("Email");
            Customer_Table.Columns.Add("Addres");
            Customer_Table.Columns.Add("Emp ID");
            Customer_Table.Columns.Add("Ticket ID");
            Customer_Table.Columns.Add("Reservation Date");
            Customer_Table.Columns.Add("Trip Date");
            Customer_Table.Columns.Add("From Destination");
            Customer_Table.Columns.Add("To Destination");
            Customer_Table.Columns.Add("Arrival Time");
            Customer_Table.Columns.Add("Leave Time");
            Customer_Table.Columns.Add("Trip Duration");
            Customer_Table.Columns.Add("Seat Number");
            Customer_Table.Columns.Add("Cost");
            Customer_Table.Columns.Add("Train ID");

            DataRow Row;

            Readerr.Read();
            
                Row = Customer_Table.NewRow();
                Row["ID"] = Readerr["ID"];
                Row["First Name"] = Readerr["FirstName"];
                Row["Last Name"] = Readerr["LastName"];
                Row["Phone"] = Readerr["phone"];
                Row["Email"] = Readerr["Email"];
                Row["Addres"] = Readerr["addres"];
                Row["Emp ID"] = Readerr["Emp_ID"];
                Row["Ticket ID"] = Readerr["ID"];
                Row["Reservation Date"] = Readerr["Reservation_Date"];
                Row["Trip Date"] = Readerr["Trip_Date"];
                Row["From Destination"] = Readerr["From_Destination"];
                Row["To Destination"] = Readerr["To_Destination"];
                Row["Arrival Time"] = Readerr["Arrival_Time"];
                Row["Leave Time"] = Readerr["leave_Time"];
                Row["Trip Duration"] = Readerr["Trip_Duration"];
                Row["Seat Number"] = Readerr["Seat_Number"];
                Row["Cost"] = Readerr["Trip_cost"];
                Row["Train ID"] = Readerr["Train_ID"];
                Customer_Table.Rows.Add(Row);
                
            
            dataGridView1.DataSource = Customer_Table;
            dataGridView1.ClearSelection();
            con.Close();

        }

        private void textBox2_Click(object sender, EventArgs e)
        {
        }

        private void searchbott_Click(object sender, EventArgs e)
        {
            //This Button For Search in the Train
            SqlConnection con = new SqlConnection("Data Source=MR_IBRAHEM;Initial Catalog=Our_Project;Integrated Security=True");

            con.Open();

            SqlCommand cmd = new SqlCommand("Search_Train", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@Dest", textBox.Text));

            SqlDataReader Reader = cmd.ExecuteReader();
            DataTable Train_Table = new DataTable();
            Train_Table.Columns.Add("Train ID");
            Train_Table.Columns.Add("Train Details");
            Train_Table.Columns.Add("Train Stauts");
            Train_Table.Columns.Add("Total Seates");
            Train_Table.Columns.Add("Available Seates");
            Train_Table.Columns.Add("Train Station");
            DataRow Row;
            while (Reader.Read())
            {
                Row = Train_Table.NewRow();
                Row["Train ID"] = Reader["ID"];
                Row["Train Details"] = Reader["T_Details"];
                Row["Train Stauts"] = Reader["T_Status"];
                Row["Total Seates"] = Reader["Total_Seats"];
                Row["Available Seates"] = Reader["Available_Seats"];
                Row["Train Station"] = Reader["Train_station"];
                Train_Table.Rows.Add(Row);
            }
            con.Close();
            Reader.Close();
            dataGridView1.DataSource = Train_Table;


        }
    }
    }








