using System.ComponentModel.DataAnnotations;

namespace ServicioVentaApi.Models.Costumers.Dto
{
    public class UpdateCostumer
    {
        [Required(ErrorMessage = "Debe ingresar su nombre")]
        public string Name { get; set; } = null!;

        [Required(ErrorMessage = "Debe ingresar su apellido")]
        public string Lastname { get; set; } = null!;

        [Required(ErrorMessage = "Debe ingresar su dirección")]
        public string Adress { get; set; } = null!;

        [Required(ErrorMessage = "Debe ingresar su telefono")]
        public string PhoneNumber { get; set; } = null!;

        [Required(ErrorMessage = "Debe ingresar un mail")]
        public string Email { get; set; } = null!;

        [Required(ErrorMessage = "Debe ingresar una contraseña")]
        public string password { get; set; } = null!;
    }
}
