using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;

class MainClass
{

    public static void Main(string[] args)
    {
        Dictionary<string, List<string>> companies = new Dictionary<string, List<string>>();


        while (true)
        {
            string[] inputCourse = Console.ReadLine().Split(" -> ");

            string command = inputCourse[0].ToLower();
            
            if (command.Equals("end"))
            {
                break;
            }

            string company = inputCourse[0];
            string employeeID = inputCourse[1];


            if (!companies.ContainsKey(company))
            {
                companies.Add(company, new List<string>());
                companies[company].Add(employeeID);
            }
            else
            {
                if (companies[company].Contains(employeeID))
                {
                  break;
                }
                else
                {
                companies[company].Add(employeeID);
                }
            }
        }

      foreach (var kvp in companies.OrderBy(v => v.Value))
      {
        Console.WriteLine($"{kvp.Key}");

        foreach (var id in companies[kvp.Key])
        {
          Console.WriteLine($"-- {id}");
        }
      }

    }
}