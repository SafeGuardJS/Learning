using System;

namespace Delegation
{
    static class FindAndReplaceManager
    {
        public static void FindNext(string someStr)
        {
            Book randBook = new Book();
            randBook.FindNext(someStr);
        }

        public static void CreateNote(string str)
        {
            Book.Notes randBook = new Book.Notes();
            randBook.CreateNote(str);
        }
    }

    class Book
    {
        public class Notes
        {
            int notesCounter = 0;

            public void CreateNote(string str)
            {
                this.notesCounter++;
                Console.WriteLine($"Создана {notesCounter} заметка: " + str);
            }
        }

        public void FindNext(string str)
        {
            Console.WriteLine("Поиск строки: " + str);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            FindAndReplaceManager.FindNext("Great job!");
            FindAndReplaceManager.CreateNote("Lovely quote.");
        }
    }
}
