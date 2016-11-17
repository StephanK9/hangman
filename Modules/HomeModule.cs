using Nancy;
using Hangman.Objects;
using System;
using System.Collections.Generic;

namespace Hangman
{
    public class HomeModule : NancyModule
    {
        public HomeModule()
        {
            Get["/"] = _ => {
                Game.ChooseWord();
                Game.ResetEverything();
                Game newGame = new Game();
                return View["index.cshtml", newGame];
            };
            Post["/"] = _ => {
                string userGuess = Request.Form["user-guess"];
                userGuess = userGuess.ToLower();

                if(!Game.GetGameWin() && !Game.GetGameLose())
                {
                    if(Game.GetSetWord().Contains(userGuess))
                    {
                        Game.SetCurrentGuess(userGuess);
                        Game.AddGoodGuess(userGuess);
                    }
                    else
                    {
                        Game.AddBadGuess(userGuess);
                        Game.IncreaseGuess();
                    }
                }
                Game.CheckGuess();
                Game.CheckWin();
                Game newGame = new Game();
                return View["index.cshtml", newGame];
            };
        }
    }
}
