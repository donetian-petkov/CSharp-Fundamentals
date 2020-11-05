using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;

class MainClass {

  public static void Main (string[] args) {

    string[] articleInput = Console.ReadLine().Split(", ");
    
    Article article = new Article(articleInput[0], articleInput[1], articleInput[2]);

    int numberOfRotations = int.Parse(Console.ReadLine());

    while (numberOfRotations > 0)
    {
      string[] input = Console.ReadLine().Split(": ");
      string command = input[0];
      string argument = input[1];

      if (command == "Edit")
      {
        article.Edit(argument);
      } 
      else if (command == "ChangeAuthor")
      {
        article.ChangeAuthor(argument);
      }
      else if (command == "Rename")
      {
        article.Rename(argument);
      }

      numberOfRotations--;
    }

    Console.WriteLine(article.ToString());

    }

  
}

class Article {

  public Article (string title, string content, string author) 
  {
    Title = title;
    Content = content;
    Author = author;
  }

  public string Title { get; set; }
  public string Content { get; set; }
  public string Author { get; set; }

  public void Edit (string content)
  {
    Content = content;
  }

  public void ChangeAuthor (string author)
  {
    Author = author;
  }

  public void Rename (string title)
  {
    Title = title;
  }

  public override string ToString ()
  {
    return $"{Title} - {Content}: {Author}";
  }

}