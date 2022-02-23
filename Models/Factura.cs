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
    public decimal totalFactura { get; set; }

    [BsonElement("SubTotal")]
    public decimal subTotal { get; set; }

    [BsonElement("Iva")]
    public decimal iva { get; set; }

    [BsonElement("Retencion")]
    public decimal retencion { get; set; }

    [BsonElement("FechaCreacion")]
    public string fechaCreacion { get; set; } = null!;

    [BsonElement("Estado")]
    public string estado { get; set; } = null!;

    [BsonElement("Pagada")]
    public Boolean pagada { get; set; }

    [BsonElement("FechaPago")]
    public string fechaPago { get; set; } = null!;

}