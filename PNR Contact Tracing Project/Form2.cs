using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PNR_Contact_Tracing_Project
{
    public partial class Form2 : Form
    {
        public Form2 instance;
        
        public Form2()
        {
            InitializeComponent();
            instance = this;
            
        }

        private void btnSortedDate_Click(object sender, EventArgs e)
        {
           
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e) // The button is renamed to btnExit
        {
            Application.Exit();
        }
        public void StreamReader()
        {
            StreamReader reader = new StreamReader(@"C:\Users\ASUS DEMO\Downloads\PNR Contact Tracing Folder\Contact Tracing.txt", true);
            string all = reader.ReadToEnd();
            MessageBox.Show(all, "Readline");
            reader.Close();
        }

        private void Readline_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Here are the files");
            StreamReader();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            List<string> sortingdate = new List<string>();
            string date = this.dateTimePicker1.Text;
        }

        //public void StreamReader()
        //{
        //    StreamReader reader = new StreamReader(@"C:\Users\ASUS DEMO\Downloads\PNR Contact Tracing Folder\Contact Tracing.txt", true);
        //    string all = reader.ReadToEnd();
        //    MessageBox.Show(all);
        //    reader.Close();
        //}
    }
}
