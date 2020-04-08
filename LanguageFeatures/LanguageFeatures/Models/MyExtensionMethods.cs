using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanguageFeatures.Models
{
    public static class MyExtensionMethods
    {
        // public static decimal TotalPrices(this ShoppingCart cartParam)
        public static decimal TotalPrices(this IEnumerable<Product> products)
        {
            decimal total = 0;
            foreach(Product prod in products)
            {
                total += prod?.Price ?? 0;
            }
            return total;
        }

        //4-25
        public static IEnumerable<Product> FilterByPrice(this IEnumerable<Product> productEnum, decimal minimumPrice)
        {
            foreach(Product prod in productEnum)
            {
                if((prod?.Price??0)>=minimumPrice)
                {
                    yield return prod;
                }
            }
        }

        public static IEnumerable<Product> FilterByName(this IEnumerable<Product> productEnum, char firstLetter)
        {
            foreach(Product prod in productEnum)
            {
                if(prod?.Name?[0]==firstLetter)//这个写法要看得懂？？看不懂
                {
                    yield return prod;
                }
            }
        }

        //4-29 Creating a General Filter Method(注意好好体会这个例子)
        public static IEnumerable<Product> Filter(this IEnumerable<Product> productEnum, Func<Product,bool> selector)
        {
            foreach(Product prod in productEnum)
            {
                if(selector(prod))
                {
                    yield return prod;
                }
            }
        }
    }
}
