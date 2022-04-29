namespace Library.Repository;

public class User
{
    public string Name { get; set; }
    public string Gender { get; set; }
    public DateTime ActiveFrom { get; set; }
    public DateTime? ActiveTo { get; set; }
}