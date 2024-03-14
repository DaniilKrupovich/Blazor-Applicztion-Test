namespace BlazorApp2.Data
{
    public class Author
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int AuthorId { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

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
