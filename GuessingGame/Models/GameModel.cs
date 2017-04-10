using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GuessingGame.Models
{
    public class GameModel
    {

        [Display(Name = "Enter your name")]
        public string PlayerName { get; set; }

        [Display(Name = "What is your guess?")]
        public int Guess { get; set; }

    }
}