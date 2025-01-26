using AutoMapper;
using MicroondasBenner.Data;
using MicroondasBenner.Data.DTOs;
using MicroondasBenner.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
        var cookModelRegistred = _context.CookModes.FirstOrDefault(c => c.Nome == createCookModelDTO.Nome);
        if (cookModelRegistred is not null) { throw new Exception("Modelo pré-definido já cadastrado"); }
        var stringRegistred = _context.CookModes.FirstOrDefault(c => c.stringAquecimento == createCookModelDTO.stringAquecimento);
        if (stringRegistred is not null) { throw new Exception("String de aquecimento já cadastrada"); }

        cookModels.Alteravel = true;
        _context.Add(cookModels);
        await _context.SaveChangesAsync();
        return cookModels;
    }

    public async Task<CookModels> UpdateCookModel(CreateCookModelDTO createCookModelDto)
    {
        var existingCookModel = await _context.CookModes.FirstOrDefaultAsync(c => c.Nome == createCookModelDto.Nome);
        if (existingCookModel == null)
        {
            throw new InvalidOperationException("CookModel não encontrado");
        }
        if (existingCookModel.Alteravel == false) 
        {
            throw new InvalidOperationException("Modelo pré definido não pode ser alterado");
        }

        _mapper.Map(createCookModelDto, existingCookModel);

        _context.CookModes.Update(existingCookModel);

        await _context.SaveChangesAsync();

        return existingCookModel;
    }

    public async Task<List<ReadCookModelDTO>> GetAllCookModel()
    {
        var cookModels = await _context.CookModes.ToListAsync();
        var mapperCookModels = _mapper.Map<List<ReadCookModelDTO>>(cookModels);

        if (!cookModels.Any()) 
        { 
            throw new Exception("Nenhum arquivo no banco de dados"); 
        }

        return mapperCookModels;
    }

    public async Task<CookModels> DeleteCookModel(string name)
    {
        var cookModelToDelete = await _context.CookModes.FirstOrDefaultAsync(c =>c.Nome == name);

        if (cookModelToDelete == null) 
        { 
            throw new Exception("Produto não localizado"); 
        };
        if (cookModelToDelete.Alteravel == false)
        {
            throw new Exception("Produto sem altorização para deletar");
        }

        _context.CookModes.Remove(cookModelToDelete);
        await _context.SaveChangesAsync();

        return cookModelToDelete;
    }
}
