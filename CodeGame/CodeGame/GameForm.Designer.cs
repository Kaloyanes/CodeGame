namespace CodeGame
{
    partial class GameForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tlpGameBoard = new TableLayoutPanel();
            txtGuess1 = new TextBox();
            txtGuess2 = new TextBox();
            txtGuess3 = new TextBox();
            txtGuess4 = new TextBox();
            btnSubmitGuess = new Button();
            btnLogout = new Button();
            btnViewHistory = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // tlpGameBoard
            // 
            tlpGameBoard.ColumnCount = 3;
            tlpGameBoard.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
            tlpGameBoard.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
            tlpGameBoard.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
            tlpGameBoard.Location = new Point(70, 52);
            tlpGameBoard.Name = "tlpGameBoard";
            tlpGameBoard.RowCount = 14;
            tlpGameBoard.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tlpGameBoard.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpGameBoard.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpGameBoard.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpGameBoard.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpGameBoard.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpGameBoard.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpGameBoard.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpGameBoard.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpGameBoard.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpGameBoard.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpGameBoard.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpGameBoard.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpGameBoard.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpGameBoard.Size = new Size(762, 364);
            tlpGameBoard.TabIndex = 0;
            // 
            // txtGuess1
            // 
            txtGuess1.Location = new Point(10, 520);
            txtGuess1.Name = "txtGuess1";
            txtGuess1.Size = new Size(50, 23);
            txtGuess1.TabIndex = 0;
            // 
            // txtGuess2
            // 
            txtGuess2.Location = new Point(70, 520);
            txtGuess2.Name = "txtGuess2";
            txtGuess2.Size = new Size(50, 23);
            txtGuess2.TabIndex = 1;
            // 
            // txtGuess3
            // 
            txtGuess3.Location = new Point(130, 520);
            txtGuess3.Name = "txtGuess3";
            txtGuess3.Size = new Size(50, 23);
            txtGuess3.TabIndex = 2;
            // 
            // txtGuess4
            // 
            txtGuess4.Location = new Point(190, 520);
            txtGuess4.Name = "txtGuess4";
            txtGuess4.Size = new Size(50, 23);
            txtGuess4.TabIndex = 3;
            // 
            // btnSubmitGuess
            // 
            btnSubmitGuess.Location = new Point(250, 520);
            btnSubmitGuess.Name = "btnSubmitGuess";
            btnSubmitGuess.Size = new Size(100, 30);
            btnSubmitGuess.TabIndex = 6;
            btnSubmitGuess.Text = "Submit Guess";
            btnSubmitGuess.Click += btnSubmitGuess_Click;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(370, 520);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(100, 30);
            btnLogout.TabIndex = 7;
            btnLogout.Text = "Logout";
            btnLogout.Click += btnLogout_Click;
            // 
            // btnViewHistory
            // 
            btnViewHistory.Location = new Point(490, 520);
            btnViewHistory.Name = "btnViewHistory";
            btnViewHistory.Size = new Size(100, 30);
            btnViewHistory.TabIndex = 8;
            btnViewHistory.Text = "View History";
            btnViewHistory.Click += btnViewHistory_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(715, 528);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 9;
            label1.Text = "label1";
            // 
            // GameForm
            // 
            ClientSize = new Size(1023, 600);
            Controls.Add(label1);
            Controls.Add(txtGuess1);
            Controls.Add(txtGuess2);
            Controls.Add(txtGuess3);
            Controls.Add(txtGuess4);
            Controls.Add(btnSubmitGuess);
            Controls.Add(btnLogout);
            Controls.Add(btnViewHistory);
            Controls.Add(tlpGameBoard);
            Name = "GameForm";
            Text = "Bletchley Game";
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpGameBoard;
        private System.Windows.Forms.TextBox txtGuess1;
        private System.Windows.Forms.TextBox txtGuess2;
        private System.Windows.Forms.TextBox txtGuess3;
        private System.Windows.Forms.TextBox txtGuess4;
        private System.Windows.Forms.Button btnSubmitGuess;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnViewHistory;
        private Label label1;
    }
}