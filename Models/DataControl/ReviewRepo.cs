using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RestaurantReviewer.Entities;
using RestaurantReviewer.Models.Interfaces;

namespace RestaurantReviewer.Models.DataControl
{
    public class ReviewRepo : iReview
    {
        private hintrestaurantdbContext _context;
        public ReviewRepo(hintrestaurantdbContext context)
        {
            _context = context;
        }


        public void DeleteReview()
        {
            throw new NotImplementedException();

        }

        public void DeleteReview(Review review, User user)
        {
            throw new NotImplementedException();
        }

        public List<Review> GetAllReviews()
        {
            throw new NotImplementedException();
        }

        public List<Review> GetAllReviewsByRiD(int id)
        {
            return _context.Ratings.Where(rate => rate.Id == id).Select(rate => new Models.Review {
                Score = rate.Score,
                Comment = rate.Message,
            }).ToList();
        }

        public List<Review> GetAllReviewsForRestaurant(Restaurant rest)
        {
            return _context.Ratings.Where(rate => rate.Id == rest.Id).Select(rate => new Models.Review {
                Score = rate.Score,
                Comment = rate.Message,
                }).ToList();
        }

        public Review GetReview(int id)
        {
            throw new NotImplementedException();
        }

        public List<Review> GetReviewByUser(int id)
        {
            throw new NotImplementedException();
        }

        public List<Review> GetReviewByUser(User user, int id)
        {
            throw new NotImplementedException();
        }

        public Review NewReview()
        {
            throw new NotImplementedException();
        }
    }
}
