using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using HangmanLib;

namespace HangmanGame
{
    public partial class GameBoard : UserControl
    {
        GameSession gameSession;
        private string GameWord { get; set; }
        public GameBoard()
        {
            InitializeComponent();
        }

        private void GameBoard_Load(object sender, EventArgs e)
        {
            label_wrongGuessedLetters.Text = "";
            gameSession = new GameSession();

            List<string> wordForHangman = gameSession.AddGameWords();
            Random rnd = new Random();
            int gameWordIndex = rnd.Next(wordForHangman.Count);

            string gameWord = wordForHangman[gameWordIndex];
            GameWord = gameWord;
            for (int i = 0; i < gameWord.Length; i++)
            {
                label_MaskedWord.Text += "* ";
            }

        }

        private void textBox_UserGuesses_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter && textBox_UserGuesses.TextLength == 1)
            {
                if(GameWord.Contains(textBox_UserGuesses.Text.ToUpper()))
                {

                }
                else
                {
                    label_wrongGuessedLetters.Text += textBox_UserGuesses.Text;
                    textBox_UserGuesses.Clear();
                }
                e.SuppressKeyPress = true;

            }
            else if(e.KeyCode == Keys.Enter && textBox_UserGuesses.TextLength > 1)
            {
                MessageBox.Show("You can only enter one letter a time!", "Wrong input error");
            }
            else if (e.KeyCode == Keys.Enter && textBox_UserGuesses.TextLength == 0)
            {
                MessageBox.Show("Empty field", "Wrong input error");
            }
        }
    }
}
