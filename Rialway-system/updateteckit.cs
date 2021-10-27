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
    public partial class updateteckit : UserControl
    {
        public updateteckit()
        {
            InitializeComponent();
        }

        private void addbutton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=MR_IBRAHEM;Initial Catalog=Our_Project;Integrated Security=True");
            int count = 0;
            try
            {

                con.Open();

                string UpdateSting = @"update Ticket set Reservation_Date = @resrvationDate ,
                                     Trip_Date = @tripDate , From_Destination = @fromDestination ,
                                     To_Destination = @toDestination , Arrival_Time = @arrivalTime , leave_Time = @leaveTime , 
                                     Trip_Duration = @tripDuration ,Seat_Number=@seatNum ,Trip_cost=@tripCost  where ID =@id_ticket ";

                SqlCommand cmd = new SqlCommand(UpdateSting, con);

                SqlParameter paramidTicket = new SqlParameter("@id_ticket", TicketID.Text);
                cmd.Parameters.Add(paramidTicket);

                SqlParameter paramres_date = new SqlParameter("@resrvationDate",dateTimePicker1.Text);
                cmd.Parameters.Add(paramres_date);

                SqlParameter paramtripdate = new SqlParameter("@tripDate", dateTimePicker2.Text);
                cmd.Parameters.Add(paramtripdate);

                SqlParameter paramfromdes = new SqlParameter("@fromDestination", t3.Text);
                cmd.Parameters.Add(paramfromdes);

                SqlParameter paramTodes = new SqlParameter("@toDestination", t4.Text);
                cmd.Parameters.Add(paramTodes);

                SqlParameter paramarrivaltime = new SqlParameter("@arrivalTime", dateTimePicker3.Text);
                cmd.Parameters.Add(paramarrivaltime);

                SqlParameter paramleavetime = new SqlParameter("@leaveTime", dateTimePicker4.Text);
                cmd.Parameters.Add(paramleavetime);

                SqlParameter paramtripdur = new SqlParameter("@tripDuration", t7.Text);
                cmd.Parameters.Add(paramtripdur);

                SqlParameter paramseatnum = new SqlParameter("@seatNum", t8.Text);
                cmd.Parameters.Add(paramseatnum);

                SqlParameter paramtripcost = new SqlParameter("@tripCost", t9.Text);
                cmd.Parameters.Add(paramtripcost);

                
                cmd.ExecuteNonQuery();
                //con.Close();
                MessageBox.Show("Updated");
                dateTimePicker1.Text = "";
                dateTimePicker2.Text = "";
                t3.Clear();
                t4.Clear();
                dateTimePicker3.Text = "";
                dateTimePicker4.Text = "";
                t7.Clear();
                t8.Clear();
                t9.Clear();
                TicketID.Clear();
                con.Close();
            }
            catch (Exception exep)
            {


                count++;
                //t1.Clear();
                //t2.Clear();
                //t3.Clear();
                //t4.Clear();
                //t5.Clear();
                //t6.Clear();
                //t7.Clear();
                //t8.Clear();
                //t9.Clear();
                //TicketID.Clear();
                if (count == 1 || count == 2)
                    MessageBox.Show(string.Format("An error occurred while Updating try again:", exep.Message));
                else
                    MessageBox.Show(string.Format(" da anta 7omar b2a :", exep.Message));

            }
        }
    }
}
