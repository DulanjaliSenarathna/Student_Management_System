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
    public partial class Student_Profile : Form
    {

        

        public Student_Profile()
        {
            InitializeComponent();
        }
       public SqlConnection abc = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Dulanjali\Documents\lodindb.mdf;Integrated Security=True;Connect Timeout=30");

        SqlDataAdapter asdf;
        DataTable ss;

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

      

        private void Student_Profile_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            home hm = new home();
            this.Hide();
            hm.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                asdf = new SqlDataAdapter("select Student_ID as 'Student ID',Student_Name as 'Student Name',NIC,Date_of_Birth as 'Birth Day',Gender,Status,Postal_Address as 'Addres',Email_Address as 'Email',Mobile_NO as 'Mobile',Educational_Qualifications as 'Education Level',Registered_Date as 'Admission Date' from Student", abc);
                ss = new DataTable();
                asdf.Fill(ss);
                dataGridView1.DataSource = ss;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text=="Student ID")
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Dulanjali\Documents\lodindb.mdf;Integrated Security=True;Connect Timeout=30 ");
                SqlDataAdapter sda = new SqlDataAdapter("select * from Student where Student_ID like '"+textBox1.Text+"%' ", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (comboBox1.Text=="NIC")
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Dulanjali\Documents\lodindb.mdf;Integrated Security=True;Connect Timeout=30 ");
                SqlDataAdapter sda = new SqlDataAdapter("select * from Student where NIC like '" + textBox1.Text + "%' ", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else
            {
                MessageBox.Show("No Items for your searching!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
                
        }
    }
} 