using System;
using System.Linq;
using System.Collections.Generic;

class ProductShop
{
    public static void Main()
    {
        Dictionary<string, Dictionary<string, double>> shops = new Dictionary<string, Dictionary<string, double>>();

        string command;
        while ((command = Console.ReadLine()) != "Revision")
        {
            string[] info = command.Split(", ", StringSplitOptions.RemoveEmptyEntries);

            string shopName = info[0];
            string productName = info[1];
            double productPrice = double.Parse(info[2]);

            if (!shops.ContainsKey(shopName))
            {
                shops.Add(shopName, new Dictionary<string, double>());
            }
            shops[shopName].Add(productName, productPrice);
        }

        foreach (var kvp in shops.OrderBy(x => x.Key))
        {
            Console.WriteLine($"{kvp.Key}->");
            foreach (var product in kvp.Value)
            {
                Console.WriteLine($"Product: {product.Key}, Price: {product.Value}");
            }
        }
    }
}