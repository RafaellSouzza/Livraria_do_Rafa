using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Livraria;

namespace Livraria_do_Rafa
{
    public class CreateModel : PageModel
    {
        private readonly Livraria.AppDbContext _context;

        public CreateModel(Livraria.AppDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Livro Livro { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Livros == null || Livro == null)
            {
                return Page();
            }

            _context.Livros.Add(Livro);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
