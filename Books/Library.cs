using System.Collections;
using System.Collections.Generic;

namespace Books
{
    public class Library : IEnumerable<Book>
    {
        private List<Book> _books = new List<Book> ();

        public void Add (Book book)
        {
            _books.Add(book);
        }

        public IEnumerator<Book> GetEnumerator()
        {
            for (int idx = 0; idx < _books.Count; ++idx)
            {
                yield return _books[idx];
            }

            // return new BookEnumerator(this);
            // return _books.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public Book this[int idx] => _books[idx];
        public int Count => _books.Count;
    }
}
