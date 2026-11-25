namespace Demo.Repository.Common.StoreProcedures
{
    public static class StoreProcedures
    {
        public static string AddAPILog = "sp_AddAPILog";
        public static string UpdateAPILog = "sp_UpdateAPILog";
        public static string GetSupplierBrands = "proc_PB_GetSupplierBrands";
        public static string GetNextSupplierExternalId = "NextSupplierExternalID";
        public static string GetFilteredSuppliers = "proc_PB_SupplierSearchFields";
        public static string AddRebateStructure = "proc_PB_CreateRebateStructure";
        public static string GetUsersInRole = "proc_UserEmailsInRole";
        public static string GetRebatePercentBySupplier = "PB_GetRebatePercentBySupplier";
        public static string CheckDuplicayForVehicleRegAndInsurerClaimNo = "proc_getVehicleReg_InsurerClaim_Check";
        public static string GetNextSequenceNumber = "proc_Return_Seq_No";
        public static string GetRequestedClaims = "proc_PB_GetClaimRequests";
        public static string GetAssignedSuppliers = "proc_PB_AssignedSuppliers";
        public static string GetUnassignedAssignedSuppliers = "proc_PB_UnassignedSuppliers";
        public static string CreateNotification = "proc_CreateNotifications";
    }
}


