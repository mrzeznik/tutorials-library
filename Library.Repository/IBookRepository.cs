namespace Library.Repository;

/// <summary>Interface defining access to books related data.</summary>
public interface IBookRepository
{
    void Add(Book book);
    IEnumerable<Book> Find(string title = "", bool availableOnly = false);
    void Borrow(string title, string user, int days = 30);
}