using SecondApi.Api.Entities;

namespace SecondApi.Api.Repositories;

public interface IDataRepositries
{
    void Create(Data data);
    void Delete(int id);
    Data? Get(int id);

    IEnumerable<Data> GetAll();
    void Update(Data updatedgame);
}
