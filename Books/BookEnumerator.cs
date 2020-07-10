using System.Collections;
using System.Collections.Generic;

namespace Books
{
    public class BookEnumerator : IEnumerator<Book>
    {
        private Library _library;
        private int _idx;

        public BookEnumerator(Library library)
        {
            _library = library;
            _idx = -1;
        }

        public Book Current => _library[_idx];

        object IEnumerator.Current => Current;

        public void Dispose()
        {
        }

        public bool MoveNext()
        {
            return ++_idx < _library.Count;
        }

        public void Reset()
        {
            _idx = -1;
        }
    }
}
