using CodeGame;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace CodeGame;
public partial class GameForm : Form
{
    private int[] secretCode;
    private List<int[]> guesses;
    private int maxAttempts = 13;

    public GameForm()
    {
        InitializeComponent();
        for (int i = 1; i < 14; i++)
        {
            this.tlpGameBoard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
        }
        InitializeGame();
    }

    private void InitializeGame()
    {
        //lblUsername.Text = $"Welcome, {UserSession.Instance.Username}";
        GenerateSecretCode();
        guesses = new List<int[]>();
        UpdateGameDisplay();
    }

    private void GenerateSecretCode()
    {
        Random rand = new Random();
        secretCode = new int[4];
        for (int i = 0; i < 4; i++)
        {
            secretCode[i] = rand.Next(0, 8);
        }

        // Uncomment the line below to see the secret code in the console
         Console.WriteLine(string.Join(' ', secretCode));
        label1.Text = "Secret Code: " + string.Join(' ', secretCode);
    }

    private void UpdateGameDisplay()
    {
        tlpGameBoard.Controls.Clear();
        AddHeaders();

        for (int i = 0; i < guesses.Count; i++)
        {
            int[] guess = guesses[i];
            int rowIndex = i + 1;


            
            var label = new Label() { Text = string.Join(' ', guess), Width = 30, Height = 30, TextAlign = ContentAlignment.MiddleCenter, Margin = new Padding(5) };
            tlpGameBoard.Controls.Add(label, 1, rowIndex);

            // Update guessed numbers and positions
            var guessedNumbersAndPositions = CalculateGuessedNumbersAndPositions(guess);
            for (int k = 0; k < guessedNumbersAndPositions.Item1; k++)
            {
                var button = new Button() { BackColor = Color.Green, Width = 30, Height = 30, Margin = new Padding(5) };
                tlpGameBoard.Controls.Add(button, 0, rowIndex);
            }

            // Update guessed numbers
            for (int k = 0; k < guessedNumbersAndPositions.Item2; k++)
            {
                var button = new Button() { BackColor = Color.Red, Width = 30, Height = 30, Margin = new Padding(5) };
                tlpGameBoard.Controls.Add(button, 2, rowIndex);
            }
        }
    }

    private Tuple<int, int> CalculateGuessedNumbersAndPositions(int[] guess)
    {
        int correctPositionCount = 0;
        int correctNumberCount = 0;

        for (int i = 0; i < 4; i++)
        {
            if (guess[i] == secretCode[i])
            {
                correctPositionCount++;
            }
            else if (secretCode.Contains(guess[i]))
            {
                correctNumberCount++;
            }
        }

        return new Tuple<int, int>(correctPositionCount, correctNumberCount);
    }

    private void btnSubmitGuess_Click(object sender, EventArgs e)
    {
        int[] guess = new int[4];
        guess[0] = int.Parse(txtGuess1.Text);
        guess[1] = int.Parse(txtGuess2.Text);
        guess[2] = int.Parse(txtGuess3.Text);
        guess[3] = int.Parse(txtGuess4.Text);

        guesses.Add(guess);

        UpdateGameDisplay();

        if (CheckWinCondition(guess))
        {
            MessageBox.Show("You guessed the code!");
            SaveGameHistory(true);
            this.Close();
            return;
        }

        if (guesses.Count >= maxAttempts)
        {
            MessageBox.Show("You've used all your attempts!");
            SaveGameHistory(false);
            this.Close();
            return;
        }
    }

    private bool CheckWinCondition(int[] guess)
    {
        for (int i = 0; i < 4; i++)
        {
            if (guess[i] != secretCode[i])
            {
                return false;
            }
        }
        return true;
    }

    private void SaveGameHistory(bool isWin)
    {
        using (var context = new GameContext())
        {
            var gameHistory = new GameHistory
            {
                UserId = UserSession.Instance.UserId,
                Username = UserSession.Instance.Username,
                Guesses = string.Join(";", guesses.Select(g => string.Join(",", g))),
                Attempts = guesses.Count,
                IsWin = isWin,
                GameDate = DateTime.Now
            };
            context.GameHistories.Add(gameHistory);
            context.SaveChanges();
        }
    }

    private void btnLogout_Click(object sender, EventArgs e)
    {


        // Clear user session
        UserSession.Instance.Logout();

        // Redirect to login form
        this.Hide();
        var loginForm = new LoginForm();
        loginForm.Show();
    }

    private void btnViewHistory_Click(object sender, EventArgs e)
    {
        var historyForm = new HistoryForm();
        historyForm.Show();
    }

    private void AddHeaders()
    {
        tlpGameBoard.Controls.Add(new Label() { Text = "Guessed numbers and positions", TextAlign = ContentAlignment.MiddleCenter }, 0, 0);
        tlpGameBoard.Controls.Add(new Label() { Text = "Player's guesses", TextAlign = ContentAlignment.MiddleCenter }, 1, 0);
        tlpGameBoard.Controls.Add(new Label() { Text = "Guessed numbers", TextAlign = ContentAlignment.MiddleCenter }, 2, 0);
    }
}
