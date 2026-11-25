namespace Demo.Core.DTOs.Request
{
    public class UpdateSupplierExternalNameDTO
    {
        public string SupplierMappingId { get; set; }
        public string ExternalName { get; set; }
        public string ActionPerformedBy { get; set; }
    }
}