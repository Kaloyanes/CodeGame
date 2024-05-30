using CodeGame;
using System;
using System.Linq;
using System.Windows.Forms;

namespace CodeGame;

public partial class HistoryForm : Form
{

    public HistoryForm()
    {
        InitializeComponent();
        LoadGameHistory();
    }

    private void LoadGameHistory()
    {
        using (var context = new GameContext())
        {
            var gameHistories = context.GameHistories
                .OrderByDescending(g => g.GameDate)
                .ToList();

            foreach (var game in gameHistories)
            {
                var listViewItem = new ListViewItem(new[]
                {
                    game.Username,
                    game.Attempts.ToString(),
                    game.IsWin ? "Win" : "Loss",
                    game.GameDate.ToString()
                });
                lvGameHistory.Items.Add(listViewItem);
            }

            var leaderboard = context.GameHistories
                .GroupBy(g => g.Username)
                .Select(g => new
                {
                    Username = g.Key,
                    Wins = g.Count(game => game.IsWin),
                    TotalGames = g.Count(),
                    WinRate = (double)g.Count(game => game.IsWin) / g.Count() * 100
                })
                .OrderByDescending(g => g.Wins)
                .ToList();

            foreach (var player in leaderboard)
            {
                var listViewItem = new ListViewItem(new[]
                {
                    player.Username,
                    player.Wins.ToString(),
                    player.TotalGames.ToString(),
                    player.WinRate.ToString("F2") + "%"
                });
                lvLeaderboard.Items.Add(listViewItem);
            }
        }
    }
}
