﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public String Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public String Genre { get; set; }
        public decimal Price { get; set; }
    }
}
