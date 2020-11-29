using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;

class MainClass
{

    public static void Main(string[] args)
    {

      int line = 1; 
      var resources = new Dictionary<string,int>();
      string previousEntry = "";

      while (true)
      {
        string inputString = Console.ReadLine();
        
        if (inputString.Equals("stop"))
        {
          break;
        }

        if (line%2 == 1)
        {
          previousEntry = inputString;
          line++;
          if (resources.ContainsKey(inputString))
          {
            continue;
          }
          else 
          {
            resources.Add(inputString, 0);
          }
        }
        else 
        {
          resources[previousEntry] += int.Parse(inputString);
          line++;
        }
        
      }

      foreach (var resource in resources)
      {
        Console.WriteLine($"{resource.Key} -> {resource.Value}");
      }
      
    }

}