namespace Demo.Core.DTOs.Request
{
    public class UpdateClientEmailAddressesDTO
    {
        public string ClientId { get; set; }
        public string Email { get; set; }
        public string NotificationEmailAddress { get; set; }
        public string tmsNotificationEmailAddress { get; set; }
        public string PaymentNotificationEmail { get; set; }
        public string ActionPerformedBy { get; set; }
    }
}