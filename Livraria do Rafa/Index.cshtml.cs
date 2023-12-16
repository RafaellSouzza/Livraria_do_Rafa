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
    public class IndexModel : PageModel
    {
        private readonly Livraria.AppDbContext _context;

        public IndexModel(Livraria.AppDbContext context)
        {
            _context = context;
        }

        public IList<Livro> Livro { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Livros != null)
            {
                Livro = await _context.Livros.ToListAsync();
            }
        }
    }
}
