namespace CodeGame
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    // Login Function that will accept username and password and login into the game
    private void btnLogin_Click(object sender, EventArgs e)
    {
      string username = txtBoxUsername.Text;
      string password = txtBoxPassword.Text;
    }
  }
}
