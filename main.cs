using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public class Task1
{
    public static void Main()
    {
        string pattern = @"%([A-Z][a-z]+)%[^|$%.]*<(\w+)>[^|$%.]*\|(\d+)\|[^|$%.]*?(\d+.?\d+)\$";
        //string pattern = @"%([A-Z][a-z]+)%<(\w+)>\|(\d+)\|(\d+.?\d+)\$";
        
        Regex ourRegex = new Regex(pattern);

        string input = Console.ReadLine();

        double sum = 0;

        while (input != "end of shift")
        {

         Match match = ourRegex.Match(input);

          if (match.Success)
         {
            string name = match.Groups[1].Value;
            string product =  match.Groups[2].Value;
            int count = int.Parse(match.Groups[3].Value);
            double price = double.Parse(match.Groups[4].Value);

            double totalPrice = count*price;

            Console.WriteLine($"{name}: {product} - {totalPrice:f2}");
            
            sum += totalPrice;

          }

          input = Console.ReadLine();
        }

        Console.WriteLine($"Total income: {sum:f2}");
    }
}