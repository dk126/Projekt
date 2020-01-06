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

namespace GARDEROBA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void logowanie_Click(object sender, EventArgs e)
        {
            /*SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\sebak\Documents\Data.mdf;Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) From LOGIN where Username = ' " + login.Text + "' and Password = '" + haslo.Text + " ' ",con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if((dt.Rows[0][0].ToString() == "1") && (string.IsNullOrWhiteSpace(login.Text) && string.IsNullOrWhiteSpace(haslo.Text)))
            {*/
                this.Hide();
                
                Start ss = new Start();
                ss.Show();
            /*}
            else
            {
                if(string.IsNullOrWhiteSpace(login.Text) && string.IsNullOrWhiteSpace(haslo.Text))
                {
                    MessageBox.Show("Wypelnij dane logowania !");
                }
                else
                {
                    this.Hide();

                    Start ss = new Start();
                    ss.Show();
                }
            }*/
        }
    }
}
