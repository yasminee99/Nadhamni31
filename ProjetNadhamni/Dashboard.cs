using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetNadhamni
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }
        Profile pf = new Profile();

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Dashboard_Shown(object sender, EventArgs e)
        {
            
            ViewTasks.Rows.Add(
               new object[]
               {
                   1,
                   "sport",
                   "Zumba",
                   12,
                   13,
                   "California Gym",
                   "Wife",
                   "2 days",
                   "Normal"
               }
                ) ;
            ViewTasks.Rows.Add(
               new object[]
               {
                   2,
                   "family",
                   "take yasmine to the dentist",
                   15,
                   16,
                   "Doctor khouja",
                   "Wife,Yasmine",
                   "1 day",
                   "urgent"
               }
                );
            ViewTasks.Rows.Add(
              new object[]
              {
                   3,
                   "school",
                   "get kids from school",
                   16,
                   "16:30",
                   "isg",
                   "kids",
                   "30 min",
                   "urgent"
              }
               );
            
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_dashboard_Click(object sender, EventArgs e)
        {
            PnlPassage.Top = btn_dashboard.Top;
            PnlPassage.Height = btn_dashboard.Height;
            
            
        }

       

        private void btn_tasks_Click(object sender, EventArgs e)
        {
            PnlPassage.Top = btn_taskDash.Top;
            PnlPassage.Height = btn_taskDash.Height;
            pnlDashboard.Visible = false;
            this.Hide();
            Tasks tsk = new Tasks();
            tsk.Show();

        }

        private void btn_statistics_Click(object sender, EventArgs e)
        {
            PnlPassage.Top = btn_statDash.Top;
            PnlPassage.Height = btn_statDash.Height;
            this.Hide();
            Statistics stc = new Statistics();
            stc.Show();
        }

        private void btn_parameters_Click(object sender, EventArgs e)
        {
            PnlPassage.Top = btn_settingsDash.Top;
            PnlPassage.Height = btn_settingsDash.Height;
        }

        private void btn_profile_Click_1(object sender, EventArgs e)
        {
            PnlPassage.Top = btn_profileDash.Top;
            PnlPassage.Height = btn_profileDash.Height;
            Profile pf = new Profile();
            this.Hide();
            pf.Show();
        }

        private void btn_settings_Click(object sender, EventArgs e)
        {
            PnlPassage.Top = btn_settingsDash.Top;
            PnlPassage.Height = btn_settingsDash.Height;
            this.Hide();
            Settings set = new Settings();
            set.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ExitDashboard_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pnlDashboard_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_edit_Click(object sender, EventArgs e)
        {

        }
    }
}
