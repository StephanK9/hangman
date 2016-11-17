using System;
using System.Collections.Generic;

namespace Hangman.Objects
{
    public class Game
    {
        private int _guess;
        private bool _gameOver;
        private string _setWord;
        private List<string> _wordLists = new List<string> { "Venice", "Lyon", "Rio de Janeiro", "Las Vegas", "New York", "Los Angeles", "Columbus", "Cleveland", "Dallas", "Fort Worth", "New Orleans", "Portland", "San Francisco", "Tokyo", "Kyoto", "Fukushima", "Yanagawa", "Onomichi", "Sapporo", "London", "Barcelona", "Rome", "Vancouver", "Moscow", "Beijing", "Ankara", "Florence", "Houston", "Miami", "Munich", "Berlin", "Singapore", "Dubai", "Cairo", "Salem", "San Diego", "Atlanta", "Chicago", "Seattle", "New Delhi", "Ho Chi Minh City", "Macao", "Taipei", "Johannesburg", "Montreal", "Fort Lauderdale", "Tampa", "Lubbock", "El Paso", "Irvine", "Santa Fe", "Anaheim", "Lake Forest", "St Petersburg", "Krasnodar", "Sochi", "Diamond Bar", "Istanbul", "Rancho Santa Margarita", "Orange", "Riverside", "Newport Beach", "Beverly Hills", "Glendale", "Burbank", "Oakland", "Redding", "Bakersfield", "Reno", "Carson City", "Olympia", "Nice", "Paris", "Madrid", "Amsterdam", "Oslo", "Stockholm", "Reykjavik", "Hammerfest", "Tromso" };

        public Game()
        {
            _guess = 0;
            _gameOver = false;
        }

        public void AddWord(string word)
        {
            _wordLists.Add(word);
        }

        public int GetGuess()
        {
            return _guess;
        }

        public void IncreaseGuess()
        {
            _guess++;
        }

        public void ResetGuess()
        {
            _guess = 0;
        }

        public void CheckGuess()
        {
            if(_guess >= 6)
            {
                _gameOver = true;
            }
        }

        public void ChooseWord()
        {
            Random rnd = new Random();
            int whichWord = rnd.Next(0, _wordLists.Count);
            Console.WriteLine("random number: " + whichWord);
            _setWord = _wordLists[whichWord];
            Console.WriteLine("set word: " + _setWord);
        }
    }
}
