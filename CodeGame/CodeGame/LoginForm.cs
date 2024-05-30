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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            using (var context = new UserContext())
            {
                var username = txtBoxUsername.Text;
                var password = txtBoxPassword.Text;
                var passwordHash = HashPassword(password);

                var user = context.Users.SingleOrDefault(u => u.Username == username && u.PasswordHash == passwordHash);

                UserSession.Instance.SetUserDetails(user.Id, user.Username);
                if (user != null)
                {
                    MessageBox.Show("Login successful!");
                    // Proceed to the main application form
                    OpenGameForm();
                }
                else
                {
                    MessageBox.Show("Invalid username or password.");
                }
            }
        }

        private void OpenGameForm()
        {
            this.Hide();
            var gameForm = new GameForm();
            gameForm.Show();
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

        private void button1_Click(object sender, EventArgs e)
        {
            new SignUpForm().Show();
        }
    }
}
