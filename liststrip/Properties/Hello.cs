using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace liststrip.Properties
{
    public partial class Hello : Form
    {
        public Hello()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

             string name = textBox1.Text;
            string password = textBox2.Text;
            string message = "error";
            string topic = "not found";


            if (name == "moiz" && password == "111" )
            {
                this.Hide();
                Form1 he = new Form1();
                he.ShowDialog();

            }


            else
            {
                MessageBox.Show(message, topic);
            }

        }
    }
}
