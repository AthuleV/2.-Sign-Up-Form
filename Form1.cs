using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2.Sign_Up_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
      
                // Perform validation (e.g., check if fields are not empty)

                string username = textBox1.Text;
                string password = textBox2.Text;

                // Here, you can save the user data to a file or a database
                // For simplicity, let's display the information in a message box

                string message = $"Username: {username}";

                MessageBox.Show(message, "Sign Up Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }
    }
}
