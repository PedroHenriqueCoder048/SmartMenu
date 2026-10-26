using System.ComponentModel.DataAnnotations;

namespace SmartMenu.Models;

public class ProductsOrder
{
 
    [Required]
    public Products? IdProduct {get;set;}
    [Required]
    public Order? IdOrder {get;set;}
    [Required(ErrorMessage = "A quantidade deve ser maior que zero")]
    [Range(1, int.MaxValue, ErrorMessage = "A quantidade deve ser no minimo 1")]
    public int Quantity {get;set;}

}