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
    public partial class VictoryScreen : UserControl
    {
        private string WinningWord { get; set;}
        public VictoryScreen(string winningWord)
        {
            InitializeComponent();
            WinningWord = winningWord;
        }

        private void VictoryScreen_Load(object sender, EventArgs e)
        {
            label_Congratz.Text = $"Congratulation {Player.Name}, you won!";
            GameBoard wonGame = new GameBoard();
            label_Gameword.Text = $"The correct word was: {WinningWord} ";
        }
    }
}
