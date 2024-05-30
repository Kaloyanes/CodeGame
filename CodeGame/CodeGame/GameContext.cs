using System.Data.Entity;

namespace CodeGame;
public class GameContext : DbContext
{
    public GameContext() : base("name=UserDBConnectionString")
    {
    }

    public DbSet<GameHistory> GameHistories { get; set; }
}

public class GameHistory
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public string Username { get; set; }
    public string Guesses { get; set; }
    public int Attempts { get; set; }
    public bool IsWin { get; set; }
    public DateTime GameDate { get; set; }
}
