﻿using GigHub.Models;
using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations;

namespace GigHub.ViewModels
{
    public class GigViewModel
    {
       
        [Required]
        public string Venue { get; set; }

        [Required]
        [FutureDate]
        public string Date { get; set; }

        [Required]
        [ValidTime]
        public string Time { get; set; }

        [Required]
        public byte Genre { get; set; }
        public IEnumerable<Genre> Genres { get; set; }
        public DateTime GetDateTime() {
                return DateTime.Parse($"{Date} {Time}");
        }
    }
}