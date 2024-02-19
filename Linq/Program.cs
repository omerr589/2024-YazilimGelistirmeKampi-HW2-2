using System.Collections.Generic;

internal class Program
{
    private static void Main(string[] args)
    {
        List<Category> categories = new List<Category>
        {
            new Category { CategoryId = 1, CategoryName = "Bilgisayar"},
            new Category { CategoryId = 2, CategoryName = "Telefon"}
        };

        List<Product> products = new List<Product>
        {
            new Product { ProductId = 1, CategoryId = 1, ProductName = "Acer Laptop", QuantityPerUnit = "32 GB RAM", UnitPrice = 10000, UnitsInStuck = 5 },
            new Product { ProductId = 2, CategoryId = 1, ProductName = "Asus Laptop", QuantityPerUnit = "16 GB RAM", UnitPrice = 8000, UnitsInStuck = 3 },
            new Product { ProductId = 3, CategoryId = 1, ProductName = "Hp Laptop", QuantityPerUnit = "8 GB RAM", UnitPrice = 6000, UnitsInStuck = 2 },
            new Product { ProductId = 4, CategoryId = 2, ProductName = "Samsung Telefon", QuantityPerUnit = "8 GB RAM", UnitPrice = 5000, UnitsInStuck = 15 },
            new Product { ProductId = 5, CategoryId = 2, ProductName = "Apple Telefon", QuantityPerUnit = "4 GB RAM", UnitPrice = 8000, UnitsInStuck = 0 }
        };

        foreach (Product product in products)
        {
            if (product.UnitPrice > 5000 && product.UnitsInStuck > 3)
            {
                Console.WriteLine(product.ProductName);
            }
        }

        Console.WriteLine("Linq ------>");
        var result = products.Where(p=>p.UnitPrice > 5000 && p.UnitsInStuck > 3);

        foreach (Product product in result)
        {
            Console.WriteLine(product.ProductName);
        }

        List<Product> filteredProduct = GetProducts(products);

        foreach (Product product in filteredProduct)
        {
            Console.WriteLine(product.ProductName);
        }

        foreach (Product product in GetProductsLinq(products))
        {
            Console.WriteLine(product.ProductName);
        }
    }

    static List<Product> GetProducts(List<Product> products)
    {
        List<Product> filteredProduct = new List<Product>();
        foreach (Product product in products)
        {
            if (product.UnitPrice > 5000 && product.UnitsInStuck > 3)
            {
                filteredProduct.Add(product);
            }
        }
        return filteredProduct;
    }

    static List<Product> GetProductsLinq(List<Product> products)
    {
        return products.Where(p => p.UnitPrice > 5000 && p.UnitsInStuck > 3).ToList();
    }

    class Product
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public string QuantityPerUnit { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitsInStuck { get; set; }
    }

    class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

    }

}