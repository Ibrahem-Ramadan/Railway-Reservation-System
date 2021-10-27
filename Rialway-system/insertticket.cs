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
    public partial class insertticket : UserControl
    {
        SqlConnection connection = new SqlConnection("Data Source=MR_IBRAHEM;Initial Catalog=Our_Project;Integrated Security=True");
                    
        public insertticket()
        {
            InitializeComponent();
        }

        private void addbutton_Click(object sender, EventArgs e)
        {
            connection.Open();
            string insert_ticket = @"insert into Ticket 
                                    values(@Reservation_Date,@Trip_Date,@From_Destination,@To_Destination,@Arrival_Time,
                                    @leave_Time,@Trip_Duration,@Seat_Number,@Trip_cost,@TrainID,@Emp_ID)";

            SqlCommand command_insert = new SqlCommand(insert_ticket, connection);
            SqlParameter RT = new SqlParameter("@Reservation_Date", dateTimePicker1.Text);
            command_insert.Parameters.Add(RT);
            SqlParameter TD = new SqlParameter("@Trip_Date", dateTimePicker2.Text);
            command_insert.Parameters.Add(TD);
            SqlParameter FD = new SqlParameter("@From_Destination", t3.Text);
            command_insert.Parameters.Add(FD);
            SqlParameter TDes = new SqlParameter("@To_Destination", t4.Text);
            command_insert.Parameters.Add(TDes);
            SqlParameter AT = new SqlParameter("@Arrival_Time", dateTimePicker3.Text);
            command_insert.Parameters.Add(AT);
            SqlParameter LT = new SqlParameter("@leave_Time", dateTimePicker4.Text);
            command_insert.Parameters.Add(LT);
            SqlParameter TDU = new SqlParameter("@Trip_Duration", t7.Text);
            command_insert.Parameters.Add(TDU);
            SqlParameter SN = new SqlParameter("@Seat_Number", t8.Text);
            command_insert.Parameters.Add(SN);
            SqlParameter TC = new SqlParameter("@Trip_cost", t9.Text);
            command_insert.Parameters.Add(TC);
            SqlParameter TI = new SqlParameter("@TrainID", comboBox1.Text);
            command_insert.Parameters.Add(TI);
            SqlParameter EI = new SqlParameter("@Emp_ID", EMPID.Text);
            command_insert.Parameters.Add(EI);


            command_insert.ExecuteNonQuery();

            //clear
           // dateTimePicker1.Text = " ";
            dateTimePicker2.Text = "";
            dateTimePicker3.Text = "";
            dateTimePicker4.Text = "";
            comboBox1.Text = "";
            t3.Clear();
            t4.Clear();
            t7.Clear();
            t8.Clear();
            t9.Clear();
            EMPID.Clear();
            connection.Close();

            MessageBox.Show("data was inserted sucessfully ");
            
        }
        //to show data " train ID " in combobox 
        private void comboBox1_Click(object sender, EventArgs e)
        {
            connection.Open();
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("select ID from Train", connection);
            adapter.Fill(table);
            comboBox1.DataSource = table;
            comboBox1.DisplayMember = "ID";
            connection.Close();
        }
    }
}
