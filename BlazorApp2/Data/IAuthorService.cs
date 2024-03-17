using BlazorApp2.Components.Pages;

namespace BlazorApp2.Data
{
    public interface IAuthorService
    {
        Author GetAuthorById(int authorId);
        List<Author> GetAuthors();
        string GetCreationTime();
        void SaveAuthor(Author author);
    }
}
