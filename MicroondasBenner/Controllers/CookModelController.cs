using MicroondasBenner.Data.DTOs;
using MicroondasBenner.Models;
using MicroondasBenner.Services;
using Microsoft.AspNetCore.Mvc;

namespace MicroondasBenner.Controllers;

[ApiController]
[Route("[controller]")]

public class CookModelController : ControllerBase
{
    private readonly CookModelsServices _services;

    public CookModelController(CookModelsServices services)
    {
        _services = services;
    }

    [HttpPost]
    public async Task<IActionResult> PostCookModel([FromBody] CreateCookModelDTO createCookModelDTO)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        try
        {
            var result = await _services.CreateCookModel(createCookModelDTO);

            return CreatedAtAction(nameof(PostCookModel), result);
        }
        catch (Exception ex) 
        {
            return BadRequest(new { ex.Message });
        }

    }

    [HttpPatch]
    public async Task<IActionResult> UpdateCookModel([FromBody] CreateCookModelDTO updateCookModelDTO)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        try
        {
            var result = await _services.UpdateCookModel(updateCookModelDTO);

            return Ok(result);
        }
        catch (Exception ex)
        {
            return BadRequest(new { ex.Message });
        }
    }

    [HttpGet]
    public async Task<IActionResult> GetAllCookModels()
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        try
        {
            var result = await _services.GetAllCookModel();

            return Ok(result);
        }
        catch (Exception ex)
        {
            return BadRequest(new { ex.Message });
        }
    }

    [HttpDelete]
    public async Task<IActionResult> DeleteCookModel(string name)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        try
        {
            var result = await _services.DeleteCookModel(name);

            return Ok(result);
        }
        catch (Exception ex)
        {
            return BadRequest(new { ex.Message });
        }
    }
}
