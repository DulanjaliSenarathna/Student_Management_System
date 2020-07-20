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
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
        }

        private void home_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Attendance att = new Attendance();
            this.Hide();
            att.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Registration re = new Registration();
          
            this.Hide();
            re.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Student_Profile pro = new Student_Profile();

            this.Hide();
            pro.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Login fo = new Login();
            this.Hide();
            fo.Show();
        }
    }
}
