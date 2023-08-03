using System.Numerics;

namespace ProductLINQ
{
    class Product
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public int Price { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>()
        {
            new Product() { Name = "Laptop", Category = "Electronics", Price = 70000 },
            new Product() { Name = "Tshirt", Category = "Clothing", Price = 1400 },
            new Product() { Name = "CoffeeMaker", Category = "Kitchen Appliances", Price = 3500 },
            new Product() { Name = "Book", Category = "Stationary", Price = 3500 },
            new Product() { Name = "SmartPhone", Category = "Electronics", Price = 35000 },
            new Product() { Name = "Sneakers", Category = "Clothing", Price = 8400 },
            new Product() { Name = "Headphone", Category = "Electronics", Price = 7000 },
            new Product() { Name = "BackPack", Category = "Accessories", Price = 3500 },
            new Product() { Name = "Watch", Category = "Accessories", Price = 10500 },
         };

            var groupedProducts = products.GroupBy(p => p.Category);

            foreach(var product in groupedProducts)
            {
                Console.WriteLine("Category : " + product.Key);
                foreach (var item in product)
                {
                    Console.WriteLine("ProductName : " + item.Name + ", ProductPrice :" + item.Price);
                }
                Console.WriteLine();
            }



            foreach(var product in groupedProducts)
            {
                var count = 0;
                foreach (var item in product)
                {
                    count++;
                }
            Console.WriteLine(count);
            }
            foreach(var product in groupedProducts)
            {
                var totalprice = 0;
                foreach (var item in product)
                {
                    totalprice += item.Price;
                }
                Console.WriteLine(totalprice);
            }
            foreach (var product in groupedProducts)
            {
             
                var maxprice = 0;
                foreach (var item in product)
                {
                    if(maxprice < item.Price){
                       maxprice = item.Price;
                
                    }
                }
                Console.WriteLine("Maximum Price : " + maxprice);
            }

        }

    }
}