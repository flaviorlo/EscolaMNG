using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AppReact._2_Domain.Model
{
    [Table("Aluno")]
    public class Aluno
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(80)]
        public string Nome { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public int Idade { get; set; }
        [Required]
        public string Cpf { get; set; }


    }
}
