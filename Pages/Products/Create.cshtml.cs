using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using SmartMenu.Models;

namespace SmartMenu.Pages.Products
{
    public class CreateModel : PageModel
    {
        private readonly AppDbContext _context;

        public CreateModel(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Product Product { get; set; } = new Product();

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostSaveAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Products.Add(Product);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }

        public async Task<IActionResult> OnPostSaveAndContinueAsync()
        {
             if (!ModelState.IsValid)
                {
                    return Page();
                }

            _context.Products.Add(Product);
            
            await _context.SaveChangesAsync();

            TempData["SuccessMessage"] =
                "Produto salvo com sucesso! Formulário pronto para novo cadastro.";

            return RedirectToPage("./Create");

        }
    }
}
