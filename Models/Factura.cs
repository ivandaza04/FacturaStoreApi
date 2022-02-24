using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace FacturaStoreApi.Models;

public class Factura
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string? Id { get; set; }

    [BsonElement("CodigoFactura")]
    public string codigoFactura { get; set; } = null!;

    [BsonElement("Cliente")]
    public string cliente { get; set; } = null!;

    [BsonElement("Ciudad")]
    public string ciudad { get; set; } = null!;

    [BsonElement("NIT")]
    public string nit { get; set; } = null!;

    [BsonElement("TotalFactura")]
    public string totalFactura { get; set; } = null!;
}