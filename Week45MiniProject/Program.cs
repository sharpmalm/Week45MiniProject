
class Program
{
    static void Main(string[] args)
    {
        List<Product> prod = new List<Product>();
        bool exit = false;
        while (!exit)
        {
            Console.WriteLine("Enter 1 to add a product, 2 to display the list of products, 3 to search for a product, or 4 to exit.");
            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    Console.WriteLine("Enter product category and press enter.");
                    string category = Console.ReadLine();
                    Console.WriteLine("Enter product name and press enter.");
                    string name = Console.ReadLine();
                    Console.WriteLine("Enter price and press enter.");
                    int price = Convert.ToInt32(Console.ReadLine());
                    prod.Add(new Product(category, name, price));
                    break;
                case "2":
                    List<Product> sortedList = prod.OrderBy(prod => prod.Price).ToList();
                    Console.WriteLine("");
                    Console.WriteLine("Category".PadRight(20) + "Name".PadRight(20) + "Price");
                    foreach (Product product in sortedList)
                    { Console.WriteLine(product.Category.PadRight(20) + product.Name.PadRight(20) + product.Price); }
                    Console.WriteLine("");
                    int totalPrice = prod.Sum(prod => prod.Price);
                    Console.WriteLine("The total price for your products is:   " + totalPrice);
                    break;
                case "3":
                    Console.WriteLine("Enter product name to search for and press enter.");
                    string searchName = Console.ReadLine();
                    List<Product> searchResults = prod.Where(prod => prod.Name.ToLower().Contains(searchName.ToLower())).ToList();
                    if (searchResults.Count > 0)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Category".PadRight(20) + "Name".PadRight(20) + "Price");


                        foreach (Product product in searchResults)
                        { Console.WriteLine(product.Category.PadRight(20) + product.Name.PadRight(20) + product.Price); }
                        Console.WriteLine("");
                    }
                    else
                    {
                        Console.WriteLine("No products found with that name.");
                    }
                    break;
                case "4":
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid input. Please try again.");
                    break;
            }
        }
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