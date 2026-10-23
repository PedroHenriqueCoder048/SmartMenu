using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SmartMenu.Models;

public class Order {

    public int Id{get; set;}
    public Client? IdClient{get;set;}
    public decimal Price {get; set;}
    public ICollection<ProductsOrder> IdProductOrder {get;set;} = new List<ProductsOrder>();
    public decimal TotalPrice {get;set;}
    public DateTime Data { get; set; } = DateTime.Now;

}