using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ServicioVentaApi.Models.Hamburguesa
{
    public class Hamburguesa
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id_Hamburguesas { get; set; }

        [Required]
        public string Nombre { get; set; } = null!;

        [Required]
        public string Descripcion { get; set; } = null!;

        [Column(TypeName = "decimal(18,2)")]
        public decimal Precio { get; set; }

        public string ImagenUrl { get; set; } = string.Empty;

        // Guardamos ingredientes como string (ej: "Carne, Queso, Lechuga")
        public string Ingredientes { get; set; } = string.Empty;

        public bool Disponible { get; set; }
    }
}
