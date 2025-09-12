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

namespace _14_SQLAllRelationsProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection("server=TUNA\\SQLEXPRESS;initial catalog=SQLAllRelations;integrated security=true");
        private void Form1_Load(object sender, EventArgs e)
        {
            connection.Open();

            SqlCommand sponsorList = new SqlCommand("Select * From Sponsors", connection);
            SqlCommand playerList = new SqlCommand("select p.PlayerId, p.PlayerName, t.TeamName From Players p INNER JOIN Teams t ON p.TeamId=t.TeamId", connection);
            SqlCommand teamSponsorList = new SqlCommand("SELECT t.TeamName, s.SponsorName FROM TeamSponsor ts INNER JOIN Teams t ON ts.TeamId = t.TeamId INNER JOIN Sponsors s ON ts.SponsorId = s.SponsorId;", connection);
            SqlCommand teamDetailList = new SqlCommand("select TeamDetails.TeamDetailId, TeamDetails.TeamCity, TeamDetails.TeamColor, TeamDetails.TeamValue,Teams.TeamName From TeamDetails Inner Join Teams on TeamDetails.TeamId=teams.teamId", connection);
            SqlCommand teamList = new SqlCommand("Select * From Teams", connection);


            SqlDataAdapter adapter = new SqlDataAdapter(sponsorList);
            SqlDataAdapter adapter2 = new SqlDataAdapter(playerList);
            SqlDataAdapter adapter4 = new SqlDataAdapter(teamSponsorList);
            SqlDataAdapter adapter3 = new SqlDataAdapter(teamDetailList);
            SqlDataAdapter adapter5 = new SqlDataAdapter(teamList);

            DataTable dt = new DataTable();
            DataTable dt2 = new DataTable();
            DataTable dt4 = new DataTable();
            DataTable dt3 = new DataTable();
            DataTable dt5 = new DataTable();

            adapter.Fill(dt);
            adapter2.Fill(dt2);
            adapter3.Fill(dt4);
            adapter4.Fill(dt3);
            adapter5.Fill(dt5);

            dataGridView1.DataSource = dt;
            dataGridView2.DataSource = dt2;
            dataGridView3.DataSource = dt4;
            dataGridView4.DataSource = dt3;
            dataGridView5.DataSource = dt5;
        }
    }
}
