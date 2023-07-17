
namespace ProjectManagmentLinq
{
    public class Program
    {
        public static void Main(String[] args)
        {

            Console.WriteLine("Welcome to Linq Program");

            List<Productreview> listobj = new List<Productreview>();

            {
                new Productreview() { ProductID = 1, Userid = 1, rating = 3, Review = "good", Islike = true };
                new Productreview() { ProductID = 2, Userid = 2, rating = 3, Review = "Wrost", Islike = false };
                new Productreview() { ProductID = 2, Userid = 3, rating = 5, Review = "very good", Islike = true };
                new Productreview() { ProductID = 4, Userid = 4, rating = 3, Review = "bad", Islike = false };
                new Productreview() { ProductID = 6, Userid = 5, rating = 5, Review = "Excellent", Islike = true };
                new Productreview() { ProductID = 6, Userid = 6, rating = 3, Review = "Wrost", Islike = false };
                new Productreview() { ProductID = 6, Userid = 7, rating = 4, Review = "good", Islike = true };
                new Productreview() { ProductID = 8, Userid = 8, rating = 5, Review = "Excellent", Islike = true };
                new Productreview() { ProductID = 9, Userid = 9, rating = 3, Review = "bad", Islike = false };
                new Productreview() { ProductID = 10, Userid = 10, rating = 5, Review = "Very good", Islike = true };
            };

            foreach (var product in listobj)
            {
                Console.WriteLine("******************");
                Console.WriteLine(product.ProductID + "  | " + product.Userid + "  | " + product.rating + " | " + product.Review + " | " + product.Islike);
            }

           // Managemenent.Top3Records(listobj);
            Managemenent.GetSelectedValues(listobj);
        }
    }
}