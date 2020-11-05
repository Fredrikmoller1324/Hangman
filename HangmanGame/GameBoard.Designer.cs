﻿namespace HangmanGame
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
            this.SuspendLayout();
            // 
            // label_MaskedWord
            // 
            this.label_MaskedWord.AutoSize = true;
            this.label_MaskedWord.BackColor = System.Drawing.SystemColors.Highlight;
            this.label_MaskedWord.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label_MaskedWord.Location = new System.Drawing.Point(234, 111);
            this.label_MaskedWord.Name = "label_MaskedWord";
            this.label_MaskedWord.Size = new System.Drawing.Size(94, 15);
            this.label_MaskedWord.TabIndex = 0;
            this.label_MaskedWord.Text = "Guess the word: ";
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
            this.label_wrongGuessedLetters.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label_wrongGuessedLetters.Location = new System.Drawing.Point(322, 221);
            this.label_wrongGuessedLetters.Name = "label_wrongGuessedLetters";
            this.label_wrongGuessedLetters.Size = new System.Drawing.Size(38, 15);
            this.label_wrongGuessedLetters.TabIndex = 2;
            this.label_wrongGuessedLetters.Text = "label1";
            // 
            // GameBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Controls.Add(this.label_wrongGuessedLetters);
            this.Controls.Add(this.textBox_UserGuesses);
            this.Controls.Add(this.label_MaskedWord);
            this.Name = "GameBoard";
            this.Size = new System.Drawing.Size(687, 440);
            this.Load += new System.EventHandler(this.GameBoard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_MaskedWord;
        private System.Windows.Forms.TextBox textBox_UserGuesses;
        private System.Windows.Forms.Label label_wrongGuessedLetters;
    }
}