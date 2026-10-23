using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SmartMenu.Pages;

public class IndexModel : PageModel
{

    public List<string> Client {get;set;} = new()
    {
      "Pedro Henrique",
      "anne carneiro",
      "Lilian Raquel"  
    };

    public List<string> Produtos { get; set; } = new()
    {
        "Hambúrguer - 8,50 €",
        "Pizza - 12,00 €",
        "Sumo - 2,00 €"
    };

    public List<string> Pedidos { get; set; } = new()
    {
        "Pedido 001 - Ana Silva",
        "Pedido 002 - João Costa",
        "Pedido 003 - Maria Santos"
    };

    

    public void OnGet()
    {

    }
}
