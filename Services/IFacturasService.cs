using FacturaStoreApi.Models;

namespace FacturaStoreApi.Services;

public interface IFacturasService
{
    Task<List<Factura>> GetAsync();

    Task<Factura?> GetAsync(string id);

    Task CreateAsync(Factura newFactura);

    Task UpdateAsync(string id, Factura updatedFactura);

    Task RemoveAsync(string id);

    Task EstadoAsync(string id, Factura updatedFactura);

}