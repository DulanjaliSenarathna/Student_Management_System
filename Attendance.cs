using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Attendance : Form
    {
        public Attendance()
        {
            InitializeComponent();
        }

        private void comboBox9_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Attendance_Load(object sender, EventArgs e)
        {
            //pictureBox2.Image=imageList.Images[4];
            comboBox1.Items.Add("/");
            comboBox1.Items.Add("0");

            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;
            textBox7.Visible = false;
            textBox8.Visible = false;
            textBox9.Visible = false;
            textBox10.Visible = false;
            textBox11.Visible = false;
            textBox12.Visible = false;
            textBox13.Visible = false;
            textBox14.Visible = false;

            comboBox2.Items.Add("/-Present");
            comboBox2.Items.Add("0-Absent");

            comboBox3.Items.Add("/-Present");
            comboBox3.Items.Add("0-Absent");

            comboBox4.Items.Add("/-Present");
            comboBox4.Items.Add("0-Absent");

            comboBox5.Items.Add("/-Present");
            comboBox5.Items.Add("0-Absent");

            comboBox6.Items.Add("/-Present");
            comboBox6.Items.Add("0-Absent");

            comboBox7.Items.Add("/-Present");
            comboBox7.Items.Add("0-Absent");

            comboBox8.Items.Add("/-Present");
            comboBox8.Items.Add("0-Absent");

            comboBox9.Items.Add("/-Present");
            comboBox9.Items.Add("0-Absent");

            comboBox10.Items.Add("/-Present");
            comboBox10.Items.Add("0-Absent");

            comboBox11.Items.Add("/-Present");
            comboBox11.Items.Add("0-Absent");

            comboBox12.Items.Add("/-Present");
            comboBox12.Items.Add("0-Absent");

            comboBox13.Items.Add("/-Present");
            comboBox13.Items.Add("0-Absent");

            comboBox14.Items.Add("/-Present");
            comboBox14.Items.Add("0-Absent");

            comboBox15.Items.Add("/-Present");
            comboBox15.Items.Add("0-Absent");


        }

       

       

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (comboBox1.Text == "/")
            {
                comboBox2.Text = "/-Present";
                comboBox3.Text = "/-Present";
                comboBox4.Text = "/-Present";
                comboBox5.Text = "/-Present";
                comboBox6.Text = "/-Present";
                comboBox7.Text = "/-Present";
                comboBox8.Text = "/-Present";
                comboBox9.Text = "/-Present";
                comboBox10.Text = "/-Present";
                comboBox11.Text = "/-Present";
                comboBox12.Text = "/-Present";
                comboBox13.Text = "/-Present";
                comboBox14.Text = "/-Present";
                comboBox15.Text = "/-Present";

            }
            else
            {
                comboBox2.Text = "0-Absent";
                comboBox3.Text = "0-Absent";
                comboBox4.Text = "0-Absent";
                comboBox5.Text = "0-Absent";
                comboBox6.Text = "0-Absent";
                comboBox7.Text = "0-Absent";
                comboBox8.Text = "0-Absent";
                comboBox9.Text = "0-Absent";
                comboBox10.Text = "0-Absent";
                comboBox11.Text = "0-Absent";
                comboBox12.Text = "0-Absent";
                comboBox13.Text = "0-Absent";
                comboBox14.Text = "0-Absent";
                comboBox15.Text = "0-Absent";
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            
            int count;
            count = 0;

             textBox1.Text = comboBox2.Text;
            textBox2.Text = comboBox3.Text;
            textBox3.Text = comboBox4.Text;
            textBox4.Text = comboBox5.Text;
            textBox5.Text = comboBox6.Text;
            textBox6.Text = comboBox7.Text;
            textBox7.Text =comboBox8.Text;
            textBox8.Text = comboBox9.Text;
            textBox9.Text = comboBox10.Text;
            textBox10.Text = comboBox11.Text;
            textBox11.Text = comboBox12.Text;
            textBox12.Text = comboBox13.Text;
            textBox13.Text = comboBox14.Text;
            textBox14.Text = comboBox15.Text;

            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            textBox5.Visible = true;
            textBox6.Visible = true;
            textBox7.Visible = true;
            textBox8.Visible = true;
            textBox9.Visible = true;
            textBox10.Visible = true;
            textBox11.Visible = true;
            textBox12.Visible = true;
            textBox13.Visible = true;
            textBox14.Visible = true;


            comboBox2.Visible = false;
            comboBox3.Visible = false;
            comboBox4.Visible = false;
            comboBox5.Visible = false;
            comboBox6.Visible = false;
            comboBox7.Visible = false;
            comboBox8.Visible = false;
            comboBox9.Visible = false;
            comboBox10.Visible = false;
            comboBox11.Visible = false;
            comboBox12.Visible = false;
            comboBox13.Visible = false;
           comboBox14.Visible = false;

            if (( textBox1.Text ==null)||
            (textBox2.Text ==null)||
            (textBox3.Text ==null)||
            (textBox4.Text ==null)||
            (textBox5.Text ==null)||
            (textBox6.Text ==null)||
            (textBox7.Text ==null)||
            (textBox8.Text ==null)||
            (textBox9.Text ==null)||
            (textBox10.Text ==null)||
            (textBox11.Text ==null)||
            (textBox12.Text ==null)||
            (textBox13.Text ==null)||
            (textBox14.Text ==null))
            {
                MessageBox.Show("No marks on Register");

                textBox1.Text = "";
                comboBox2.Text = "";
                textBox1.Visible = false;
                comboBox2.Visible = true;

                textBox2.Text = "";
                comboBox3.Text = "";
                textBox2.Visible = false;
                comboBox3.Visible = true;

                textBox3.Text = "";
                comboBox4.Text = "";
                textBox3.Visible = false;
                comboBox4.Visible = true;

                textBox4.Text = "";
                comboBox5.Text = "";
                textBox4.Visible = false;
                comboBox5.Visible = true;

                textBox5.Text = "";
                comboBox6.Text = "";
                textBox5.Visible = false;
                comboBox6.Visible = true;

                textBox6.Text = "";
                comboBox7.Text = "";
                textBox6.Visible = false;
                comboBox7.Visible = true;

                textBox7.Text = "";
                comboBox8.Text = "";
                textBox7.Visible = false;
                comboBox8.Visible = true;

                textBox8.Text = "";
                comboBox9.Text = "";
                textBox8.Visible = false;
                comboBox9.Visible = true;

                textBox9.Text = "";
                comboBox10.Text = "";
                textBox9.Visible = false;
                comboBox10.Visible = true;

                textBox10.Text = "";
                comboBox11.Text = "";
                textBox10.Visible = false;
                comboBox11.Visible = true;

                textBox11.Text = "";
                comboBox12.Text = "";
                textBox11.Visible = false;
                comboBox12.Visible = true;

                textBox12.Text = "";
                comboBox13.Text = "";
                textBox12.Visible = false;
                comboBox13.Visible = true;

                textBox13.Text = "";
                comboBox14.Text = "";
                textBox13.Visible = false;
                comboBox14.Visible = true;

                textBox14.Text = "";
                comboBox15.Text = "";
                textBox14.Visible = false;
                comboBox15.Visible = true;

                comboBox1.Text = "";

            }

            if (textBox1.Text == "/-Present")
            {
                count = count + 1;
                lblcount_students.Text = Convert.ToString(count);
            }
            if (textBox2.Text == "/-Present")
            {
                count = count + 1;
                lblcount_students.Text = Convert.ToString(count);
            }

            if (textBox3.Text == "/-Present")
            {
                count = count + 1;
                lblcount_students.Text = Convert.ToString(count);
            }

            if (textBox4.Text == "/-Present")
            {
                count = count + 1;
                lblcount_students.Text = Convert.ToString(count);
            }

            if (textBox5.Text == "/-Present")
            {
                count = count + 1;
                lblcount_students.Text = Convert.ToString(count);
            }

            if (textBox6.Text == "/-Present")
            {
                count = count + 1;
                lblcount_students.Text = Convert.ToString(count);
            }

            if (textBox7.Text == "/-Present")
            {
                count = count + 1;
                lblcount_students.Text = Convert.ToString(count);
            }
            if (textBox8.Text == "/-Present")
            {
                count = count + 1;
                lblcount_students.Text = Convert.ToString(count);
            }
            if (textBox9.Text == "/-Present")
            {
                count = count + 1;
                lblcount_students.Text = Convert.ToString(count);
            }
            if (textBox10.Text == "/-Present")
            {
                count = count + 1;
                lblcount_students.Text = Convert.ToString(count);
            }

            if (textBox11.Text == "/-Present")
            {
                count = count + 1;
                lblcount_students.Text = Convert.ToString(count);
            }

            if (textBox12.Text == "/-Present")
            {
                count = count + 1;
                lblcount_students.Text = Convert.ToString(count);
            }

            if (textBox13.Text == "/-Present")
            {
                count = count + 1;
                lblcount_students.Text = Convert.ToString(count);
            }

            if (textBox14.Text == "/-Present")
            {
                count = count + 1;
                lblcount_students.Text = Convert.ToString(count);
            }
             
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            comboBox1.Text = "";
            lblcount_students.Text = "";

            textBox1.Text = "";
            comboBox2.Text = "";
            textBox1.Visible = false;
            comboBox2.Visible = true;

            textBox2.Text = "";
            comboBox3.Text = "";
            textBox2.Visible = false;
            comboBox3.Visible = true;

            textBox3.Text = "";
            comboBox4.Text = "";
            textBox3.Visible = false;
            comboBox4.Visible = true;

            textBox4.Text = "";
            comboBox5.Text = "";
            textBox4.Visible = false;
            comboBox5.Visible = true;

            textBox5.Text = "";
            comboBox6.Text = "";
            textBox5.Visible = false;
            comboBox6.Visible = true;

            textBox6.Text = "";
            comboBox7.Text = "";
            textBox6.Visible = false;
            comboBox7.Visible = true;

            textBox7.Text = "";
            comboBox8.Text = "";
            textBox7.Visible = false;
            comboBox8.Visible = true;

            textBox8.Text = "";
            comboBox9.Text = "";
            textBox8.Visible = false;
            comboBox9.Visible = true;

            textBox9.Text = "";
            comboBox10.Text = "";
            textBox9.Visible = false;
            comboBox10.Visible = true;

            textBox10.Text = "";
            comboBox11.Text = "";
            textBox10.Visible = false;
            comboBox11.Visible = true;

            textBox11.Text = "";
            comboBox12.Text = "";
            textBox11.Visible = false;
            comboBox12.Visible = true;

            textBox12.Text = "";
            comboBox13.Text = "";
            textBox12.Visible = false;
            comboBox13.Visible = true;

            textBox13.Text = "";
            comboBox14.Text = "";
            textBox13.Visible = false;
            comboBox14.Visible = true;

            textBox14.Text = "";
            comboBox15.Text = "";
            textBox14.Visible = false;
            comboBox15.Visible = true;


        }

        private void Attendance_Activated(object sender, EventArgs e)
        {
            int StdID=100100;

            label19.Text = Convert.ToString(StdID + 10);
            label20.Text = Convert.ToString(StdID + 11);
            label21.Text = Convert.ToString(StdID + 12);
            label22.Text = Convert.ToString(StdID + 13);
            label23.Text = Convert.ToString(StdID + 14);
            label24.Text = Convert.ToString(StdID + 15);
            label25.Text = Convert.ToString(StdID + 16);
            label26.Text = Convert.ToString(StdID + 17);
            label27.Text = Convert.ToString(StdID + 18);
            label28.Text = Convert.ToString(StdID + 19);
            label29.Text = Convert.ToString(StdID + 20);
            label30.Text = Convert.ToString(StdID + 21);
            label31.Text = Convert.ToString(StdID + 22);
            label32.Text = Convert.ToString(StdID + 23);


            label47.Text = Convert.ToString(101);
            label48.Text = Convert.ToString(101);
            label49.Text = Convert.ToString(101);
            label50.Text = Convert.ToString(101);
            label51.Text = Convert.ToString(101);
            label52.Text = Convert.ToString(101);
            label53.Text = Convert.ToString(101);
            label54.Text = Convert.ToString(101);
            label55.Text = Convert.ToString(101);
            label56.Text = Convert.ToString(101);
            label57.Text = Convert.ToString(101);
            label58.Text = Convert.ToString(101);
            label59.Text = Convert.ToString(101);
            label60.Text = Convert.ToString(101);

            label33.Text = "Senevirathna H G N Rukshani";
            label34.Text = "Keerthisingha K M L Maduwanthi";
            label34.Text = "Gunasena W G T Nishamanee";
            label35.Text = "Jayalal G V Sanjeewa";
            label36.Text = "Karunarathna I H Nilantha";
            label37.Text = "Samarathunga K M D Vijayanthi";
            label38.Text = "Bombuwala B A Chamika";
            label39.Text = "Welikanna W A M Gayani ";
            label40.Text = "Dananjani D";
            label41.Text = "Lakmini E";
            label42.Text = "De Silva N Lakshini";
            label43.Text = "Dewage I D D Madushanka";
            label44.Text = "Dissanayake D A A Indeevari";
            label45.Text = "Ranaveera M Sewwandi";
            label46.Text = "Wickramaarachchi D Uththara";





        }

        private void label33_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = imageList1.Images[0];
        }

        private void label34_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = imageList1.Images[1];
        }

        private void label35_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = imageList1.Images[2];
        }

        private void label36_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = imageList1.Images[3];
        }

        private void label37_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = imageList1.Images[4];
        }

        private void label38_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = imageList1.Images[5];
        }

        private void label39_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = imageList1.Images[6];
        }

        private void label40_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = imageList1.Images[7];
        }

        private void label41_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = imageList1.Images[8];
        }

        private void label42_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = imageList1.Images[9];
        }

        private void label43_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = imageList1.Images[10];
        }

        private void label44_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = imageList1.Images[11];
        }

        private void label45_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = imageList1.Images[12];
        }

        private void label46_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = imageList1.Images[13];
        }

        private void button4_Click(object sender, EventArgs e)
        {
            home hm = new home();
            this.Hide();
            hm.Show();
        }

        }
        }

       
    

