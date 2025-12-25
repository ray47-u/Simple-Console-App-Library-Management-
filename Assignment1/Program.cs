// See https://aka.ms/new-console-template for more information
using System;
using System.Globalization;

namespace LibraryManagementSystem
{
    public class LibraryItem
    {
        public string Title { get; set; }
        public int ItemId { get; set; }
        public bool IsAvailable { get; set; }
        //Constructor
        public LibraryItem(string title, int itemid, bool isavailbale)
        {

            Title = title;
            ItemId = itemid;
            IsAvailable = isavailbale;
        }
        //Virtual method
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Item ID:{ItemId}");
            Console.WriteLine($"Title : {Title}");
            Console.WriteLine($"Available: {IsAvailable}");
        }



    }
    public class Book : LibraryItem
    {
        public string Author { get; set; }

        public Book(string title, int itemid, bool isavailable, string author) : base(title, itemid, isavailable)
        {
            Author = author;
        }


        public override void DisplayInfo()
        {
            Console.WriteLine("Book Details");
            base.DisplayInfo();
            Console.WriteLine($"Author Name:{Author}");
        }

    }
    public class Magazines:LibraryItem
    {
        public int IssueNumber { get; set; }

        public Magazines(String title,int itemid,bool isavailable,int issuenumber):base( title,itemid,isavailable)
        {
            IssueNumber = issuenumber;
        }
        public override void DisplayInfo()
        {
            Console.WriteLine("Magazine Details:");
            base.DisplayInfo();
            Console.WriteLine($"Issue Number:{IssueNumber}");
        }
    }

    class program
    {

        public static void Main(string[] args)
        {
            Console.WriteLine("Library Management System");
            Console.WriteLine("------|-------\n");

            Book book1 = new Book("Pather Panchali", 101, true, "Bibhutibhushan Bandyopadhyay");
            Book book2 = new Book("Amar Bondhu Rashed", 103, true, "Muhammed Zafar Iqbal");
            Magazines magazine1 = new Magazines("Bichitra", 201, true, 120);

            Console.WriteLine("Initial Library Items:");
            Console.WriteLine("------|-------");
            book1.DisplayInfo();
            book2.DisplayInfo();
            magazine1.DisplayInfo();

            Console.WriteLine("\n\n Borrowing Process:");
            Console.WriteLine("------|-------");

         
            Console.WriteLine("\nBefore borrowing:");
            Console.WriteLine($"Book '{book1.Title}' - Available: {book1.IsAvailable}");

            
            book1.IsAvailable = false;

            
            Console.WriteLine("\nAfter borrowing:");
            Console.WriteLine($"Book '{book1.Title}' - Available: {book1.IsAvailable}");

            
            Console.WriteLine("\n\nUpdated Library Items:");
            Console.WriteLine("------|-------");
            book1.DisplayInfo();
            book2.DisplayInfo();
            magazine1.DisplayInfo();

            Console.WriteLine("\n\n complete.");
        }
    }
}



