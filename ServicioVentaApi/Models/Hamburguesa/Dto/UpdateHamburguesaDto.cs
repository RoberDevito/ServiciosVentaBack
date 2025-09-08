using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace ServicioVentaApi.Models.Hamburguesa.Dto
{
    public class UpdateHamburguesaDto
    {
        [Required(ErrorMessage = "El nombre de la hamburguesa es obligatorio")]
        public string Nombre { get; set; } = null!;

        [Required(ErrorMessage = "La descripcion de la hamburguesa es obligatoria")]
        public string Descripcion { get; set; }

        [Required(ErrorMessage = "El precio de la hamburguesa es obligatorio")]
        public decimal Precio { get; set; }

        [Required(ErrorMessage = "La imagen de la hamburguesa es obligatoria")]
        public string ImagenUrl { get; set; }

        [Required(ErrorMessage = "Los ingredientes de la hamburguesa son obligatorios")]
        public List<string> Ingredientes { get; set; }

        [Required(ErrorMessage = "El estado de disponibilidad es requerido.")]
        public bool Disponible { get; set; }
    }
}
