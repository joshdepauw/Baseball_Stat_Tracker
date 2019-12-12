//Josh DePauw
//Baseball Stat Keeper
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using System.Data.Entity.Validation;

namespace Baseball_Stats_Keeper
{
    public partial class Update_Player_Page : Form
    {
        //create object
        // Baseball_Stats_Keeper.practiceDatabaseEntities dbcontext = new Baseball_Stats_Keeper.practiceDatabaseEntities();

        //variables
        int atBats;
        int hits;
        int strikeOuts;
        int walks;
        int singles;
        int doubles;
        int triples;
        int homeruns;
        int rbi;
        int runs;



        public Update_Player_Page()
        {
            InitializeComponent();
        }
        private Baseball_Stats_Keeper.practiceDatabaseEntities dbcontext = null;
        private void RefreshStats()
        {
            //dispose of old dbcontext
            if (dbcontext != null)
            {
                dbcontext.Dispose();
            }
            //create a new dbcontext so we can reorder records based on edits
            dbcontext = new Baseball_Stats_Keeper.practiceDatabaseEntities();

            //order by 
            dbcontext.Players
                .OrderBy(player => player.PlayerID)
                .ThenBy(players => players.LastName)
                .ThenBy(players => players.FirstName)
                .Load();
            //specift datasource
            playerBindingSource.DataSource = dbcontext.Players.Local;
            playerBindingSource.MoveFirst();
        }

        private void btnUpdateSearch_Click(object sender, EventArgs e)
        {

            var input = Int32.Parse(txt_Search_PlayerID.Text.ToString());
            //a query to search the player table by PlayerID
            var PlayerIDQuery =
                from player in dbcontext.Players
                where player.PlayerID == input
                orderby player.LastName, player.FirstName
                select player;            

            //display the results
            playerBindingSource.DataSource = PlayerIDQuery.ToList();
            playerBindingSource.MoveFirst(); // goes to the first result

            //enable textboxes to update stats for selected player
            txtUpdateAtBats.Enabled = true;
            txtUpdateDoubles.Enabled = true;
            txtUpdateHits.Enabled = true;
            txtUpdateHR.Enabled = true;
            txtUpdateRBI.Enabled = true;
            txtUpdateRuns.Enabled = true;
            txtUpdateSingles.Enabled = true;
            txtUpdateStrikeouts.Enabled = true;
            txtUpdateTriples.Enabled = true;
            txtUpdateWalks.Enabled = true;

        }
        private void btnUpdateCancel_Click(object sender, EventArgs e)
        {
            //closes the Update Stats page
            this.Close();
        }

        private void btnUpdateUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                atBats = Convert.ToInt32(txtUpdateAtBats.Text);
                hits = Convert.ToInt32(txtUpdateHits.Text);
                strikeOuts = Convert.ToInt32(txtUpdateStrikeouts.Text);
                walks = Convert.ToInt32(txtUpdateWalks.Text);
                singles = Convert.ToInt32(txtUpdateSingles.Text);
                doubles = Convert.ToInt32(txtUpdateDoubles.Text);
                triples = Convert.ToInt32(txtUpdateTriples.Text);
                homeruns = Convert.ToInt32(txtUpdateHR.Text);
                rbi = Convert.ToInt32(txtUpdateRBI.Text);
                runs = Convert.ToInt32(txtUpdateRuns.Text);

            }
            catch (Exception ex)
            {
                if (ex is DbEntityValidationException || ex is FormatException)
                {
                    MessageBox.Show("All fields need to be filled out using numbers");
                }
            }
            var playID = Int32.Parse(txt_Search_PlayerID.Text.ToString());
            //query the database for the row to be updated
            var updateStats =
                from stat in dbcontext.Stats
                where stat.PlayerID ==playID
                select stat;

            //execute the query and change values
            foreach (Stat stat in updateStats)

            {
                stat.Hits += hits;
                stat.AtBats += atBats;
                stat.StrikeOuts += strikeOuts;
                stat.Walks += walks;
                stat.Singles += singles;
                stat.Doubles += doubles;
                stat.Triples += triples;
                stat.Homeruns += homeruns;
                stat.RBI += rbi;
                stat.Runs += runs;
            };
            //submit changes to database
            try
            {
                dbcontext.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Stats were not successfully updated");
            }
            MessageBox.Show("Stats were updated!");
            btn_view_stats.Visible = true;
        }

        private void Update_Player_Page_Load(object sender, EventArgs e)
        {
            RefreshStats();
        }

        private void btn_view_stats_Click(object sender, EventArgs e)
        {
            Players_View_Page playersView = new Players_View_Page();
            playersView.Show();
        }
    }
}
