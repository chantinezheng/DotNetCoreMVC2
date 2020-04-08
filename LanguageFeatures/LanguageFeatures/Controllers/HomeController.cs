using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LanguageFeatures.Models;
using Microsoft.AspNetCore.Mvc;

namespace LanguageFeatures.Controllers
{
    public class HomeController : Controller
    {
        //Listing 4-30. Using a Function to Filter Objects
        bool FilterByPrice(Product p)
        {
            return (p?.Price ?? 0) >= 20;
        }
        public IActionResult Index()
        {
            //return View(new string[] { "C#","Language","Features"});

            //4-5
            //List<string> results = new List<string>();
            //foreach(Product p in Product.GetProducts())
            //{
            //    string name = p?.Name??"<No Name>";
            //    decimal? price = p?.Price??0;
            //    string relatedName = p?.Related?.Name??"<None>";
            //    results.Add(string.Format("Name: {0}, Price: {1},Related:{2}", name, price,relatedName));
            //}
            //return View(results);

            //4-17
            //object[] data = new object[]
            //{
            //    275M,29.95M,"APPLE","orange",100,10
            //};
            //decimal total = 0;
            //for (int i = 0; i < data.Length;i++)
            //{
            //    if(data[i] is decimal d)//is是检验类型，如果是decimal，就要赋值给d; 注意只有上面两个带M是decimal
            //        //100和10不是decimal类型的
            //    {
            //        total += d;
            //    }
            //}
            //return View("Index",new string[] {$"Total:{total:C2}" });//??为什么要这么写

            //4-18 Pattern Matching in Switch Statements(有空要补充)

            //4-21 Applying an Extension Method in the HomeController.cs File in the Controllers Folder
            //ShoppingCart cart = new ShoppingCart { Products=Product.GetProducts()};
            //decimal cartTotal = cart.TotalPrices();
            //return View("Index", new string[] { $"Total:{cartTotal:C2}" });

            //4-24. Applying an Extension Method in the HomeController.cs File in the Controllers Folder
            //ShoppingCart cart = new ShoppingCart { Products = Product.GetProducts() };

            //Product[] productArray =
            //{
            //    new Product{Name="Kayak",Price=275M},
            //    new Product{Name="Lifejacket",Price=48.95M}
            //};

            //decimal cartTotal = cart.TotalPrices();
            //decimal arrayTotal = productArray.TotalPrices();

            //return View("Index", new string[]
            //{
            //    $"Cart Total: {cartTotal:C2}",
            //    $"Array Total: {arrayTotal:C2}"
            //});

            ////4-26 Using the Filtering Extension Method
            //Product[] productArray =
            //{
            //    new Product{Name="Kayak",Price=275M},
            //    new Product{Name="Lifejacket",Price=48.95M},
            //     new Product{Name="Soccer ball",Price=19.5M},
            //    new Product{Name="Corner flag",Price=34.95M}
            //};
            //decimal arrayTotal = productArray.FilterByPrice(20).TotalPrices();
            //return View("Index", new string[] { $"Array Total:{arrayTotal:C2}" });

            ////4-28 Using Two Filter Methods 
            //Product[] productArray =
            //{
            //    new Product{Name="Kayak",Price=275M},
            //    new Product{Name="Lifejacket",Price=48.95M},
            //     new Product{Name="Soccer ball",Price=19.5M},
            //    new Product{Name="Corner flag",Price=34.95M}
            //};
            //decimal arrayTotal = productArray.FilterByPrice(20).TotalPrices();
            //decimal nameFilterTotal = productArray.FilterByName('S').TotalPrices();
            //return View("Index", new string[] { $"Array Total:{arrayTotal:C2}" ,
            //                                    $"Name Total:{nameFilterTotal:C2}"});

            ////4-30 Using a Function to Filter Objects
            //Func<Product, bool> nameFilter = delegate (Product prod)
            //   {
            //       return prod?.Name?[0] == 'S';
            //   };
            //Product[] productArray =
            //{
            //    new Product{Name="Kayak",Price=275M},
            //    new Product{Name="Lifejacket",Price=48.95M},
            //     new Product{Name="Soccer ball",Price=19.5M},
            //    new Product{Name="Corner flag",Price=34.95M}
            //};

            //Listing 4-30. Using a Function to Filter Objects
            //decimal priceFilterTotal = productArray.Filter(FilterByPrice).TotalPrices();
            //decimal nameFilterTotal = productArray.Filter(nameFilter).TotalPrices();

            //Listing 4 - 31.Using Lambda Expression
            //decimal priceFilterTotal = productArray.Filter(p => (p?.Price ?? 0) > 20).TotalPrices();
            //decimal nameFilterTotal = productArray.Filter(p => p?.Name?[0] == 'S').TotalPrices();

            //return View("Index", new string[] { $"Array Total:{priceFilterTotal:C2}" ,
            //                                    $"Name Total:{nameFilterTotal:C2}"});

            //Listing 4-36. Creating an Anonymous Type
            //var products = new[]
            //{
            //   new {Name="Kayak",Price=275M},
            //   new {Name="Lifejacket",Price=48.95M},
            //   new  {Name="Soccer ball",Price=19.5M},
            //   new {Name="Corner flag",Price=34.95M}
            //};
            //// return View(products.Select(p => p.Name));

            ////Listing 4-37. Displaying the Type Name
            //return View(products.Select(p => p.GetType().Name));



        }
    }
}