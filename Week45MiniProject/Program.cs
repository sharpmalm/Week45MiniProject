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
        Console.WriteLine("");
        foreach (Product prods in prod)
        {
            
            Console.WriteLine(prods.Category + " " + prods.Name + " " + prods.Price);
            
        }
        Console.WriteLine("");
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