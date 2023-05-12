
using System.ComponentModel.DataAnnotations;

namespace GalloFlix.DataTransferObjects;
    public class LoginDto
    {
        public string Email { get; set; }
        [Display(Name = "Email ou Nome de Usuário")]
        [Required(ErrorMessage ="Por favor, informe seu email ou nome de usuário")]
        
        public string Password { get; set; }        
        
        [Display(Name = "Manter Conectado?")]
        public bool RemenberMe { get; set; }
        public string ReturnUrl { get; set; }
    }