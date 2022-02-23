using FacturaStoreApi.Models;
using FacturaStoreApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace FacturaStoreApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class FacturasController : ControllerBase
{
    private readonly FacturasService _facturasService;

    public FacturasController(FacturasService facturasService) =>
        _facturasService = facturasService;

    [HttpGet]
    public async Task<List<Factura>> Get() =>
        await _facturasService.GetAsync();

    [HttpGet("{id:length(24)}")]
    public async Task<ActionResult<Factura>> Get(string id)
    {
        var factura = await _facturasService.GetAsync(id);

        if (factura is null)
        {
            return NotFound();
        }

        return factura;
    }

    [HttpPost]
    public async Task<IActionResult> Post(Factura newFactura)
    {
        await _facturasService.CreateAsync(newFactura);

        return CreatedAtAction(nameof(Get), new { id = newFactura.Id }, newFactura);
    }

    [HttpPut("{id:length(24)}")]
    public async Task<IActionResult> Update(string id, Factura updatedFactura)
    {
        var factura = await _facturasService.GetAsync(id);

        if (factura is null)
        {
            return NotFound();
        }

        updatedFactura.Id = factura.Id;

        await _facturasService.UpdateAsync(id, updatedFactura);

        return NoContent();
    }

    [HttpDelete("{id:length(24)}")]
    public async Task<IActionResult> Delete(string id)
    {
        var factura = await _facturasService.GetAsync(id);

        if (factura is null)
        {
            return NotFound();
        }

        await _facturasService.RemoveAsync(id);

        return NoContent();
    }
}