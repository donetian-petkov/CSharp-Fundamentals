using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;

class MainClass
{

    public static void Main(string[] args)
    {
        Dictionary<string, List<double>> students = new Dictionary<string, List<double>>();

        int numberOfInputs = int.Parse(Console.ReadLine());
        int i = 0;

        while (i < numberOfInputs)
        {

            string student = Console.ReadLine();
            double grade = Double.Parse(Console.ReadLine());

            if (!students.ContainsKey(student))
            {
              students.Add(student, new List<double>() { grade });
            }
            else
            {
              students[student].Add(grade);
            }   

            numberOfInputs--;

        }

        Dictionary<string, double> filteredStudents = new Dictionary<string, double>();

        foreach (var student in students)
      {
       
        double averageGrade = 0;
        double totalGrades = 0;
        foreach (var grade in students[student.Key])
        {
           totalGrades = (totalGrades + grade);
        }
        averageGrade = totalGrades/students[student.Key].Count;

        if (averageGrade >= 4.50)
        {
          filteredStudents.Add(student.Key, averageGrade);
        }
      }

      foreach (var kvp in filteredStudents.OrderByDescending(v => v.Value))
      {
        Console.WriteLine($"{kvp.Key} -> {kvp.Value:f2}");
      }

    }
}