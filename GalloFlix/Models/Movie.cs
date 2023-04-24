using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GalloFlix.Models;
    public class Movie
    {
         [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

    
        [Display(Name ="Título Original")]
        [Required(ErrorMessage = "O Título é obrigatório!")]
        [StringLength(100, ErrorMessage = "O Título deve possuir no máximo 100 caracteres")]
         public string Title { get; set; }


        [Display(Name ="Título Original")]
        [Required(ErrorMessage = "O Título Orginal é obrigatório!")]
        [StringLength(100, ErrorMessage = "O Título Original deve possuir no máximo 100 caracteres")]
         public int OriginalTitle { get; set; }

        [Display(Name ="Sinopse")]
        [Required(ErrorMessage = "A Sinopse é obrigatória")]
        [StringLength(5000, ErrorMessage = "O Sinopse deve possuir no máximo 5000 caracteres")]
        public string Synopsis { get; set; }

        [Column(TypeName ="Year")]
        [Display(Name = "Ano de Estreia")]
        [Required(ErrorMessage = "O Ano de Estreia é obrigatório!")]
        public Int16 MovieYear { get; set; }

        [Display(Name = "Duração (em minutos)")]
        [Required(ErrorMessage = "A Duração é obrigatória!")]

        public Int16 Duration { get; set; }

        [Display(Name = "Classificação Etária")]
        [Required(ErrorMessage = "O Classificação Etária é obrigatória!")]

        public byte AgeRating { get; set; }

        [StringLength(200)]
        [Display(Name = "Foto")]
        public string Image { get; set; }

        [NotMapped]
        [Display(Name = "Duração")]
        
        public string HourDuration { get {
            return TimeSpan.FromMinutes(Duration).ToString(@"%h 'h 'mn'min' ");
        }}
    }