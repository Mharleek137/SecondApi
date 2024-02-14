using System.ComponentModel.DataAnnotations;

namespace SecondApi.Api.Entities;

public class Data
{
    
    public int ID { get; set; }
    [Required]
    //[StringLength(50)]
    public required string UserName { get; set; }
    [Required]
    //[StringLength(500)]
    public int Rank { get; set; }
    [Required]
   // [StringLength(50)]
    public required string Weapon { get; set; }
    [Required]
    //[StringLength(50)]
    public required string GameType { get; set; }
    [Required]
    //[StringLength(20)]
    public required string Position { get; set; }
    [Required]
    //[StringLength(50)]
    public int Stats { get; set; }
    [Required]
    
    public required string GameStyle { get; set; }
    [Required]
    //[StringLength(100)]
    public required string ImageUrl { get; set; }
}