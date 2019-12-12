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
using System.Data.SqlClient;
using System.Data.Entity;
using System.Collections.ObjectModel;

namespace Baseball_Stats_Keeper
{
    public partial class MainPage : Form
    {
        
        public MainPage()
        {
            InitializeComponent();
        }

       
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //closes the program
            Application.Exit();
        }

        private void aboutTheAppToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //about the app
            MessageBox.Show("Created by Josh DePauw", "Baseball Stat Keeper");
        }

        private void addPlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //when user click Players - View Players
            //View Players
            Players_View_Page playersView = new Players_View_Page();
            playersView.Show();
        }

        private void addPlayerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //when the user click Players-Update-Add Player
            //add Player
            Add_Player_Page addPlayer = new Add_Player_Page();
            addPlayer.Show();
        }

        private void updateStatsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //when the user clicks Players-Update-Update Players
            //updates stats in the database
            Update_Player_Page updatePlayer = new Update_Player_Page();
            updatePlayer.Show();
        }

       
    }
}
