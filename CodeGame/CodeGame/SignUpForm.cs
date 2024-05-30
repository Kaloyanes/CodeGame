using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
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
        private void btnSignup_Click(object sender, EventArgs e)
        {
            using (var context = new UserContext())
            {
                var username = txtBoxUsername.Text;
                var password = txtBoxPassword.Text;

                if (context.Users.Any(u => u.Username == username))
                {
                    MessageBox.Show("Username already exists.");
                    return;
                }

                var user = new User
                {
                    Username = username,
                    PasswordHash = HashPassword(password)
                };

                context.Users.Add(user);
                context.SaveChanges();

                MessageBox.Show("Signup successful!");
                this.Close();
            }
        }

        private string HashPassword(string password)
        {
            using (var sha256 = SHA256.Create())
            {
                var bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                var builder = new StringBuilder();
                foreach (var b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }
    }
}
