using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantReviewer.Models
{
    public class Review
    {
        private string Message;
        private int userId;

        public int Id { get; set; }
        public int Score { get; set; }
        public int User { get; set; }
        public string Comment { get; set; }
        public int RestaurantId { get; set; }
        public Entities.User User1 { get; }

        public Review(int id, int score, int user, string comment, int restaurantId)
        {
            Id = id;
            Score = score;
            User = user;
            Comment = comment;
            RestaurantId = restaurantId;

        }


        public Review(int id, int score, int restaurantId, string message, Entities.User user)
        {
            Id = id;
            Score = score;
            RestaurantId = restaurantId;
            Comment = message;
            User1 = user;
        }
    }
}
