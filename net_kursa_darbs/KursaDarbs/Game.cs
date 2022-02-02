using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace KursaDarbs
{
    public partial class Game : Form

    {
        string name;
        int counter = 0;
        int score = 0;
        Random rnd = new Random();
        string playerName;
        IList<Label> labelList = new List<Label>();

        string[] names = new string[20];
        

        public Game()
        {
            InitializeComponent();
            txtEnter.Hide();
            btnEnter.Hide();
            InitializeNames();

        }
        private void InitializeNames()
        {
            names[0] = "BANANAS";
            names[1] = "Car";
            names[2] = "Flower";
            names[3] = "Girl";
            names[4] = "Sleep";
            names[5] = "Computer";
            names[6] = "Window";
            names[7] = "Barel";
            names[8] = "Sheep";
            names[9] = "OUCH";
            names[10] = "HODOR";
            names[11] = "Mouse";
            names[12] = "Birthday";
            names[13] = "MyBirthday";
            names[14] = "Help";
            names[15] = "HELP";
            names[16] = "Sneeze";
            names[17] = "Ruber";
            names[18] = "Ears";
            names[19] = ".Net";
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            name = txtName.Text;
            txtName.Hide();
            btnSubmit.Hide();
            lblEnterName.Hide();
            playerName = txtName.Text;
            txtEnter.Show();
            btnEnter.Show();
            txtEnter.Focus();
            gameTimer.Start();

        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            counter++;
            if (counter>20)
            {
                gameTimer.Interval = gameTimer.Interval - 1;
                counter = 0;
                spawnLabel();

            }
            
            for (int i= 0; i< labelList.Count;i++)
            {
                labelList[i].Location = new Point(labelList[i].Location.X, labelList[i].Location.Y + 2);
                if (labelList[i].Location.Y > 279)
                {

                    failState();

                }

            }


        }
        private void failState ()
        {

            OleDbConnection con = new OleDbConnection();
            con.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\figit\Documents\Studijas\Programmesana2\Darbi\KursaDarbs\KursaDarbi.mdb";
            con.Open();
            OleDbCommand cmd = con.CreateCommand();

            cmd.CommandText = "INSERT INTO Score (PlayerName, Score) VALUES (@PlayerName,@Score)";
            cmd.Parameters.AddWithValue("@PlayerName", OleDbType.Char).Value = playerName;
            cmd.Parameters.AddWithValue("@Score", OleDbType.Char).Value = score;

            cmd.ExecuteNonQuery();


            con.Close();
            mnuMainMenu mainM = new mnuMainMenu();
            mainM.Show();
            this.Close();
        }
        private void spawnLabel ()
        {
            
            Label flyingText = new Label();

            flyingText.Text = names[rnd.Next(0, 19)];
            
            
            flyingText.Location = new Point(rnd.Next(0, 700),10);
            flyingText.Show();
            flyingText.Font = new Font("Ravie", 9);
            flyingText.AutoSize = true;
            this.Controls.Add(flyingText);

            labelList.Add(flyingText);

            
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {

            killTextBoxes();
        }

        private void killTextBoxes ()
        {
            for (int i = 0; i < labelList.Count; i++)
            {
                if (labelList[i].Text == txtEnter.Text)
                {
                    this.Controls.Remove(labelList[i]);
                    labelList.Remove(labelList[i]);
                    i = i - 1;
                    score++;

                }

            }
            txtEnter.Text = "";
        }
        private void txtEnter_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtEnter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                killTextBoxes();
            }
        }

        private void Game_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}
