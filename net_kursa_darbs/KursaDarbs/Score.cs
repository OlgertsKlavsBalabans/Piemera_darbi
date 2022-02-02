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
    public partial class frmScore : Form
    {
        public frmScore()
        {
            InitializeComponent();
            loadScore();
        }
        private void loadScore ()
        {
            OleDbConnection con = new OleDbConnection();
            con.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\Documents\Studijas\Programmesana2\Darbi\KursaDarbs\KursaDarbi.mdb";
            con.Open();
            OleDbCommand cmd = con.CreateCommand();


            cmd.CommandText = "SELECT * FROM Score";
            OleDbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ListViewItem lists = new ListViewItem(reader[1].ToString());
                lists.SubItems.Add(reader[2].ToString());
                lvwScore.Items.Add(lists);
            }
            con.Close();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblScore_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            mnuMainMenu main = new mnuMainMenu();
            main.Show();
            this.Close();
        }

        private void frmScore_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }
    }
}
