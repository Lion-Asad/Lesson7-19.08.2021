﻿using System;

namespace Lesson7
{
    public class Rectangle
    {
        double side1, side2;

        public Rectangle(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }

        public double AreaCalculator()
        {
            double s = side1 * side2;
            return s;
        }

        public double PerimeterCalculator()
        {
            double p = 2 * (side1 + side2);
            return p;
        }

        public double Area
        {
            get { return AreaCalculator(); }
        }
        public double Perimeter
        {
            get { return PerimeterCalculator(); }
        }
    }

        class Program
        {
        static void Main(string[] args)
        
        {
            Rectangle r = new Rectangle(3,4);
            System.Console.WriteLine(r.Area);
            System.Console.WriteLine(r.Perimeter);
            System.Console.WriteLine("\n Китобхона"); //задание 2

            Book books = new Book();                
                books.Title = "Дохунда";

                books.Author = "Садриддин АЙни";

                books.Content = "300";
                               
                books.InfoBooks();

                Book bookse = new Book();
                bookse.Title = "мактаби кухна";

                bookse.Author = "Садриддин Айни";
                bookse.Content = "250";                
                bookse.InfoBooks();

                Console.ReadLine();
        }
        public class Book
            {
            public string Title;
            public string Author;
            public string Content;
            public void InfoBooks()
             {
                 Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Имя книги, {Title}");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"Автор: {Author}");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Content:{Content}");
                System.Console.WriteLine("\n");
             }

            }
        }    
        
        
}



