namespace CodeGame
{
    partial class HistoryForm
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
            lvLeaderboard = new ListView();
            lvGameHistory = new ListView();
            SuspendLayout();
            // 
            // lvLeaderboard
            // 
            lvLeaderboard.Location = new Point(30, 12);
            lvLeaderboard.Name = "lvLeaderboard";
            lvLeaderboard.Size = new Size(121, 426);
            lvLeaderboard.TabIndex = 0;
            lvLeaderboard.UseCompatibleStateImageBehavior = false;
            // 
            // lvGameHistory
            // 
            lvGameHistory.Location = new Point(232, 12);
            lvGameHistory.Name = "lvGameHistory";
            lvGameHistory.Size = new Size(121, 426);
            lvGameHistory.TabIndex = 1;
            lvGameHistory.UseCompatibleStateImageBehavior = false;
            // 
            // HistoryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(402, 450);
            Controls.Add(lvGameHistory);
            Controls.Add(lvLeaderboard);
            Name = "HistoryForm";
            Text = "HistoryForm";
            ResumeLayout(false);
        }

        #endregion

        private ListView lvLeaderboard;
        private ListView lvGameHistory;
    }
}