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

namespace Baseball_Stats_Keeper
{
    public partial class Players_View_Page : Form
    {
        public Players_View_Page()
        {
            InitializeComponent();
        }
        //entity framework dbcontext
        private Baseball_Stats_Keeper.practiceDatabaseEntities dbcontext = null;

        //fill playersbinding source will all rows by name
        private void RefreshPlayers()
        {
            //dispose of old dbcontext
            if (dbcontext != null)
            {
                dbcontext.Dispose();
            }
            //create a new dbcontext so we can reorder records based on edits
            dbcontext = new Baseball_Stats_Keeper.practiceDatabaseEntities();

            //order the players table by last name then first name
            dbcontext.Players
                .OrderBy(players => players.LastName)
                .ThenBy(players => players.FirstName)
                .Load();
            //specify datasource
            playerBindingSource.DataSource = dbcontext.Players.Local;
            playerBindingSource.MoveFirst();
        }
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
            dbcontext.Stats
                .OrderBy(stats => stats.PlayerID)
                .Load();
            //specift datasource
            statBindingSource.DataSource = dbcontext.Stats.Local;
            statBindingSource.MoveFirst();
        }
        private void Players_View_Page_Load(object sender, EventArgs e)
        {
            //loads data into datagrid
            RefreshPlayers();
            RefreshStats();
        }
        private void btnSearchName_Click(object sender, EventArgs e)
        {
            //a query to search the player table by last name
            var lastNameQuery =
                from player in dbcontext.Players
                where player.LastName.StartsWith(txtSearchName.Text)
                orderby player.LastName, player.FirstName
                select player;

            //display the results
            playerBindingSource.DataSource = lastNameQuery.ToList();
            playerBindingSource.MoveFirst(); // goes to the first result
        }

        private void comboBoxFilterBy_SelectedItemChanged(object sender, EventArgs e)
        {
            ComboBox comboBoxFilterBy = (ComboBox)sender;
            var selectedStat = comboBoxFilterBy.SelectedItem;
            
            if (selectedStat == null) return;
            //a query to search stats based on what is filtered from combobox
            var statQuery =

                (from stat in dbcontext.Stats
                 select new
                 {
                     atBats = stat.AtBats,
                     doubles = stat.Doubles,
                     hits = stat.Hits,
                     homeruns = stat.Homeruns,
                     walks = stat.Walks,
                     singles = stat.Singles,
                     strikeOuts = stat.StrikeOuts,
                     triples = stat.Triples
                 }).ToList();
            comboBoxFilterBy.DataSource = statQuery;
            comboBoxFilterBy.SelectedItem = statQuery[0];
        }

        private void BtnViewClose_Click(object sender, EventArgs e)
        {
            //closes View Players page
            this.Close();
        }
    }

}
