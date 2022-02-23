using FacturaStoreApi.Models;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace FacturaStoreApi.Services;

public class FacturasService
{
    private readonly IMongoCollection<Factura> _facturasCollection;

    public FacturasService(
        IOptions<FacturaStoreDatabaseSettings> facturaStoreDatabaseSettings)
    {
        var mongoClient = new MongoClient(
            facturaStoreDatabaseSettings.Value.ConnectionString);

        var mongoDatabase = mongoClient.GetDatabase(
            facturaStoreDatabaseSettings.Value.DatabaseName);

        _facturasCollection = mongoDatabase.GetCollection<Factura>(
            facturaStoreDatabaseSettings.Value.FacturasCollectionName);
    }

    public async Task<List<Factura>> GetAsync() =>
        await _facturasCollection.Find(_ => true).ToListAsync();

    public async Task<Factura?> GetAsync(string id) =>
        await _facturasCollection.Find(x => x.Id == id).FirstOrDefaultAsync();

    public async Task CreateAsync(Factura newFactura) =>
        await _facturasCollection.InsertOneAsync(newFactura);

    public async Task UpdateAsync(string id, Factura updatedFactura) =>
        await _facturasCollection.ReplaceOneAsync(x => x.Id == id, updatedFactura);

    public async Task RemoveAsync(string id) =>
        await _facturasCollection.DeleteOneAsync(x => x.Id == id);
}