using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Basics_3
{
    class Movie
    {
        public string title;
        public string actor;
        private string rating;
        public static int movieCount = 0; // it belongs to the class

        public Movie(string aTitle, string aActor, string aRating)
        {
            title = aTitle;
            actor = aActor;
            Rating = aRating;
            movieCount++; // every time a movie object is created, the count gets incremented. It shows how many instances were created.
        }

        // getters and setters

        public string Rating
        {
            get { return rating; } // get the rating

            // set the rating
            set { 
                if (value == "*" || value == "**" || value == "***" || value == "****" || value == "*****") {
                    rating = value;
                }
                else {
                    rating = "no stars at all";
                }
            } 
        }
    }
}
