using System;
using System.Collections.Generic;

enum Size
{
    XS = 1,
    S,
    M,
    L,
    XL
}

class Person
{
    public int ID { get; set; }
    public string Name { get; set; }
}

class Card
{
    public string Title { get; set; }
    public string Content { get; set; }
    public Person AssignedTo { get; set; }
    public Size Size { get; set; }
}

class Board
{
    public List<Card> TodoLine { get; set; } = new List<Card>();
    public List<Card> InProgressLine { get; set; } = new List<Card>();
    public List<Card> DoneLine { get; set; } = new List<Card>();
}

class Program
{
    static List<Person> teamMembers = new List<Person>
    {
        new Person { ID = 1, Name = "John" },
        new Person { ID = 2, Name = "Jane" }
        // diğer takım üyelerini buraya ekleyin
    };

    static void Main(string[] args)
    {
        Board board = new Board();
        // Başlangıçta 3 kart eklemek için:
        board.TodoLine.Add(new Card { Title = "Task 1", Content = "Do something", AssignedTo = teamMembers[0], Size = Size.M });
        board.InProgressLine.Add(new Card { Title = "Task 2", Content = "Working on it", AssignedTo = teamMembers[1], Size = Size.L });
        board.DoneLine.Add(new Card { Title = "Task 3", Content = "Completed", AssignedTo = teamMembers[0], Size = Size.S });

        while (true)
        {
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz:");
            Console.WriteLine("(1) Board Listelemek");
            Console.WriteLine("(2) Board'a Kart Eklemek");
            Console.WriteLine("(3) Board'dan Kart Silmek");
            Console.WriteLine("(4) Kart Taşımak");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    ListBoard(board);
                    break;
                case 2:
                    AddCardToBoard(board);
                    break;
                case 3:
                    RemoveCardFromBoard(board);
                    break;
                case 4:
                    MoveCard(board);
                    break;
                default:
                    Console.WriteLine("Geçersiz seçim!");
                    break;
            }
        }
    }

    static void ListBoard(Board board)
    {
        // Board listeleme işlemi burada yapılır
    }

    static void AddCardToBoard(Board board)
    {
        // Kart ekleme işlemi burada yapılır
    }

    static void RemoveCardFromBoard(Board board)
    {
        // Kart silme işlemi burada yapılır
    }

    static void MoveCard(Board board)
    {
        // Kart taşıma işlemi burada yapılır
    }
}