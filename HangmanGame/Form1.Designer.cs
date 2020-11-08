namespace HangmanGame
{
    partial class Form1_start
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_WelcomeToGame = new System.Windows.Forms.Label();
            this.textBox_UserNameInput = new System.Windows.Forms.TextBox();
            this.button_PlayGame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_WelcomeToGame
            // 
            this.label_WelcomeToGame.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_WelcomeToGame.AutoSize = true;
            this.label_WelcomeToGame.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_WelcomeToGame.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_WelcomeToGame.Location = new System.Drawing.Point(210, 119);
            this.label_WelcomeToGame.Name = "label_WelcomeToGame";
            this.label_WelcomeToGame.Size = new System.Drawing.Size(365, 46);
            this.label_WelcomeToGame.TabIndex = 0;
            this.label_WelcomeToGame.Text = "Welcome to Hangman!";
            // 
            // textBox_UserNameInput
            // 
            this.textBox_UserNameInput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_UserNameInput.Location = new System.Drawing.Point(323, 181);
            this.textBox_UserNameInput.Name = "textBox_UserNameInput";
            this.textBox_UserNameInput.Size = new System.Drawing.Size(132, 23);
            this.textBox_UserNameInput.TabIndex = 1;
            this.textBox_UserNameInput.Text = "Enter a Name";
            this.textBox_UserNameInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_UserNameInput.Click += new System.EventHandler(this.textBox_UserNameInput_Click);
            this.textBox_UserNameInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_UserNameInput_KeyDown);
            // 
            // button_PlayGame
            // 
            this.button_PlayGame.Location = new System.Drawing.Point(337, 230);
            this.button_PlayGame.Name = "button_PlayGame";
            this.button_PlayGame.Size = new System.Drawing.Size(102, 40);
            this.button_PlayGame.TabIndex = 2;
            this.button_PlayGame.Text = "Play Game";
            this.button_PlayGame.UseVisualStyleBackColor = true;
            this.button_PlayGame.Click += new System.EventHandler(this.button_PlayGame_Click);
            // 
            // Form1_start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_PlayGame);
            this.Controls.Add(this.textBox_UserNameInput);
            this.Controls.Add(this.label_WelcomeToGame);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1_start";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hangman";
            this.Load += new System.EventHandler(this.Form1_start_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_WelcomeToGame;
        private System.Windows.Forms.TextBox textBox_UserNameInput;
        private System.Windows.Forms.Button button_PlayGame;
    }
}

