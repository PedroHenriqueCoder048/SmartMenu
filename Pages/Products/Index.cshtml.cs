using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using NuGet.Protocol;
using SmartMenu.Models;

namespace SmartMenu.Pages.Products
{
    public class IndexModel : PageModel
    {
        private readonly AppDbContext _context;
        public IndexModel(AppDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public List<Product> Products {get;set;} = new List<Product>(); 

        public async Task OnGetAsync()
        {
            Products = await _context.Products.ToListAsync();
        }

        public async  Task<IActionResult> OnPost()
        {

            if (!ModelState.IsValid)
            {
                return Page();
            }

            if (Products == null || !Products.Any())
            {
                Console.WriteLine("------------------------");
                Console.WriteLine("Carrinho vazio");

                return Page();
            }

            foreach (var product in Products)
            {
                
                if (Request.Form.Keys)
                {
                    Console.WriteLine(product.ToJson());
                }

            }

            return RedirectToPage("/Index");

        }

    }
}
