//using Azure.Core;
using CarDealerAPI.Utils;
using Microsoft.AspNetCore.Mvc;
using ServicioVentaApi.Models.Hamburguesa;
using ServicioVentaApi.Models.Hamburguesa.Dto;
using ServicioVentaApi.Services;
using ServicioVentaApi.Utils;
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
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(Hamburguesa))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ValidationErrorResponse))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(HttpMessage))]
        public async Task<ActionResult> Create([FromBody] CreateHamburguesaDto hamburguesa)
        {
            try
            {
                var createdAuto = await _hamburguesaServices.CreateOne(hamburguesa);
                return Created("api/cars", createdAuto);
            }
            catch (HttpError ex)
            {
                return StatusCode((int)ex.StatusCode, new HttpMessage(ex.Message));
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new HttpMessage($"Error al crear el auto"));
            }
        }
    }


}