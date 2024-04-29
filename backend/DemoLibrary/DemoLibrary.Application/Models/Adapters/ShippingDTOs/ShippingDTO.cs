
namespace DemoLibrary.Application.Models.Adapters.ShippingDTOs
{
    public class ShippingDTO
    {
        public int Option { get; set; }
        public string User { get; set;}
        public string OriginCode { get; set;}
        public string ShippingNumber { get; set; }
        public string ShippingTypeCode { get; set; }
        public string OriginatorCode { get; set; }
        public string OriginatorName { get; set; }
        public string EmissionDate { get; set; }
        public string ReferencePO { get; set; }
        public string ReferenceTypePO { get; set; }
        public string ReferenceWO { get; set; }
        public string DestinationCode { get; set; }
        public string ProviderCode { get; set; }
        public string ProviderName { get; set; }
        public string State { get; set; }
        public string PackageCode { get; set; }
        public string PackagesNumber { get; set; }
        public string Observation { get; set; }
        public string AssignedBuyerCode { get; set; }
        public string PageNumber { get; set; }
        public string NumberOfRecords { get; set; }
    }
}
