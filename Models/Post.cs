using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoEntityFramework.Models
{
    [Table("Post")]
    public class Post
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Identity banco de dados
        public int Id { get; set; }

        [ForeignKey("AuthorId")]
        public int AuthorId { get; set; }
        public User Author { get; set; }

        [ForeignKey("CategoryId")]
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(160)]
        [Column("Title", TypeName = "VARCHAR")]
        public string Title { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(255)]
        [Column("Summary", TypeName = "VARCHAR")]
        public string Summary { get; set; }

        [Required]
        [Column("Body", TypeName = "TEXT")]
        public string Body { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(80)]
        [Column("Slug", TypeName = "VARCHAR")]
        public string Slug { get; set; }

        [Required]
        [Column("CreateDate", TypeName = "DATETIME")]
        public DateTime CreateDate { get; set; }

        [Required]
        [Column("LastUpdateDate", TypeName = "DATETIME")]
        public DateTime LastUpdateDate { get; set; }

    }
}