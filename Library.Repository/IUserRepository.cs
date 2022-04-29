namespace Library.Repository;

/// <summary>Interface defining access to users related data.</summary>
public interface IUserRepository
{
    void Add(User user);
    IEnumerable<User> Find(string name = "");
}