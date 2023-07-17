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
    }
}
