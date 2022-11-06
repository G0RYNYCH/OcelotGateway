namespace Writer.Api.Repositories;

public interface IWriterRepository
{
    List<Models.Writer> GetAll();
    Models.Writer Insert(Models.Writer writer);
    Models.Writer? Get(int id);
}