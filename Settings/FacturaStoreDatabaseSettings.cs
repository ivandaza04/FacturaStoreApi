namespace FacturaStoreApi.Models;

public class FacturaStoreDatabaseSettings
{
    public string ConnectionString { get; set; } = null!;

    public string DatabaseName { get; set; } = null!;

    public string FacturasCollectionName { get; set; } = null!;
}