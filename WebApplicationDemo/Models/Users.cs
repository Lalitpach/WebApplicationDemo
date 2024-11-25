using System.ComponentModel.DataAnnotations;

namespace WebApplicationDemo.Models
{
    public class Users
    {
        [Required(ErrorMessage = "name is required")]
        [Range(100, 999, ErrorMessage = "id must be 3 digit")]
        public int id { get; set; }

        [Required(ErrorMessage = "name is required")]
        [MaxLength(40)]
        [MinLength(3)]

        public string? Name { get; set; }
        [Required(ErrorMessage = "email is required")]
        [DataType(DataType.EmailAddress)]

        public string? Email { get; set; }
        [Required(ErrorMessage = "age is reqired")]
        [Range(minimum: 18, maximum: 58)]
        public int Age { get; set; }

        [Required(ErrorMessage = "dept is required")]
        public string dept { get; set; }
        [Required(ErrorMessage = "salary is required")]

        public int sallary  { get; set; }


    }
}
