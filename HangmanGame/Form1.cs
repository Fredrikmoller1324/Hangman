﻿using HangmanLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HangmanGame
{
    public partial class Form1_start : Form
    {
        private GameBoard gameBoard;
        public Form1_start()
        {
            InitializeComponent();
        }

        private void Form1_start_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox_UserNameInput_Click(object sender, EventArgs e)
        {
            textBox_UserNameInput.Clear();
        }

        private void button_PlayGame_Click(object sender, EventArgs e)
        {
            if(textBox_UserNameInput.Text.Length > 1)
            {
                Player PlayerName = new Player(textBox_UserNameInput.Text);
                gameBoard = new GameBoard();
                Controls.Add(gameBoard);
                gameBoard.Dock = DockStyle.Fill;
                gameBoard.Visible = true;
                gameBoard.BringToFront();
            }
            else
            {
                MessageBox.Show("Yuor name needs to be longer than 1 letter!", "Wrong Input");
            }
        }
    }
}
