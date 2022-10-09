﻿using System.ComponentModel.DataAnnotations;

namespace Data.Models
{
    public class TVModel
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public string Diagonal { get; set; }
        public string Resolution { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set; }

    }
}