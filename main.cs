using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Text.RegularExpressions;

public class Main
{
    public static void Main()
    {
        string pattern = @">>([A-z]+)<<(\d+\.?\d*)!(\d+)";
        
        Regex ourRegex = new Regex(pattern);

        string input = Console.ReadLine();
        double sum = 0;

        Console.WriteLine("Bought furtniture:");

        while (input != "Purchase")
        {
          input = Console.ReadLine();

          Match match = ourRegex.Match(input);

          if (match.Success)
          {
            string name = match.Groups[1].Value;
            double price = double.Parse(match.Groups[2].Value);
            int quantity = int.Parse(match.Groups[3].Value);
            sum += price*quantity;

            Console.WriteLine(name);
          }
        }

        Console.WriteLine($"Total money spend: {sum:f2}");
    }
}