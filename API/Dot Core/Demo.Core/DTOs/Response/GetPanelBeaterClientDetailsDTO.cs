using System;
using System.Collections.Generic;

namespace Demo.Core.DTOs.Response
{
    public class GetPanelBeaterClientDetailsDTO
    {
        public Guid ClientId { get; set; }
        public string ClientName { get; set; }
        public string ClientTradingName { get; set; }
        public string CompanyRegNumber { get; set; }
        public string VATRegNumber { get; set; }
        public string TMSClientCode { get; set; }
        public string Email { get; set; }
        public string NotificationEmailAddress { get; set; }
        public string PartsAuthEmailAddress { get; set; }
        public string TMSNotificationEmailAddress { get; set; }
        public string PaymentNotificationEMail { get; set; }
        public string TMSNotificationEmailAddressNewReference { get; set; }
        public string TMSNotificationEmailAddressPartsSummaries { get; set; }
        public string TelNumber { get; set; }
        public string FaxNumber { get; set; }
        public string CellNumber { get; set; }
        public string PhysicalAddr1 { get; set; }
        public string PhysicalAddr2 { get; set; }
        public string PhysicalAddr3 { get; set; }
        public string PhysicalAddrCode { get; set; }
        public string PostalAddr1 { get; set; }
        public string PostalAddr2 { get; set; }
        public string PostalAddr3 { get; set; }
        public string PostalAddrCode { get; set; }
        public string AccountCode { get; set; }
        public string LoanAccountCode { get; set; }
        public string ExternalId { get; set; }
        public bool? OnHold { get; set; }
        public string OnHoldReason { get; set; }
        public bool? PayAndClear { get; set; }
        public string RemittanceContactEmail { get; set; }
        public string RemittanceContactPerson { get; set; }
        public bool? Active { get; set; }
        public bool? Legal { get; set; }
        public bool? DeductionCODFeeEnabled { get; set; }
        public Guid? FactorerId { get; set; }
        public bool? EnableDeductions { get; set; }
        public bool? IgnoreInsurerRebate { get; set; }
        public string FinalInvoiceNotificationEmail { get; set; }
        public Guid? RegionId { get; set; }
        public Guid? CityId { get; set; }
        public Guid? SuburbId { get; set; }
        public bool? BatchPayments { get; set; }
        public decimal? DefaultFunding { get; set; }
        public decimal? ContingencyPercent { get; set; }
        public string ClaimAdministrator { get; set; }
        public string WIPAlertPerson { get; set; }
        public string PartsSummaryAlertPerson { get; set; }
        public string PopUpPartsSummaryAlertPerson { get; set; }
        public string ClaimController { get; set; }
        public string ClaimControllerAlt { get; set; }
        public string BankAllocation { get; set; }
        public string Rating { get; set; }
        public List<Recipient> Recipients { get; set; }
        public List<PanelBeaterClientSupplier> PanelBeaterClientSuppliers { get; set; }
    }
    public class Recipient
    {
        public Guid ReportSchedulerRecipients { get; set; }
        public string Recipients { get; set; }
        public string DisplayName { get; set; }
        public Guid ReportsToPDFID { get; set; }
    }
    public class SearchPanelBeaterClientDeatilsDTO
    {
        public string ClientId { get; set; }
    }

    public class PanelBeaterClientSupplier
    {
        public Guid ClientSupplierId { get; set; }
        public Guid ClientId { get; set; }
        public Guid SupplierId { get; set; }
        public string SupplierName { get; set; }
        public string NotificationEmailAddress { get; set; }
        public string AccountCode { get; set; }
    }
}