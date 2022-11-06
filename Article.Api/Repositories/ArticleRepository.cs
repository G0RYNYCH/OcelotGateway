namespace Article.Api.Repositories;
public class ArticleRepository : List<Models.Article>, IArticleRepository
{
    private readonly static List<Models.Article> articles = Populate();

    private static List<Models.Article> Populate()
    {
        var result = new List<Models.Article>()
        {
            new Models.Article
            {
                Id = 1,
                Title = "First Article",
                WriterId = 1,
                LastUpdate = DateTime.Now
            },
            new Models.Article
            {
                Id = 2,
                Title = "Second title",
                WriterId = 2,
                LastUpdate = DateTime.Now
            },
            new Models.Article
            {
                Id = 3,
                Title = "Third title",
                WriterId = 3,
                LastUpdate = DateTime.Now
            }
        };

        return result;
    }

    public List<Models.Article> GetAll()
    {
        return articles;
    }

    public Models.Article? Get(int id)
    {
        return articles.FirstOrDefault(x => x.Id == id);
    }

    public int Delete(int id)
    {
        var removed = articles.SingleOrDefault(x => x.Id == id);
        if (removed != null)
            articles.Remove(removed);

        return removed?.Id ?? 0;
    }
}
