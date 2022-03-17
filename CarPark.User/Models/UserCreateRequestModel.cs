using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CarPark.User.Models
{
    public class UserCreateRequestModel
    {
        [Required(ErrorMessage = "Required")]
        [DisplayName("NameSurname")]
        public string NameSurname { get; set; }
        [Required(ErrorMessage = "Required")]
        [DisplayName("JobTitle")]
        public string JobTitle { get; set; }
    }
}
