using AutoMapper;
using ServicioVentaApi.Models.Hamburguesa;
using ServicioVentaApi.Models.Hamburguesa.Dto;
using static System.Runtime.InteropServices.JavaScript.JSType;

public class HamburguesaProfile : Profile
{
    public HamburguesaProfile()
    {
        // Entity -> DTO
        CreateMap<Hamburguesa, AllHamburguesasDto>();

        // DTO -> Entity (para creaci�n y actualizaci�n)
        CreateMap<CreateHamburguesaDto, Hamburguesa>();
        CreateMap<UpdateHamburguesaDto, Hamburguesa>();
    }
}