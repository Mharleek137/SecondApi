using SecondApi.Api.Entities;
using SecondApi.Api.Repositories;

namespace SecondApi.Api.EndPoints;

public static class DataEndPoints
{
    const string GetDataEndPoint = "GetGame";
    
    public static RouteGroupBuilder MapDataEndPoints(this IEndpointRouteBuilder routes)
    {
        
        var group = routes.MapGroup("/datas")
                    .WithParameterValidation();
        //creating a get endpoint to get all data
        group.MapGet("/", (IDataRepositries repositries) => repositries.GetAll());
        group.MapGet("/{id}", (IDataRepositries repositries, int id) =>
        {
            Data? data = repositries.Get(id);
            return data is not null ? Results.Ok(data) : Results.NotFound();
        })
        .WithName(GetDataEndPoint);
        group.MapPost("/", (IDataRepositries repositries, Data data) =>
        {
            repositries.Create(data);
            return Results.CreatedAtRoute(GetDataEndPoint, new { id = data.ID }, data);
        }
        );

        group.MapPut("/{id}", (IDataRepositries repositries, int id, Data UpdatedData) =>
        {
            Data? ExistingData = repositries.Get(id);
            if (ExistingData is null)
            {
                return Results.NotFound();
            }
            ExistingData.ID = UpdatedData.ID;
            ExistingData.UserName = UpdatedData.UserName;
            ExistingData.Rank = UpdatedData.Rank;
            ExistingData.Weapon = UpdatedData.Weapon;
            ExistingData.GameType = UpdatedData.GameType;
            ExistingData.Position = UpdatedData.Position;
            ExistingData.Stats = UpdatedData.Stats;
            ExistingData.GameStyle = UpdatedData.GameStyle;
            ExistingData.ImageUrl = UpdatedData.ImageUrl;
            repositries.Update(ExistingData);
            return Results.NoContent();

        });
        group.MapDelete("/{id}", (IDataRepositries repositries, int id) =>
        {
            Data? data = repositries.Get(id);
            if (data is not null)
            {
                repositries.Delete(id);
            }
            return Results.Ok();
        });
        return group;
    }
}