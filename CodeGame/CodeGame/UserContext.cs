using System.Data.Entity;

namespace CodeGame;

public class UserContext : DbContext
{
    public UserContext() : base("name=UserDBConnectionString") { }

    public DbSet<User> Users { get; set; }
}

public class User
{
    public int Id { get; set; }
    public string Username { get; set; }
    public string PasswordHash { get; set; }
}
