using AutoMapper;
using MicroondasBenner.Data;
using MicroondasBenner.Data.DTOs;
using MicroondasBenner.Models;

namespace MicroondasBenner.Services;

public class CookModelsServices
{
    protected MicrowaveDbContext _context;
    protected IMapper _mapper;

    public CookModelsServices(MicrowaveDbContext context, IMapper mapper) 
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<CookModels> CreateCookModel(CreateCookModelDTO createCookModelDTO)
    {
        CookModels cookModels = _mapper.Map<CookModels>(createCookModelDTO);
        _context.Add(cookModels);
        await _context.SaveChangesAsync();
        return cookModels;
    }
}
