using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;


namespace WindowsFormsApplication1
{


    public partial class Registration : Form
    {
       

        public Registration()
        {
            InitializeComponent();
        }
        SqlCommand command = new SqlCommand(); 
        SqlConnection ABC = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Dulanjali\Documents\lodindb.mdf;Integrated Security=True;Connect Timeout=30");
        SqlDataReader read;
      
        SqlDataAdapter asdf;
        DataTable ss ;
        SqlCommandBuilder cmdbl;
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void insert_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "" & textBox1.Text != "" & textBox4.Text != "" & comboBox2.Text != "" & comboBox3.Text != "" & textBox5.Text != "" & textBox6.Text != "" & textBox7.Text != "" & comboBox1.Text != "")
            {
                ABC.Open();
                SqlCommand command = ABC.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "insert into Student values ('" + textBox2.Text + "','" + textBox1.Text + "','" + textBox4.Text + "','" + dateTimePicker2.Text + "','" + comboBox2.Text + "','" + comboBox3.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + comboBox1.Text + "','" + dateTimePicker2.Text + "') ";
                command.ExecuteNonQuery();
                ABC.Close();
                disp_Data();
                MessageBox.Show("Saved Successefully");
                textBox2.Clear();
                textBox1.Clear();
                textBox4.Clear();
                dateTimePicker2.Value = DateTime.Now;
                comboBox2.SelectedIndex = -1;
                comboBox3.SelectedIndex = -1;
                textBox5.Clear();
                textBox6.Clear();
                textBox7.Clear();
                comboBox1.SelectedIndex = -1;
                dateTimePicker2.Value = DateTime.Now;
            }
            else
            {
                MessageBox.Show("Fill Required Fields!");
            }
        }
            
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                textBox1.Focus();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                textBox4.Focus();
        }

        private void dateTimePicker2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                comboBox2.Focus();
        }

        private void comboBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                comboBox3.Focus();
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                textBox6.Focus();
        }

        void Reset()
        {
            textBox2.Text=textBox1.Text= textBox4.Text= textBox5.Text =textBox6.Text =textBox7.Text=  "";
             comboBox2.Text= comboBox3.Text=comboBox1.Text="";
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                textBox7.Focus();

        }

        private void comboBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                textBox5.Focus();
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                comboBox1.Focus();
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                dateTimePicker1.Focus();
        }

        private void dateTimePicker1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                insert.PerformClick();
        }

      
        private void Registration_Load(object sender, EventArgs e)
        {
            command.Connection = ABC;
            disp_Data();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            home hm = new home();
            this.Hide();
            hm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           string Constring = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Dulanjali\Documents\lodindb.mdf;Integrated Security=True;Connect Timeout=30";
           string Query = "update Student set Student_ID='" + this.textBox2.Text + "',Student_Name ='" + this.textBox1.Text + "',NIC='" + this.textBox4.Text + "',Date_of_Birth='" + this.dateTimePicker2.Text + "',Gender='" + this.comboBox2.Text + "',Status='" + this.comboBox3.Text + "',Postal_Address='" + this.textBox5.Text + "', Email_Address ='" + this.textBox6.Text + "',Mobile_NO='" + this.textBox5.Text + "',Educational_Qualifications='" + this.comboBox1.Text + "',Registered_Date='" + this.dateTimePicker2.Text + "' where Student_ID='" + this.textBox2.Text + "';";
           SqlConnection ABC = new SqlConnection(Constring);
           SqlCommand command = new SqlCommand(Query, ABC);
           SqlDataReader read;
           try
           {
               ABC.Open();
               read = command.ExecuteReader();
               MessageBox.Show("Update Successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
               while (read.Read())
               {

               }

           }
           catch (Exception ex)
           {

               MessageBox.Show(ex.Message);
          
           }  
           }
            
        
    

        private void button4_Click(object sender, EventArgs e)
        {
            ABC.Open();
            SqlCommand command = ABC.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "delete from Student where Student_ID = '" + textBox2.Text + "'";
            command.ExecuteNonQuery();
            ABC.Close();
            disp_Data();
           
            MessageBox.Show("Delete Successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            textBox2.Clear();

        }
        public void disp_Data()
        {
            ABC.Open();
            SqlCommand command = ABC.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "select * from Student";
            command.ExecuteNonQuery();
            DataTable ss = new DataTable();
            SqlDataAdapter asdf = new SqlDataAdapter(command);
            asdf.Fill(ss);
            dataGridView1.DataSource = ss;
            ABC.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                asdf = new SqlDataAdapter("select Student_ID,Student_Name,NIC,Date_of_Birth,Gender,Status,Postal_Address,Email_Address,Mobile_NO,Educational_Qualifications,Registered_Date from Student", ABC);
                ss = new DataTable();
                asdf.Fill(ss);
                dataGridView1.DataSource = ss;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public object Student_ID { get; set; }
    }
}

   


         
        

    

