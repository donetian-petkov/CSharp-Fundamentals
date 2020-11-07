using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;

class MainClass
{

    public static void Main(string[] args)
    {

        List<string> cards = Console.ReadLine().Split(":").ToList();

        Deck deck = new Deck();

        while (true)
        {
            string stringInput = Console.ReadLine();

            if (stringInput == "Ready")
            {
                break;
            }

            string[] commands = stringInput.Split(" ");

            if (commands[0] == "Add")
            {
                string card = commands[1];

                if (!cards.Contains(card))
                {
                    Console.WriteLine("Card not found.");
                }
                else
                {
                    deck.Add(card);
                }
            }
            else if (commands[0] == "Insert")
            {
                string card = commands[1];
                int index = int.Parse(commands[2]);

                if (!cards.Contains(card) || cards.Count - 1 < index || index < 0)
                {
                    Console.WriteLine("Error!");
                }
                else
                {
                    deck.Insert(card, index);
                }
            }
            else if (commands[0] == "Remove")
            {
                string card = commands[1];

                if (!deck.Cards.Contains(card))
                {
                    Console.WriteLine("Card not found.");
                }
                else
                {
                    deck.Remove(card);
                }
            }
            else if (commands[0] == "Swap")
            {
                string cardOne = commands[1];
                string cardTwo = commands[2];

                deck.Swap(cardOne, cardTwo);
            }
            else if (commands[0] == "Shuffle")
            {
                deck.ShuffleDeck();
            }
        }

        Console.WriteLine(string.Join(" ", deck.Cards));

    }

}

public class Deck
{

    public Deck()
    {

    }

    public List<string> Cards = new List<string>();

    public void Add(string card)
    {
        this.Cards.Add(card);
    }

    public void Insert(string card, int index)
    {

        this.Cards.Insert(index, card);
    }

    public void Remove(string card)
    {

        this.Cards.Remove(card);

    }

    public void Swap(string cardOne, string cardTwo)
    {
        int indexOne = this.Cards.FindIndex(a => a == cardOne);
        int indexTwo = this.Cards.FindIndex(a => a == cardTwo);

        string swapCard = this.Cards[indexOne];
        this.Cards[indexOne] = this.Cards[indexTwo];
        this.Cards[indexTwo] = swapCard;
    }

    public void ShuffleDeck()
    {
        this.Cards.Reverse();
    }

}