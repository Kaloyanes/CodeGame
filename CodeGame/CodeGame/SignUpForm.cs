using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeGame
{
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
        }

        // Register Function that will accept username and password and register into the game and directly login in 
        private void button1_Click(object sender, EventArgs e)
        {
            // Getting the username and password from the textboxes
            string username = txtBoxUsername.Text;
            string password = txtBoxPassword.Text;
        }
    }
}
