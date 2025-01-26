using AutoMapper;
using MicroondasBenner.Data.DTOs;
using MicroondasBenner.Models;

namespace MicroondasBenner.Profiles;

public class CookModelProfile: Profile
{
    public CookModelProfile() 
    {
        CreateMap<CreateCookModelDTO, CookModels>();
        CreateMap<CookModels, ReadCookModelDTO>();
    }
}
