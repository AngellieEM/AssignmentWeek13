using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AssignmentWeek13
{
    public partial class FormPlayer : Form
    {
        public FormPlayer()
        {
            InitializeComponent();
        }

        MySqlConnection sqlConnect = new MySqlConnection("server=localhost;uid=root;pwd=;database=premier_league");
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        String sqlQuery;
        DataTable dtPlayer = new DataTable();
        int Posisi = 0;

        private void FormPlayer_Load(object sender, EventArgs e)
        {

            sqlQuery = "SELECT p.player_id, p.player_name, p.birthdate, n.nation AS 'nationality', t.team_name AS 'team member', p.team_number FROM player p LEFT JOIN nationality n ON p.nationality_id = n.nationality_id LEFT JOIN team t ON p.team_id = t.team_id";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtPlayer);
            cbNationality.DataSource = dtPlayer;
            cbNationality.DisplayMember = "nationality";
            cbTeam.DataSource = dtPlayer;
            cbTeam.DisplayMember = "team member";
            IsiDataPlayer(0);
            dtpBirthDate.CustomFormat = "dddd, MMMM dd, yyyy";
            dtpBirthDate.Format = DateTimePickerFormat.Custom;
        }

        public void IsiDataPlayer(int PosisiSekarang)
        {
            //MessageBox.Show(Posisi.ToString());
            tbPlayerID.Text = dtPlayer.Rows[Posisi][0].ToString();
            tbPlayerName.Text = dtPlayer.Rows[Posisi][1].ToString();
            dtpBirthDate.Text = dtPlayer.Rows[Posisi][2].ToString();
            cbNationality.Text = dtPlayer.Rows[Posisi][3].ToString(); 
            cbTeam.Text = dtPlayer.Rows[Posisi][4].ToString();
            numudTeamNum.Text = dtPlayer.Rows[Posisi][5].ToString();

            Posisi = PosisiSekarang;
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            IsiDataPlayer(0);
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            IsiDataPlayer(dtPlayer.Rows.Count - 1);
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (Posisi > 0)
            {
                Posisi--;
                IsiDataPlayer(Posisi);
            }
            else
            {
                MessageBox.Show("Data sudah data yang pertama!");
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (Posisi < dtPlayer.Rows.Count - 1)
            {
                Posisi++;
                IsiDataPlayer(Posisi);
            }
            else
            {
                MessageBox.Show("Data sudah data yang terakhir!");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           if(lblNotOrAvailable.Text == "Not Available")
           {
                MessageBox.Show("Team number ada yang sama");
           }
           else
           {
               sqlConnect.Open();
               sqlQuery = "UPDATE player p, team t, nationality n SET p.player_name = '"+tbPlayerName.Text+"', p.birthdate = '"+ dtpBirthDate.Text +"', n.nation = '"+ cbNationality.Text +"', t.team_name = '"+ cbTeam.Text +"', p.team_number = '" + numudTeamNum.Text + "' WHERE p.player_id = '" + tbPlayerID.Text +"';";
               sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
               sqlAdapter = new MySqlDataAdapter(sqlCommand);
               sqlAdapter.Fill(dtPlayer);
               MessageBox.Show("Data tersimpan!");
               sqlConnect.Close();
           }
        }
            
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
