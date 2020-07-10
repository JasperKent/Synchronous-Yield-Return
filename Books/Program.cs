using System;
using System.Linq;

namespace Books
{
    class Program
    {
        static void Main()
        {
            Library library = new Library
            {
                new Book { Title = "Dr No", Author = "Ian Fleming" },
                new Book { Title = "Emma", Author = "Jane Austen" },
                new Book { Title = "Goldfinger", Author = "Ian Fleming" },
                new Book { Title = "Pride and Prejudice", Author = "Jane Austen" }
            };

            foreach (var b in library)
                Console.WriteLine(b);
        }
    }
}
