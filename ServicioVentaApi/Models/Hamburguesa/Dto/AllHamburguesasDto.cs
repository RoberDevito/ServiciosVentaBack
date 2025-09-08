using System.Runtime.InteropServices;

namespace ServicioVentaApi.Models.Hamburguesa.Dto
{
    public class AllHamburguesasDto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public string ImagenUrl { get; set; }
        public List<string> Ingredientes { get; set; }
    }
}