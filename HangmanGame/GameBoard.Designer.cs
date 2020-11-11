namespace HangmanGame
{
    partial class GameBoard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_MaskedWord = new System.Windows.Forms.Label();
            this.textBox_UserGuesses = new System.Windows.Forms.TextBox();
            this.label_wrongGuessedLetters = new System.Windows.Forms.Label();
            this.label_AlreadyGuessed = new System.Windows.Forms.Label();
            this.label_WrongguessedLettersMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_MaskedWord
            // 
            this.label_MaskedWord.AutoSize = true;
            this.label_MaskedWord.BackColor = System.Drawing.SystemColors.Highlight;
            this.label_MaskedWord.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label_MaskedWord.Location = new System.Drawing.Point(342, 138);
            this.label_MaskedWord.Name = "label_MaskedWord";
            this.label_MaskedWord.Size = new System.Drawing.Size(0, 15);
            this.label_MaskedWord.TabIndex = 0;
            // 
            // textBox_UserGuesses
            // 
            this.textBox_UserGuesses.Location = new System.Drawing.Point(322, 166);
            this.textBox_UserGuesses.Name = "textBox_UserGuesses";
            this.textBox_UserGuesses.Size = new System.Drawing.Size(100, 23);
            this.textBox_UserGuesses.TabIndex = 1;
            this.textBox_UserGuesses.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_UserGuesses_KeyDown);
            // 
            // label_wrongGuessedLetters
            // 
            this.label_wrongGuessedLetters.AutoSize = true;
            this.label_wrongGuessedLetters.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label_wrongGuessedLetters.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_wrongGuessedLetters.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label_wrongGuessedLetters.Location = new System.Drawing.Point(263, 286);
            this.label_wrongGuessedLetters.Name = "label_wrongGuessedLetters";
            this.label_wrongGuessedLetters.Size = new System.Drawing.Size(227, 21);
            this.label_wrongGuessedLetters.TabIndex = 2;
            this.label_wrongGuessedLetters.Text = "Displays wrong Guessed letters";
            // 
            // label_AlreadyGuessed
            // 
            this.label_AlreadyGuessed.AutoSize = true;
            this.label_AlreadyGuessed.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label_AlreadyGuessed.Location = new System.Drawing.Point(322, 206);
            this.label_AlreadyGuessed.Name = "label_AlreadyGuessed";
            this.label_AlreadyGuessed.Size = new System.Drawing.Size(124, 15);
            this.label_AlreadyGuessed.TabIndex = 3;
            this.label_AlreadyGuessed.Text = "alreadyGuessedLetters";
            // 
            // label_WrongguessedLettersMessage
            // 
            this.label_WrongguessedLettersMessage.AutoSize = true;
            this.label_WrongguessedLettersMessage.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label_WrongguessedLettersMessage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_WrongguessedLettersMessage.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label_WrongguessedLettersMessage.Location = new System.Drawing.Point(306, 250);
            this.label_WrongguessedLettersMessage.Name = "label_WrongguessedLettersMessage";
            this.label_WrongguessedLettersMessage.Size = new System.Drawing.Size(162, 21);
            this.label_WrongguessedLettersMessage.TabIndex = 4;
            this.label_WrongguessedLettersMessage.Text = "Wrong guessed letter:";
            // 
            // GameBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Controls.Add(this.label_WrongguessedLettersMessage);
            this.Controls.Add(this.label_AlreadyGuessed);
            this.Controls.Add(this.label_wrongGuessedLetters);
            this.Controls.Add(this.textBox_UserGuesses);
            this.Controls.Add(this.label_MaskedWord);
            this.Name = "GameBoard";
            this.Size = new System.Drawing.Size(820, 493);
            this.Load += new System.EventHandler(this.GameBoard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_MaskedWord;
        private System.Windows.Forms.TextBox textBox_UserGuesses;
        private System.Windows.Forms.Label label_wrongGuessedLetters;
        private System.Windows.Forms.Label label_AlreadyGuessed;
        private System.Windows.Forms.Label label_WrongguessedLettersMessage;
    }
}
