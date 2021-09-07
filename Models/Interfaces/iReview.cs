using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RestaurantReviewer.Models.ViewModels;

namespace RestaurantReviewer.Models.Interfaces
{
    public interface iReview
    {
        List<Review> GetAllReviews();
        void NewReview(ReviewDisplay rev);
        void DeleteReview(int id);
        Review GetReview(int id);

        List<Review> GetAllReviewsByRiD(int id);
        decimal AverageRating(List<Review> list);

    }
}
