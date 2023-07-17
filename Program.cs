
namespace ProjectManagmentLinq
{
    public class Program
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Welcome to Product Review Managment Program!!!");

            List<ProductReview> ProductReviewList = new List<ProductReview>()
            {
                new ProductReview(){Productid = 1,UserID = 10,Rating=5,Review="Good",IsLike=true},
                new ProductReview(){Productid = 2,UserID = 11,Rating=4,Review="Nice",IsLike=true},
                new ProductReview(){Productid = 3,UserID = 12,Rating=3,Review="Average",IsLike=true},
                new ProductReview(){Productid = 4,UserID = 13,Rating=4,Review="Nice",IsLike=true},
                new ProductReview(){Productid = 5,UserID = 14,Rating=5,Review="Good",IsLike=true}

            };
        }
    }
}