using Livraria;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Livraria_do_Rafa.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly AppDbContext _context; 

        public IList<Livro> Livros { get; private set; }

        public IndexModel(ILogger<IndexModel> logger, AppDbContext context) 
        {
            _logger = logger;
            _context = context;
        }

        public void OnGet()
        {
            Livros = _context.Livros.ToList();
        }
    }
}
