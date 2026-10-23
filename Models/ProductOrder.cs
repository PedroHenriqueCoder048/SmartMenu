using System.ComponentModel.DataAnnotations;

namespace SmartMenu.Models;

public class ProductsOrder
{
    [Required,MaxLength(100)]
    public string? Name {get;set;}
    [Required]
    public decimal Price {get; set;}
    [Required]
    public string? TypeProduct {get;set;}
    public string? Descreption{get;set;}
    [Required]
    public  ICollection<Order> IdOrder {get;set;} = new List<Order>();
    public int Quantity {get;set;}

}