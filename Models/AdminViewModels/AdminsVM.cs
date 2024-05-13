using System.ComponentModel.DataAnnotations;

namespace holiganbet.Models.AdminViewModels;

public class AdminsVM
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Kullanıcı adı boş geçilemez!")]
    [MinLength(3, ErrorMessage = "Kullanıcı adı en az 3 karakter olmalıdır!")]
    public string Username { get; set; }

    [Required(ErrorMessage = "Şifre alanı boş geçilemez!")]
    public string Password { get; set; }
}