namespace Demo.Core.DTOs.Request
{
    public class UpdateSupplierNotificationEmailDTO
    {
        public string ClientSupplierId { get; set; }
        public string NotificationEmailAddress { get; set; }
        public string ActionPerformedBy { get; set; }
    }
}