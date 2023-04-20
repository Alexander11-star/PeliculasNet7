using System.ComponentModel.DataAnnotations;

namespace ApiPeliculas.Modelos.Dtos
{
    public class UsuarioRegistroDto
    {
        [Required(ErrorMessage = "El usuario es obligatiorio")]
        public string NombreUsuario { get; set; }
        [Required(ErrorMessage = "El nombre es obligatiorio")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "El password es obligatiorio")]
        public string Password { get; set; }
        public string Role { get; set; }
    }
}
