using System.ComponentModel.DataAnnotations;

namespace SmartMenu.Models;

public class Products
{
    
    public string? Name {get;set;}
    public decimal Price {get; set;}
    public string? TypeProduct {get;set;}
    public string? Descreption{get;set;}
    public ProductsOrder? IdProductOrder {get;set;}
    public decimal UnitPrice {get;set;}
}