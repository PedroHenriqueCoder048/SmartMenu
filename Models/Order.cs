using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SmartMenu.Models;

public class Order {

    public int Id{get; set;}
    public decimal Price {get; set;}
    public decimal TotalPrice {get;set;}
    public DateTime Data { get; set; } = DateTime.Now;


    public Client Client{get;set;} = null! ; 
    public ICollection<ProductsOrder> IdProductOrders {get;set;} = new List<ProductsOrder>();


}