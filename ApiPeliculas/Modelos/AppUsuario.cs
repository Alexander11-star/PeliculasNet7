using Microsoft.AspNetCore.Identity;

namespace ApiPeliculas.Modelos
{
    public class AppUsuario : IdentityUser
    {
        //Añadir campos personalizados
        public string Nombre { get; set; }

        //En la consola de comando de VS escribimos -> add-migration AgregadoNETIdentity
        //Despues -> update-database
    }
}
