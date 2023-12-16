namespace Livraria
{
    public class LivroCategoria
    {
        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }
        public int LivroId { get; set; }
        public Livro Livro { get; set; }
    }
}
