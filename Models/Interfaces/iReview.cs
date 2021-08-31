﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantReviewer.Models.Interfaces
{
    interface iReview
    {
        List<Review> GetAllReviews();
        List<Review> GetReviewByUser(User user, int id);
        Review NewReview();
        void DeleteReview(Review review, User user);
        Review GetReview(int id);

        

    }
}
