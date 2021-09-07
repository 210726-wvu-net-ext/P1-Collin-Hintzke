using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantReviewer.Models.Interfaces
{
    public interface iReview
    {
        List<Review> GetAllReviews();
        List<Review> GetReviewByUser(User user, int id);
        Review NewReview();
        void DeleteReview(Review review, User user);
        Review GetReview(int id);
        List<Review> GetAllReviewsForRestaurant(Restaurant rest);
        List<Review> GetAllReviewsByRiD(int id);

        

    }
}
