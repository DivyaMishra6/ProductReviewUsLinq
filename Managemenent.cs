using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagmentLinq
{
    public class Managemenent
    {
        public static void Top3Records(List<Productreview> listobj)
        {
            var Product = (from product in listobj orderby product.rating descending select product).Take(3);

            foreach (var product in Product)
            {
                Console.WriteLine("*************");
                Console.WriteLine(product.ProductID + " | " + product.Userid + " | " + product.rating + " | " + product.Review + "  | " + product.Islike);
                Console.WriteLine("*************");
            }
        }

        public static void GetSelectedValues(List<Productreview> listobj)
        {
            var ProductData = from product in listobj
                              where (product.ProductID == 1 && product.rating > 3 ||
                              product.ProductID == 4 && product.rating > 3 ||
                              product.ProductID == 9 && product.rating > 3)
                              select product;

            foreach (var product in ProductData)
            {
                Console.WriteLine("*************");
                Console.WriteLine(product.ProductID + " | " + product.Userid + " | " + product.rating + " | " + product.Review + "  | " + product.Islike);
                Console.WriteLine("*************");
            }
        }

        public static void GetCount(List<Productreview> listobj)
        {
            var productdata = listobj.GroupBy(x => x.ProductID).Select(x => new { ProductID = x.Key, Count = x.Count() });
            foreach (var product in productdata)
            {
                Console.WriteLine(product.ProductID + " " + product.Count);
            }
        }
    }
}
