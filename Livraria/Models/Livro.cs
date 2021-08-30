using System.ComponentModel.DataAnnotations;

namespace Livraria.Models
{
    public class Livro
    {
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string Titulo { get; set; }
    }
}
