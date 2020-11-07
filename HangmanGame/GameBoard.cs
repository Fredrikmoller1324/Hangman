using HangmanLib;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace HangmanGame
{
    public partial class GameBoard : UserControl
    {
        GameSession gameSession;
        public string GameWord { get; set; }
        public GameBoard()
        {
            InitializeComponent();
        }

        private void GameBoard_Load(object sender, EventArgs e)
        {
            label_wrongGuessedLetters.Text = "";
            gameSession = new GameSession();
            label_AlreadyGuessed.Text = "";
            label_AlreadyGuessed.Visible = false;

            List<string> wordForHangman = gameSession.AddGameWords();
            Random rnd = new Random();
            int gameWordIndex = rnd.Next(wordForHangman.Count);

            string gameWord = wordForHangman[gameWordIndex];
            GameWord = gameWord;
            for (int i = 0; i < gameWord.Length; i++)
            {
                label_MaskedWord.Text += "*";
            }

        }

        private void textBox_UserGuesses_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && textBox_UserGuesses.TextLength == 1)
            {
                if (!GameWord.Contains(textBox_UserGuesses.Text.ToUpper()))
                {
                    if (label_wrongGuessedLetters.Text.Contains(textBox_UserGuesses.Text.ToUpper()))
                    {
                        label_AlreadyGuessed.Text = "You already guessed that letter";
                        label_AlreadyGuessed.Visible = true;
                    }
                    else
                    {
                        label_AlreadyGuessed.Visible = false;
                        label_wrongGuessedLetters.Text += $"{textBox_UserGuesses.Text.ToUpper()} ";
                        textBox_UserGuesses.Clear();
                    }
                }
                else
                {
                    List<int> indicesOfCorrectLetter = new List<int>();
                    //Checkar varje char i rätta spelordet om en char i spelordet matchar char i spelarens input textbox.
                    // om det inte matchar öka index med 1, om det matchar, spara först det index-värdet i list med alla matachande indexvärden
                    //sen öka index med 1 igen
                    int index = 0;
                    foreach (char letter in GameWord)
                    {
                        if(letter == char.Parse(textBox_UserGuesses.Text.ToUpper()))
                        {
                            indicesOfCorrectLetter.Add(index);
                        }
                        index++;
                    }

                    //skapar en temporär char-array som innehållar alla chars i labeln med maskerade chars
                    //(som är lika lång som antalet chars i rätta spelordet)
                    char[] temp = label_MaskedWord.Text.ToCharArray();

                    //går igenom alla matchande indices som var sparat i listan
                    //och ersätter maskerad labels "*" med spelarens input från textbox på inskickade index-värden
                    // plussa med 1 pga label är * + space
                    foreach (int  i in indicesOfCorrectLetter)
                    {
                        if(i == 0)
                        {
                            temp[i] = char.Parse(textBox_UserGuesses.Text);
                        }
                        else
                        {
                            temp[i] = char.Parse(textBox_UserGuesses.Text);
                        }
                    }
                    label_MaskedWord.Text = new string(temp).ToUpper();
                    textBox_UserGuesses.Clear();
                    
                    if(label_MaskedWord.Text == GameWord)
                    {
                        VictoryScreen victoryScreen = new VictoryScreen(GameWord);
                        Controls.Add(victoryScreen);
                        victoryScreen.Visible = true;
                        victoryScreen.BringToFront();
                        victoryScreen.Dock = DockStyle.Fill;
                        victoryScreen.BackColor = Color.AntiqueWhite;
                    }




                }
                e.SuppressKeyPress = true;

            }
            else if (e.KeyCode == Keys.Enter && textBox_UserGuesses.TextLength > 1)
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
