using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Livraria;

namespace Livraria_do_Rafa
{
    public class DeleteModel : PageModel
    {
        private readonly Livraria.AppDbContext _context;

        public DeleteModel(Livraria.AppDbContext context)
        {
            _context = context;
        }

        [BindProperty]
      public Livro Livro { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Livros == null)
            {
                return NotFound();
            }

            var livro = await _context.Livros.FirstOrDefaultAsync(m => m.Id == id);

            if (livro == null)
            {
                return NotFound();
            }
            else 
            {
                Livro = livro;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Livros == null)
            {
                return NotFound();
            }
            var livro = await _context.Livros.FindAsync(id);

            if (livro != null)
            {
                Livro = livro;
                _context.Livros.Remove(Livro);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
