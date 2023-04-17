using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GalloFlix.Models;
    public class Movie
    {
         [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OriginalTitle { get; set; }

        [Display(Name ="Título Original")]
        [Required(ErrorMessage = "O Título Orginal é obrigatório!")]
        [StringLength(100, ErrorMessage = "O Título deve possuir no máximo 100 caracteres")]
        public string Title { get; set; }

        [Display(Name ="Sinopse")]
        [StringLength(5000, ErrorMessage = "O Sinopse deve possuir no máximo 5000 caracteres")]
        public string Synopsis { get; set; }

        public int MovieYear { get; set; }

        public int Duartion { get; set; }

        public int AgeRating { get; set; }

        public string Image { get; set; }

    }