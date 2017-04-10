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
        [Required(ErrorMessage = "You must enter your name")]
        [MinLength(2, ErrorMessage = "Name is too short")]
        [MaxLength(20, ErrorMessage = "Name is too long")]
        public string PlayerName { get; set; }

        [Display(Name = "What is your guess?")]
        [Required(ErrorMessage = "You must enter your guess")]
        [Range(1,10, ErrorMessage = "Guess must be between 1 and 10")]
        public int Guess { get; set; }

    }
}