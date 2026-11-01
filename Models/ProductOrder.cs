using System.ComponentModel.DataAnnotations;

namespace SmartMenu.Models;

public class ProductsOrder
{
 
    public int Id { get; set; }

    [Required]
    [Range(1, int.MaxValue, ErrorMessage = "A quantidade deve ser no minimo 1")]
    public int Quantity {get;set;}

    [Required]
    public Order Order {get;set;} = null!;
    
    [Required]
    public Product Product {get;set;} =null!;

    public ICollection<ProductsOrder> ProductsOrders { get; set; }
        = new List<ProductsOrder>();

}