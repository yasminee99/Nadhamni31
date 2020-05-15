using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetNadhamni
{
    public partial class Job : Form
    {
        public Job()
        {
            InitializeComponent();
        }
        int days;
        String starth, startm, endh, endm;
        String starttime,endtime;
        private void btnSaveJob_Click(object sender, EventArgs e)
        {
            starth = cmb_startTimeJobH.Text;
            startm = cmb_endTimeJobM.Text;
            starttime = starth + startm;
            endh = cmb_endTimeJobH.Text;
            endm = cmb_endTimeJobM.Text;
            endtime = endh + endm;


            SqlConnection con = new SqlConnection();
            if (txt_hierStatus.Text == "" || txt_specialtyJob.Text == "" || txt_establishmentJob.Text == "")
            {
                if (MondayJob.Checked == true || TuesdayJob.Checked == true || wednesdayJob.Checked == true || ThursdayJob.Checked == true || fridayJob.Checked == true || SaturdayJob.Checked == true || SundayJob.Checked == true) { 
                MessageBox.Show("Please fill all fields");
                return; }
            }
            else
            {
                try
                {

                    con.ConnectionString = @"Data Source=DESKTOP-69MM1NJ\SQLEXPRESS;Initial Catalog=NadhamniDB;Integrated Security=True;Pooling=False";
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into Job(HierarchicalStatus,Department,Establishment,DaysOfWork,StartTime,EndTime) values(@HierarchicalStatus,@Department,@Establishment,@DaysOfWork,@StartTime,@EndTime)", con);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@HierarchicalStatus", txt_hierStatus.Text);
                    cmd.Parameters.AddWithValue("@Department", txt_specialtyJob.Text);
                    cmd.Parameters.AddWithValue("@Establishment", txt_establishmentJob.Text);
                    cmd.Parameters.AddWithValue("@DaysOfWork", days);
                    cmd.Parameters.AddWithValue("@StartTime", starttime); 
                    cmd.Parameters.AddWithValue("@EndTime", endtime);

                    //Execute Command
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("success");

                    Dashboard d = new Dashboard();
                    d.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    if (con.State == ConnectionState.Open)
                        con.Close();
                }
           }
        
           
        }

        private void MondayJob_CheckedChanged(object sender, EventArgs e)
        {
            days++;
        }

        private void TuesdayJob_CheckedChanged(object sender, EventArgs e)
        {
            days++;
        }

        private void wednesdayJob_CheckedChanged(object sender, EventArgs e)
        {
            days++;
        }

        private void Job_Load(object sender, EventArgs e)
        {

        }

        private void ThursdayJob_CheckedChanged(object sender, EventArgs e)
        {
            days++;
        }

        private void fridayJob_CheckedChanged(object sender, EventArgs e)
        {
            days++;
        }

        private void SaturdayJob_CheckedChanged(object sender, EventArgs e)
        {
            days++;
        }

        private void SundayJob_CheckedChanged(object sender, EventArgs e)
        {
            days++;
        }
    }
}
