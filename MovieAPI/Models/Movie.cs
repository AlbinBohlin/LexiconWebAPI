using MovieAPI.Models;

namespace MovieAPI.Items
{
    public class Movie
    {
        public int Id{ get; set; }
        public int Year { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public TimeSpan Duration { get; set; } = TimeSpan.FromMinutes(Random.Shared.Next(80,240));

        public List<Review> reviews { get; set; } = []; 

    }
}
