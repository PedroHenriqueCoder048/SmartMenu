using System.ComponentModel.DataAnnotations;

namespace SmartMenu.Models;

public class Client
{
    
    public int Id {get; set;}
    public string? Name {get;set;}
    public Order? IdOrder {get; set;}

}

