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
}
