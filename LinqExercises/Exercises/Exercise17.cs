namespace LinqExercises
{
    public static class Exercise17
    {
        /*
            You have a list of products and a list of orders (where each order has a ProductID and Quantity). Use LINQ to find the top N products by total sales amount.
        */
        public static void Solve()
        {
            var products = new List<Product>
            {
                new Product { ProductID = 1, ProductName = "Laptop", Price = 1000 },
                new Product { ProductID = 2, ProductName = "Phone", Price = 500 },
                new Product { ProductID = 3, ProductName = "Tablet", Price = 300 }
            };

            var orders = new List<Order>
            {
                new Order { ProductID = 1, Quantity = 5 },
                new Order { ProductID = 2, Quantity = 10 },
                new Order { ProductID = 3, Quantity = 7 },
                new Order { ProductID = 1, Quantity = 3 }
            };

            int topN = 2;

            var topProducts = orders.GroupBy(o => o.ProductID).Select((g) => new { ProductID = g.Key, TotalQuantity = g.Sum(i => i.Quantity) }).Join(products, o => o.ProductID, p => p.ProductID, (o, p) => new { o.ProductID, p.ProductName, TotalSales = o.TotalQuantity * p.Price }).OrderByDescending((r) => r.TotalSales).Take(topN);

            foreach (var product in topProducts)
            {
                Console.WriteLine($"{product.ProductName} has total sales of {product.TotalSales:C}");
            }
        }

        class Product
        {
            public int ProductID { get; set; }
            public string ProductName { get; set; } = "";
            public decimal Price { get; set; }
        }

        class Order
        {
            public int ProductID { get; set; }
            public int Quantity { get; set; }
        }

    }
}

