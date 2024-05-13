using System.ComponentModel.DataAnnotations;

namespace holiganbet.Models.AdminViewModels;

public class UsersVM
{
    public int Id { get; set; }

    [Required(ErrorMessage = "KE-mail boş geçilemez!")]
    public string Email { get; set; }

    [Required(ErrorMessage = "Kullanıcı adı boş geçilemez!")]
    [MinLength(6, ErrorMessage = "Kullanıcı adı en az 6 karakter olmalıdır!")]
    public string Username { get; set; }

    [Required(ErrorMessage = "Şifre boş geçilemez!")]
    [MinLength(6, ErrorMessage = "Şifre en az 6 karakter olmalıdır!")]
    public string Password { get; set; }

    [Required(ErrorMessage = "İsim boş geçilemez!")]
    [MinLength(3, ErrorMessage = "Ad en az 3 karakter olmalıdır!")]
    public string Name { get; set; }

    [Required(ErrorMessage = "Soyad boş geçilemez!")]
    [MinLength(3, ErrorMessage = "Soyad en az 3 karakter olmalıdır!")]
    public string Surname { get; set; }

    [Required(ErrorMessage = "Doğum tarihi boş geçilemez!")]
    public DateOnly Birthdate { get; set; }
}