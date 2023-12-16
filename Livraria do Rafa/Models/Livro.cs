using System.Collections.Generic;

namespace Livraria
{
    public class Livro
    {
        public int Id { get; set; }
        public string ImagemUrl { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public string Autor { get; set; }
        public decimal PrecoNormal { get; set; }
        public decimal PrecoComDesconto { get; set; }
        public List<LivroCategoria> LivroCategorias { get; set; }
    }

}
