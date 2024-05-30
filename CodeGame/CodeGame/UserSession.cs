public class UserSession
{
    private static UserSession instance = null;
    private static readonly object padlock = new object();

    public int UserId { get; private set; }
    public string Username { get; private set; }

    private UserSession() { }

    public static UserSession Instance
    {
        get
        {
            lock (padlock)
            {

                if (instance == null)
                {
                    instance = new UserSession();
                }
                return instance;
            }
        }
    }

    public void SetUserDetails(int userId, string username)
    {
        UserId = userId;
        Username = username;
    }

    public void Logout()
    {
        UserId = 0;
        Username = string.Empty;
    }
}
