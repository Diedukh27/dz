namespace WebATB.Models.Users;

public class UserItemModel
{
    internal int id;

    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public string Phone { get; set; } = null!;
    public string Image { get; set; } = null!;
}
