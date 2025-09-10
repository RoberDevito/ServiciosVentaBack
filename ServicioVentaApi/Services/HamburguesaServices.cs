using ServicioVentaApi.Utils;
using ServicioVentaApi.Models.Hamburguesa;
using ServicioVentaApi.Config;
using Microsoft.EntityFrameworkCore;
using ServicioVentaApi.Models.Hamburguesa.Dto;
using System.Net;
using AutoMapper;

namespace ServicioVentaApi.Services
{
    public class HamburguesaServices 
    {
        private readonly ApplicationDbContext _db;
        private readonly IMapper _mapper;

        public HamburguesaServices(ApplicationDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        private async Task<Hamburguesa> GetOneByIdOrException(int id)
        {
            var hamburguesa = await _db.Hamburguesas
                .Where(a => a.Id_Hamburguesas == id)
                .FirstOrDefaultAsync();

            if (hamburguesa == null)
            {
                throw new HttpError($"No se encontro la hamburguesa con ID = {id}", HttpStatusCode.NotFound);
            }

            return hamburguesa;
        }

        public async Task<List<AllHamburguesasDto>> GetAll()
        {
            var hamburguesasDb = await _db.Hamburguesas.ToListAsync();
            var hamburguesas = _mapper.Map<List<AllHamburguesasDto>>(hamburguesasDb);
            return hamburguesas;
        }

       /* public async Task<Hamburguesa> CreateOne(CreateHamburguesaDto auto)
        {
            var a = _mapper.Map<Hamburguesa>(auto);
            var estado = await _estadoServices.GetOneByName("Disponible");
            a.Estado = estado;

            await _db.Autos.AddAsync(a);
            await _db.SaveChangesAsync();
            return a;

        }*/

        public async Task<Hamburguesa> GetOneById(int id)
        {
            return await GetOneByIdOrException(id);
        }
    }
}