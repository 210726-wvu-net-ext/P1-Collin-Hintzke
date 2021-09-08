using RestaurantReviewer.Models;
using System;
using Xunit;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void isAdmin()
        {
            bool test = false;
            User guy = new User
            {
                Name = "John",
                Pass = "Pass",
                IsAdmin = 1
            };
            if (guy.IsAdmin == 1)
            {
                test = true;
            }



            Assert.True(test, "isAdmin is 1 therefore true");

        }

        [Fact]
        public void CheckZip()
        {
            bool check = true;
            Restaurant rest = new Restaurant()
            {
                Id = 1,
                Name = "fooood",
                Location = "places",
                ZipCode = "525162",
            };

            foreach (char c in rest.ZipCode)
            {
                if (c < '0' || c > '9')
                    check = false;
            }

            Assert.True(check, "Zip consists of only numbers");
        }
        [Fact]
        public void CheckScore()
        {
            bool test = true;
            Review rev = new Review()
            {
                Id = 1,
                Score = 7,
                User = 2,
                Comment = "Suuup",
                RestaurantId = 1
            };
            if (rev.Score > 5)
            {
                test = false;
            }
            else if (rev.Score < 0)
            {

                test = false;

            }
            else
            {
                test = true;
            }



            Assert.False(test, "Score of the review should be between 1-5");

        }
        [Fact]
        public void AverageNumber()
        {
            //Given
            bool result = false;
            double[] numbers = { 1000, 2000, 3000, 4000, 5000 };
            int count = 0;
            int total = 0;
            foreach (int number in numbers)
            {
                total = total + number;
                count++;
            }
            double actual = total / count;
            double expected = 3000;
            //When
            if (actual == expected)
            {
                result = true;
            }
            //Then
            Assert.True(result);
        }
    }
}
