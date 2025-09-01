using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorPagesMovie.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O título é obrigatório.")]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "O título deve ter entre 3 e 60 caracteres.")]
        public string Title { get; set; } = string.Empty;

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "A data de lançamento é obrigatória.")]
        public DateTime ReleaseDate { get; set; }

        [Required(ErrorMessage = "O gênero é obrigatório.")]
        [StringLength(30)]
        public string Genre { get; set; } = string.Empty;

        [Column(TypeName = "decimal(18, 2)")]
        [Range(1, 100, ErrorMessage = "O preço deve estar entre 1 e 100.")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "O rating é obrigatório.")]
        [StringLength(5, ErrorMessage = "O rating deve ter no máximo 5 caracteres.")]
        public string Rating { get; set; } = string.Empty;
    }
}
