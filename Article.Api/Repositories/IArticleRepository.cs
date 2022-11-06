namespace Article.Api.Repositories;

public interface IArticleRepository
{
    List<Models.Article> GetAll();
    Models.Article? Get(int id);
    int Delete(int id);
}