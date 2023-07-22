namespace Core.Application.Dtos;

public class UserForRegisterDto : IDto
{
    public string Email { get; set; }
    public string Password { get; set; }
    public string PasswordVerify { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string PhoneNumber { get; set; }

    public UserForRegisterDto()
    {
        Email = string.Empty;
        Password = string.Empty;
        FirstName = string.Empty;
        LastName = string.Empty;
        PasswordVerify = string.Empty;
        PhoneNumber = string.Empty;
    }

    public UserForRegisterDto(string email, string password, string firstName, string lastName, string passwordVerify, string phoneNumber)
    {
        Email = email;
        Password = password;
        FirstName = firstName;
        LastName = lastName;
        PasswordVerify = passwordVerify;
        PhoneNumber = phoneNumber;
    }
}
