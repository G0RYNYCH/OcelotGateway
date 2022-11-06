using Article.Api.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Article.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ArticlesController : ControllerBase
{
    private readonly IArticleRepository articleRepository;
    public ArticlesController(IArticleRepository articleRepository)
    {
        this.articleRepository = articleRepository;
    }

    [HttpGet]
    public IActionResult Get()
    {
        return Ok(articleRepository.GetAll());
    }

    [HttpGet("{id}")]
    public IActionResult Get(int id)
    {
        var article = articleRepository.Get(id);
        if (article is null)
            return NotFound();

        return Ok(article);
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        var deletedId = articleRepository.Delete(id);
        if (deletedId == 0)
            return NotFound();

        return NoContent();
    }
}
