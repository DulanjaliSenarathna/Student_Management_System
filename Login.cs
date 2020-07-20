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

namespace WindowsFormsApplication1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0; AttachDbFilename=c:\users\dulanjali\documents\visual studio 2013\Projects\WindowsFormsApplication1\WindowsFormsApplication1\lodindb.mdf;Integrated Security=True;Connect Timeout=30");
            string Qry = "select * from login where Username='" + textusername.Text.Trim() + "' and Password = '" + textpassword.Text.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(Qry, con);
            DataTable dt = new DataTable();
            try
            {
                sda.Fill(dt);
            }
            catch (Exception)
            {
                
                throw;
            }
            if (string.IsNullOrEmpty(textusername.Text))
            {
                MessageBox.Show("Please enter your Username!","Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textusername.Focus();
                return;

            }

            if (string.IsNullOrEmpty(textpassword.Text))
            {
                MessageBox.Show("Please enter your Password!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textpassword.Focus();
                return;

            }

            if (dt.Rows.Count == 1)
            {
                MessageBox.Show("UserName and Password are correct","Message",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                home hm = new home();
                this.Hide();


                hm.Show();




            }
            else
            {
                MessageBox.Show("UserName and Password are Incorrect","Message",MessageBoxButtons.OK,MessageBoxIcon.Error);

            }
            textusername.Clear();
            textpassword.Clear();

        }

      

        private void textusername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                textpassword.Focus();
        }

        private void textpassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                button1.PerformClick();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
          
        }
    }
}
