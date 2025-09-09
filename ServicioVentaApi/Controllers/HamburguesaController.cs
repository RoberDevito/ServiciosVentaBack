using Azure.Core;
using Microsoft.AspNetCore.Mvc;
using ServicioVentaApi.Models.Hamburguesa;  
using ServicioVentaApi.Models.Hamburguesa.Dto;
using ServicioVentaApi.Services;
using System.Net;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;


namespace ServicioVentaApi.Controllers 
{
    [ApiController]
    [Route("api/hamburguesa")]
    public class HamburguesaController : ControllerBase
    {
        private readonly HamburguesaServices _hamburguesaServices;
        public HamburguesaController(HamburguesaServices hamburguesaServices)
        {
            _hamburguesaServices = hamburguesaServices;
        }

        [HttpGet]
        public async Task<List<AllHamburguesasDto>> GetAll()
        {
            return await _hamburguesaServices.GetAll();
        }

    }
}
