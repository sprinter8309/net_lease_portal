using System.ComponentModel.DataAnnotations;

namespace SearchNavigator.Models
{
    public class CarLeaseRequestModel
    {
        public int CarId { get; set; }
        public string? CarPreviewImage { get; set; }
        public string? CarBrand { get; set; }
        public string? CarModel { get; set; }
        public string? CarCity { get; set; }
        public decimal CarLeaseRate { get; set; }

        [Required(ErrorMessage = "Обязателен ввод имени клиента")]
        [DataType(DataType.Text, ErrorMessage = "Имя клиента должно быть в текстовом формате")]
        [StringLength(32, ErrorMessage = "Имя пользователя от 2 до 32 символов", MinimumLength = 2)]
        public string? PersonName { get; set; }

        [Required(ErrorMessage = "Обязателен ввод номера телефона")]
        [DataType(DataType.PhoneNumber, ErrorMessage = "Формат телефона должен быть корректным")]
        [StringLength(32, ErrorMessage = "Телефон клиента от 2 до 32 символов", MinimumLength = 6)]
        public string? PersonPhone { get; set; }

        [DataType(DataType.EmailAddress, ErrorMessage = "Неправильный формат Email")]        
        public string? PersonEmail { get; set; }

        [Required(ErrorMessage = "Обязателен ввод номера паспорта")]
        [StringLength(15, ErrorMessage = "Номер паспорта от 10 до 15 символов", MinimumLength = 10)]
        public string? PersonPassportNumber { get; set; }
    }
}
