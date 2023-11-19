class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("My Products");
        List<Product> prod = new List<Product>();
                
        while (true)
        {
            Console.WriteLine("Enter product category and press enter.");
            string category = Console.ReadLine();
            if (category.ToLower().Trim() == "q")
            {
                break;
            }

            Console.WriteLine("Enter product name and press enter.");
            string name = Console.ReadLine();
            Console.WriteLine("Enter price and press enter.");
            int price = Convert.ToInt32(Console.ReadLine());
            
            prod.Add(new Product(category, name, price));
        }
        List<Product> sortedList = prod.OrderBy(prod => prod.Price).ToList();
        Console.WriteLine("");
        Console.WriteLine("Category".PadRight(20) + "Name".PadRight(20) + "Price");
        
        //foreach (Product prods in prod)
        foreach (Product product in sortedList)
        {

            //Console.WriteLine(prods.Category.PadRight(20) + prods.Name.PadRight(20) + prods.Price);
            Console.WriteLine(product.Category.PadRight(20) + product.Name.PadRight(20) + product.Price);
        }
        
        Console.WriteLine("");
        int totalPrice = prod.Sum(prod => prod.Price);
        Console.WriteLine("The total price for your products is:   " + totalPrice);
        Console.WriteLine();
        Console.WriteLine("----------------------------");
    }
}

class Product
{
    public Product(string category, string name, int price)
    {
        Category = category;
        Name = name;
        Price = price;
    }

    public string Category { get; set; }
    public string Name { get; set; }
    public int Price { get; set; }  
}