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
                return View["index.cshtml"];
            };
        }
    }
}
