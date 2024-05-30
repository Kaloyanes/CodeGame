namespace CodeGame
{
    partial class SignUpForm
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
            label2 = new Label();
            label1 = new Label();
            txtBoxPassword = new TextBox();
            txtBoxUsername = new TextBox();
            btnSignUp = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(270, 178);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 7;
            label2.Text = "Username";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(270, 232);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 6;
            label1.Text = "Password";
            // 
            // txtBoxPassword
            // 
            txtBoxPassword.Location = new Point(270, 250);
            txtBoxPassword.Name = "txtBoxPassword";
            txtBoxPassword.PasswordChar = '*';
            txtBoxPassword.Size = new Size(261, 23);
            txtBoxPassword.TabIndex = 5;
            // 
            // txtBoxUsername
            // 
            txtBoxUsername.Location = new Point(270, 196);
            txtBoxUsername.Name = "txtBoxUsername";
            txtBoxUsername.Size = new Size(261, 23);
            txtBoxUsername.TabIndex = 4;
            // 
            // btnSignUp
            // 
            btnSignUp.Location = new Point(352, 279);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(96, 23);
            btnSignUp.TabIndex = 8;
            btnSignUp.Text = "Register";
            btnSignUp.UseVisualStyleBackColor = true;
            btnSignUp.Click += btnSignup_Click;
            // 
            // SignUpForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSignUp);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtBoxPassword);
            Controls.Add(txtBoxUsername);
            Name = "SignUpForm";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private TextBox txtBoxPassword;
        private TextBox txtBoxUsername;
        private Button btnSignUp;
    }
}