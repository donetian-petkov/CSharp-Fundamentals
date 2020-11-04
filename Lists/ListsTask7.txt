using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;

class MainClass {

  public static void Main (string[] args) {

    List<string> arraysInput = Console.ReadLine().Split('|').ToList();

    arraysInput.Reverse();

    List<string> newList = new List<string>();

    for (int i = 0 ; i < arraysInput.Count ; i++)
    {
      List<string> numberList = arraysInput[i].Split(' ', StringSplitOptions.RemoveEmptyEntries)
     .ToList();

     for (int j = 0 ; j < numberList.Count; j++)
     {
       newList.Add(numberList[j]);
     }
    }

    Console.WriteLine(string.Join(" " , newList));

    
    
    

  }
}