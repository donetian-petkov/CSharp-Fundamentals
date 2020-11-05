using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;

class MainClass {

  public static void Main (string[] args) {

    int numberStudents = int.Parse(Console.ReadLine());

    List<Student> students = new List<Student>();

    for (int i = 0 ; i < numberStudents ; i++)
    {
      string[] newStudent = Console.ReadLine().Split(" ");

      string firstName = newStudent[0];
      string lastName = newStudent[1];
      double grade = double.Parse(newStudent[2]);

      Student student = new Student(firstName, lastName, grade);

      students.Add(student);
    }

    students.Sort((c1,c2) => c1.Grade.CompareTo(c2.Grade)); 

    students.Reverse();

    Console.WriteLine(string.Join(Environment.NewLine,students));
  

  }
}

class Student {

  public Student (string firstName, string lastName, double grade)
  {
    FirstName = firstName;
    LastName = lastName;
    Grade = grade;
  } 

  public string FirstName { get; set; }
  public string LastName { get; set; }
  public double Grade { get; set; }

  public override string ToString()
  {
    return $"{FirstName} {LastName}: {Grade:f2}";
  }


}