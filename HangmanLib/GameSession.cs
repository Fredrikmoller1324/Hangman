using System;
using System.Collections.Generic;
using System.Text;

namespace HangmanLib
{
    public class GameSession
    {
        private List<string> gameWords = new List<string>();

        public List<string> AddGameWords()
        {
            gameWords.Add("Car".ToUpper());
            //gameWords.Add("pilot".ToUpper());
            //gameWords.Add("boll".ToUpper());
            //gameWords.Add("korv".ToUpper());
            //gameWords.Add("mus".ToUpper());
            return gameWords;
        }
    }
}
