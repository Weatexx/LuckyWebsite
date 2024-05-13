using System.ComponentModel.DataAnnotations;

namespace holiganbet.Models.ViewModels;

public class ContactsVM
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Ad, Soyad kısmı boş geçilemez!")]
    [MinLength(3, ErrorMessage = "Ad, Soyad en az 3 karakter olmalıdır!")]
    public string Namesurname { get; set; }

    [Required(ErrorMessage = "Telefon numarası alanı boş geçilemez!")]
    public string Phone { get; set; }
}