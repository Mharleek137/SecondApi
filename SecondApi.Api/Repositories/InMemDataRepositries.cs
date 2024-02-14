using SecondApi.Api.Entities;

namespace SecondApi.Api.Repositories;

public class InMemDataRepositries : IDataRepositries
{
    private readonly List<Data> datas = new()
    {
        new Data()
        {
            ID = 1,
            UserName = "Patric",
            Rank = 100,
            Weapon = "Striker",
            GameStyle = "Camping",
            GameType = "Multiplayer, Battle Royale",
            Position = "-",
            Stats = 0,
            ImageUrl = "https//placehold.co/100",
        },
        new Data()
        {
            ID = 2,
            UserName = "IKM",
            Rank = 220,
            Weapon = "SMG",
            GameStyle = "Freestyle",
            GameType = "Multiplayer, Battle Royale",
            Position = "-",
            Stats = 0,
            ImageUrl = "htts//placehold.co/100",
        },
        new Data()
        {
            ID = 3,
            UserName = "Mharleek",
            Rank = 220,
            Weapon = "SMG",
            GameStyle = "Freestyle",
            GameType = "Multiplayer, Battle Royale",
            Position = "-",
            Stats = 0,
            ImageUrl = "https//placehold.co./100",
        },
        new Data()
        {
            ID = 4,
            UserName = "Xoftmax",
            Rank = 220,
            Weapon = "SMG",
            GameStyle = "Freestyle",
            GameType = "Multiplayer, Battle Royale",
            Position = "-",
            Stats = 0,
            ImageUrl = "https//placehold.co/100",
        },
        new Data()
        {
            ID = 5,
            UserName = "Smokey",
            Rank = 220,
            Weapon = "SMG",
            GameStyle = "Freestyle",
            GameType = "Multiplayer, Battle Royale",
            Position = "-",
            Stats = 0,
            ImageUrl = "https//placehold.co/100",
        }
    };

    public IEnumerable<Data> GetAll()
    {
        return datas;
    }

    public Data? Get(int id)
    {
        return datas.Find(data => data.ID == id);
    }

    public void Create(Data data)
    {
        data.ID = datas.Max(data => data.ID) + 1;
        datas.Add(data);
    }
    public void Update(Data UpdatedData)
    {
        var index = datas.FindIndex(data => data.ID == UpdatedData.ID);
        datas[index] = UpdatedData;
    }
    public void Delete(int id)
    {
        var index = datas.FindIndex(data => data.ID == id);
        datas.RemoveAt(index);
    }
}