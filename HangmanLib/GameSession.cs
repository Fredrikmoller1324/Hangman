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
            gameWords.Add("car".ToUpper());
            gameWords.Add("pilot".ToUpper());
            gameWords.Add("ball".ToUpper());
            gameWords.Add("weiner".ToUpper());
            gameWords.Add("mouse".ToUpper());
            gameWords.Add("dog".ToUpper());
            gameWords.Add("ape".ToUpper());
            gameWords.Add("mustard".ToUpper());
            gameWords.Add("computerengineer".ToUpper());
            gameWords.Add("xenotransplantation".ToUpper());

            return gameWords;
        }
    }
}
