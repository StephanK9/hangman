using System;
using System.Collections.Generic;

namespace Hangman.Objects
{
    public class Game
    {
        private static int _guess = 0;
        private static bool _gameLose = false;
        private static bool _gameWin = false;
        private static string _setWord;
        private static string _currentGuess;
        private static List<string> _wordStatuses = new List<string> {};
        private static List<string> _badGuesses = new List<string> {};
        private static List<string> _wordLists = new List<string> { "Venice", "Lyon", "Rio de Janeiro", "Las Vegas", "New York", "Los Angeles", "Columbus", "Cleveland", "Dallas", "Fort Worth", "New Orleans", "Portland", "San Francisco", "Tokyo", "Kyoto", "Fukushima", "Yanagawa", "Onomichi", "Sapporo", "London", "Barcelona", "Rome", "Vancouver", "Moscow", "Beijing", "Ankara", "Florence", "Houston", "Miami", "Munich", "Berlin", "Singapore", "Dubai", "Cairo", "Salem", "San Diego", "Atlanta", "Chicago", "Seattle", "New Delhi", "Ho Chi Minh City", "Macao", "Taipei", "Johannesburg", "Montreal", "Fort Lauderdale", "Tampa", "Lubbock", "El Paso", "Irvine", "Santa Fe", "Anaheim", "Lake Forest", "St Petersburg", "Krasnodar", "Sochi", "Diamond Bar", "Istanbul", "Rancho Santa Margarita", "Orange", "Riverside", "Newport Beach", "Beverly Hills", "Glendale", "Burbank", "Oakland", "Redding", "Bakersfield", "Reno", "Carson City", "Olympia", "Nice", "Paris", "Madrid", "Amsterdam", "Oslo", "Stockholm", "Reykjavik", "Hammerfest", "Tromso" };
        private int _guessMobile = 0;
        private string _setWordMobile;
        private string _currentGuessMobile;
        private bool _gameLoseMobile;
        private bool _gameWinMobile;
        private List<string> _wordStatusesMobile = new List<string> {};
        private List<string> _badGuessesMobile = new List<string> {};

        public Game()
        {
            UpdateGame();
        }

        public void UpdateGame()
        {
            _guessMobile = _guess;
            _setWordMobile = _setWord;
            _currentGuessMobile = _currentGuess;
            _wordStatusesMobile = _wordStatuses;
            _badGuessesMobile = _badGuesses;
            _gameLoseMobile = _gameLose;
            _gameWinMobile = _gameWin;
        }

        public static List<string> GetWordStatus()
        {
            return _wordStatuses;
        }

        public List<string> GetWordStatusM()
        {
            return _wordStatusesMobile;
        }

        public static void SetCurrentGuess(string guess)
        {
            _currentGuess = guess;
        }

        public static string GetCurrentGuess()
        {
            return _currentGuess;
        }

        public string GetCurrentGuessM()
        {
            return _currentGuessMobile;
        }

        public static void AddWord(string word)
        {
            _wordLists.Add(word);
        }

        public static void AddBadGuess(string letter)
        {
            _badGuesses.Add(letter);
        }

        public static List<string> GetBadGuesses()
        {
            return _badGuesses;
        }

        public List<string> GetBadGuessesM()
        {
            return _badGuessesMobile;
        }

        public static int GetGuess()
        {
            return _guess;
        }

        public int GetGuessM()
        {
            return _guessMobile;
        }

        public static void IncreaseGuess()
        {
            _guess++;
        }

        public static void ResetEverything()
        {
            _guess = 0;
            _badGuesses = new List<string> {};
            _gameLose = false;
            _gameWin = false;
        }

        public static void CheckGuess()
        {
            if(_guess >= 6)
            {
                _gameLose = true;
            }
        }

        public static void CheckWin()
        {
            if(!_wordStatuses.Contains("__"))
            {
                _gameWin = true;
            }
        }

        public static bool GetGameWin()
        {
            return _gameWin;
        }

        public static bool GetGameLose()
        {
            return _gameLose;
        }

        public bool GetGameWinM()
        {
            return _gameWinMobile;
        }

        public bool GetGameLoseM()
        {
            return _gameLoseMobile;
        }

        public static void ChooseWord()
        {
            _wordStatuses = new List<string> {};
            Random rnd = new Random();
            int whichWord = rnd.Next(0, _wordLists.Count);
            _setWord = _wordLists[whichWord].ToLower();

            for(int index = 0; index < _setWord.Length; index++)
            {
                if(_setWord[index].ToString() == " ")
                {
                    _wordStatuses.Add("|");
                }
                else
                {
                    _wordStatuses.Add("__");
                }
            }
        }

        public static void AddGoodGuess(string guess) {
            for(int index = 0; index < _setWord.Length; index++)
            {
                string compareLetter = _setWord[index].ToString();
                if(compareLetter == guess)
                {
                    _wordStatuses[index] = guess;
                }
            }
        }

        public static string GetSetWord()
        {
            return _setWord;
        }

        public string GetSetWordM()
        {
            return _setWordMobile;
        }
    }
}
