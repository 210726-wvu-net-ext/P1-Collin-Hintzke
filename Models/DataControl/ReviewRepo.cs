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
            List<Review> list = _context.Ratings.Select(
                Review => new Review(Review.Id, Review.Score, Review.RestaurantId, Review.Message, Review.User)
            ).ToList();
            List<Review> query = list.Where(Review => Review.RestaurantId == id).ToList();
            query.Reverse();
            return query;
        }

        public List<Review> GetAllReviewsForRestaurant(Restaurant rest)
        {
            /* return _context.Ratings.Where(rate => rate.Id == rest.Id).Select(rate => new Review {
                 Score = rate.Score,
                 Comment = rate.Message,
                 User = rate.UserId,
                 RestaurantId = rate.RestaurantId
                 }).ToList();*/

            throw new NotImplementedException();

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
