using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoEntityFramework.Models
{
    [Table("Category")]
    public class Category
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Identity banco de dados
        public int Id { get; set; }

        [Required] //not null
        [MinLength(3)] // tamanho minimo
        [MaxLength(80)] // tamanho maximo
        [Column("Name", TypeName = "NVARCHAR")] // nome da coluna e tipo
        public string Name { get; set; }

        [Required] //not null
        [MinLength(3)] // tamanho minimo
        [MaxLength(80)] // tamanho maximo
        [Column("Slug", TypeName = "NVARCHAR")] // nome da coluna e tipo
        public string Slug { get; set; }
    }
}