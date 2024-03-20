using System.ComponentModel.DataAnnotations;

namespace ProjModel.Aula01.Models
{
    public class Categoria
    {

        public int CategoriaId { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "O campo {0} suporte no máximo {1} caracteres!")]
        [MinLength(5, ErrorMessage = "O campo {0} precisa ter pelo menos {1} caracteres!")]
        //[StringLength(50)] //Exception - Usuario
       // [MaxLength(50, ErrorMessage = "O Campo {0} não pode ter menos que {1} caracteres")] // TRUNCATE
        public string Nome { get; set; }

        public virtual ICollection<Produto>? Produtos { get; set; }
    }
}
