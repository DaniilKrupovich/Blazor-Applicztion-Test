
namespace BlazorApp2.Data
{
    public class AuthorService : IAuthorService
    {
        public DateTime CreationDate { get; set; }
        public List<Author> Authors { get; set; }

        public AuthorService()
        {
            CreationDate = DateTime.Now;
            Authors = new List<Author>();
            Authors.Add(new Author("Daniil Krupovich", "He is student BSU", ++Author.Counter, "255281832", "krupovich@bsu.by"));
            Authors.Add(new Author("Hleb", "None", ++Author.Counter, "293317125", "hleb@bsu.by"));
            Authors.Add(new Author("Sasha", "None", ++Author.Counter, "332616654", "sasha@bsu.by"));
        }

        public Author GetAuthorById(int authorId)
        {
            return Authors.Where(author => author.AuthorId== authorId).FirstOrDefault();
        }

        public List<Author> GetAuthors()
        {
            return Authors;
        }
        public string GetCreationTime()
        {
            return CreationDate.ToLongTimeString();
        }
        public void SaveAuthor(Author author)
        {
            author.AuthorId = ++Author.Counter;
            Authors.Add(author);
        }
    }
}
