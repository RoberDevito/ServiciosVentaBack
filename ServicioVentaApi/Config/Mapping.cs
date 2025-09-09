using AutoMapper;
using ServicioVentaApi.Models.Hamburguesa;
using ServicioVentaApi.Models.Hamburguesa.Dto;

public class HamburguesaProfile : Profile
{
    public HamburguesaProfile()
    {
        // Entity -> DTO
        CreateMap<Hamburguesa, AllHamburguesasDto>();

        // DTO -> Entity (para creación y actualización)
        CreateMap<CreateHamburguesaDto, Hamburguesa>();
        CreateMap<UpdateHamburguesaDto, Hamburguesa>();
    }
}