using Core.Persistence.Repositories;

namespace Domain.Entities;
public class Brand : Entity<int>
{
    public string Name { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public string Website { get; set; }
    public string Country { get; set; }
    public string AvatarFilePath { get; set; }
    public bool Approved { get; set; }
}
