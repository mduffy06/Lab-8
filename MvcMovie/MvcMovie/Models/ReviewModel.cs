using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovie.Models
{
    public class ReviewModel
    {
        public MovieReview MovieReview { get; set; }
        public MovieGenreViewModel MovieGenre { get; set; }

    }
}
