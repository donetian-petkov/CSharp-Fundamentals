using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public class Task2
{
    public static void Main()
    {
        int numberOfInputs = int.Parse(Console.ReadLine());

        string pattern = @"^(\$)?(\%)?([A-Z][a-z]{3,})(?(1)\$)(?(2)\%):\s\[(\d+)\]\|\[(\d+)\]\|\[(\d+)\]\|$";
        
        Regex ourRegex = new Regex(pattern);

        while (numberOfInputs > 0)
        {

          string input = Console.ReadLine();

           Match match = ourRegex.Match(input);

          if (match.Success)
          {
            string tag = match.Groups[3].Value;
            int numberOne = int.Parse(match.Groups[4].Value);
            int numberTwo = int.Parse(match.Groups[5].Value);
            int numberThree = int.Parse(match.Groups[6].Value);

            char charNumberOne = Convert.ToChar(numberOne);
            char charNumberTwo = Convert.ToChar(numberTwo);
            char charNumberThree = Convert.ToChar(numberThree);

            Console.WriteLine($"{tag}: {charNumberOne}{charNumberTwo}{charNumberThree}");
          }
          else 
          {
            Console.WriteLine("Valid message not found!");
          }

          numberOfInputs--;

        }
    }
}