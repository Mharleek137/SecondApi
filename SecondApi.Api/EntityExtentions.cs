using SecondApi.Api.Entities;

namespace SecondApi.Api;

public static class EntityExtentions
{
    public static DataDto AsDto(this Data data)
    {
        return new DataDto(
            data.ID,
            data.UserName,
            data.GameType,
            data.Weapon,
            data.Rank,
            data.Position
        );
    }
}