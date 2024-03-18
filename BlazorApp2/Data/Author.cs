using System.ComponentModel.DataAnnotations;

namespace BlazorApp2.Data
{
    public class Author
    {
        [Required(ErrorMessage ="Name is required ")]
        [StringLength(50,ErrorMessage ="name can not be longer then 20 chars")]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        public int AuthorId { get; set; }
        [Required(ErrorMessage = "Name is required ")]
        public string PhoneNumber { get; set; }
        [Required(ErrorMessage = "Email is required ")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        public string Email { get; set; }

        public static int Counter { get; set; } = 0;

        public Author()
        {

        }
        public Author(string name, string description, int authorId, string phoneNumber, string email)
        {
            Name = name;
            Description = description;
            AuthorId = authorId;
            PhoneNumber = phoneNumber;
            Email = email;
        }
    }
}
