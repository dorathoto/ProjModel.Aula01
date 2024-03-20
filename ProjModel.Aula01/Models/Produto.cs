using System.ComponentModel.DataAnnotations;

namespace ProjModel.Aula01.Models
{
    public class Produto
    {
        public int ProdutoId { get; set; }

        [Required]
        [MaxLength(100, ErrorMessage ="O campo {0} precisa ter pelo menos {1} caracteres!")]
        public string Nome { get; set; }

        [Required]
       // [Range(0.01, double.MaxValue)] //Falha bastante para PT-BR teria que fazer um validador separado
        public decimal Preco { get; set; }

        [Required]
        public int CategoriaId { get; set; }

        public virtual Categoria? Categoria { get; set; }
    }
}
