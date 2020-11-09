using HangmanLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;
using System.Media;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Policy;

namespace HangmanGame
{
    public partial class Form1_start : Form
    {
        WindowsMediaPlayer wPlayer = new WindowsMediaPlayer();
        public Player playerName;
        private GameBoard gameBoard;
        public Form1_start()
        {
            InitializeComponent();
        }

        private void Form1_start_Load(object sender, EventArgs e)
        {
            // tar ut pathway till project som behöver kombineras för att få ut resourcesmappen där låten är lagrad
            string projectpath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string UrlMusic = Path.Combine(projectpath, "Resources\\Cuckoo's Nest - Nat Keefe & Hot Buttered Rum.mp3");
            wPlayer.URL = UrlMusic;
            
            wPlayer.controls.play();
            wPlayer.settings.setMode("loop", true);
            wPlayer.settings.volume = 2;

        }

        private void textBox_UserNameInput_Click(object sender, EventArgs e)
        {
            textBox_UserNameInput.Clear();
        }
        private void StartGameSession()
        {
            if (textBox_UserNameInput.Text.Length > 1)
            {
                string playersname = textBox_UserNameInput.Text;
                playerName = new Player(playersname);
                gameBoard = new GameBoard();
                Controls.Add(gameBoard);
                gameBoard.Dock = DockStyle.Fill;
                gameBoard.Visible = true;
                gameBoard.BringToFront();
            }
            else
            {
                MessageBox.Show("Your name needs to be longer than 1 letter!", "Wrong Input");
            }
        }

        private void button_PlayGame_Click(object sender, EventArgs e)
        {
            StartGameSession();
        }

        private void textBox_UserNameInput_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter) { StartGameSession(); e.SuppressKeyPress = true; }
        }

        private void button_muteMusic_Click(object sender, EventArgs e)
        {
            if (wPlayer.settings.volume > 0) { wPlayer.settings.volume = 0; }
            else { wPlayer.settings.volume = 2; }
        }
    }
}
