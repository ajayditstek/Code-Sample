using System;

namespace Demo.Core.DTOs.Request
{
    public class AddPanelBeaterClientDTO
    {
        public string ClientName { get; set; }
        public string ClientTradingName { get; set; }
        public string CompanyRegNumber { get; set; }
        public string VATRegNumber { get; set; }
        public string ExternalID { get; set; }
        public string TMSClientCode { get; set; }
        public string tmsNotificationEmailAddressNewReference { get; set; }
        public string tmsNotificationEmailAddressPartsSummaries { get; set; }
        public string Email { get; set; }
        public string NotificationEmailAddress { get; set; }
        public string PartsAuthEmailAddress { get; set; }
        public string TMSNotificationEmailAddress { get; set; }
        public string PaymentNotificationEMail { get; set; }
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
        public string WIPAlertPerson { get; set; }
        public string AccountCode { get; set; }
        public string FactorerId { get; set; }
        public string LoanAccountCode { get; set; }
        public string Rating { get; set; }
        public string RemittanceContactEmail { get; set; }
        public string RemittanceContactPerson { get; set; }
        public bool PayAndClear { get; set; }
        public bool EnableDeductions { get; set; }
        public string FinalInvoiceNotificationEmail { get; set; }
        public string RegionId { get; set; }
        public string CityId { get; set; }
        public string SuburbId { get; set; }
        public bool BatchPayments { get; set; }
        public decimal ContingencyPercent { get; set; }
        public decimal DefaultFunding { get; set; }
        public bool IgnoreInsurerRebate { get; set; }
        public string ClaimAdministrator { get; set; }
        public string PartsSummaryAlertPerson { get; set; }
        public string PopUpPartsSummaryAlertPerson { get; set; }
        public string ActionPerformedBy { get; set; }
        public string ClaimController { get; set; }
        public string ClaimControllerAlt { get; set; }
        public string BankAllocation { get; set; }
        public bool OnHold { get; set; }
        public string OnHoldReason { get; set; }
        public bool? DeductionCodfeeEnabled { get; set; }
        // public bool IgnoreInsurerRebate { get; set; }

    }

    public class UpdatePanelBeaterClientDTO : AddPanelBeaterClientDTO
    {
        public string ClientId { get; set; }
        public bool Active { get; set; }
        public bool Legal { get; set; }

    }


}