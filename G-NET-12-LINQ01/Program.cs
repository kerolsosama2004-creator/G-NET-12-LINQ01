using System.Buffers.Text;
using System.Diagnostics.Metrics;
using System.Globalization;

namespace G_NET_12_LINQ01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region LINQ01 assignment

            //1.Get all products from "Seafood"
            //var seafoodProducts = ProductList
            //   .Where(p => p.Category == "Seafood");

            //foreach (var p in seafoodProducts)
            //{
            //    Console.WriteLine($"{p.ProductName} - {p.UnitPrice}");
            //} 
            //==========================================================================
            //2.Get only product names
            //var productNames = ProductList
            //    .Select(p => p.ProductName);

            //foreach (var name in productNames)
            //{
            //    Console.WriteLine(name);
            //}
            //==========================================================================
            //3.Sort by UnitPrice(ascending)
            //var sortedProducts = ProductList
            //    .OrderBy(p => p.UnitPrice);

            //foreach (var p in sortedProducts)
            //{
            //    Console.WriteLine($"{p.ProductName} - {p.UnitPrice}");
            //}
            //==========================================================================
            //4.Products with price between 10 and 30
            //var filteredProducts = ProductList
            //    .Where(p => p.UnitPrice >= 10 && p.UnitPrice <= 30);

            //foreach (var p in filteredProducts)
            //{
            //    Console.WriteLine($"{p.ProductName} - {p.UnitPrice}");
            //}
            //==========================================================================
            //5.In stock + "Condiments"
            //var condimentsInStock = ProductList
            //    .Where(p => p.UnitsInStock > 0 && p.Category == "Condiments");

            //foreach (var p in condimentsInStock)
            //{
            //    Console.WriteLine($"{p.ProductName}");
            //}
            //==========================================================================
            //6.Anonymous type
            //var result = ProductList.Select(p => new
            //{
            //    Name = p.ProductName,
            //    Price = p.UnitPrice,
            //    StockStatus = p.UnitsInStock > 0 ? "Available" : "Out of Stock"
            //});

            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item.Name} - {item.Price} - {item.StockStatus}");
            //}
            //==========================================================================
            //7.Print with position(1 - based)
            //var indexed = ProductList
            //    .Select((p, index) => new { Index = index + 1, Name = p.ProductName });

            //foreach (var item in indexed)
            //{
            //    Console.WriteLine($"{item.Index}. {item.Name}");
            //}
            //==========================================================================
            //8.Sort by Category asc, then UnitPrice desc
            //var sorted = ProductList
            //    .OrderBy(p => p.Category)
            //    .ThenByDescending(p => p.UnitPrice);

            //foreach (var p in sorted)
            //{
            //    Console.WriteLine($"{p.Category} - {p.ProductName} - {p.UnitPrice}");
            //}
            //==========================================================================
            //9.Beverages sorted by stock descending
            //var beverages = ProductList
            //    .Where(p => p.Category == "Beverages")
            //    .OrderByDescending(p => p.UnitsInStock);

            //foreach (var p in beverages)
            //{
            //    Console.WriteLine($"{p.ProductName} - {p.UnitsInStock}");
            //}
            //==========================================================================
            //10.Query Syntax(Orders ≥ 1997)
            //var orders =
            //    from c in Customers
            //    from o in c.Orders
            //    where o.OrderDate.Year >= 1997
            //    select new
            //    {
            //        c.CustomerID,
            //        o.OrderDate
            //    };

            //foreach (var o in orders)
            //{
            //    Console.WriteLine($"{o.CustomerID} - {o.OrderDate}");
            //}
            //==========================================================================
            //11.Show position with ProductName
            //var result11 = ProductList
            //    .Select((p, i) => new { Position = i + 1, p.ProductName });
            //foreach (var item in result11)
            //{
            //    Console.WriteLine($"{item.Position}. {item.ProductName}");
            //}
            //==========================================================================
            //12.Sort words(length → then case -insensitive)
            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //    var sortedWords = Arr
            //        .OrderBy(w => w.Length)
            //        .ThenBy(w => w, StringComparer.OrdinalIgnoreCase);
            //    foreach (var word in sortedWords)
            //    {
            //        Console.WriteLine(word);
            //    }
            //==========================================================================
            //    13.Digits with second letter = 'i'(reversed)
            //    string[] digits =
            //    {
            //        "zero","one","two","three","four",
            //        "five","six","seven","eight","nine"
            //    };

            //    var result13 = digits
            //        .Where(d => d.Length > 1 && d[1] == 'i')
            //        .Reverse();
            //    foreach (var d in result13)
            //    {
            //        Console.WriteLine(d);
            //    }

            #endregion
        }
    }
}
