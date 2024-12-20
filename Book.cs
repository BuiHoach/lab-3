using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_03
{
    internal class Book
    {
        public string Author { get; set; }  // Author of the book
        public int Pages { get; set; }  // Number of pages in the book
        public string ISBN { get; set; }  // International Standard Book Number
        public string Title { get; set; }  // Title of the book
        public int CurrentPage { get; private set; }  // Current page the reader is on

        // Default constructor
        public Book()
        {
            Author = "Unknown";
            Pages = 0;
            ISBN = "Unknown";
            Title = "Untitled";
            CurrentPage = 1;
        }

        // Constructor with parameters
        public Book(string author, int pages, string isbn, string title)
        {
            Author = author;
            Pages = pages;
            ISBN = isbn;
            Title = title;
            CurrentPage = 1; // Set the default current page to 1
        }

        // Method to flip page forward
        public void FlipPageForward()
        {
            if (CurrentPage < Pages)
            {
                CurrentPage++;
            }
            else
            {
                Console.WriteLine("You are already on the last page.");
            }
        }

        // Method to flip page backward
        public void FlipPageBackward()
        {
            if (CurrentPage > 1)
            {
                CurrentPage--;
            }
            else
            {
                Console.WriteLine("You are already on the first page.");
            }
        }

        // Display book information
        public void DisplayBookInfo()
        {
            Console.WriteLine("Title: {0}", Title);
            Console.WriteLine("Author: {0}", Author);
            Console.WriteLine("ISBN: {0}", ISBN);
            Console.WriteLine("Pages: {0}", Pages);
            Console.WriteLine("Current Page: {0}", CurrentPage);
            Console.WriteLine();
        }
    }
}
