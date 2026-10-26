using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartMenu.Models;

public class Products
{
    [Key]
    public int Id {get; set;}

    [Required, StringLength(100, ErrorMessage = "O campo {0} deve ter entre 3 e 100 caracteres")]
    [Display(Name = "Nome do Produto")]
    public string? Name {get;set;}

    [Required]
    [Display (Name = "Preço do Produto")]
    [Column(TypeName = "decimal(18,2)")]
    public decimal UnitPrice {get; set;}

    [Required]
    [Display(Name = "Tipo do Produto")]
    public string? TypeProduct {get;set;}
    
    [Display(Name = "Descrição do Produto")]
    public string? Descreption{get;set;}

    public ProductsOrder? IdProductOrder {get;set;}
    public decimal UnitPrice {get;set;}
}