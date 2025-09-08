using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace ServicioVentaApi.Models.Hamburguesa
{
    public class Hamburguesa
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public decimal Precio { get; set; }
        public string ImagenUrl { get; set; }
        public List<string> Ingredientes { get; set; }
        public bool Disponible { get; set; }
    }
}