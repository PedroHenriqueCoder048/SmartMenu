using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartMenu.Models;

public class Client
{
    [Key]
    [Display(Name = "Código do Cliente")]
    public int Id {get; set;}
    
    [Required(errorMessage = "Campo obrigatório")]
    [StringLength(100, MinimumLength = 3, ErrorMessage = "O nome deve ter entre 3 e 100 caracteres")]
    [Display(Name = "Nome do Cliente")]
    public string? Name {get;set;}

    public Order? IdOrder {get; set;}

}

