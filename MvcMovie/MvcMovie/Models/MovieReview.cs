﻿using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovie.Models
{
    public class MovieReview
    {
        public Movie movie { get; set; }
        public List<Review> review { get; set; }
    }
}
