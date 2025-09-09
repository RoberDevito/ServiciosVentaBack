using System.ComponentModel.DataAnnotations;

namespace ServicioVentaApi.Models.Admins.Dto
{
    public class CreateAdmin
    {
        [Required(ErrorMessage = "Debe ingresar su nombre")]
        public string name { get; set; } = null!;

        [Required(ErrorMessage = "Debe ingresar su apellido")]
        public string lastname { get; set; } = null!;

        [Required(ErrorMessage = "Debe ingresar un mail")]
        public string email { get; set; } = null!;

        [Required(ErrorMessage = "Debe ingresar una contraseña")]
        public string password { get; set; } = null!;
    }
}
