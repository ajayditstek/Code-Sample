namespace Demo.Repository.Enums
{
    public enum ResponseStatus
    {
        Success = 1,
        Error,
        Warning,
        Info
    }
    public static class ResponseCode
    {
       public static int Success = 200;
       public static int Error = 400;
    }
    public static class ResponseMessages
    {
        public static string SupplierExternalNameSaved = "Supplier external name saved successfully.";
        public static string SupplierBrandSaved = "Supplier brand saved successfully.";
        public static string SupplierNameAlreadyExists = "Supplier name already exists.";
        public static string ErrorCreatingRebateStructure = "Error creating specified rebate structure.";
        public static string SupplierCreated = "Supplier added successfully.";
        public static string SupplierEdited = "Supplier updated successfully.";
        public static string HoldResonRequired = "A reason is required when placing a supplier on hold.";
        public static string RequestedSupplierAdded = "Requested supplier added successfully.";
        public static string PanelBeaterClientAdded = "Panel beater client added successfully.";
        public static string PanelBeaterClientWithSameNameExists = "Panel beater client with same name already exists.";
        public static string PanelBeaterClientUpdated = "Panel beater client updated successfully.";
        public static string NoPanelBeaterExists = "No Panel beater client with such Id exits.";
        public static string PbClientSupplierUpdated = "Panel beater client supplier updated successfully.";
        public static string NoPbClientSupplierExists = "No Panel beater client supplier exists with such Id.";
        public static string NoSupplierExternalNameExist = "No External Name with such Id Exists.";
        public static string SupplierExternalNameUpdated = "Supplier external name updated successfully.";
        public static string SupplierExternalNameDeleted = "Supplier external name deleted successfully.";
        public static string NoSupplierClientExists = "No Supplier client with such Id exists.";
        public static string SupplierClientUpdated = "Supplier client updated successfully.";
        public static string NoSupplierBrandExists = "No Supplier Brand exist with such Id.";
        public static string SupplierBrandDeleted = "Supplier brand deleted successfully.";
        public static string SupplyLocationsUpdated = "Supply locations updated successfully.";
        public static string SupplyNotificationEmailUpdated = "Supply Notification Email updated successfully.";
        public static string ClientEmailsUpdated = "Panel Beater Client Emails updated successfully.";
        public static string NoClaimExists = "No Claim with such Id exists.";
        public static string PartSummaryRequested = "Parts summary requested successfully.";
        public static string ClaimAdded = "Claim created successfully.";
        public static string InsurerClaimNumberAlreadyInUse = "Insurer claim number already in use.";
        public static string JobCardNoAlreadyExists = "Job Card No. is already in use.";
        public static string ClaimDocumentAdded = "Claim document added successfully.";
        public static string ClaimNotedAdded = "Claim note added successfully.";
        public static string AddClaimNoteFirst = "Please add claim note first.";
        public static string ClaimUpdated = "Claim updated successfully.";
        public static string CannotChangeInvoiceType = "Cannot change the invoice type after final invoice authorisation.";
        public static string CannotSetToNoParts = "Cannot set Invoice Type to No Parts, a parts invoice has already been captured.";
        public static string PleaseEnterCredentials = "Please Enter Credentials First.";
        public static string LoginSuccessful = "Login Successful.";
        public static string InvalidLoginCredentials = "Invalid login credentials.";
        public static string ClaimRequested = "Claim Requested successfully.";
        public static string ClaimRequestedDeclined = "Claim request declined.";
        public static string NoClaimRequestExists = "No Claim request with such Id Exists.";
        public static string InvoiceTypeConflict = "Invoice Type Conflict: Claim is marked as no Parts but suppliers are selected.";
        public static string EstimatedDaysToCompleteError = "Estimated days to complete the job cannot be less then 1.";
        public static string InvoiceTypeError = "A Supplier must be selected to create a claim of type: Parts Only.";
        public static string RequestedClaimAdded = "Claim created successfully with Demo Number : ";
        public static string NoAssignedSupplierExists = "No Supplier exists with such Id for panel beater";
        public static string SupplierUnassigned = "Supplier unassigned sucessfully.";
        public static string SupplierRequested = "Supplier requested successfully.";
        public static string AddRequiredFields = "Please add rquired fields.";
        public static string SupplierAssigned = "Supplier assigned to panel beater successfully.";
        public static string EnsureYouAreAssignedToPanelBeater = "Please ensure you are assigned to a panel beater.";
        public static string InsurerRequestSent = "The insurer request was sent successfully, a Demo employee will get back to you shortly.";
        public static string VehicleRegistrationAlreadyInUse = "Vehicle registration number already in use.";
        public static string ClaimNumberPrefixIncorrect = "The Claim No Prefix is incorrect. it should be ";
        public static string ClaimNumberSuffixIncorrect = "The Claim No Suffix is incorrect. it should be ";
        public static string ClaimDraftSaved = "Claim draft saved successfully.";
        public static string ClaimDraftDeleted = "Claim draft deleted successfully.";
        public static string NoClaimDraftExists = "No Claim draft exists with such Id.";
        public static string DeclinedClaimDeleted = "Declined claim deleted successfully.";
        public static string RequestedClaimDeleted = "Requested claim deleted successfully.";
        public static string ClaimDraftUpdated = "Claim draft updated successfully.";
        public static string DocumentRemoved = "Document deleted successfully.";
        public static string NoDocumentExists = "No document with such Id exists.";

        //public static string SupplierChargesSurcharge = "Supplier is a COD supplier, Payment will charge 5% surcharge.";
    }
}
