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
using System.Data.Entity.Validation;

namespace Baseball_Stats_Keeper
{
    public partial class Add_Player_Page : Form
    {
        //create object
        Baseball_Stats_Keeper.practiceDatabaseEntities dbcontext = new Baseball_Stats_Keeper.practiceDatabaseEntities();

        string fname;
        string lname;
        int grade;
        string team;
        public Add_Player_Page()
        {
            InitializeComponent();
        }
        private void btnAddSave_Click(object sender, EventArgs e)
        {
            try
            {
                fname = txtAddFirst.Text;
                lname = txtAddLast.Text;
                grade = Convert.ToInt32(txtAddAge.Text);
                team = txtAddTeam.Text;

                if (grade < 1 || grade > 12)
                {
                    MessageBox.Show("Grade must be between 1 and 12");
                }
                else
                {
                    Player p = new Player
                    {
                        FirstName = fname,
                        LastName = lname,
                        Grade = grade,
                        Team = team
                    };
                    dbcontext.Players.Add(p); //adds to database
                    dbcontext.SaveChanges(); //saves changes
                                            
                    MessageBox.Show("Player was successfully added to the database");
                    //clear the textboxes
                    txtAddAge.Clear();
                    txtAddFirst.Clear();
                    txtAddLast.Clear();
                    txtAddTeam.Clear();

                    btn_Add_View.Visible = true;
                }
            }
            catch (Exception ex)
            {
                if (ex is DbEntityValidationException || ex is FormatException)
                {
                    MessageBox.Show("All fields need to be filled out and grade must be a number");
                }
            }
        }

        private void btnAddCancel_Click(object sender, EventArgs e)
        {
            //closes the Add Player window
            this.Close();
        }

        private void btn_Add_View_Click(object sender, EventArgs e)
        {
            Players_View_Page playersView = new Players_View_Page();
            playersView.Show();
            
        }
    }
}
 
