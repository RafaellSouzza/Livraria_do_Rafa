using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Livraria;

namespace Livraria_do_Rafa.Pages.Livros
{
    public class CriarLivroModel : PageModel
    {
        private readonly Livraria.AppDbContext _context;
        [BindProperty]
        public Livro Livro { get; set; } = default!;


        public CriarLivroModel(Livraria.AppDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

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

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Criar([Bind("Titulo,Autor,AnoDePublicacao")] Livro livro)
        {
            if (ModelState.IsValid)
            {
                _context.Add(livro);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return RedirectToPage("./Index");
        }
    }
}
