using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MauiAvondlesOef3._3
{
     class Movie
    {
        public Movie(string title, string imageUrl, string year, double rating, TimeSpan duration)
        {
            Title = title;
            ImageUrl = imageUrl;
            Year = year;
            Rating = rating;
            Duration = duration;
        }
        public string Title { get; set; }

        public string ImageUrl { get; set; }

        public string Year { get; set; }

        public double Rating { get; set; }

        public TimeSpan Duration { get; set; }



       List<Movie> movies = new List<Movie>();
       // movies.Add()


    }
}
