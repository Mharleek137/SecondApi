namespace SecondApi.Api;

public record DataDt0
(
    int ID ,
    
    string UserName ,
    
    int Rank ,
   
    string Weapon ,
    
    string GameType ,
 
    string Position ,
  
    int Stats ,

    string GameStyle ,
  
    string ImageUrl ,
);

public record CreateDataDto
(
    string UserName ,
    
    int Rank ,
   
    [Required][StringLength(50)]string Weapon ,
    
    [Required][StringLength(50)]string GameType ,
 
    [Required][StringLength(50)]string Position ,
  
    [Range(1 , 100)]int Stats ,

    [Required][StringLength(50)]string GameStyle ,
  
    [Required][StringLength(50)]string ImageUrl ,
);