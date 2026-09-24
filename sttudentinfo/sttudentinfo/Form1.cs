using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sttudentinfo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //declare variable
            string studentname, intstudentid, department, intsemester, fullinfo;

            // assign variable
            studentname = txtstudentname.Text;
            int studentid = int.Parse(txtstudentid.Text);
            department = txtdepartment.Text;
            int semester = int.Parse(txtsemester.Text);

            //process concatination
            fullinfo = studentname + "" + studentid + "" + department + "" + semester;

            //display
            lbloutput.Text = fullinfo;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //clear
            txtstudentname.Clear();
            txtstudentid.Clear();
            txtdepartment.Clear();
            txtsemester.Clear();
            lbloutput.Text = "";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //this clise
            this.Close();
        }
    }
}
