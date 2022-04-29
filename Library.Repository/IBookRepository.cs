using System.Collections.Generic;

namespace Library.Repository
{
    /// <summary>Interface defining access to books related data.</summary>
    public interface IBookRepository
    {
        /// <summary>Find books, one can specify filter criteria.</summary>
        IEnumerable<Book> Find(string title = "", bool availableOnly = false);

        /// <summary>Find all borrow history of single book.</summary>
        IEnumerable<Borrow> FindBorrows(string title);

        /// <summary>Add a new book to the library shelf.</summary>
        void Add(Book book);

        /// <summary>Mark a book as borrowed by given user.
        /// <para>No action will be performed if:</para>
        /// <para>- Book is not found</para>
        /// <para>- Book is already taken</para>
        /// <para>- User is not active</para></summary>
        void Borrow(Book title, User user, int days = 30);
    }
}