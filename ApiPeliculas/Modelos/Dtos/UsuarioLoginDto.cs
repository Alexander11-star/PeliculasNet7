using System.ComponentModel.DataAnnotations;

namespace ApiPeliculas.Modelos.Dtos
{
    public class UsuarioLoginDto
    {
        [Required(ErrorMessage = "El usuario es obligatiorio")]
        public string NombreUsuario { get; set; }
        [Required(ErrorMessage = "El nombre es obligatiorio")] 
        public string Password { get; set; }
    }
}
