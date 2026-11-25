using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Demo.Core.Model
{
    public partial class UATDemoPortalContext : DbContext
    {
        public UATDemoPortalContext()
        {
        }

        public UATDemoPortalContext(DbContextOptions<UATDemoPortalContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AdministrationConfig> AdministrationConfigs { get; set; }
        public virtual DbSet<AdministrationTaskList> AdministrationTaskLists { get; set; }
        public virtual DbSet<AgeAnalysis> AgeAnalyses { get; set; }
        public virtual DbSet<AspnetApplication> AspnetApplications { get; set; }
        public virtual DbSet<AspnetMembership> AspnetMemberships { get; set; }
        public virtual DbSet<AspnetPath> AspnetPaths { get; set; }
        public virtual DbSet<AspnetPersonalizationAllUser> AspnetPersonalizationAllUsers { get; set; }
        public virtual DbSet<AspnetPersonalizationPerUser> AspnetPersonalizationPerUsers { get; set; }
        public virtual DbSet<AspnetProfile> AspnetProfiles { get; set; }
        public virtual DbSet<AspnetReport> AspnetReports { get; set; }
        public virtual DbSet<AspnetRole> AspnetRoles { get; set; }
        public virtual DbSet<AspnetSchemaVersion> AspnetSchemaVersions { get; set; }
        public virtual DbSet<AspnetUser> AspnetUsers { get; set; }
        public virtual DbSet<AspnetUsersInRole> AspnetUsersInRoles { get; set; }
        public virtual DbSet<AspnetWebEventEvent> AspnetWebEventEvents { get; set; }
        public virtual DbSet<AuditPastelMatchedItem> AuditPastelMatchedItems { get; set; }
        public virtual DbSet<BankDeposit> BankDeposits { get; set; }
        public virtual DbSet<BankDepositMapping> BankDepositMappings { get; set; }
        public virtual DbSet<Factorer> Factorers { get; set; }
        public virtual DbSet<FinancialPeriod> FinancialPeriods { get; set; }
        public virtual DbSet<GcBordereau> GcBordereaus { get; set; }
        public virtual DbSet<GcBroker> GcBrokers { get; set; }
        public virtual DbSet<GcBrokersMapping> GcBrokersMappings { get; set; }
        public virtual DbSet<GcClaim> GcClaims { get; set; }
        public virtual DbSet<GcClaimDocument> GcClaimDocuments { get; set; }
        public virtual DbSet<GcClaimExcessRule> GcClaimExcessRules { get; set; }
        public virtual DbSet<GcClaimLog> GcClaimLogs { get; set; }
        public virtual DbSet<GcCorrespondance> GcCorrespondances { get; set; }
        public virtual DbSet<GcFitmentCenter> GcFitmentCenters { get; set; }
        public virtual DbSet<GcFitmentInvoice> GcFitmentInvoices { get; set; }
        public virtual DbSet<GcFitmentInvoiceItem> GcFitmentInvoiceItems { get; set; }
        public virtual DbSet<GcFitter> GcFitters { get; set; }
        public virtual DbSet<GcGlassAdminMapping> GcGlassAdminMappings { get; set; }
        public virtual DbSet<GcGlassAdministrator> GcGlassAdministrators { get; set; }
        public virtual DbSet<GcGlassAdministratorFitmentCenter> GcGlassAdministratorFitmentCenters { get; set; }
        public virtual DbSet<GcGlassAdministratorSupplier> GcGlassAdministratorSuppliers { get; set; }
        public virtual DbSet<GcGlassLookup> GcGlassLookups { get; set; }
        public virtual DbSet<GcInsurer> GcInsurers { get; set; }
        public virtual DbSet<GcInsurerScheme> GcInsurerSchemes { get; set; }
        public virtual DbSet<GcSupplier> GcSuppliers { get; set; }
        public virtual DbSet<GcSupplierInvoice> GcSupplierInvoices { get; set; }
        public virtual DbSet<ImportSupplierMapping> ImportSupplierMappings { get; set; }
        public virtual DbSet<ImportedApiSupplierDocument> ImportedApiSupplierDocuments { get; set; }
        public virtual DbSet<ImportedApiSupplierDocumentsItem> ImportedApiSupplierDocumentsItems { get; set; }
        public virtual DbSet<ImportedBarlowWorldDocumentDatum> ImportedBarlowWorldDocumentData { get; set; }
        public virtual DbSet<ImportedDocumentDataPartsSupplier> ImportedDocumentDataPartsSuppliers { get; set; }
        public virtual DbSet<ImportedSupplierCodfeeLineItem> ImportedSupplierCodfeeLineItems { get; set; }
        public virtual DbSet<ImportedSupplierDocument> ImportedSupplierDocuments { get; set; }
        public virtual DbSet<ImportedSupplierDocumentsItem> ImportedSupplierDocumentsItems { get; set; }
        public virtual DbSet<ImportedSupplierDocumentsPb> ImportedSupplierDocumentsPbs { get; set; }
        public virtual DbSet<ImportedSupplierDocumentsPdf> ImportedSupplierDocumentsPdfs { get; set; }
        public virtual DbSet<InterestRunToPastel> InterestRunToPastels { get; set; }
        public virtual DbSet<Location> Locations { get; set; }
        public virtual DbSet<Lookup> Lookups { get; set; }
        public virtual DbSet<LuMimetype> LuMimetypes { get; set; }
        public virtual DbSet<MasterCorrespondance> MasterCorrespondances { get; set; }
        public virtual DbSet<MenuItem> MenuItems { get; set; }
        public virtual DbSet<MenuRoleMapping> MenuRoleMappings { get; set; }
        public virtual DbSet<MenuUserMapping> MenuUserMappings { get; set; }
        public virtual DbSet<Notification> Notifications { get; set; }
        public virtual DbSet<PastelContingencyLedger> PastelContingencyLedgers { get; set; }
        public virtual DbSet<PastelCreditorsLedger> PastelCreditorsLedgers { get; set; }
        public virtual DbSet<PastelDebtRecoveryLedger> PastelDebtRecoveryLedgers { get; set; }
        public virtual DbSet<PastelDebtorsLedger> PastelDebtorsLedgers { get; set; }
        public virtual DbSet<PastelDeductionSuspenseAccountsLedger> PastelDeductionSuspenseAccountsLedgers { get; set; }
        public virtual DbSet<PastelMatchedItem> PastelMatchedItems { get; set; }
        public virtual DbSet<PastelMatchedItemsTmp> PastelMatchedItemsTmps { get; set; }
        public virtual DbSet<PastelRebateProvisionLedger> PastelRebateProvisionLedgers { get; set; }
        public virtual DbSet<PastelSdklog> PastelSdklogs { get; set; }
        public virtual DbSet<PbAgeAnalysisExtract> PbAgeAnalysisExtracts { get; set; }
        public virtual DbSet<PbAssessorCompany> PbAssessorCompanies { get; set; }
        public virtual DbSet<PbAssessorDetail> PbAssessorDetails { get; set; }
        public virtual DbSet<PbBankStatement> PbBankStatements { get; set; }
        public virtual DbSet<PbBankStatementItem> PbBankStatementItems { get; set; }
        public virtual DbSet<PbBankStatementItemInvoiceMapping> PbBankStatementItemInvoiceMappings { get; set; }
        public virtual DbSet<PbBankUploadDataItem> PbBankUploadDataItems { get; set; }
        public virtual DbSet<PbBankUploadDataReversal> PbBankUploadDataReversals { get; set; }
        public virtual DbSet<PbBankUploadDatum> PbBankUploadData { get; set; }
        public virtual DbSet<PbBrand> PbBrands { get; set; }
        public virtual DbSet<PbClaim> PbClaims { get; set; }
        public virtual DbSet<PbClaimDeduction> PbClaimDeductions { get; set; }
        public virtual DbSet<PbClaimDeductionMapping> PbClaimDeductionMappings { get; set; }
        public virtual DbSet<PbClaimDocument> PbClaimDocuments { get; set; }
        public virtual DbSet<PbClaimEmail> PbClaimEmails { get; set; }
        public virtual DbSet<PbClaimEmailAttachment> PbClaimEmailAttachments { get; set; }
        public virtual DbSet<PbClaimEmailSupplier> PbClaimEmailSuppliers { get; set; }
        public virtual DbSet<PbClaimEmailSupplierInvoice> PbClaimEmailSupplierInvoices { get; set; }
        public virtual DbSet<PbClaimLog> PbClaimLogs { get; set; }
        public virtual DbSet<PbClaimLogsDeleted> PbClaimLogsDeleteds { get; set; }
        public virtual DbSet<PbClaimRecovery> PbClaimRecoveries { get; set; }
        public virtual DbSet<PbClaimRequest> PbClaimRequests { get; set; }
        public virtual DbSet<PbClaimRequestSupplier> PbClaimRequestSuppliers { get; set; }
        public virtual DbSet<PbClaimRevertLog> PbClaimRevertLogs { get; set; }
        public virtual DbSet<PbClaimSupplier> PbClaimSuppliers { get; set; }
        public virtual DbSet<PbClaimsFactored> PbClaimsFactoreds { get; set; }
        public virtual DbSet<PbClient> PbClients { get; set; }
        public virtual DbSet<PbClientInsurer> PbClientInsurers { get; set; }
        public virtual DbSet<PbClientPaymentReference> PbClientPaymentReferences { get; set; }
        public virtual DbSet<PbClientSupplier> PbClientSuppliers { get; set; }
        public virtual DbSet<PbContact> PbContacts { get; set; }
        public virtual DbSet<PbCorrespondance> PbCorrespondances { get; set; }
        public virtual DbSet<PbInsurer> PbInsurers { get; set; }
        public virtual DbSet<PbInsurerAdministratorBrokerMapping> PbInsurerAdministratorBrokerMappings { get; set; }
        public virtual DbSet<PbInsurerCheckList> PbInsurerCheckLists { get; set; }
        public virtual DbSet<PbInsurerCheckListItem> PbInsurerCheckListItems { get; set; }
        public virtual DbSet<PbInsurerClaimCheckList> PbInsurerClaimCheckLists { get; set; }
        public virtual DbSet<PbInsurerInsurerUnderwriterMapping> PbInsurerInsurerUnderwriterMappings { get; set; }
        public virtual DbSet<PbInsurerObsoleteMapping> PbInsurerObsoleteMappings { get; set; }
        public virtual DbSet<PbInsurerUnderwriterAdministratorMapping> PbInsurerUnderwriterAdministratorMappings { get; set; }
        public virtual DbSet<PbInvoiceReclaim> PbInvoiceReclaims { get; set; }
        public virtual DbSet<PbPaymentBatch> PbPaymentBatches { get; set; }
        public virtual DbSet<PbProductDefinition> PbProductDefinitions { get; set; }
        public virtual DbSet<PbPurchaseNote> PbPurchaseNotes { get; set; }
        public virtual DbSet<PbRebateStructure> PbRebateStructures { get; set; }
        public virtual DbSet<PbRegisterPanelbeater> PbRegisterPanelbeaters { get; set; }
        public virtual DbSet<PbReport> PbReports { get; set; }
        public virtual DbSet<PbReportSchedule> PbReportSchedules { get; set; }
        public virtual DbSet<PbReportScheduleParameter> PbReportScheduleParameters { get; set; }
        public virtual DbSet<PbReportScheduleRecipient> PbReportScheduleRecipients { get; set; }
        public virtual DbSet<PbReportToPdf> PbReportToPdfs { get; set; }
        public virtual DbSet<PbReportsLog> PbReportsLogs { get; set; }
        public virtual DbSet<PbSupplier> PbSuppliers { get; set; }
        public virtual DbSet<PbSupplierBrand> PbSupplierBrands { get; set; }
        public virtual DbSet<PbSupplierBrandsRegistration> PbSupplierBrandsRegistrations { get; set; }
        public virtual DbSet<PbSupplierClaimValidation> PbSupplierClaimValidations { get; set; }
        public virtual DbSet<PbSupplierCodpaymentBatch> PbSupplierCodpaymentBatches { get; set; }
        public virtual DbSet<PbSupplierGroup> PbSupplierGroups { get; set; }
        public virtual DbSet<PbSupplierSupplyArea> PbSupplierSupplyAreas { get; set; }
        public virtual DbSet<PbSuppliersRegistration> PbSuppliersRegistrations { get; set; }
        public virtual DbSet<PbSuppliersRequest> PbSuppliersRequests { get; set; }
        public virtual DbSet<RebateDocument> RebateDocuments { get; set; }
        public virtual DbSet<ReleaseNote> ReleaseNotes { get; set; }
        public virtual DbSet<ReportsNumber> ReportsNumbers { get; set; }
        public virtual DbSet<ReportsPrint> ReportsPrints { get; set; }
        public virtual DbSet<RoleDisplayName> RoleDisplayNames { get; set; }
        public virtual DbSet<SupplierStatementCheckList> SupplierStatementCheckLists { get; set; }
        public virtual DbSet<SystemLog> SystemLogs { get; set; }
        public virtual DbSet<TempCacheLog> TempCacheLogs { get; set; }
        public virtual DbSet<TmpAccountMappingInsurer> TmpAccountMappingInsurers { get; set; }
        public virtual DbSet<TmpPastelAccountNumberMapping> TmpPastelAccountNumberMappings { get; set; }
        public virtual DbSet<TmpRebateDatum> TmpRebateData { get; set; }
        public virtual DbSet<TmpWipdata1> TmpWipdata1s { get; set; }
        public virtual DbSet<TmpWipdata2> TmpWipdata2s { get; set; }
        public virtual DbSet<UserCompanyRole> UserCompanyRoles { get; set; }
        public virtual DbSet<UserDetail> UserDetails { get; set; }
        public virtual DbSet<UserFunctionAllocation> UserFunctionAllocations { get; set; }
        public virtual DbSet<UserLog> UserLogs { get; set; }
        public virtual DbSet<View2> View2s { get; set; }
        public virtual DbSet<View3> View3s { get; set; }
        public virtual DbSet<VwAspnetApplication> VwAspnetApplications { get; set; }
        public virtual DbSet<VwAspnetMembershipUser> VwAspnetMembershipUsers { get; set; }
        public virtual DbSet<VwAspnetProfile> VwAspnetProfiles { get; set; }
        public virtual DbSet<VwAspnetRole> VwAspnetRoles { get; set; }
        public virtual DbSet<VwAspnetUser> VwAspnetUsers { get; set; }
        public virtual DbSet<VwAspnetUsersInRole> VwAspnetUsersInRoles { get; set; }
        public virtual DbSet<VwAspnetWebPartStatePath> VwAspnetWebPartStatePaths { get; set; }
        public virtual DbSet<VwAspnetWebPartStateShared> VwAspnetWebPartStateShareds { get; set; }
        public virtual DbSet<VwAspnetWebPartStateUser> VwAspnetWebPartStateUsers { get; set; }
        public virtual DbSet<WcrdataExtract> WcrdataExtracts { get; set; }
        public virtual DbSet<WcrdataExtractNew> WcrdataExtractNews { get; set; }
        public virtual DbSet<WipPenaltyDatum> WipPenaltyData { get; set; }
        public virtual DbSet<APILog> APILogs { get; set; }
        public virtual DbSet<ErrorLog> ErrorLogs { get; set; }
        public virtual DbSet<PbClaimDraft> PbClaimDrafts { get; set; }
        public virtual DbSet<PbClaimDraftSupplier> PbClaimDraftSuppliers { get; set; }
        public virtual DbSet<PbClaimPartSupplier> PbClaimPartSuppliers { get; set; }
        public virtual DbSet<PbClaimSupplierPart> PbClaimSupplierParts { get; set; }
        public virtual DbSet<PbSupplierPart> PbSupplierParts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
//             if (!optionsBuilder.IsConfigured)
//             {
// #warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
//                 optionsBuilder.UseSqlServer("Data Source=tcp:einvoicing.database.windows.net;Initial Catalog=UATDemoPortal;User ID=E-Invoicing;Password=Admin@1234;Persist Security Info=True;");
//             }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<AdministrationConfig>(entity =>
            {
                entity.HasKey(e => new { e.Category, e.Item })
                    .HasName("PK_AdministrationConfig_1");

                entity.ToTable("AdministrationConfig");

                entity.Property(e => e.Category)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Item)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AdministrationTaskList>(entity =>
            {
                entity.ToTable("AdministrationTaskList");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.NextRunInterval)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.NextRunTime).HasColumnType("datetime");

                entity.Property(e => e.Recipients)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Sqlquery)
                    .IsUnicode(false)
                    .HasColumnName("SQLQuery");

                entity.Property(e => e.TaskName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.TaskType)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AgeAnalysis>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("AgeAnalysis");

                entity.Property(e => e.ClaimId).HasColumnName("ClaimID");

                entity.Property(e => e.ClaimNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Client)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Cscode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("CSCode");

                entity.Property(e => e.Current).HasColumnType("numeric(19, 4)");

                entity.Property(e => e.Ddate)
                    .HasColumnType("datetime")
                    .HasColumnName("DDate");

                entity.Property(e => e.DefaultReason)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ExpectedPaymentDate).HasColumnType("datetime");

                entity.Property(e => e.Insurers)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceNo)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.Matchref)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Newid).HasColumnName("_NEWID");

                entity.Property(e => e.Notes).HasMaxLength(250);

                entity.Property(e => e.Demonumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ref)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ronumber)
                    .HasMaxLength(75)
                    .IsUnicode(false)
                    .HasColumnName("RONumber");

                entity.Property(e => e.TotalDue).HasColumnType("money");

                entity.Property(e => e._120days)
                    .HasColumnType("numeric(19, 4)")
                    .HasColumnName("120Days");

                entity.Property(e => e._30days)
                    .HasColumnType("numeric(19, 4)")
                    .HasColumnName("30Days");

                entity.Property(e => e._60days)
                    .HasColumnType("numeric(19, 4)")
                    .HasColumnName("60Days");

                entity.Property(e => e._90days)
                    .HasColumnType("numeric(19, 4)")
                    .HasColumnName("90Days");
            });

            modelBuilder.Entity<AspnetApplication>(entity =>
            {
                entity.HasKey(e => e.ApplicationId)
                    .HasName("PK__aspnet_A__C93A4C981CB3C557")
                    .IsClustered(false);

                entity.ToTable("aspnet_Applications");

                entity.HasIndex(e => e.LoweredApplicationName, "UQ__aspnet_A__17477DE4ED45A005")
                    .IsUnique();

                entity.HasIndex(e => e.ApplicationName, "UQ__aspnet_A__309103314E965A33")
                    .IsUnique();

                entity.Property(e => e.ApplicationId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ApplicationName)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.Description).HasMaxLength(256);

                entity.Property(e => e.LoweredApplicationName)
                    .IsRequired()
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<AspnetMembership>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__aspnet_M__1788CC4D0ED07DBA")
                    .IsClustered(false);

                entity.ToTable("aspnet_Membership");

                entity.Property(e => e.UserId).ValueGeneratedNever();

                entity.Property(e => e.Comment).HasColumnType("ntext");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.FailedPasswordAnswerAttemptWindowStart).HasColumnType("datetime");

                entity.Property(e => e.FailedPasswordAttemptWindowStart).HasColumnType("datetime");

                entity.Property(e => e.LastLockoutDate).HasColumnType("datetime");

                entity.Property(e => e.LastLoginDate).HasColumnType("datetime");

                entity.Property(e => e.LastPasswordChangedDate).HasColumnType("datetime");

                entity.Property(e => e.LoweredEmail).HasMaxLength(256);

                entity.Property(e => e.MobilePin)
                    .HasMaxLength(16)
                    .HasColumnName("MobilePIN");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.PasswordAnswer).HasMaxLength(128);

                entity.Property(e => e.PasswordQuestion).HasMaxLength(256);

                entity.Property(e => e.PasswordSalt)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.HasOne(d => d.Application)
                    .WithMany(p => p.AspnetMemberships)
                    .HasForeignKey(d => d.ApplicationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__aspnet_Me__Appli__7FB5F314");

                entity.HasOne(d => d.User)
                    .WithOne(p => p.AspnetMembership)
                    .HasForeignKey<AspnetMembership>(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__aspnet_Me__UserI__00AA174D");
            });

            modelBuilder.Entity<AspnetPath>(entity =>
            {
                entity.HasKey(e => e.PathId)
                    .HasName("PK__aspnet_P__CD67DC5820D4DC31")
                    .IsClustered(false);

                entity.ToTable("aspnet_Paths");

                entity.Property(e => e.PathId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.LoweredPath)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.Path)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.HasOne(d => d.Application)
                    .WithMany(p => p.AspnetPaths)
                    .HasForeignKey(d => d.ApplicationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__aspnet_Pa__Appli__019E3B86");
            });

            modelBuilder.Entity<AspnetPersonalizationAllUser>(entity =>
            {
                entity.HasKey(e => e.PathId)
                    .HasName("PK__aspnet_P__CD67DC59ED388A42");

                entity.ToTable("aspnet_PersonalizationAllUsers");

                entity.Property(e => e.PathId).ValueGeneratedNever();

                entity.Property(e => e.LastUpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.PageSettings)
                    .IsRequired()
                    .HasColumnType("image");

                entity.HasOne(d => d.Path)
                    .WithOne(p => p.AspnetPersonalizationAllUser)
                    .HasForeignKey<AspnetPersonalizationAllUser>(d => d.PathId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__aspnet_Pe__PathI__02925FBF");
            });

            modelBuilder.Entity<AspnetPersonalizationPerUser>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__aspnet_P__3214EC06C19DC55E")
                    .IsClustered(false);

                entity.ToTable("aspnet_PersonalizationPerUser");

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.LastUpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.PageSettings)
                    .IsRequired()
                    .HasColumnType("image");

                entity.HasOne(d => d.Path)
                    .WithMany(p => p.AspnetPersonalizationPerUsers)
                    .HasForeignKey(d => d.PathId)
                    .HasConstraintName("FK__aspnet_Pe__PathI__038683F8");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspnetPersonalizationPerUsers)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__aspnet_Pe__UserI__047AA831");
            });

            modelBuilder.Entity<AspnetProfile>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__aspnet_P__1788CC4C78412E71");

                entity.ToTable("aspnet_Profile");

                entity.Property(e => e.UserId).ValueGeneratedNever();

                entity.Property(e => e.LastUpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.PropertyNames)
                    .IsRequired()
                    .HasColumnType("ntext");

                entity.Property(e => e.PropertyValuesBinary)
                    .IsRequired()
                    .HasColumnType("image");

                entity.Property(e => e.PropertyValuesString)
                    .IsRequired()
                    .HasColumnType("ntext");

                entity.HasOne(d => d.User)
                    .WithOne(p => p.AspnetProfile)
                    .HasForeignKey<AspnetProfile>(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__aspnet_Pr__UserI__056ECC6A");
            });

            modelBuilder.Entity<AspnetReport>(entity =>
            {
                entity.HasKey(e => e.ReportId)
                    .HasName("PK_Reports");

                entity.ToTable("aspnet_Reports");

                entity.Property(e => e.ReportId)
                    .ValueGeneratedNever()
                    .HasColumnName("ReportID");

                entity.Property(e => e.AllowedRoles)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.LuReportCategory)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LU_ReportCategory");

                entity.Property(e => e.LuReportType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("LU_ReportType");

                entity.Property(e => e.ReportName)
                    .IsRequired()
                    .HasMaxLength(150);
            });

            modelBuilder.Entity<AspnetRole>(entity =>
            {
                entity.HasKey(e => e.RoleId)
                    .HasName("PK__aspnet_R__8AFACE1BC1608F8F")
                    .IsClustered(false);

                entity.ToTable("aspnet_Roles");

                entity.Property(e => e.RoleId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Description).HasMaxLength(256);

                entity.Property(e => e.LoweredRoleName)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.RoleName)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.HasOne(d => d.Application)
                    .WithMany(p => p.AspnetRoles)
                    .HasForeignKey(d => d.ApplicationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__aspnet_Ro__Appli__0662F0A3");
            });

            modelBuilder.Entity<AspnetSchemaVersion>(entity =>
            {
                entity.HasKey(e => new { e.Feature, e.CompatibleSchemaVersion })
                    .HasName("PK__aspnet_S__5A1E6BC118EB5C90");

                entity.ToTable("aspnet_SchemaVersions");

                entity.Property(e => e.Feature).HasMaxLength(128);

                entity.Property(e => e.CompatibleSchemaVersion).HasMaxLength(128);
            });

            modelBuilder.Entity<AspnetUser>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__aspnet_U__1788CC4D2D800F3C")
                    .IsClustered(false);

                entity.ToTable("aspnet_Users");

                entity.Property(e => e.UserId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.LastActivityDate).HasColumnType("datetime");

                entity.Property(e => e.LoweredUserName)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.MobileAlias).HasMaxLength(16);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.HasOne(d => d.Application)
                    .WithMany(p => p.AspnetUsers)
                    .HasForeignKey(d => d.ApplicationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__aspnet_Us__Appli__075714DC");
            });

            modelBuilder.Entity<AspnetUsersInRole>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId })
                    .HasName("PK__aspnet_U__AF2760ADD479B5E5");

                entity.ToTable("aspnet_UsersInRoles");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspnetUsersInRoles)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__aspnet_Us__RoleI__084B3915");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspnetUsersInRoles)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__aspnet_Us__UserI__093F5D4E");
            });

            modelBuilder.Entity<AspnetWebEventEvent>(entity =>
            {
                entity.HasKey(e => e.EventId)
                    .HasName("PK__aspnet_W__7944C810D6993B1D");

                entity.ToTable("aspnet_WebEvent_Events");

                entity.Property(e => e.EventId)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.ApplicationPath).HasMaxLength(256);

                entity.Property(e => e.ApplicationVirtualPath).HasMaxLength(256);

                entity.Property(e => e.Details).HasColumnType("ntext");

                entity.Property(e => e.EventOccurrence).HasColumnType("decimal(19, 0)");

                entity.Property(e => e.EventSequence).HasColumnType("decimal(19, 0)");

                entity.Property(e => e.EventTime).HasColumnType("datetime");

                entity.Property(e => e.EventTimeUtc).HasColumnType("datetime");

                entity.Property(e => e.EventType)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.ExceptionType).HasMaxLength(256);

                entity.Property(e => e.MachineName)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.Message).HasMaxLength(1024);

                entity.Property(e => e.RequestUrl).HasMaxLength(1024);
            });

            modelBuilder.Entity<AuditPastelMatchedItem>(entity =>
            {
                entity.ToTable("Audit_Pastel_MatchedItems");

                entity.Property(e => e.Id)
                    .HasColumnName("_ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Amount).HasColumnType("money");

                entity.Property(e => e.BatchId)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("BatchID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Cscode)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("CSCode");

                entity.Property(e => e.CurrAmt).HasColumnType("money");

                entity.Property(e => e.CurrTaxAmt).HasColumnType("money");

                entity.Property(e => e.DDate)
                    .HasColumnType("datetime")
                    .HasColumnName("dDate");

                entity.Property(e => e.Dc)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("DC");

                entity.Property(e => e.Description)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Discount)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.EntryType).HasColumnType("money");

                entity.Property(e => e.ExportNum)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Id1).HasColumnName("ID");

                entity.Property(e => e.InsertedDate).HasColumnType("datetime");

                entity.Property(e => e.LineFlag).HasColumnType("money");

                entity.Property(e => e.MatchRef)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Original).HasColumnType("money");

                entity.Property(e => e.Pperiod)
                    .HasColumnType("money")
                    .HasColumnName("PPeriod");

                entity.Property(e => e.DemoNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RawData)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Ref)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.TaxAmt).HasColumnType("money");

                entity.Property(e => e.TaxType).HasColumnType("money");

                entity.Property(e => e.UserDef)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BankDeposit>(entity =>
            {
                entity.HasKey(e => e.PaymentDepositId)
                    .HasName("PK__BankDepo__470FFC807518C4F4");

                entity.Property(e => e.PaymentDepositId)
                    .ValueGeneratedNever()
                    .HasColumnName("PaymentDepositID");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CsvFileId).HasColumnName("csvFileID");

                entity.Property(e => e.DepositAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DepositDate).HasColumnType("datetime");

                entity.Property(e => e.DepositReference)
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BankDepositMapping>(entity =>
            {
                entity.ToTable("BankDepositMapping");

                entity.Property(e => e.BankDepositMappingId)
                    .ValueGeneratedNever()
                    .HasColumnName("BankDepositMappingID");

                entity.Property(e => e.AllocatedAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ClaimId).HasColumnName("ClaimID");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CreditAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DueToPbamount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("DueToPBAmount");

                entity.Property(e => e.DueToDemoAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PaymentDepositId).HasColumnName("PaymentDepositID");

                entity.Property(e => e.ShortFallAmount).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<Factorer>(entity =>
            {
                entity.Property(e => e.FactorerId)
                    .ValueGeneratedNever()
                    .HasColumnName("FactorerID");

                entity.Property(e => e.Commission).HasColumnType("money");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.FactorerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.NotificationEmailAddress)
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FinancialPeriod>(entity =>
            {
                entity.Property(e => e.FinancialPeriodId)
                    .ValueGeneratedNever()
                    .HasColumnName("FinancialPeriodID");

                entity.Property(e => e.ClosedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.FinancialPeriod1).HasColumnName("FinancialPeriod");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Notes)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StartDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<GcBordereau>(entity =>
            {
                entity.HasKey(e => e.BordereauId);

                entity.ToTable("GC_Bordereau");

                entity.Property(e => e.BordereauId)
                    .ValueGeneratedNever()
                    .HasColumnName("BordereauID");

                entity.Property(e => e.BordereauEndDate).HasColumnType("date");

                entity.Property(e => e.BordereauNumber)
                    .IsRequired()
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.BordereauStartDate).HasColumnType("date");

                entity.Property(e => e.InsurerId).HasColumnName("InsurerID");
            });

            modelBuilder.Entity<GcBroker>(entity =>
            {
                entity.HasKey(e => e.BrokerId)
                    .HasName("PK__GC_Broke__5D1D9A30896446CF");

                entity.ToTable("GC_Brokers");

                entity.Property(e => e.BrokerId)
                    .ValueGeneratedNever()
                    .HasColumnName("BrokerID");

                entity.Property(e => e.BrokerName)
                    .IsRequired()
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("date");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("date");

                entity.Property(e => e.NotificationEmailAddress)
                    .HasMaxLength(300)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GcBrokersMapping>(entity =>
            {
                entity.HasKey(e => e.BrokerMappingId)
                    .HasName("PK__GC_Broke__5A753FBC6F3D60E9");

                entity.ToTable("GC_BrokersMapping");

                entity.Property(e => e.BrokerMappingId)
                    .ValueGeneratedNever()
                    .HasColumnName("BrokerMappingID");

                entity.Property(e => e.BrokerId).HasColumnName("BrokerID");

                entity.Property(e => e.InsurerId).HasColumnName("InsurerID");
            });

            modelBuilder.Entity<GcClaim>(entity =>
            {
                entity.HasKey(e => e.ClaimId);

                entity.ToTable("GC_Claims");

                entity.Property(e => e.ClaimId)
                    .ValueGeneratedNever()
                    .HasColumnName("ClaimID");

                entity.Property(e => e.Area)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.AuthoriseBy)
                    .HasMaxLength(75)
                    .IsUnicode(false)
                    .HasColumnName("authoriseBy");

                entity.Property(e => e.AuthoriseDate)
                    .HasColumnType("datetime")
                    .HasColumnName("authoriseDate");

                entity.Property(e => e.BordereauNumber)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.BrokerBy)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.BrokerDate).HasColumnType("datetime");

                entity.Property(e => e.BrokerId).HasColumnName("BrokerID");

                entity.Property(e => e.CancelledBy)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.CancelledDate).HasColumnType("datetime");

                entity.Property(e => e.CancelledReason)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.CapturedByUserId).HasColumnName("CapturedByUserID");

                entity.Property(e => e.CapturedByUserRole)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.CauseDescription)
                    .HasMaxLength(125)
                    .IsUnicode(false);

                entity.Property(e => e.CauseOfDamage)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.ClaimAmountEstimate).HasColumnType("money");

                entity.Property(e => e.ClaimAmountExcess).HasColumnType("money");

                entity.Property(e => e.ClaimAmountFinal).HasColumnType("money");

                entity.Property(e => e.ClaimDeclinedBy)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.ClaimDeclinedDate).HasColumnType("datetime");

                entity.Property(e => e.ClaimStatus)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.ClaimSubmitTo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ClaimedClosedDate).HasColumnType("datetime");

                entity.Property(e => e.ClosedBy)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.ClosedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DateOfLoss).HasColumnType("datetime");

                entity.Property(e => e.DeclinedReason)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.FitmentInvoiceId).HasColumnName("FitmentInvoiceID");

                entity.Property(e => e.FitterAssignDate).HasColumnType("datetime");

                entity.Property(e => e.FitterId).HasColumnName("FitterID");

                entity.Property(e => e.FittterBy)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.GlassAdministratorBy)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.GlassAdministratorDate).HasColumnType("datetime");

                entity.Property(e => e.GlassAdministratorId).HasColumnName("GlassAdministratorID");

                entity.Property(e => e.GlassCode)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.GlassFitmentCenterBy)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.GlassFitmentCenterDate).HasColumnType("datetime");

                entity.Property(e => e.GlassFitmentCenterId).HasColumnName("GlassFitmentCenterID");

                entity.Property(e => e.GlassType)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.InsuredAddress1)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.InsuredAddress2)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.InsuredAddressPostalCode)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.InsuredAltPhoneNumber)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.InsuredCellNumber)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.InsuredFirstName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.InsuredIdnumber)
                    .HasMaxLength(75)
                    .IsUnicode(false)
                    .HasColumnName("InsuredIDNumber");

                entity.Property(e => e.InsuredLastName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.InsuredPhoneNumber)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.InsurerClaimNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InsurerId).HasColumnName("InsurerID");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.OrderNote)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.PolicyNumber)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.DemoNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Province)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.QuoteAuthorisedBy)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.QuoteAuthorisedDate).HasColumnType("datetime");

                entity.Property(e => e.QuoteRequestedBy)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.QuoteRequestedDate).HasColumnType("datetime");

                entity.Property(e => e.QuoteSubmittedBy)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.QuoteSubmittedDate).HasColumnType("datetime");

                entity.Property(e => e.RequiresAuthorisation).HasColumnName("requiresAuthorisation");

                entity.Property(e => e.ScheduledFittingAddress1)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ScheduledFittingAddress2)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ScheduledFittingAddress3)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ScheduledFittingDate).HasColumnType("datetime");

                entity.Property(e => e.ScheduledFittingTimeSlot)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SchemeId).HasColumnName("SchemeID");

                entity.Property(e => e.SupplierAssignDate).HasColumnType("datetime");

                entity.Property(e => e.SupplierBy)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.SupplierId).HasColumnName("SupplierID");

                entity.Property(e => e.SupplierInvoiceId).HasColumnName("SupplierInvoiceID");

                entity.Property(e => e.SupplierOrderNumber)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.UseOeglass).HasColumnName("UseOEGlass");

                entity.Property(e => e.VehicleMake)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.VehicleMmcode)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("VehicleMMCode");

                entity.Property(e => e.VehicleModel)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.VehicleRegistrationNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VehicleVin)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("VehicleVIN");
            });

            modelBuilder.Entity<GcClaimDocument>(entity =>
            {
                entity.HasKey(e => e.ClaimDocumentId)
                    .HasName("PK_GC_Documents");

                entity.ToTable("GC_ClaimDocuments");

                entity.Property(e => e.ClaimDocumentId)
                    .ValueGeneratedNever()
                    .HasColumnName("ClaimDocumentID");

                entity.Property(e => e.ClaimId).HasColumnName("ClaimID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DocumentData).HasColumnType("image");

                entity.Property(e => e.DocumentName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.DocumentType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Keywords)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<GcClaimExcessRule>(entity =>
            {
                entity.HasKey(e => e.ClaimExcessRuleId)
                    .HasName("PK__GC_Claim__EC85A66DD3AE2AB8");

                entity.ToTable("GC_ClaimExcessRules");

                entity.Property(e => e.ClaimExcessRuleId)
                    .ValueGeneratedNever()
                    .HasColumnName("ClaimExcessRuleID");

                entity.Property(e => e.ExcessRuleDescription)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ExcessRuleMinimum).HasColumnType("money");

                entity.Property(e => e.ExcessRulePercentage).HasColumnType("money");
            });

            modelBuilder.Entity<GcClaimLog>(entity =>
            {
                entity.HasKey(e => e.ClaimLogId);

                entity.ToTable("GC_ClaimLog");

                entity.Property(e => e.ClaimLogId)
                    .ValueGeneratedNever()
                    .HasColumnName("ClaimLogID");

                entity.Property(e => e.Category)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ClaimId).HasColumnName("ClaimID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(250);
            });

            modelBuilder.Entity<GcCorrespondance>(entity =>
            {
                entity.HasKey(e => e.CorrespondanceId);

                entity.ToTable("GC_Correspondance");

                entity.Property(e => e.CorrespondanceId)
                    .ValueGeneratedNever()
                    .HasColumnName("CorrespondanceID");

                entity.Property(e => e.AttachmentFilenames).HasMaxLength(3500);

                entity.Property(e => e.ClaimEmailId).HasColumnName("ClaimEmailID");

                entity.Property(e => e.ClaimId).HasColumnName("ClaimID");

                entity.Property(e => e.FitterId).HasColumnName("FitterID");

                entity.Property(e => e.GlassAdministratorId).HasColumnName("GlassAdministratorID");

                entity.Property(e => e.History)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.LogDate).HasColumnType("datetime");

                entity.Property(e => e.MessageCategory)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MessageSubject).HasMaxLength(150);

                entity.Property(e => e.MessageType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Recipients).HasMaxLength(250);

                entity.Property(e => e.RecipientsBcc)
                    .HasMaxLength(250)
                    .HasColumnName("RecipientsBCC");

                entity.Property(e => e.RecipientsCc)
                    .HasMaxLength(250)
                    .HasColumnName("RecipientsCC");

                entity.Property(e => e.SentDate).HasColumnType("datetime");

                entity.Property(e => e.ServerResponse).HasMaxLength(100);

                entity.Property(e => e.SupplierId).HasColumnName("SupplierID");
            });

            modelBuilder.Entity<GcFitmentCenter>(entity =>
            {
                entity.HasKey(e => e.FitmentCenterId)
                    .HasName("PK_GC_Fitter");

                entity.ToTable("GC_FitmentCenters");

                entity.Property(e => e.FitmentCenterId)
                    .ValueGeneratedNever()
                    .HasColumnName("FitmentCenterID");

                entity.Property(e => e.BankAccountHolder)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BankAccountNumber)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BankBranchName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BankName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CellNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CityId).HasColumnName("CityID");

                entity.Property(e => e.CompanyRegNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("date");

                entity.Property(e => e.Email)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ExternalId)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("ExternalID");

                entity.Property(e => e.FaxNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FitmentCenterName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("date");

                entity.Property(e => e.NotificationEmailAddress)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.PhysicalAddr1)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.PhysicalAddr2)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.PhysicalAddr3)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.PhysicalAddrCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PostalAddr1)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.PostalAddr2)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.PostalAddr3)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.PostalAddrCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Region)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RegionId).HasColumnName("RegionID");

                entity.Property(e => e.SuburbId).HasColumnName("SuburbID");

                entity.Property(e => e.TelNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VatregNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("VATRegNumber");
            });

            modelBuilder.Entity<GcFitmentInvoice>(entity =>
            {
                entity.HasKey(e => e.FitmentInvoiceId)
                    .HasName("PK_GC_FitmentInvoiceID");

                entity.ToTable("GC_FitmentInvoices");

                entity.Property(e => e.FitmentInvoiceId)
                    .ValueGeneratedNever()
                    .HasColumnName("FitmentInvoiceID");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("date");

                entity.Property(e => e.InvoiceDate).HasColumnType("date");

                entity.Property(e => e.InvoiceNumber)
                    .IsRequired()
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceValue).HasColumnType("money");

                entity.Property(e => e.InvoiceVat)
                    .HasColumnType("money")
                    .HasColumnName("InvoiceVAT");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("date");

                entity.Property(e => e.Reference)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GcFitmentInvoiceItem>(entity =>
            {
                entity.HasKey(e => e.FitmentInvoiceItemId)
                    .HasName("PK_GC_FitmentInvoiceItemID");

                entity.ToTable("GC_FitmentInvoiceItems");

                entity.Property(e => e.FitmentInvoiceItemId)
                    .ValueGeneratedNever()
                    .HasColumnName("FitmentInvoiceItemID");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("date");

                entity.Property(e => e.FitmentInvoiceId).HasColumnName("FitmentInvoiceID");

                entity.Property(e => e.ItemCode)
                    .IsRequired()
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.ItemDescription)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ItemQuantity).HasColumnType("money");

                entity.Property(e => e.ItemValue).HasColumnType("money");

                entity.Property(e => e.ItemVat)
                    .HasColumnType("money")
                    .HasColumnName("ItemVAT");

                entity.Property(e => e.LineItemValue).HasColumnType("money");

                entity.Property(e => e.LineItemVat)
                    .HasColumnType("money")
                    .HasColumnName("LineItemVAT");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("date");
            });

            modelBuilder.Entity<GcFitter>(entity =>
            {
                entity.HasKey(e => e.FitterId)
                    .HasName("PK_GC_FitterID");

                entity.ToTable("GC_Fitters");

                entity.Property(e => e.FitterId)
                    .ValueGeneratedNever()
                    .HasColumnName("FitterID");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("date");

                entity.Property(e => e.FitmentCenterId).HasColumnName("FitmentCenterID");

                entity.Property(e => e.FitterName)
                    .IsRequired()
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("date");

                entity.Property(e => e.NotificationEmailAddress)
                    .HasMaxLength(300)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GcGlassAdminMapping>(entity =>
            {
                entity.HasKey(e => e.GlassAdminMappingId)
                    .HasName("PK__GC_Glass__7F3AEAB50906A95D");

                entity.ToTable("GC_GlassAdminMapping");

                entity.Property(e => e.GlassAdminMappingId)
                    .ValueGeneratedNever()
                    .HasColumnName("GlassAdminMappingID");

                entity.Property(e => e.GlassAdministratorId).HasColumnName("GlassAdministratorID");

                entity.Property(e => e.InsurerId).HasColumnName("InsurerID");
            });

            modelBuilder.Entity<GcGlassAdministrator>(entity =>
            {
                entity.HasKey(e => e.GlassAdministratorId)
                    .HasName("PK_GC_GlassAdministrator");

                entity.ToTable("GC_GlassAdministrators");

                entity.Property(e => e.GlassAdministratorId)
                    .ValueGeneratedNever()
                    .HasColumnName("GlassAdministratorID");

                entity.Property(e => e.BankAccountHolder)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BankAccountNumber)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BankBranchName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BankName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CellNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyRegNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("date");

                entity.Property(e => e.Email)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ExternalId)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("ExternalID");

                entity.Property(e => e.FaxNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GlassAdministratorName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("date");

                entity.Property(e => e.NotificationEmailAddress)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.PhysicalAddr1)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.PhysicalAddr2)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.PhysicalAddr3)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.PhysicalAddrCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PostalAddr1)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.PostalAddr2)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.PostalAddr3)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.PostalAddrCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TelNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VatregNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("VATRegNumber");
            });

            modelBuilder.Entity<GcGlassAdministratorFitmentCenter>(entity =>
            {
                entity.HasKey(e => e.AdministratorFittersId)
                    .HasName("PK_AdministratorFitters");

                entity.ToTable("GC_GlassAdministratorFitmentCenters");

                entity.Property(e => e.AdministratorFittersId)
                    .ValueGeneratedNever()
                    .HasColumnName("AdministratorFittersID");

                entity.Property(e => e.AdministratorId).HasColumnName("AdministratorID");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("date");

                entity.Property(e => e.FitmentCenterId).HasColumnName("FitmentCenterID");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("date");
            });

            modelBuilder.Entity<GcGlassAdministratorSupplier>(entity =>
            {
                entity.HasKey(e => e.AdministratorSuppliersId)
                    .HasName("PK_AdministratorSuppliers");

                entity.ToTable("GC_GlassAdministratorSuppliers");

                entity.Property(e => e.AdministratorSuppliersId)
                    .ValueGeneratedNever()
                    .HasColumnName("AdministratorSuppliersID");

                entity.Property(e => e.AdministratorId).HasColumnName("AdministratorID");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("date");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("date");

                entity.Property(e => e.SupplierId).HasColumnName("SupplierID");
            });

            modelBuilder.Entity<GcGlassLookup>(entity =>
            {
                entity.HasKey(e => e.GlassId)
                    .HasName("PK_GC_GlassID");

                entity.ToTable("GC_GlassLookup");

                entity.Property(e => e.GlassId)
                    .ValueGeneratedNever()
                    .HasColumnName("GlassID");

                entity.Property(e => e.Category)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Description).HasMaxLength(250);

                entity.Property(e => e.ItemNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Notes)
                    .HasMaxLength(2500)
                    .IsUnicode(false);

                entity.Property(e => e.RetailPrice).HasColumnType("money");

                entity.Property(e => e.VehicleMake)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.VehicleModel)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.YearFrom)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.YearTo)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GcInsurer>(entity =>
            {
                entity.HasKey(e => e.InsurerId)
                    .HasName("PK_GC_Insurer");

                entity.ToTable("GC_Insurers");

                entity.Property(e => e.InsurerId)
                    .ValueGeneratedNever()
                    .HasColumnName("InsurerID");

                entity.Property(e => e.AccountCode)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.BankAccountHolder)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BankAccountNumber)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BankBranchName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BankName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BordereauInterval)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.CellNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyRegNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("date");

                entity.Property(e => e.Email)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ExternalId)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("ExternalID");

                entity.Property(e => e.FaxNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InsurerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InsurerTradingName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceRecipient)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("date");

                entity.Property(e => e.NextBordereauEndDate).HasColumnType("datetime");

                entity.Property(e => e.NextBordereauStartDate).HasColumnType("datetime");

                entity.Property(e => e.NotificationEmailAddress)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.PhysicalAddr1)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.PhysicalAddr2)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.PhysicalAddr3)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.PhysicalAddrCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PostalAddr1)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.PostalAddr2)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.PostalAddr3)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.PostalAddrCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TelNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VatregNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("VATRegNumber");
            });

            modelBuilder.Entity<GcInsurerScheme>(entity =>
            {
                entity.HasKey(e => new { e.InsurerId, e.SchemeId })
                    .HasName("PK_InsurerScheme");

                entity.ToTable("GC_InsurerSchemes");

                entity.Property(e => e.InsurerId).HasColumnName("InsurerID");

                entity.Property(e => e.SchemeId).HasColumnName("SchemeID");

                entity.Property(e => e.SchemeName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GcSupplier>(entity =>
            {
                entity.HasKey(e => e.SupplierId)
                    .HasName("PK_GC_Supplier");

                entity.ToTable("GC_Suppliers");

                entity.Property(e => e.SupplierId)
                    .ValueGeneratedNever()
                    .HasColumnName("SupplierID");

                entity.Property(e => e.AccountCode)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.BankAccountHolder)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BankAccountNumber)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BankBranchName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BankName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CellNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CityId).HasColumnName("CityID");

                entity.Property(e => e.CompanyRegNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("date");

                entity.Property(e => e.Email)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ExternalId)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("ExternalID");

                entity.Property(e => e.FaxNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("date");

                entity.Property(e => e.NotificationEmailAddress)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentTerms)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.PhysicalAddr1)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.PhysicalAddr2)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.PhysicalAddr3)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.PhysicalAddrCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PostalAddr1)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.PostalAddr2)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.PostalAddr3)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.PostalAddrCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Region)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RegionId).HasColumnName("RegionID");

                entity.Property(e => e.SuburbId).HasColumnName("SuburbID");

                entity.Property(e => e.SupplierGroupName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SupplierName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TelNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VatregNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("VATRegNumber");
            });

            modelBuilder.Entity<GcSupplierInvoice>(entity =>
            {
                entity.HasKey(e => e.SupplierInvoiceId)
                    .HasName("PK_GC_SupplierInvoiceID");

                entity.ToTable("GC_SupplierInvoices");

                entity.Property(e => e.SupplierInvoiceId)
                    .ValueGeneratedNever()
                    .HasColumnName("SupplierInvoiceID");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("date");

                entity.Property(e => e.InvoiceDate).HasColumnType("date");

                entity.Property(e => e.InvoiceNumber)
                    .IsRequired()
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceValue).HasColumnType("money");

                entity.Property(e => e.InvoiceVat)
                    .HasColumnType("money")
                    .HasColumnName("InvoiceVAT");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("date");

                entity.Property(e => e.SupplierId).HasColumnName("SupplierID");
            });

            modelBuilder.Entity<ImportSupplierMapping>(entity =>
            {
                entity.HasKey(e => e.SupplierMappingId)
                    .HasName("PK_Import_Supplier_Mappings");

                entity.ToTable("Import_Supplier_Mapping");

                entity.Property(e => e.SupplierMappingId)
                    .ValueGeneratedNever()
                    .HasColumnName("SupplierMappingID");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("date");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("date");

                entity.Property(e => e.DemoSupplierId).HasColumnName("DemoSupplierID");

                entity.Property(e => e.SupplierNameExternal)
                    .IsRequired()
                    .HasMaxLength(75)
                    .IsUnicode(false)
                    .HasColumnName("SupplierName_External");
            });

            modelBuilder.Entity<ImportedApiSupplierDocument>(entity =>
            {
                entity.HasKey(e => e.ApisupplierDocumentId)
                    .HasName("PK_Imported_API_SupplierDocumentID");

                entity.ToTable("Imported_API_SupplierDocuments");

                entity.Property(e => e.ApisupplierDocumentId)
                    .ValueGeneratedNever()
                    .HasColumnName("APISupplierDocumentID");

                entity.Property(e => e.ClaimId).HasColumnName("ClaimID");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DocumentDate).HasColumnType("datetime");

                entity.Property(e => e.DocumentNumber)
                    .IsRequired()
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.DocumentSource)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DocumentTotal).HasColumnType("money");

                entity.Property(e => e.DocumentType)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DocumentValue).HasColumnType("money");

                entity.Property(e => e.DocumentVat)
                    .HasColumnType("money")
                    .HasColumnName("DocumentVAT");

                entity.Property(e => e.MappedImportedSupplierDocumentId).HasColumnName("MappedImportedSupplierDocumentID");

                entity.Property(e => e.MatchedBy)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.MatchedDate).HasColumnType("datetime");

                entity.Property(e => e.MatchedImportedSupplierDocumentId).HasColumnName("MatchedImportedSupplierDocumentID");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Notes)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DemoNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProcessStatus)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ProcessedBy)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.ProcessedDate).HasColumnType("datetime");

                entity.Property(e => e.Reference)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.SupplierId).HasColumnName("SupplierID");
            });

            modelBuilder.Entity<ImportedApiSupplierDocumentsItem>(entity =>
            {
                entity.HasKey(e => e.ApisupplierDocumentsItemId);

                entity.ToTable("Imported_API_SupplierDocumentsItems");

                entity.Property(e => e.ApisupplierDocumentsItemId)
                    .ValueGeneratedNever()
                    .HasColumnName("APISupplierDocumentsItemID");

                entity.Property(e => e.ApisupplierDocumentId).HasColumnName("APISupplierDocumentID");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("date");

                entity.Property(e => e.ImportDataId).HasColumnName("ImportDataID");

                entity.Property(e => e.ItemTotal).HasColumnType("money");

                entity.Property(e => e.ItemValue).HasColumnType("money");

                entity.Property(e => e.ItemVat)
                    .HasColumnType("money")
                    .HasColumnName("ItemVAT");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("date");

                entity.Property(e => e.PartDescription)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.PartNumber)
                    .IsRequired()
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.Quantity).HasColumnType("money");
            });

            modelBuilder.Entity<ImportedBarlowWorldDocumentDatum>(entity =>
            {
                entity.HasKey(e => e.DataId)
                    .HasName("PK_Imported_DataID");

                entity.ToTable("Imported_BarlowWorldDocumentData");

                entity.Property(e => e.DataId)
                    .ValueGeneratedNever()
                    .HasColumnName("DataID");

                entity.Property(e => e.AccountName)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.AccountNumber)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("date");

                entity.Property(e => e.Dealership)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.DiscountRate).HasColumnType("money");

                entity.Property(e => e.DocDate).HasColumnType("date");

                entity.Property(e => e.DocumentBaseTotal).HasColumnType("money");

                entity.Property(e => e.DocumentNumber)
                    .IsRequired()
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.DocumentType)
                    .IsRequired()
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.ExtendedPrice).HasColumnType("money");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("date");

                entity.Property(e => e.OriginalPrice).HasColumnType("money");

                entity.Property(e => e.DemoInvoiceRecordId)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("DemoInvoiceRecordID");

                entity.Property(e => e.DemoNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PriceInclVat)
                    .HasColumnType("money")
                    .HasColumnName("PriceInclVAT");

                entity.Property(e => e.ProcessedDate).HasColumnType("datetime");

                entity.Property(e => e.ProcessedStatus)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Quantity).HasColumnType("money");

                entity.Property(e => e.Reference)
                    .IsRequired()
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.RtscodeOrPartNumber)
                    .IsRequired()
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .HasColumnName("RTSCodeOrPartNumber");

                entity.Property(e => e.SupplierType)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.SuppliersDemoNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Vat)
                    .HasColumnType("money")
                    .HasColumnName("VAT");

                entity.Property(e => e.Wip)
                    .IsRequired()
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .HasColumnName("WIP");
            });

            modelBuilder.Entity<ImportedDocumentDataPartsSupplier>(entity =>
            {
                entity.HasKey(e => e.DataId)
                    .HasName("PK_Imported_DocumentData_PS_DataID");

                entity.ToTable("Imported_DocumentData_PartsSuppliers");

                entity.Property(e => e.DataId)
                    .ValueGeneratedNever()
                    .HasColumnName("DataID");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("date");

                entity.Property(e => e.DiscountPercent).HasColumnType("money");

                entity.Property(e => e.DocumentDate).HasColumnType("date");

                entity.Property(e => e.DocumentNumber)
                    .IsRequired()
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.DocumentType)
                    .IsRequired()
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.ImportType)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("IMportType");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("date");

                entity.Property(e => e.PartDescription)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.PartNumber)
                    .IsRequired()
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.PartsSupplierDealership)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("PartsSupplier_Dealership");

                entity.Property(e => e.PbAccountName)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("PB_AccountName");

                entity.Property(e => e.PbAccountNumber)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("PB_AccountNumber");

                entity.Property(e => e.PriceExclVat)
                    .HasColumnType("money")
                    .HasColumnName("PriceExclVAT");

                entity.Property(e => e.PriceInclDiscount).HasColumnType("money");

                entity.Property(e => e.PriceInclVat)
                    .HasColumnType("money")
                    .HasColumnName("PriceInclVAT");

                entity.Property(e => e.PriceRetail).HasColumnType("money");

                entity.Property(e => e.ProcessedDate).HasColumnType("datetime");

                entity.Property(e => e.ProcessedStatus)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Quantity).HasColumnType("money");

                entity.Property(e => e.Reference)
                    .IsRequired()
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.SuppliersNotes)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Vat)
                    .HasColumnType("money")
                    .HasColumnName("VAT");
            });

            modelBuilder.Entity<ImportedSupplierCodfeeLineItem>(entity =>
            {
                entity.HasKey(e => e.CodfeeLineItemId)
                    .HasName("PK__Imported__04BCA44A86431497");

                entity.ToTable("Imported_SupplierCODFeeLineItems");

                entity.Property(e => e.CodfeeLineItemId)
                    .ValueGeneratedNever()
                    .HasColumnName("CODFeeLineItemID");

                entity.Property(e => e.ClaimId).HasColumnName("ClaimID");

                entity.Property(e => e.Codfee)
                    .HasColumnType("money")
                    .HasColumnName("CODFee");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.NoCodfee).HasColumnName("NoCODFee");

                entity.Property(e => e.RebatePercent).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.SupplierDocumentId).HasColumnName("SupplierDocumentID");

                entity.Property(e => e.SupplierId).HasColumnName("SupplierID");
            });

            modelBuilder.Entity<ImportedSupplierDocument>(entity =>
            {
                entity.HasKey(e => e.SupplierDocumentId)
                    .HasName("PK_Imported_SupplierDocumentID");

                entity.ToTable("Imported_SupplierDocuments");

                entity.Property(e => e.SupplierDocumentId)
                    .ValueGeneratedNever()
                    .HasColumnName("SupplierDocumentID");

                entity.Property(e => e.ClaimId).HasColumnName("ClaimID");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DocumentDate).HasColumnType("datetime");

                entity.Property(e => e.DocumentNumber)
                    .IsRequired()
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.DocumentSource)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DocumentTotal).HasColumnType("money");

                entity.Property(e => e.DocumentType)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DocumentValue).HasColumnType("money");

                entity.Property(e => e.DocumentVat)
                    .HasColumnType("money")
                    .HasColumnName("DocumentVAT");

                entity.Property(e => e.HardCopyReceivedBy)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.HardCopyReceivedDate).HasColumnType("datetime");

                entity.Property(e => e.InvoicePaidBy)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.InvoicePaidDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Notes)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.OmitText)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PastelConfirmComments)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PastelConfirmDate).HasColumnType("datetime");

                entity.Property(e => e.PastelOiReceiptDate)
                    .HasColumnType("datetime")
                    .HasColumnName("PastelOI_ReceiptDate");

                entity.Property(e => e.PastelOiReceiptDateUpdateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("PastelOI_ReceiptDate_UpdateDate");

                entity.Property(e => e.PortalSystem)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DemoNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DemoNumberFame)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProcessStatus)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ProcessedBy)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.ProcessedDate).HasColumnType("datetime");

                entity.Property(e => e.ProcessedToFame).HasColumnType("datetime");

                entity.Property(e => e.ProcessedToFameStatus)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Reference)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.SupplierCodbatchReference).HasColumnName("SupplierCODBatchReference");

                entity.Property(e => e.SupplierId).HasColumnName("SupplierID");
            });

            modelBuilder.Entity<ImportedSupplierDocumentsItem>(entity =>
            {
                entity.HasKey(e => e.SupplierDocumentsItemId);

                entity.ToTable("Imported_SupplierDocumentsItems");

                entity.Property(e => e.SupplierDocumentsItemId)
                    .ValueGeneratedNever()
                    .HasColumnName("SupplierDocumentsItemID");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("date");

                entity.Property(e => e.DiscountPercent).HasColumnType("money");

                entity.Property(e => e.ImportDataId).HasColumnName("ImportDataID");

                entity.Property(e => e.ItemTotal).HasColumnType("money");

                entity.Property(e => e.ItemValue).HasColumnType("money");

                entity.Property(e => e.ItemVat)
                    .HasColumnType("money")
                    .HasColumnName("ItemVAT");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("date");

                entity.Property(e => e.PartDescription)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.PartNumber)
                    .IsRequired()
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.Quantity).HasColumnType("money");

                entity.Property(e => e.RetailPrice).HasColumnType("money");

                entity.Property(e => e.SupplierDocumentId).HasColumnName("SupplierDocumentID");
            });

            modelBuilder.Entity<ImportedSupplierDocumentsPb>(entity =>
            {
                entity.HasKey(e => e.SupplierDocumentId)
                    .HasName("PK__Imported__CA28663F3219C60E");

                entity.ToTable("Imported_SupplierDocuments_PB");

                entity.Property(e => e.SupplierDocumentId)
                    .ValueGeneratedNever()
                    .HasColumnName("SupplierDocumentID");

                entity.Property(e => e.AuthorisedBy)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.AuthorisedDate).HasColumnType("datetime");

                entity.Property(e => e.ClaimDocumentId).HasColumnName("ClaimDocumentID");

                entity.Property(e => e.ClaimId).HasColumnName("ClaimID");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DocumentDate).HasColumnType("datetime");

                entity.Property(e => e.DocumentNumber)
                    .IsRequired()
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.DocumentSource)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DocumentTotal).HasColumnType("money");

                entity.Property(e => e.DocumentType)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DocumentValue).HasColumnType("money");

                entity.Property(e => e.DocumentVat)
                    .HasColumnType("money")
                    .HasColumnName("DocumentVAT");

                entity.Property(e => e.HardCopyReceivedBy)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.HardCopyReceivedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Notes)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DemoNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SupplierId).HasColumnName("SupplierID");
            });

            modelBuilder.Entity<ImportedSupplierDocumentsPdf>(entity =>
            {
                entity.HasKey(e => e.SupplierDocumentId);

                entity.ToTable("Imported_SupplierDocumentsPDF");

                entity.Property(e => e.SupplierDocumentId)
                    .ValueGeneratedNever()
                    .HasColumnName("SupplierDocumentID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DocumentData).HasColumnType("image");

                entity.Property(e => e.DocumentNumber)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.DocumentType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Supplier)
                    .HasMaxLength(80)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<InterestRunToPastel>(entity =>
            {
                entity.HasKey(e => e.InterestRunId)
                    .HasName("PK__Interest__CADC590A4E462BC9");

                entity.ToTable("Interest_Run_To_Pastel");

                entity.Property(e => e.InterestRunId)
                    .ValueGeneratedNever()
                    .HasColumnName("InterestRunID");

                entity.Property(e => e.BatchId).HasColumnName("BatchID");

                entity.Property(e => e.CalendarDays).HasColumnType("money");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.ClientName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.CloseBal).HasColumnType("money");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CulmInterest).HasColumnType("money");

                entity.Property(e => e.DaysOs)
                    .HasColumnType("money")
                    .HasColumnName("DaysOS");

                entity.Property(e => e.DiscountFee).HasColumnType("money");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.FinalAuthorisedDate).HasColumnType("datetime");

                entity.Property(e => e.InterestAmount).HasColumnType("money");

                entity.Property(e => e.InterestDays).HasColumnType("money");

                entity.Property(e => e.InterestRate).HasColumnType("money");

                entity.Property(e => e.OpenBalLedger).HasColumnType("money");

                entity.Property(e => e.ReceiptInCurrentPeriod).HasColumnType("money");

                entity.Property(e => e.SettlementDate).HasColumnType("datetime");

                entity.Property(e => e.StartDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Location>(entity =>
            {
                entity.Property(e => e.LocationId)
                    .ValueGeneratedNever()
                    .HasColumnName("LocationID");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ParentLocationId).HasColumnName("ParentLocationID");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(75)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Lookup>(entity =>
            {
                entity.ToTable("Lookup");

                entity.Property(e => e.LookupId)
                    .ValueGeneratedNever()
                    .HasColumnName("LookupID");

                entity.Property(e => e.Category)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Value)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LuMimetype>(entity =>
            {
                entity.ToTable("LU_MIMEtype");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.FileExtension)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Mimetype)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("MIMEtype");
            });

            modelBuilder.Entity<MasterCorrespondance>(entity =>
            {
                entity.HasKey(e => e.MasterId);

                entity.ToTable("Master_Correspondance");

                entity.Property(e => e.MasterId)
                    .ValueGeneratedNever()
                    .HasColumnName("MasterID");

                entity.Property(e => e.AttachmentFilenames).HasMaxLength(3500);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.MessageName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MessageType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Template).IsRequired();

                entity.Property(e => e.TemplateSubject)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MenuItem>(entity =>
            {
                entity.ToTable("menuItems");

                entity.Property(e => e.MenuItemId)
                    .ValueGeneratedNever()
                    .HasColumnName("menuItemID");

                entity.Property(e => e.DisplayOrder).HasColumnName("displayOrder");

                entity.Property(e => e.ItemText)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.ItemUrl)
                    .HasMaxLength(75)
                    .IsUnicode(false)
                    .HasColumnName("ItemURL");
            });

            modelBuilder.Entity<MenuRoleMapping>(entity =>
            {
                entity.ToTable("menuRoleMapping");

                entity.Property(e => e.MenuRoleMappingId)
                    .ValueGeneratedNever()
                    .HasColumnName("menuRoleMappingID");

                entity.Property(e => e.MenuItemId).HasColumnName("menuItemID");

                entity.Property(e => e.RoleId).HasColumnName("RoleID");
            });

            modelBuilder.Entity<MenuUserMapping>(entity =>
            {
                entity.ToTable("menuUserMapping");

                entity.Property(e => e.MenuUserMappingId)
                    .ValueGeneratedNever()
                    .HasColumnName("menuUserMappingID");

                entity.Property(e => e.MenuItemId).HasColumnName("menuItemID");

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<Notification>(entity =>
            {
                entity.Property(e => e.NotificationId)
                    .ValueGeneratedNever()
                    .HasColumnName("NotificationID");

                entity.Property(e => e.AcknowledgedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.AcknowledgedDate).HasColumnType("datetime");

                entity.Property(e => e.BatchId).HasColumnName("BatchID");

                entity.Property(e => e.Category)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Message)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.RelevantClaimId).HasColumnName("Relevant_ClaimID");

                entity.Property(e => e.RelevantClientId).HasColumnName("Relevant_ClientID");

                entity.Property(e => e.RelevantInsurerId).HasColumnName("Relevant_InsurerID");

                entity.Property(e => e.RelevantSupplierId).HasColumnName("Relevant_SupplierID");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<PastelContingencyLedger>(entity =>
            {
                entity.ToTable("Pastel_Contingency_Ledger");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.AccountName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AccountNo)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Amount).HasColumnType("money");

                entity.Property(e => e.BatchId)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("BatchID");

                entity.Property(e => e.CreatedDate).HasColumnType("date");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.ExternalId)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("ExternalID");

                entity.Property(e => e.Gdc)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("GDC");

                entity.Property(e => e.JobCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.OpenBal).HasColumnType("money");

                entity.Property(e => e.DemoNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Refrence)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TaxAmount).HasColumnType("money");

                entity.Property(e => e.Total).HasColumnType("money");

                entity.Property(e => e.TransactionDescription)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("UserID");
            });

            modelBuilder.Entity<PastelCreditorsLedger>(entity =>
            {
                entity.ToTable("Pastel_Creditors_Ledger");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.AccountName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AccountNo)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Amount).HasColumnType("money");

                entity.Property(e => e.BatchId)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("BatchID");

                entity.Property(e => e.CreatedDate).HasColumnType("date");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.ExternalId)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("ExternalID");

                entity.Property(e => e.Gdc)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("GDC");

                entity.Property(e => e.JobCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.OpenBal).HasColumnType("money");

                entity.Property(e => e.DemoNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Refrence)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TaxAmount).HasColumnType("money");

                entity.Property(e => e.Total).HasColumnType("money");

                entity.Property(e => e.TransactionDescription)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("UserID");
            });

            modelBuilder.Entity<PastelDebtRecoveryLedger>(entity =>
            {
                entity.ToTable("Pastel_Debt_Recovery_Ledger");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.AccountName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AccountNo)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Amount).HasColumnType("money");

                entity.Property(e => e.BatchId)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("BatchID");

                entity.Property(e => e.CreatedDate).HasColumnType("date");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.ExternalId)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("ExternalID");

                entity.Property(e => e.Gdc)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("GDC");

                entity.Property(e => e.JobCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.OpenBal).HasColumnType("money");

                entity.Property(e => e.DemoNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Refrence)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TaxAmount).HasColumnType("money");

                entity.Property(e => e.Total).HasColumnType("money");

                entity.Property(e => e.TransactionDescription)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("UserID");
            });

            modelBuilder.Entity<PastelDebtorsLedger>(entity =>
            {
                entity.ToTable("Pastel_Debtors_Ledger");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.AccountName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AccountNo)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Amount).HasColumnType("money");

                entity.Property(e => e.BatchId)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("BatchID");

                entity.Property(e => e.CreatedDate).HasColumnType("date");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.ExternalId)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("ExternalID");

                entity.Property(e => e.Gdc)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("GDC");

                entity.Property(e => e.JobCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.OpenBal).HasColumnType("money");

                entity.Property(e => e.DemoNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Refrence)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TaxAmount).HasColumnType("money");

                entity.Property(e => e.Total).HasColumnType("money");

                entity.Property(e => e.TransactionDescription)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("UserID");
            });

            modelBuilder.Entity<PastelDeductionSuspenseAccountsLedger>(entity =>
            {
                entity.ToTable("Pastel_Deduction_Suspense_Accounts_Ledger");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.AccountName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AccountNo)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Amount).HasColumnType("money");

                entity.Property(e => e.BatchId)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("BatchID");

                entity.Property(e => e.CreatedDate).HasColumnType("date");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.ExternalId)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("ExternalID");

                entity.Property(e => e.Gdc)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("GDC");

                entity.Property(e => e.JobCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.OpenBal).HasColumnType("money");

                entity.Property(e => e.DemoNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Refrence)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TaxAmount).HasColumnType("money");

                entity.Property(e => e.Total).HasColumnType("money");

                entity.Property(e => e.TransactionDescription)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("UserID");
            });

            modelBuilder.Entity<PastelMatchedItem>(entity =>
            {
                entity.ToTable("Pastel_MatchedItems");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Amount).HasColumnType("money");

                entity.Property(e => e.BatchId)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("BatchID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Cscode)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("CSCode");

                entity.Property(e => e.CurrAmt).HasColumnType("money");

                entity.Property(e => e.CurrTaxAmt).HasColumnType("money");

                entity.Property(e => e.DDate)
                    .HasColumnType("datetime")
                    .HasColumnName("dDate");

                entity.Property(e => e.Dc)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("DC");

                entity.Property(e => e.Description)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Discount)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.EntryType).HasColumnType("money");

                entity.Property(e => e.ExportNum)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.LineFlag).HasColumnType("money");

                entity.Property(e => e.MatchRef)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Original).HasColumnType("money");

                entity.Property(e => e.Pperiod)
                    .HasColumnType("money")
                    .HasColumnName("PPeriod");

                entity.Property(e => e.DemoNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RawData)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Ref)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.TaxAmt).HasColumnType("money");

                entity.Property(e => e.TaxType).HasColumnType("money");

                entity.Property(e => e.UserDef)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PastelMatchedItemsTmp>(entity =>
            {
                entity.ToTable("Pastel_MatchedItems_tmp");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Amount).HasColumnType("money");

                entity.Property(e => e.BatchId)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("BatchID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Cscode)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("CSCode");

                entity.Property(e => e.CurrAmt).HasColumnType("money");

                entity.Property(e => e.CurrTaxAmt).HasColumnType("money");

                entity.Property(e => e.DDate)
                    .HasColumnType("datetime")
                    .HasColumnName("dDate");

                entity.Property(e => e.Dc)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("DC");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Discount)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.EntryType).HasColumnType("money");

                entity.Property(e => e.ExportNum)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.LineFlag).HasColumnType("money");

                entity.Property(e => e.MatchRef)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Original).HasColumnType("money");

                entity.Property(e => e.Pperiod)
                    .HasColumnType("money")
                    .HasColumnName("PPeriod");

                entity.Property(e => e.RawData)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Ref)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.TaxAmt).HasColumnType("money");

                entity.Property(e => e.TaxType).HasColumnType("money");

                entity.Property(e => e.UserDef)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PastelRebateProvisionLedger>(entity =>
            {
                entity.ToTable("Pastel_Rebate_Provision_Ledger");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.AccountName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AccountNo)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Amount).HasColumnType("money");

                entity.Property(e => e.BatchId)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("BatchID");

                entity.Property(e => e.CreatedDate).HasColumnType("date");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.ExternalId)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("ExternalID");

                entity.Property(e => e.Gdc)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("GDC");

                entity.Property(e => e.JobCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.OpenBal).HasColumnType("money");

                entity.Property(e => e.DemoNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Refrence)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TaxAmount).HasColumnType("money");

                entity.Property(e => e.Total).HasColumnType("money");

                entity.Property(e => e.TransactionDescription)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("UserID");
            });

            modelBuilder.Entity<PastelSdklog>(entity =>
            {
                entity.ToTable("PastelSDKLog");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Category)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.PastelCall)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PastelDataString).HasMaxLength(500);

                entity.Property(e => e.Pastelresult).HasMaxLength(250);

                entity.Property(e => e.ProjectCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PbAgeAnalysisExtract>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PB_AgeAnalysisExtract");

                entity.Property(e => e.AgeAnalysisNotesDefaultReason)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AvgAging).HasColumnType("numeric(38, 9)");

                entity.Property(e => e.ClaimAmount).HasColumnType("money");

                entity.Property(e => e.ClaimNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Current).HasColumnType("numeric(38, 4)");

                entity.Property(e => e.DateDifferance).HasColumnType("numeric(18, 6)");

                entity.Property(e => e.Dd)
                    .HasColumnType("numeric(19, 4)")
                    .HasColumnName("dd");

                entity.Property(e => e.ExpectedPaymentDate).HasColumnType("datetime");

                entity.Property(e => e.GroupTotalDue).HasColumnType("money");

                entity.Property(e => e.InsuranceCompany)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceDate).HasColumnType("datetime");

                entity.Property(e => e.InvoiceNo)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceTotal).HasColumnType("money");

                entity.Property(e => e.Notes).HasMaxLength(250);

                entity.Property(e => e.PanelBeater)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.PbtotalDue)
                    .HasColumnType("money")
                    .HasColumnName("PBTotalDue");

                entity.Property(e => e.DemoRef)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TotalDue).HasColumnType("money");

                entity.Property(e => e._120days)
                    .HasColumnType("numeric(38, 4)")
                    .HasColumnName("120Days");

                entity.Property(e => e._30days)
                    .HasColumnType("numeric(38, 4)")
                    .HasColumnName("30Days");

                entity.Property(e => e._60days)
                    .HasColumnType("numeric(38, 4)")
                    .HasColumnName("60Days");

                entity.Property(e => e._90days)
                    .HasColumnType("numeric(38, 4)")
                    .HasColumnName("90Days");
            });

            modelBuilder.Entity<PbAssessorCompany>(entity =>
            {
                entity.HasKey(e => e.AssessorCompanyId)
                    .HasName("PK__PB_Asses__3CBBA6919AA0EE2E");

                entity.ToTable("PB_AssessorCompany");

                entity.Property(e => e.AssessorCompanyId)
                    .ValueGeneratedNever()
                    .HasColumnName("AssessorCompanyID");

                entity.Property(e => e.CompanyName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<PbAssessorDetail>(entity =>
            {
                entity.HasKey(e => e.AssessorDetailId)
                    .HasName("PK__PB_Asses__D9010DD2F544B599");

                entity.ToTable("PB_AssessorDetails");

                entity.Property(e => e.AssessorDetailId)
                    .ValueGeneratedNever()
                    .HasColumnName("AssessorDetailID");

                entity.Property(e => e.AssessorCompanyId).HasColumnName("AssessorCompanyID");

                entity.Property(e => e.AssessorName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContactDetails)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<PbBankStatement>(entity =>
            {
                entity.HasKey(e => e.BankStatementId)
                    .HasName("PK__PB_BankS__D4AD9F443D9249FB");

                entity.ToTable("PB_BankStatement");

                entity.Property(e => e.BankStatementId)
                    .ValueGeneratedNever()
                    .HasColumnName("BankStatementID");

                entity.Property(e => e.BankHolderName)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.ClosingBalance).HasColumnType("money");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.OpeningBalance).HasColumnType("money");

                entity.Property(e => e.StatementDate).HasColumnType("datetime");

                entity.Property(e => e.TransactionTotalValue).HasColumnType("money");
            });

            modelBuilder.Entity<PbBankStatementItem>(entity =>
            {
                entity.HasKey(e => e.BankStatementItemsId)
                    .HasName("PK__PB_BankS__45B6DC4F4FC790C0");

                entity.ToTable("PB_BankStatementItems");

                entity.Property(e => e.BankStatementItemsId)
                    .ValueGeneratedNever()
                    .HasColumnName("BankStatementItemsID");

                entity.Property(e => e.AuthorisedBy)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.AuthorisedDate).HasColumnType("datetime");

                entity.Property(e => e.BankStatementId).HasColumnName("BankStatementID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.FinalisedBy)
                    .HasMaxLength(75)
                    .IsUnicode(false)
                    .HasColumnName("FinalisedBY");

                entity.Property(e => e.FinalisedDate).HasColumnType("datetime");

                entity.Property(e => e.ItemAmount).HasColumnType("money");

                entity.Property(e => e.ItemDate).HasColumnType("datetime");

                entity.Property(e => e.ItemDescription)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.RawData)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ReconComment)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.RefundAddedBy)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.RefundAddedDate).HasColumnType("datetime");

                entity.Property(e => e.RefundDocumentId).HasColumnName("RefundDocumentID");

                entity.Property(e => e.RemittanceAddedBy)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.RemittanceAddedDate).HasColumnType("datetime");

                entity.Property(e => e.RemittanceDocumentId).HasColumnName("RemittanceDocumentID");
            });

            modelBuilder.Entity<PbBankStatementItemInvoiceMapping>(entity =>
            {
                entity.HasKey(e => e.InvoiceMappingId)
                    .HasName("PK__PB_BankS__0922B4F7D2C5EA52");

                entity.ToTable("PB_BankStatementItem_InvoiceMapping");

                entity.Property(e => e.InvoiceMappingId)
                    .ValueGeneratedNever()
                    .HasColumnName("InvoiceMappingID");

                entity.Property(e => e.BankStatementItemId).HasColumnName("BankStatementItemID");

                entity.Property(e => e.ClaimId).HasColumnName("ClaimID");

                entity.Property(e => e.Contingency).HasColumnType("money");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.InvoiceAmount).HasColumnType("money");

                entity.Property(e => e.InvoiceNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.PaidDirectToPb)
                    .HasColumnType("money")
                    .HasColumnName("PaidDirectToPB");

                entity.Property(e => e.DemoNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PrintedBy).HasMaxLength(75);

                entity.Property(e => e.PrintedDate).HasColumnType("datetime");

                entity.Property(e => e.ShortFall).HasColumnType("money");
            });

            modelBuilder.Entity<PbBankUploadDataItem>(entity =>
            {
                entity.HasKey(e => e.BankUploadDataItemsId)
                    .HasName("PK__PB_BankU__10343D6AB1322DC4");

                entity.ToTable("PB_BankUploadDataItems");

                entity.Property(e => e.BankUploadDataItemsId)
                    .ValueGeneratedNever()
                    .HasColumnName("BankUploadDataItemsID");

                entity.Property(e => e.BankAccountHolderName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BankAccountNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BankBranchCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BankName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BankUploadDataId).HasColumnName("BankUploadDataID");

                entity.Property(e => e.BatchName)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.ClaimId).HasColumnName("ClaimID");

                entity.Property(e => e.FinalInvoiceAuthorisedDate).HasColumnType("datetime");

                entity.Property(e => e.LineFileData)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentBatchId).HasColumnName("PaymentBatchID");

                entity.Property(e => e.DemoNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PbBankUploadDataReversal>(entity =>
            {
                entity.HasKey(e => e.BankUploadDataReversalId)
                    .HasName("PK__PB_BankU__E76EA6CB6058DC47");

                entity.ToTable("PB_BankUploadData_reversals");

                entity.Property(e => e.BankUploadDataReversalId)
                    .ValueGeneratedNever()
                    .HasColumnName("BankUploadDataReversalID");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.FileData)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.FileProcessedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<PbBankUploadDatum>(entity =>
            {
                entity.HasKey(e => e.BankUploadDataId)
                    .HasName("PK__PB_BankU__CCA036708DCD62D6");

                entity.ToTable("PB_BankUploadData");

                entity.Property(e => e.BankUploadDataId)
                    .ValueGeneratedNever()
                    .HasColumnName("BankUploadDataID");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.FileData)
                    .IsRequired()
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PbBrand>(entity =>
            {
                entity.HasKey(e => e.BrandId);

                entity.ToTable("PB_Brands");

                entity.Property(e => e.BrandId)
                    .ValueGeneratedNever()
                    .HasColumnName("BrandID");

                entity.Property(e => e.Brand)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PbClaim>(entity =>
            {
                entity.HasKey(e => e.ClaimId)
                    .HasName("PK_Claims");

                entity.ToTable("PB_Claims");

                entity.HasIndex(e => e.DemoSeqNo, "uc_DemoSeqNo")
                    .IsUnique();

                entity.Property(e => e.ClaimId)
                    .ValueGeneratedNever()
                    .HasColumnName("ClaimID");

                entity.Property(e => e.AgeAnalysisNotesDefaultReason)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AllocationAmount).HasColumnType("money");

                entity.Property(e => e.AllocationReason)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.AodshortPayment)
                    .HasColumnType("money")
                    .HasColumnName("AODShortPayment");

                entity.Property(e => e.AuthoriseBy)
                    .HasMaxLength(75)
                    .IsUnicode(false)
                    .HasColumnName("authoriseBy");

                entity.Property(e => e.AuthoriseDate)
                    .HasColumnType("datetime")
                    .HasColumnName("authoriseDate");

                entity.Property(e => e.AuthorisedClaimAmount).HasColumnType("money");

                entity.Property(e => e.BankCharges).HasColumnType("money");

                entity.Property(e => e.BookInBy)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.BookInDate).HasColumnType("datetime");

                entity.Property(e => e.BordereauNumber)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.CancelConFirmBy)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.CancelConfirmDate).HasColumnType("datetime");

                entity.Property(e => e.CancelDeclinedBy)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.CancelDeclinedDate).HasColumnType("datetime");

                entity.Property(e => e.CancelReason)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.CancelRequestBy)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.CancelRequestDate).HasColumnType("datetime");

                entity.Property(e => e.ClaimAmount).HasColumnType("money");

                entity.Property(e => e.ClaimExcess).HasColumnType("money");

                entity.Property(e => e.ClaimPartsValue).HasColumnType("money");

                entity.Property(e => e.ClaimStatus)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.ClaimStatusClient)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.ClosedBy)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.ClosedDate).HasColumnType("datetime");

                entity.Property(e => e.Codfee)
                    .HasColumnType("money")
                    .HasColumnName("CODFee");

                entity.Property(e => e.CollectionNotes)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ContingencyAmount).HasColumnType("money");

                entity.Property(e => e.ContingencyAmountFlat).HasColumnType("money");

                entity.Property(e => e.ContingencyPercent).HasColumnType("money");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DocsReceivedNotes)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.EstimatedBookInDate).HasColumnType("datetime");

                entity.Property(e => e.ExpectedPaymentDate).HasColumnType("datetime");

                entity.Property(e => e.FactorerId).HasColumnName("FactorerID");

                entity.Property(e => e.FinalCostingApprovedBy)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.FinalCostingApprovedDate).HasColumnType("datetime");

                entity.Property(e => e.FinalCostingNote)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FinalCostingRequestedBy)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.FinalCostingRequestedDate).HasColumnType("datetime");

                entity.Property(e => e.FinalCostingUnderQueryBy)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.FinalCostingUnderQueryDate).HasColumnType("datetime");

                entity.Property(e => e.FinalInvoiceAmount).HasColumnType("money");

                entity.Property(e => e.FinalInvoiceAmountNett).HasColumnType("money");

                entity.Property(e => e.FinalInvoiceApprovalBy)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.FinalInvoiceApprovalDate).HasColumnType("datetime");

                entity.Property(e => e.FinalInvoiceAuthorisedAmount).HasColumnType("money");

                entity.Property(e => e.FinalInvoiceAuthorisedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FinalInvoiceAuthorisedDate).HasColumnType("datetime");

                entity.Property(e => e.FinalInvoiceBy)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.FinalInvoiceCalculatedBy)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.FinalInvoiceCalculatedDate).HasColumnType("datetime");

                entity.Property(e => e.FinalInvoiceCodfee)
                    .HasColumnType("money")
                    .HasColumnName("FinalInvoiceCODFee");

                entity.Property(e => e.FinalInvoiceDate).HasColumnType("datetime");

                entity.Property(e => e.FinalInvoiceNo)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.FinalInvoiceNote).IsUnicode(false);

                entity.Property(e => e.FinalInvoicePastelJournalDate).HasColumnType("datetime");

                entity.Property(e => e.FinalInvoiceRequestBy)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.FinalInvoiceRequestDate).HasColumnType("datetime");

                entity.Property(e => e.FinalInvoiceSupplierPartsAmount).HasColumnType("money");

                entity.Property(e => e.FundingAmount).HasColumnType("money");

                entity.Property(e => e.InitialClaimAmount).HasColumnType("money");

                entity.Property(e => e.InitialClaimExcess).HasColumnType("money");

                entity.Property(e => e.InsuredName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.InsuredPhoneNumber)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.InsurerClaimNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InsurerDiscountPercentage).HasColumnType("money");

                entity.Property(e => e.InsurerDiscountPercentageAmount).HasColumnType("money");

                entity.Property(e => e.InsurerId).HasColumnName("InsurerID");

                entity.Property(e => e.InsurerIdsecondary).HasColumnName("InsurerIDSecondary");

                entity.Property(e => e.InsurerLiaisonPerson)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InsurerScheme)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Interest).HasColumnType("money");

                entity.Property(e => e.InvoiceType)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.JobStartDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.NextExpectedFinalInvoiceDate).HasColumnType("datetime");

                entity.Property(e => e.NextExpectedPaymentDate).HasColumnType("datetime");

                entity.Property(e => e.PaidBy)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.PaidDate).HasColumnType("datetime");

                entity.Property(e => e.PaidDirectToPb)
                    .HasColumnType("money")
                    .HasColumnName("PaidDirectToPB");

                entity.Property(e => e.PartsPurchasedClosedJobs).HasColumnType("money");

                entity.Property(e => e.PartsPurchasedClosedJobsWip)
                    .HasColumnType("money")
                    .HasColumnName("PartsPurchasedClosedJobsWIP");

                entity.Property(e => e.PartsSummaryNotifiedDate).HasColumnType("datetime");

                entity.Property(e => e.PartsSummaryNotifiedPerson)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.PastelConfirmFinalInvoiceDatComments)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PastelConfirmFinalInvoiceDataDate).HasColumnType("datetime");

                entity.Property(e => e.PastelConfirmProjectCodeDate).HasColumnType("datetime");

                entity.Property(e => e.PastelConfirmSalesDataComments)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PastelConfirmSalesDataDate).HasColumnType("datetime");

                entity.Property(e => e.PastelCostCode)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PastelOiReceiptDate)
                    .HasColumnType("datetime")
                    .HasColumnName("PastelOI_ReceiptDate");

                entity.Property(e => e.PastelOiReceiptDateUpdateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("PastelOI_ReceiptDate_UpdateDate");

                entity.Property(e => e.PastelOiReceiptId).HasColumnName("PastelOI_ReceiptID");

                entity.Property(e => e.PastelOiReceiptedAmount)
                    .HasColumnType("money")
                    .HasColumnName("PastelOi_ReceiptedAmount");

                entity.Property(e => e.PaymentBatchId).HasColumnName("PaymentBatchID");

                entity.Property(e => e.PaymentDueToPb)
                    .HasColumnType("money")
                    .HasColumnName("PaymentDueToPB");

                entity.Property(e => e.PaymentRefNo)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.PbFinalInvoiceBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PB_FinalInvoiceBy");

                entity.Property(e => e.PbFinalInvoiceDate)
                    .HasColumnType("datetime")
                    .HasColumnName("PB_FinalInvoiceDate");

                entity.Property(e => e.PbPartsAuthorisedBy)
                    .HasMaxLength(75)
                    .IsUnicode(false)
                    .HasColumnName("PB_PartsAuthorisedBy");

                entity.Property(e => e.PbPartsAuthorisedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("PB_PartsAuthorisedDate");

                entity.Property(e => e.PbinvoiceToInsurerDate)
                    .HasColumnType("datetime")
                    .HasColumnName("PBInvoiceToInsurerDate");

                entity.Property(e => e.DemoNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProductDefinition).HasColumnType("money");

                entity.Property(e => e.ReceivedPbinsurerFinalInvoiceEmailDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ReceivedPBInsurerFinalInvoiceEmailDate");

                entity.Property(e => e.Reclaim).HasColumnType("money");

                entity.Property(e => e.ReferringBroker)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RejectNotes).IsUnicode(false);

                entity.Property(e => e.RejectReason)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.RequiresAuthorisation).HasColumnName("requiresAuthorisation");

                entity.Property(e => e.Ronumber)
                    .HasMaxLength(75)
                    .IsUnicode(false)
                    .HasColumnName("RONumber");

                entity.Property(e => e.ShortPayment).HasColumnType("money");

                entity.Property(e => e.VehicleMake)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.VehicleModel)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.VehicleRegistrationNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VehicleVin)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("VehicleVIN");

                entity.Property(e => e.WipaltRptFlaggedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("WIPAltRptFlaggedBy");

                entity.Property(e => e.WipaltRptFlaggedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("WIPAltRptFlaggedDate");

                entity.Property(e => e._7dayAltRptFlaggedBy)
                    .HasMaxLength(75)
                    .IsUnicode(false)
                    .HasColumnName("7DayAltRptFlaggedBy");

                entity.Property(e => e._7dayAltRptFlaggedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("7DayAltRptFlaggedDate");
            });

            modelBuilder.Entity<PbClaimDeduction>(entity =>
            {
                entity.HasKey(e => e.ClaimDeductionId)
                    .HasName("PK__PB_ClaimDeductionID");

                entity.ToTable("PB_ClaimDeductions");

                entity.Property(e => e.ClaimDeductionId)
                    .ValueGeneratedNever()
                    .HasColumnName("ClaimDeductionID");

                entity.Property(e => e.ClaimId).HasColumnName("ClaimID");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeductionPastelJournalDate).HasColumnType("datetime");

                entity.Property(e => e.DeductionType)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.DeductionValue).HasColumnType("money");

                entity.Property(e => e.EffectiveDate).HasColumnType("datetime");

                entity.Property(e => e.MaxReclaimPercent).HasColumnType("money");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.PastelConfirmComments)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PastelConfirmDate).HasColumnType("datetime");

                entity.Property(e => e.SupplierDocumentId).HasColumnName("SupplierDocumentID");
            });

            modelBuilder.Entity<PbClaimDeductionMapping>(entity =>
            {
                entity.HasKey(e => e.ClaimDeductionMappingId)
                    .HasName("PK__PB_Claim__C53C23AC5E93D87C");

                entity.ToTable("PB_ClaimDeductionMapping");

                entity.Property(e => e.ClaimDeductionMappingId)
                    .ValueGeneratedNever()
                    .HasColumnName("ClaimDeductionMappingID");

                entity.Property(e => e.ClaimDeductionId).HasColumnName("ClaimDeductionID");

                entity.Property(e => e.ClaimId).HasColumnName("ClaimID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<PbClaimDocument>(entity =>
            {
                entity.HasKey(e => e.ClaimDocumentId)
                    .HasName("PK_Documents");

                entity.ToTable("PB_ClaimDocuments");

                entity.Property(e => e.ClaimDocumentId)
                    .ValueGeneratedNever()
                    .HasColumnName("ClaimDocumentID");

                entity.Property(e => e.ArchiveDate).HasColumnType("datetime");

                entity.Property(e => e.ClaimId).HasColumnName("ClaimID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.DocumentData).HasColumnType("image");

                entity.Property(e => e.DocumentName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.DocumentType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InsurerChecklistItemId).HasColumnName("InsurerChecklistItemID");

                entity.Property(e => e.Keywords)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<PbClaimEmail>(entity =>
            {
                entity.HasKey(e => e.ClaimEmailId)
                    .HasName("PK_ClaimEmails");

                entity.ToTable("PB_ClaimEmails");

                entity.Property(e => e.ClaimEmailId)
                    .ValueGeneratedNever()
                    .HasColumnName("ClaimEmailID");

                entity.Property(e => e.BalanceDue).HasColumnType("money");

                entity.Property(e => e.BookInDate).HasColumnType("datetime");

                entity.Property(e => e.CashSecurityPercent).HasColumnType("money");

                entity.Property(e => e.CashSecurityValue).HasColumnType("money");

                entity.Property(e => e.ClaimAmount).HasColumnType("money");

                entity.Property(e => e.ClaimId).HasColumnName("ClaimID");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.ContingencyPercent).HasColumnType("money");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DateReceived).HasColumnType("datetime");

                entity.Property(e => e.DiscountCostPercent).HasColumnType("money");

                entity.Property(e => e.DiscountCostValue).HasColumnType("money");

                entity.Property(e => e.EmailBodyHtml).HasColumnName("EmailBodyHTML");

                entity.Property(e => e.EmailMessageId)
                    .HasMaxLength(150)
                    .HasColumnName("EmailMessageID");

                entity.Property(e => e.EmailSender)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.EmailSubject)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.EmailType)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.FileData)
                    .HasMaxLength(2500)
                    .IsUnicode(false);

                entity.Property(e => e.FinalInvoiceAmount).HasColumnType("money");

                entity.Property(e => e.FundingPercent).HasColumnType("money");

                entity.Property(e => e.InsuredsContactNumber)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.InsuredsName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Insurer)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.InsurerClaimNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InsurerId).HasColumnName("InsurerID");

                entity.Property(e => e.InsurerScheme)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceType)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.PanelBeaterId)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("PanelBeaterID");

                entity.Property(e => e.PartsAmount).HasColumnType("money");

                entity.Property(e => e.Ronumber)
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .HasColumnName("RONumber");

                entity.Property(e => e.VehicleMake)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.VehicleModel)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.VehicleRegistration)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.VehicleVin)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("VehicleVIN");
            });

            modelBuilder.Entity<PbClaimEmailAttachment>(entity =>
            {
                entity.HasKey(e => e.ClaimEmailAttachementId)
                    .HasName("PK_ClaimEmailAttachments");

                entity.ToTable("PB_ClaimEmailAttachments");

                entity.Property(e => e.ClaimEmailAttachementId)
                    .ValueGeneratedNever()
                    .HasColumnName("ClaimEmailAttachementID");

                entity.Property(e => e.AttachementName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.AttachmentData).HasColumnType("image");

                entity.Property(e => e.ClaimEmailId).HasColumnName("ClaimEmailID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<PbClaimEmailSupplier>(entity =>
            {
                entity.HasKey(e => e.ClaimEmailSupplierId);

                entity.ToTable("PB_ClaimEmailSuppliers");

                entity.Property(e => e.ClaimEmailSupplierId)
                    .ValueGeneratedNever()
                    .HasColumnName("ClaimEmailSupplierID");

                entity.Property(e => e.ClaimEmailId).HasColumnName("ClaimEmailID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.EstimatedValue).HasColumnType("money");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.DemoFunded)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.SupplierCode)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.SupplierId).HasColumnName("SupplierID");

                entity.Property(e => e.SupplierName)
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PbClaimEmailSupplierInvoice>(entity =>
            {
                entity.HasKey(e => e.ClaimEmailSupplierInvoiceId)
                    .HasName("PK_PB_ClaimEmailSupplierInvoces");

                entity.ToTable("PB_ClaimEmailSupplierInvoices");

                entity.Property(e => e.ClaimEmailSupplierInvoiceId)
                    .ValueGeneratedNever()
                    .HasColumnName("ClaimEmailSupplierInvoiceID");

                entity.Property(e => e.ClaimEmailId).HasColumnName("ClaimEmailID");

                entity.Property(e => e.ClaimId).HasColumnName("ClaimID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.InvoiceDate).HasColumnType("datetime");

                entity.Property(e => e.InvoiceNumber)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceValue).HasColumnType("money");

                entity.Property(e => e.MatchedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MatchedDate).HasColumnType("datetime");

                entity.Property(e => e.MatchedImportedSupplierDocumentId).HasColumnName("MatchedImportedSupplierDocumentID");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.PbsupplierInvoiceMatch).HasColumnName("PBSupplierInvoiceMatch");

                entity.Property(e => e.DemoFunded)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.SupplierCode)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.SupplierId).HasColumnName("SupplierID");

                entity.Property(e => e.SupplierName)
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PbClaimLog>(entity =>
            {
                entity.HasKey(e => e.ClaimLogId)
                    .HasName("PK_ClaimLog");

                entity.ToTable("PB_ClaimLog");

                entity.Property(e => e.ClaimLogId)
                    .ValueGeneratedNever()
                    .HasColumnName("ClaimLogID");

                entity.Property(e => e.Category)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ClaimId).HasColumnName("ClaimID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(250);

                entity.Property(e => e.Notes).IsUnicode(false);
            });

            modelBuilder.Entity<PbClaimLogsDeleted>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PB_ClaimLogsDeleted");

                entity.Property(e => e.Category)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ClaimId).HasColumnName("ClaimID");

                entity.Property(e => e.ClaimLogId).HasColumnName("ClaimLogID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(250);

                entity.Property(e => e.Notes).IsUnicode(false);

                entity.Property(e => e.TimeDeleted).HasColumnType("datetime");
            });

            modelBuilder.Entity<PbClaimRecovery>(entity =>
            {
                entity.HasKey(e => e.ClaimRecoveriesId)
                    .HasName("PK__PB_Claim__019DCFD132CB82C6");

                entity.ToTable("PB_ClaimRecoveries");

                entity.Property(e => e.ClaimRecoveriesId)
                    .ValueGeneratedNever()
                    .HasColumnName("ClaimRecoveriesID");

                entity.Property(e => e.ClaimDeductionId).HasColumnName("ClaimDeductionID");

                entity.Property(e => e.ClaimId).HasColumnName("ClaimID");

                entity.Property(e => e.CnclaimDeductionId).HasColumnName("CNClaimDeductionID");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.PaymentType)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentValue).HasColumnType("money");
            });

            modelBuilder.Entity<PbClaimRequest>(entity =>
            {
                entity.HasKey(e => e.ClaimRequestId)
                    .HasName("PK__PB_Claim__79AECBF2361EE85A");

                entity.ToTable("PB_ClaimRequests");

                entity.HasIndex(e => e.ClaimId, "UNIQUE_ClaimRequestID")
                    .IsUnique();

                entity.Property(e => e.ClaimRequestId)
                    .ValueGeneratedNever()
                    .HasColumnName("ClaimRequestID");

                entity.Property(e => e.ApprovedBy)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.ApprovedDate).HasColumnType("datetime");

                entity.Property(e => e.ClaimAmount).HasColumnType("money");

                entity.Property(e => e.ClaimExcess).HasColumnType("money");

                entity.Property(e => e.ClaimId).HasColumnName("ClaimID");

                entity.Property(e => e.ClaimPartsValue).HasColumnType("money");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeclinedBy)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.DeclinedDate).HasColumnType("datetime");

                entity.Property(e => e.EstimatedBookInDate).HasColumnType("datetime");

                entity.Property(e => e.InsuredName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.InsuredPhoneNumber)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.InsurerClaimNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InsurerId).HasColumnName("InsurerID");

                entity.Property(e => e.InsurerIdsecondary).HasColumnName("InsurerIDSecondary");

                entity.Property(e => e.InsurerLiaisonPerson)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceType)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Ronumber)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("RONumber");

                entity.Property(e => e.VehicleMake)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.VehicleModel)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.VehicleRegistrationNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PbClaimRequestSupplier>(entity =>
            {
                entity.HasKey(e => e.ClaimRequestSupplierId)
                    .HasName("PK__PB_Claim__7329EEC4841E7562");

                entity.ToTable("PB_ClaimRequestSuppliers");

                entity.Property(e => e.ClaimRequestSupplierId)
                    .ValueGeneratedNever()
                    .HasColumnName("ClaimRequestSupplierID");

                entity.Property(e => e.ClaimRequestId).HasColumnName("ClaimRequestID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.SupplierId).HasColumnName("SupplierID");
            });

            modelBuilder.Entity<PbClaimRevertLog>(entity =>
            {
                entity.HasKey(e => e.ClaimRevertLogId)
                    .HasName("PK__PB_Claim__86FC81D5724B5E47");

                entity.ToTable("PB_ClaimRevertLog");

                entity.Property(e => e.ClaimRevertLogId)
                    .ValueGeneratedNever()
                    .HasColumnName("ClaimRevertLogID");

                entity.Property(e => e.AllocationAmount).HasColumnType("money");

                entity.Property(e => e.AllocationReason)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.AodshortPayment)
                    .HasColumnType("money")
                    .HasColumnName("AODShortPayment");

                entity.Property(e => e.AuthorisedClaimAmount).HasColumnType("money");

                entity.Property(e => e.BankCharges).HasColumnType("money");

                entity.Property(e => e.ClaimAmount).HasColumnType("money");

                entity.Property(e => e.ClaimId).HasColumnName("ClaimID");

                entity.Property(e => e.Codfee)
                    .HasColumnType("money")
                    .HasColumnName("CODFee");

                entity.Property(e => e.ContingencyAmount).HasColumnType("money");

                entity.Property(e => e.ContingencyAmountFlat).HasColumnType("money");

                entity.Property(e => e.ContingencyPercent).HasColumnType("money");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.FactorerId).HasColumnName("FactorerID");

                entity.Property(e => e.FinalCostingApprovedDate).HasColumnType("datetime");

                entity.Property(e => e.FinalCostingRequestedDate).HasColumnType("datetime");

                entity.Property(e => e.FinalInvoiceAmount).HasColumnType("money");

                entity.Property(e => e.FinalInvoiceAmountNett).HasColumnType("money");

                entity.Property(e => e.FinalInvoiceApprovalDate).HasColumnType("datetime");

                entity.Property(e => e.FinalInvoiceAuthorisedAmount).HasColumnType("money");

                entity.Property(e => e.FinalInvoiceAuthorisedDate).HasColumnType("datetime");

                entity.Property(e => e.FinalInvoiceCalculatedDate).HasColumnType("datetime");

                entity.Property(e => e.FinalInvoiceCodfee)
                    .HasColumnType("money")
                    .HasColumnName("FinalInvoiceCODFee");

                entity.Property(e => e.FinalInvoiceDate).HasColumnType("datetime");

                entity.Property(e => e.FinalInvoicePastelJournalDate).HasColumnType("datetime");

                entity.Property(e => e.FinalInvoicePastelJournalRepostDate).HasColumnType("datetime");

                entity.Property(e => e.FinalInvoiceRequestDate).HasColumnType("datetime");

                entity.Property(e => e.FinalInvoiceReversalPastelJournalDate).HasColumnType("datetime");

                entity.Property(e => e.FinalInvoiceSupplierPartsAmount).HasColumnType("money");

                entity.Property(e => e.FundingAmount).HasColumnType("money");

                entity.Property(e => e.InsurerDiscountPercentage).HasColumnType("money");

                entity.Property(e => e.InsurerDiscountPercentageAmount).HasColumnType("money");

                entity.Property(e => e.Interest).HasColumnType("money");

                entity.Property(e => e.InvoiceType)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.PaidDate).HasColumnType("datetime");

                entity.Property(e => e.PaidDirectToPb)
                    .HasColumnType("money")
                    .HasColumnName("PaidDirectToPB");

                entity.Property(e => e.PartsPurchasedClosedJobs).HasColumnType("money");

                entity.Property(e => e.PartsPurchasedClosedJobsWip)
                    .HasColumnType("money")
                    .HasColumnName("PartsPurchasedClosedJobsWIP");

                entity.Property(e => e.PastelOiReceiptDate)
                    .HasColumnType("datetime")
                    .HasColumnName("PastelOI_ReceiptDate");

                entity.Property(e => e.PastelOiReceiptDateUpdateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("PastelOI_ReceiptDate_UpdateDate");

                entity.Property(e => e.PastelOiReceiptId).HasColumnName("PastelOI_ReceiptID");

                entity.Property(e => e.PaymentBatchId).HasColumnName("PaymentBatchID");

                entity.Property(e => e.PaymentDueToPb)
                    .HasColumnType("money")
                    .HasColumnName("PaymentDueToPB");

                entity.Property(e => e.PbPartsAuthorisedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("PB_PartsAuthorisedDate");

                entity.Property(e => e.ProductDefinition).HasColumnType("money");

                entity.Property(e => e.Reclaim).HasColumnType("money");

                entity.Property(e => e.ReverseReason)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.RevertDate).HasColumnType("datetime");

                entity.Property(e => e.ShortPayment).HasColumnType("money");
            });

            modelBuilder.Entity<PbClaimSupplier>(entity =>
            {
                entity.HasKey(e => e.ClaimSupplierId)
                    .HasName("PK_ClaimSuppliers");

                entity.ToTable("PB_ClaimSuppliers");

                entity.Property(e => e.ClaimSupplierId)
                    .ValueGeneratedNever()
                    .HasColumnName("ClaimSupplierID");

                entity.Property(e => e.ClaimId).HasColumnName("ClaimID");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.SupplierId).HasColumnName("SupplierID");
            });

            modelBuilder.Entity<PbClaimsFactored>(entity =>
            {
                entity.HasKey(e => e.ClaimId)
                    .HasName("PK__PB_Claims_Factored");

                entity.ToTable("PB_Claims_Factored");

                entity.Property(e => e.ClaimId)
                    .ValueGeneratedNever()
                    .HasColumnName("ClaimID");

                entity.Property(e => e.Commission).HasColumnType("money");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.FactoredDate).HasColumnType("datetime");

                entity.Property(e => e.FactorerId).HasColumnName("FactorerID");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.NotificationEmailAddress)
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PbClient>(entity =>
            {
                entity.HasKey(e => e.ClientId)
                    .HasName("PK_Clients");

                entity.ToTable("PB_Clients");

                entity.Property(e => e.ClientId)
                    .ValueGeneratedNever()
                    .HasColumnName("ClientID");

                entity.Property(e => e.AccountCode)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.BankAccountHolderName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BankAccountNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BankAllocation)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.BankBranchCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BankName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BankingDetailsModifiedBy).HasMaxLength(150);

                entity.Property(e => e.BankingDetailsModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.CellNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CityId).HasColumnName("CityID");

                entity.Property(e => e.ClaimAdministrator)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.ClaimController)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.ClaimControllerAlt)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.ClientName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ClientTradingName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyRegNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContingencyPercent).HasColumnType("money");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("date");

                entity.Property(e => e.DeductionAodshortPaymentsEnabled).HasColumnName("DeductionAODShortPaymentsEnabled");

                entity.Property(e => e.DeductionAodshortPaymentsEnabledBy)
                    .HasMaxLength(75)
                    .IsUnicode(false)
                    .HasColumnName("DeductionAODShortPaymentsEnabledBy");

                entity.Property(e => e.DeductionAodshortPaymentsEnabledDate)
                    .HasColumnType("datetime")
                    .HasColumnName("DeductionAODShortPaymentsEnabledDate");

                entity.Property(e => e.DeductionCodfeeEnabled).HasColumnName("DeductionCODFeeEnabled");

                entity.Property(e => e.DeductionCodfeeEnabledBy)
                    .HasMaxLength(75)
                    .IsUnicode(false)
                    .HasColumnName("DeductionCODFeeEnabledBy");

                entity.Property(e => e.DeductionCodfeeEnabledDate)
                    .HasColumnType("datetime")
                    .HasColumnName("DeductionCODFeeEnabledDate");

                entity.Property(e => e.DeductionInterestEnabledBy)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.DeductionInterestEnabledDate).HasColumnType("datetime");

                entity.Property(e => e.DeductionInvoiceReclaim90daysEnabledBy)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.DeductionInvoiceReclaim90daysEnabledDate).HasColumnType("datetime");

                entity.Property(e => e.DeductionPaidDirectToPbenabled).HasColumnName("DeductionPaidDirectToPBEnabled");

                entity.Property(e => e.DeductionPaidDirectToPbenabledBy)
                    .HasMaxLength(75)
                    .IsUnicode(false)
                    .HasColumnName("DeductionPaidDirectToPBEnabledBy");

                entity.Property(e => e.DeductionPaidDirectToPbenabledDate)
                    .HasColumnType("datetime")
                    .HasColumnName("DeductionPaidDirectToPBEnabledDate");

                entity.Property(e => e.DeductionShortPaymentEnabledBy)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.DeductionShortPaymentEnabledDate).HasColumnType("datetime");

                entity.Property(e => e.DefaultFunding).HasColumnType("money");

                entity.Property(e => e.Email)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ExternalId)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("ExternalID");

                entity.Property(e => e.FactorerId).HasColumnName("FactorerID");

                entity.Property(e => e.FaxNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FinalInvoiceNotificationEmail)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("FinalInvoiceNotificationEMail");

                entity.Property(e => e.InterestRate).HasColumnType("money");

                entity.Property(e => e.LoanAccountCode)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("date");

                entity.Property(e => e.NotificationEmailAddress)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.OnHoldReason)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PartsAuthEmailAddress)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.PartsPurchasedOnClosedJobsBy)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.PartsPurchasedOnClosedJobsDate).HasColumnType("datetime");

                entity.Property(e => e.PartsPurchasedOnClosedJobsWipby)
                    .HasMaxLength(75)
                    .IsUnicode(false)
                    .HasColumnName("PartsPurchasedOnClosedJobsWIPBy");

                entity.Property(e => e.PartsPurchasedOnClosedJobsWipdate)
                    .HasColumnType("datetime")
                    .HasColumnName("PartsPurchasedOnClosedJobsWIPDate");

                entity.Property(e => e.PartsPurchasedOnClosedJobsWipenabled).HasColumnName("PartsPurchasedOnClosedJobsWIPEnabled");

                entity.Property(e => e.PartsSummaryAlertPerson)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PastelConfirmDate).HasColumnType("datetime");

                entity.Property(e => e.PaymentNotificationEmail)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("PaymentNotificationEMail");

                entity.Property(e => e.PhysicalAddr1)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.PhysicalAddr2)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.PhysicalAddr3)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.PhysicalAddrCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PopUpPartsSummaryAlertPerson)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.PostalAddr1)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.PostalAddr2)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.PostalAddr3)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.PostalAddrCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Rating)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.RebateProvisionAccountCode)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Region)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RegionId).HasColumnName("RegionID");

                entity.Property(e => e.RemittanceContactEmail)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.RemittanceContactPerson)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.SuburbId).HasColumnName("SuburbID");

                entity.Property(e => e.TelNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TmsclientCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("TMSClientCode");

                entity.Property(e => e.TmsnotificationEmailAddress)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("TMSNotificationEmailAddress");

                entity.Property(e => e.TmsnotificationEmailAddressNewReference)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("TMSNotificationEmailAddress_NewReference");

                entity.Property(e => e.TmsnotificationEmailAddressPartsSummaries)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("TMSNotificationEmailAddress_PartsSummaries");

                entity.Property(e => e.VatregNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("VATRegNumber");

                entity.Property(e => e.WipalertPerson)
                    .HasMaxLength(75)
                    .IsUnicode(false)
                    .HasColumnName("WIPAlertPerson");
            });

            modelBuilder.Entity<PbClientInsurer>(entity =>
            {
                entity.HasKey(e => e.ClientInsurerId);

                entity.ToTable("PB_ClientInsurers");

                entity.Property(e => e.ClientInsurerId)
                    .ValueGeneratedNever()
                    .HasColumnName("ClientInsurerID");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("date");

                entity.Property(e => e.InsurerDiscountPercentage).HasColumnType("money");

                entity.Property(e => e.InsurerId).HasColumnName("InsurerID");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("date");
            });

            modelBuilder.Entity<PbClientPaymentReference>(entity =>
            {
                entity.HasKey(e => e.ClientPaymentReferenceId)
                    .HasName("PK__PB_Clien__C235D19F9893DA40");

                entity.ToTable("PB_ClientPaymentReferences");

                entity.Property(e => e.ClientPaymentReferenceId)
                    .ValueGeneratedNever()
                    .HasColumnName("ClientPaymentReferenceID");

                entity.Property(e => e.ClaimId).HasColumnName("ClaimID");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.ClientReference)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.PaymentBatchId).HasColumnName("PaymentBatchID");

                entity.Property(e => e.PaymentDate).HasColumnType("datetime");

                entity.Property(e => e.PaymentValue).HasColumnType("money");

                entity.Property(e => e.DemoReference)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SupplierDocumentId).HasColumnName("SupplierDocumentID");
            });

            modelBuilder.Entity<PbClientSupplier>(entity =>
            {
                entity.HasKey(e => e.ClientSupplierId)
                    .HasName("PK_ClientSuppliers");

                entity.ToTable("PB_ClientSuppliers");

                entity.Property(e => e.ClientSupplierId)
                    .ValueGeneratedNever()
                    .HasColumnName("ClientSupplierID");

                entity.Property(e => e.AccountCode)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("date");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("date");

                entity.Property(e => e.NotificationEmailAddress)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.SupplierId).HasColumnName("SupplierID");
            });

            modelBuilder.Entity<PbContact>(entity =>
            {
                entity.HasKey(e => e.ContactId)
                    .HasName("PK_Contact");

                entity.ToTable("PB_Contacts");

                entity.Property(e => e.ContactId)
                    .ValueGeneratedNever()
                    .HasColumnName("ContactID");

                entity.Property(e => e.ContactRole)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContactTitle)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ContactType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.Fax)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName).HasMaxLength(50);

                entity.Property(e => e.IdNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ID_Number");

                entity.Property(e => e.IdType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ID_Type");

                entity.Property(e => e.LastName).HasMaxLength(50);

                entity.Property(e => e.MemberId).HasColumnName("MemberID");

                entity.Property(e => e.Password)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneHome)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneMobile)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneWork)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Skype)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PbCorrespondance>(entity =>
            {
                entity.HasKey(e => e.CorrespondanceId)
                    .HasName("PK_Correspondance");

                entity.ToTable("PB_Correspondance");

                entity.Property(e => e.CorrespondanceId)
                    .ValueGeneratedNever()
                    .HasColumnName("CorrespondanceID");

                entity.Property(e => e.AttachmentFilenames).HasMaxLength(3500);

                entity.Property(e => e.ClaimEmailId).HasColumnName("ClaimEmailID");

                entity.Property(e => e.ClaimId).HasColumnName("ClaimID");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.History)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.LogDate).HasColumnType("datetime");

                entity.Property(e => e.MessageCategory)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.MessageSubject).HasMaxLength(150);

                entity.Property(e => e.MessageType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Recipients).HasMaxLength(250);

                entity.Property(e => e.RecipientsBcc)
                    .HasMaxLength(250)
                    .HasColumnName("RecipientsBCC");

                entity.Property(e => e.RecipientsCc)
                    .HasMaxLength(250)
                    .HasColumnName("RecipientsCC");

                entity.Property(e => e.SentDate).HasColumnType("datetime");

                entity.Property(e => e.ServerResponse).HasMaxLength(100);

                entity.Property(e => e.SupplierId).HasColumnName("SupplierID");

                entity.Property(e => e.Username)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PbInsurer>(entity =>
            {
                entity.HasKey(e => e.InsurerId)
                    .HasName("PK_Insurer");

                entity.ToTable("PB_Insurers");

                entity.Property(e => e.InsurerId)
                    .ValueGeneratedNever()
                    .HasColumnName("InsurerID");

                entity.Property(e => e.AccountCode)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.BankAccountHolder)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BankAccountNumber)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BankBranchName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BankName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BankingDetailsModifiedBy).HasMaxLength(150);

                entity.Property(e => e.BankingDetailsModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.CellNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ClaimNoPrefixText)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ClaimNoSufixText)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyRegNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("date");

                entity.Property(e => e.Email)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ExternalId)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("ExternalID");

                entity.Property(e => e.FaxNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FixedRebatePercent).HasColumnType("money");

                entity.Property(e => e.InsurerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InsurerTradingName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.InsurerType).HasMaxLength(50);

                entity.Property(e => e.InsurerTypeId).HasColumnName("InsurerTypeID");

                entity.Property(e => e.InvoiceRecipient)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("date");

                entity.Property(e => e.NotificationEmailAddress)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.ObsoleteMappingId).HasColumnName("ObsoleteMappingID");

                entity.Property(e => e.ObsoleteReason)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.OnHoldReason)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PhysicalAddr1)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.PhysicalAddr2)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.PhysicalAddr3)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.PhysicalAddrCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PostalAddr1)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.PostalAddr2)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.PostalAddr3)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.PostalAddrCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SelfInsuredCategoryId).HasColumnName("SelfInsuredCategoryID");

                entity.Property(e => e.TelNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VatregNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("VATRegNumber");
            });

            modelBuilder.Entity<PbInsurerAdministratorBrokerMapping>(entity =>
            {
                entity.HasKey(e => e.MappingId)
                    .HasName("PK__PB_Insur__8B5781BD8C053810");

                entity.ToTable("PB_Insurer_AdministratorBrokerMapping");

                entity.Property(e => e.MappingId)
                    .ValueGeneratedNever()
                    .HasColumnName("MappingID");

                entity.Property(e => e.AdministratorId).HasColumnName("AdministratorID");

                entity.Property(e => e.BrokerId).HasColumnName("BrokerID");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.InsurerId).HasColumnName("InsurerID");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.UnderwriterId).HasColumnName("UnderwriterID");
            });

            modelBuilder.Entity<PbInsurerCheckList>(entity =>
            {
                entity.HasKey(e => e.InsurerChecklistId);

                entity.ToTable("PB_Insurer_CheckList");

                entity.Property(e => e.InsurerChecklistId)
                    .ValueGeneratedNever()
                    .HasColumnName("InsurerChecklistID");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("date");

                entity.Property(e => e.InsurerChecklistItemId).HasColumnName("InsurerChecklistItemID");

                entity.Property(e => e.InsurerId).HasColumnName("InsurerID");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("date");
            });

            modelBuilder.Entity<PbInsurerCheckListItem>(entity =>
            {
                entity.HasKey(e => e.InsurerChecklistItemId);

                entity.ToTable("PB_Insurer_CheckList_Items");

                entity.Property(e => e.InsurerChecklistItemId)
                    .ValueGeneratedNever()
                    .HasColumnName("InsurerChecklistItemID");

                entity.Property(e => e.Category)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CheckListItem)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("date");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("date");
            });

            modelBuilder.Entity<PbInsurerClaimCheckList>(entity =>
            {
                entity.HasKey(e => e.InsurerClaimChecklistId);

                entity.ToTable("PB_Insurer_Claim_CheckList");

                entity.Property(e => e.InsurerClaimChecklistId)
                    .ValueGeneratedNever()
                    .HasColumnName("InsurerClaimChecklistID");

                entity.Property(e => e.ClaimDocumentId).HasColumnName("ClaimDocumentID");

                entity.Property(e => e.ClaimId).HasColumnName("ClaimID");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.InsurerChecklistId).HasColumnName("InsurerChecklistID");

                entity.Property(e => e.InsurerId).HasColumnName("InsurerID");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<PbInsurerInsurerUnderwriterMapping>(entity =>
            {
                entity.HasKey(e => e.MappingId)
                    .HasName("PK__PB_Insur__8B5781BD8ED0A30F");

                entity.ToTable("PB_Insurer_InsurerUnderwriterMapping");

                entity.Property(e => e.MappingId)
                    .ValueGeneratedNever()
                    .HasColumnName("MappingID");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.InsurerId).HasColumnName("InsurerID");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.UnderwriterId).HasColumnName("UnderwriterID");
            });

            modelBuilder.Entity<PbInsurerObsoleteMapping>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PB_Insurer_Obsolete_Mapping");

                entity.Property(e => e.InsurerId).HasColumnName("InsurerID");

                entity.Property(e => e.ObsoleteMappingId).HasColumnName("ObsoleteMappingID");
            });

            modelBuilder.Entity<PbInsurerUnderwriterAdministratorMapping>(entity =>
            {
                entity.HasKey(e => e.MappingId)
                    .HasName("PK__PB_Insur__8B5781BDF9CD92D9");

                entity.ToTable("PB_Insurer_UnderwriterAdministratorMapping");

                entity.Property(e => e.MappingId)
                    .ValueGeneratedNever()
                    .HasColumnName("MappingID");

                entity.Property(e => e.AdministratorId).HasColumnName("AdministratorID");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.InsurerId).HasColumnName("InsurerID");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.UnderwriterId).HasColumnName("UnderwriterID");
            });

            modelBuilder.Entity<PbInvoiceReclaim>(entity =>
            {
                entity.HasKey(e => e.InvoiceReclaimId)
                    .HasName("PK__PB_Invoi__7C0CC70773924AA4");

                entity.ToTable("PB_InvoiceReclaim");

                entity.Property(e => e.InvoiceReclaimId)
                    .ValueGeneratedNever()
                    .HasColumnName("InvoiceReclaimID");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ItemValue).HasColumnType("money");

                entity.Property(e => e.LinkId).HasColumnName("LinkID");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.SupplierDocumentId).HasColumnName("SupplierDocumentID");
            });

            modelBuilder.Entity<PbPaymentBatch>(entity =>
            {
                entity.HasKey(e => e.BatchId);

                entity.ToTable("PB_PaymentBatches");

                entity.Property(e => e.BatchId)
                    .ValueGeneratedNever()
                    .HasColumnName("BatchID");

                entity.Property(e => e.BatchName)
                    .IsRequired()
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.BatchPaidBy)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.BatchPaidDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CsvFileData).IsUnicode(false);

                entity.Property(e => e.CsvFileId).HasColumnName("CsvFileID");

                entity.Property(e => e.CsvFileName)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PbProductDefinition>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PB_ProductDefinitions");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceDiscountPercentage).HasColumnType("money");

                entity.Property(e => e.ProductDefinitionId).HasColumnName("ProductDefinitionID");
            });

            modelBuilder.Entity<PbPurchaseNote>(entity =>
            {
                entity.HasKey(e => e.PurchaseNoteId)
                    .HasName("PK__PB_Purch__44FCAEBB8BF6F2C9");

                entity.ToTable("PB_PurchaseNotes");

                entity.Property(e => e.PurchaseNoteId)
                    .ValueGeneratedNever()
                    .HasColumnName("PurchaseNoteID");

                entity.Property(e => e.ClaimId).HasColumnName("ClaimID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Discount).HasColumnType("money");

                entity.Property(e => e.FundingAmount).HasColumnType("money");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.PartsPurchasedByDemo).HasColumnType("money");

                entity.Property(e => e.DemoToPay).HasColumnType("money");

                entity.Property(e => e.SecurityAmount).HasColumnType("money");

                entity.Property(e => e.TotalInvoiceAmount).HasColumnType("money");
            });

            modelBuilder.Entity<PbRebateStructure>(entity =>
            {
                entity.HasKey(e => e.RebateStructureId);

                entity.ToTable("PB_RebateStructures");

                entity.Property(e => e.RebateStructureId)
                    .ValueGeneratedNever()
                    .HasColumnName("RebateStructureID");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.ClientPercent).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.EffectiveDate).HasColumnType("datetime");

                entity.Property(e => e.InsurerId).HasColumnName("InsurerID");

                entity.Property(e => e.InsurerPercent).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.DemoPercent).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SupplierId).HasColumnName("SupplierID");

                entity.Property(e => e.TotalPercent).HasColumnType("decimal(18, 4)");
            });

            modelBuilder.Entity<PbRegisterPanelbeater>(entity =>
            {
                entity.HasKey(e => e.RegisterId);

                entity.ToTable("PB_RegisterPanelbeater");

                entity.Property(e => e.RegisterId)
                    .ValueGeneratedNever()
                    .HasColumnName("RegisterID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ExternalId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ExternalID");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.PanelbeaterName)
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PbReport>(entity =>
            {
                entity.HasKey(e => e.ReportId)
                    .HasName("PK__PB_Repor__D5BD48E5247D636F");

                entity.ToTable("PB_Reports");

                entity.Property(e => e.ReportId)
                    .ValueGeneratedNever()
                    .HasColumnName("ReportID");

                entity.Property(e => e.AllowedRoles)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.DisplayName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.GlobalRole)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.LuReportCategory)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LU_ReportCategory");

                entity.Property(e => e.LuReportSubCategory)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LU_ReportSubCategory");

                entity.Property(e => e.LuReportType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("LU_ReportType");

                entity.Property(e => e.ReportName)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.ReportToPdfenabled).HasColumnName("ReportToPDFEnabled");
            });

            modelBuilder.Entity<PbReportSchedule>(entity =>
            {
                entity.HasKey(e => e.ReportScheduleId)
                    .HasName("PK_ReportSchedule");

                entity.ToTable("PB_ReportSchedule");

                entity.Property(e => e.ReportScheduleId).HasColumnName("ReportScheduleID");

                entity.Property(e => e.Interval)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IntervalQuantity)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.IntervalType)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.LastRunTime).HasColumnType("datetime");

                entity.Property(e => e.NextRunTime).HasColumnType("datetime");

                entity.Property(e => e.ReportFormat)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReportId).HasColumnName("ReportID");
            });

            modelBuilder.Entity<PbReportScheduleParameter>(entity =>
            {
                entity.ToTable("PB_ReportScheduleParameters");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ClientId)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ClientID");

                entity.Property(e => e.Parameters).IsUnicode(false);

                entity.Property(e => e.RecipientList)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.ReportId).HasColumnName("ReportID");
            });

            modelBuilder.Entity<PbReportScheduleRecipient>(entity =>
            {
                entity.HasKey(e => e.ReportSchedulerRecipients)
                    .HasName("PK__PB_Repor__269D96B35F67FC2D");

                entity.ToTable("PB_ReportScheduleRecipients");

                entity.Property(e => e.ReportSchedulerRecipients).ValueGeneratedNever();

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.CreateBy)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.DeleteBy)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.Recipients)
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.ReportId).HasColumnName("ReportID");
            });

            modelBuilder.Entity<PbReportToPdf>(entity =>
            {
                entity.HasKey(e => e.ReportsToPdfid)
                    .HasName("PK__PB_Repor__236B320106387B53");

                entity.ToTable("PB_ReportToPDF");

                entity.Property(e => e.ReportsToPdfid)
                    .ValueGeneratedNever()
                    .HasColumnName("ReportsToPDFID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CustomPdf).HasColumnName("CustomPDF");

                entity.Property(e => e.DeleteBy)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.DeleteDate).HasColumnType("datetime");

                entity.Property(e => e.DisplayName)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Params)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ProcToRun)
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PbReportsLog>(entity =>
            {
                entity.HasKey(e => e.ReportsLogId)
                    .HasName("PK__PB_Repor__8F09034142BE858B");

                entity.ToTable("PB_ReportsLog");

                entity.Property(e => e.ReportsLogId)
                    .ValueGeneratedNever()
                    .HasColumnName("ReportsLogID");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ReportId).HasColumnName("ReportID");
            });

            modelBuilder.Entity<PbSupplier>(entity =>
            {
                entity.HasKey(e => e.SupplierId)
                    .HasName("PK_Supplier");

                entity.ToTable("PB_Suppliers");

                entity.Property(e => e.SupplierId)
                    .ValueGeneratedNever()
                    .HasColumnName("SupplierID");

                entity.Property(e => e.AccountCode)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.BankAccountHolder)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BankAccountNumber)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BankBranchName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BankName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BankingDetailsModifiedBy).HasMaxLength(150);

                entity.Property(e => e.BankingDetailsModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.BranchCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Brand)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CellNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CityId).HasColumnName("CityID");

                entity.Property(e => e.CompanyRegNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContactPerson)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("date");

                entity.Property(e => e.CreditorDepartmentEmailAddress)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ExternalId)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("ExternalID");

                entity.Property(e => e.FaxNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IntegrationName)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("date");

                entity.Property(e => e.NoCodfee).HasColumnName("NoCODFee");

                entity.Property(e => e.NotificationEmailAddress)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.NotificationEmailAddressBcc)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("NotificationEmailAddress_bcc");

                entity.Property(e => e.OnHoldReason)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PastelCategory).HasMaxLength(50);

                entity.Property(e => e.PastelConfirmData)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.PastelConfirmDate).HasColumnType("datetime");

                entity.Property(e => e.PaymentTerms)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.PhysicalAddr1)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.PhysicalAddr2)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.PhysicalAddr3)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.PhysicalAddrCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PostalAddr1)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.PostalAddr2)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.PostalAddr3)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.PostalAddrCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Region)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RegionId).HasColumnName("RegionID");

                entity.Property(e => e.RemittanceContactEmail)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.RemittanceContactPerson)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.SuburbId).HasColumnName("SuburbID");

                entity.Property(e => e.SupplierGroupId).HasColumnName("SupplierGroupID");

                entity.Property(e => e.SupplierGroupName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SupplierName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SupplierTradingName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.SupplierType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TelNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VatregNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("VATRegNumber");
            });

            modelBuilder.Entity<PbSupplierBrand>(entity =>
            {
                entity.HasKey(e => e.PanelBeaterBrandId);

                entity.ToTable("PB_SupplierBrands");

                entity.Property(e => e.PanelBeaterBrandId)
                    .ValueGeneratedNever()
                    .HasColumnName("PanelBeaterBrandID");

                entity.Property(e => e.BrandId).HasColumnName("BrandID");

                entity.Property(e => e.SupplierId).HasColumnName("SupplierID");
            });

            modelBuilder.Entity<PbSupplierBrandsRegistration>(entity =>
            {
                entity.HasKey(e => e.PanelBeaterBrandId);

                entity.ToTable("PB_SupplierBrandsRegistration");

                entity.Property(e => e.PanelBeaterBrandId)
                    .ValueGeneratedNever()
                    .HasColumnName("PanelBeaterBrandID");

                entity.Property(e => e.BrandId).HasColumnName("BrandID");

                entity.Property(e => e.SupplierId).HasColumnName("SupplierID");
            });

            modelBuilder.Entity<PbSupplierClaimValidation>(entity =>
            {
                entity.HasKey(e => e.AttemptId)
                    .HasName("PK_AttemptID");

                entity.ToTable("PB_SupplierClaimValidation");

                entity.Property(e => e.AttemptId)
                    .HasColumnName("AttemptID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.ClaimAmount).HasColumnType("money");

                entity.Property(e => e.ClaimId).HasColumnName("ClaimID");

                entity.Property(e => e.ClaimStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Notification).IsUnicode(false);

                entity.Property(e => e.DemoNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SupplierId).HasColumnName("SupplierID");
            });

            modelBuilder.Entity<PbSupplierCodpaymentBatch>(entity =>
            {
                entity.HasKey(e => e.CodbatchId)
                    .HasName("PK__PB_Suppl__C215872374AC15B6");

                entity.ToTable("PB_SupplierCODPaymentBatches");

                entity.Property(e => e.CodbatchId)
                    .ValueGeneratedNever()
                    .HasColumnName("CODBatchID");

                entity.Property(e => e.BatchName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ClosedOffBy)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.ClosedOffDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.PaidBy)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.PaidDate)
                    .HasMaxLength(75)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PbSupplierGroup>(entity =>
            {
                entity.HasKey(e => e.SupplierGroupId);

                entity.ToTable("PB_SupplierGroups");

                entity.Property(e => e.SupplierGroupId)
                    .ValueGeneratedNever()
                    .HasColumnName("SupplierGroupID");

                entity.Property(e => e.DefaultPastelAccountCode)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.SupplierGroup)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PbSupplierSupplyArea>(entity =>
            {
                entity.HasKey(e => e.SupplyAreaId)
                    .HasName("PK__PB_Suppl__90EFD73DCFE5C48F");

                entity.ToTable("PB_SupplierSupplyAreas");

                entity.Property(e => e.SupplyAreaId)
                    .ValueGeneratedNever()
                    .HasColumnName("SupplyAreaID");

                entity.Property(e => e.CityId).HasColumnName("CityID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModeifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SupplierId).HasColumnName("SupplierID");
            });

            modelBuilder.Entity<PbSuppliersRegistration>(entity =>
            {
                entity.HasKey(e => e.SupplierRegisterId);

                entity.ToTable("PB_SuppliersRegistration");

                entity.Property(e => e.SupplierRegisterId)
                    .ValueGeneratedNever()
                    .HasColumnName("SupplierRegisterID");

                entity.Property(e => e.AccountCode)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.AddedBy)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.AddedDate).HasColumnType("datetime");

                entity.Property(e => e.BankAccountHolder)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BankAccountNumber)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BankBranchName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BankName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Brand)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CellNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyRegNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("date");

                entity.Property(e => e.Email)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ExternalId)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("ExternalID");

                entity.Property(e => e.FaxNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IntegrationName)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("date");

                entity.Property(e => e.NotificationEmailAddress)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentTerms)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.PhysicalAddr1)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.PhysicalAddr2)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.PhysicalAddr3)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.PhysicalAddrCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PostalAddr1)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.PostalAddr2)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.PostalAddr3)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.PostalAddrCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Region)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SupplierGroupName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SupplierName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SupplierTradingName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.TelNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VatregNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("VATRegNumber");
            });

            modelBuilder.Entity<PbSuppliersRequest>(entity =>
            {
                entity.HasKey(e => e.RequestId);

                entity.ToTable("PB_SuppliersRequest");

                entity.Property(e => e.RequestId)
                    .ValueGeneratedNever()
                    .HasColumnName("RequestID");

                entity.Property(e => e.CellNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyRegNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeclinedReason)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.EstimatedMonthlyPurchases).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.FaxNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.PaymentTerms)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.PhysicalAddr1)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.PhysicalAddr2)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.PhysicalAddr3)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.PhysicalAddrCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PostalAddr1)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.PostalAddr2)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.PostalAddr3)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.PostalAddrCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ProcessedDate).HasColumnType("datetime");

                entity.Property(e => e.Responce)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SupplierName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TelNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<RebateDocument>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.ClaimId).HasColumnName("ClaimID");

                entity.Property(e => e.ClientAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.ClientPercent).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DocumentDate).HasColumnType("datetime");

                entity.Property(e => e.DocumentNumber)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.DocumentTotal).HasColumnType("money");

                entity.Property(e => e.DocumentType)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.InsertedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InsertedDate).HasColumnType("datetime");

                entity.Property(e => e.InsurerAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.InsurerId).HasColumnName("InsurerID");

                entity.Property(e => e.InsurerPercent).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DemoAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DemoNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DemoPercent).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.RebateDueDate).HasColumnType("datetime");

                entity.Property(e => e.Ronumber)
                    .HasMaxLength(75)
                    .IsUnicode(false)
                    .HasColumnName("RONumber");

                entity.Property(e => e.SupplierDocumentId).HasColumnName("SupplierDocumentID");

                entity.Property(e => e.SupplierId).HasColumnName("SupplierID");

                entity.Property(e => e.ToPastelBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ToPastelDate).HasColumnType("datetime");

                entity.Property(e => e.TotalAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalPercent).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<ReleaseNote>(entity =>
            {
                entity.Property(e => e.ReleaseNoteId)
                    .ValueGeneratedNever()
                    .HasColumnName("ReleaseNoteID");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ReportsNumber>(entity =>
            {
                entity.HasKey(e => e.Number)
                    .HasName("PK_Numbers");

                entity.ToTable("Reports_Numbers");

                entity.Property(e => e.Number).ValueGeneratedNever();
            });

            modelBuilder.Entity<ReportsPrint>(entity =>
            {
                entity.ToTable("ReportsPrint");

                entity.Property(e => e.ReportsPrintId)
                    .HasColumnName("ReportsPrintID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CustomPdf).HasColumnName("CustomPDF");

                entity.Property(e => e.DeliverTo)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ErrorMessage)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.InsertedBy)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('System')");

                entity.Property(e => e.InsertedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MethodName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('SSRS')");

                entity.Property(e => e.NotSsrs).HasColumnName("NotSSRS");

                entity.Property(e => e.ProcessedOn).HasColumnType("datetime");

                entity.Property(e => e.ReportFormat)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ReportParams)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.ReportServerName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Sqlscript)
                    .IsUnicode(false)
                    .HasColumnName("SQLScript");
            });

            modelBuilder.Entity<RoleDisplayName>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("role_DisplayNames");

                entity.Property(e => e.DisplayName)
                    .IsRequired()
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("displayName");
            });

            modelBuilder.Entity<SupplierStatementCheckList>(entity =>
            {
                entity.HasKey(e => e.SupplierStatementId)
                    .HasName("PK__Supplier__E6CB65E03EF9A159");

                entity.ToTable("SupplierStatementCheckList");

                entity.Property(e => e.SupplierStatementId)
                    .ValueGeneratedNever()
                    .HasColumnName("SupplierStatementID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.PaidBy)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.PaidDate).HasColumnType("datetime");

                entity.Property(e => e.ReceivedBy)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.ReceivedDate).HasColumnType("datetime");

                entity.Property(e => e.ReconciledBy)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.ReconciledDate).HasColumnType("datetime");

                entity.Property(e => e.SupplierId).HasColumnName("SupplierID");
            });

            modelBuilder.Entity<SystemLog>(entity =>
            {
                entity.ToTable("SystemLog");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.EventData).HasMaxLength(150);

                entity.Property(e => e.EventDate).HasColumnType("datetime");

                entity.Property(e => e.EventMessage).HasMaxLength(3500);

                entity.Property(e => e.InsertedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InsertedOn).HasColumnType("datetime");

                entity.Property(e => e.Source)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TempCacheLog>(entity =>
            {
                entity.HasKey(e => e.CacheLogId)
                    .HasName("PK__temp_Cac__EFCC5306C714A6A4");

                entity.ToTable("temp_CacheLog");

                entity.Property(e => e.CacheLogId)
                    .ValueGeneratedNever()
                    .HasColumnName("CacheLogID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Ipaddress)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("IPAddress");
            });

            modelBuilder.Entity<TmpAccountMappingInsurer>(entity =>
            {
                entity.ToTable("tmpAccountMappingInsurer");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ClaimNo).HasMaxLength(255);

                entity.Property(e => e.ClientTradingAs)
                    .HasMaxLength(255)
                    .HasColumnName("Client Trading As");

                entity.Property(e => e.ExtId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ExtID");

                entity.Property(e => e.Insurer).HasMaxLength(255);

                entity.Property(e => e.InsurerId).HasColumnName("InsurerID");

                entity.Property(e => e.InvoiceAmount).HasColumnName("Invoice Amount");

                entity.Property(e => e.Demonumber)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TmpPastelAccountNumberMapping>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tmpPastelAccountNumberMapping");

                entity.Property(e => e.AccNo)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.ClientNo)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.InsurerCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.InsurerId).HasColumnName("InsurerID");

                entity.Property(e => e.QuoteNo)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TmpRebateDatum>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tmpRebateData");

                entity.Property(e => e.ClientAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ClientName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ClientPercent)
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.DocumentDate)
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.DocumentNumber)
                    .IsRequired()
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.DocumentTotal).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DocumentType)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.InsurerAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.InsurerClaimNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InsurerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InsurerPercent)
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.DemoAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DemoNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DemoPercent)
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.Ronumber)
                    .HasMaxLength(75)
                    .IsUnicode(false)
                    .HasColumnName("RONumber");

                entity.Property(e => e.SupplierName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TotalAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalPercent)
                    .HasMaxLength(31)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TmpWipdata1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tmpWIPData1");

                entity.Property(e => e.BalanceDueOrOwing).HasColumnType("numeric(38, 8)");

                entity.Property(e => e.ClaimSettlementDate).HasColumnType("datetime");

                entity.Property(e => e.ClosedDate).HasColumnType("datetime");

                entity.Property(e => e.ContingentRebate).HasColumnType("numeric(38, 8)");

                entity.Property(e => e.CumulatedPenalties).HasColumnType("numeric(34, 7)");

                entity.Property(e => e.ExternalId)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("ExternalID");

                entity.Property(e => e.FinalInvoiceAuthorisedDate).HasColumnType("datetime");

                entity.Property(e => e.FullRebateValue).HasColumnType("decimal(38, 8)");

                entity.Property(e => e.InvoiceDate).HasColumnType("datetime");

                entity.Property(e => e.InvoiceNumber)
                    .IsRequired()
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.PanelBeater)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.PartsPaymentDate).HasColumnType("datetime");

                entity.Property(e => e.PastelOiReceiptDate)
                    .HasColumnType("datetime")
                    .HasColumnName("PastelOI_ReceiptDate");

                entity.Property(e => e.PbmonthlyPenaltyFee)
                    .HasColumnType("numeric(23, 7)")
                    .HasColumnName("PBMonthlyPenaltyFee");

                entity.Property(e => e.PbrebatePercent)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("PBRebatePercent");

                entity.Property(e => e.PbrebateValue)
                    .HasColumnType("decimal(38, 8)")
                    .HasColumnName("PBRebateValue");

                entity.Property(e => e.Pbsettlement)
                    .HasColumnType("numeric(38, 8)")
                    .HasColumnName("PBSettlement");

                entity.Property(e => e.PenaltyUsed).HasColumnType("numeric(34, 7)");

                entity.Property(e => e.DemoNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DemoRebatePercent).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DemoRebateValue).HasColumnType("decimal(38, 8)");

                entity.Property(e => e.ProductDefinition)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.RealisedThisMonth)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.RebateUsed).HasColumnType("decimal(38, 8)");

                entity.Property(e => e.ReportEndDate).HasColumnType("datetime");

                entity.Property(e => e.ReportStartDate).HasColumnType("datetime");

                entity.Property(e => e.Ssno)
                    .IsRequired()
                    .HasMaxLength(27)
                    .IsUnicode(false)
                    .HasColumnName("SSNo");

                entity.Property(e => e.SupplierInvoiceValue).HasColumnType("money");

                entity.Property(e => e.SupplierName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TotalRebatePercent).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.VehicleRegNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TmpWipdata2>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tmpWIPData2");

                entity.Property(e => e.BalanceDueOrOwing).HasColumnType("numeric(38, 8)");

                entity.Property(e => e.ClaimSettlementDate).HasColumnType("datetime");

                entity.Property(e => e.ClosedDate).HasColumnType("datetime");

                entity.Property(e => e.ContingentRebate).HasColumnType("numeric(38, 8)");

                entity.Property(e => e.CumulatedPenalties).HasColumnType("numeric(34, 7)");

                entity.Property(e => e.ExternalId)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("ExternalID");

                entity.Property(e => e.FinalInvoiceAuthorisedDate).HasColumnType("datetime");

                entity.Property(e => e.FullRebateValue).HasColumnType("decimal(38, 8)");

                entity.Property(e => e.InvoiceDate).HasColumnType("datetime");

                entity.Property(e => e.InvoiceNumber)
                    .IsRequired()
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.PanelBeater)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.PartsPaymentDate).HasColumnType("datetime");

                entity.Property(e => e.PastelOiReceiptDate)
                    .HasColumnType("datetime")
                    .HasColumnName("PastelOI_ReceiptDate");

                entity.Property(e => e.PbmonthlyPenaltyFee)
                    .HasColumnType("numeric(23, 7)")
                    .HasColumnName("PBMonthlyPenaltyFee");

                entity.Property(e => e.PbrebatePercent)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("PBRebatePercent");

                entity.Property(e => e.PbrebateValue)
                    .HasColumnType("decimal(38, 8)")
                    .HasColumnName("PBRebateValue");

                entity.Property(e => e.Pbsettlement)
                    .HasColumnType("numeric(38, 8)")
                    .HasColumnName("PBSettlement");

                entity.Property(e => e.PenaltyUsed).HasColumnType("numeric(34, 7)");

                entity.Property(e => e.DemoNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DemoRebatePercent).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DemoRebateValue).HasColumnType("decimal(38, 8)");

                entity.Property(e => e.ProductDefinition)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.RealisedThisMonth)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.RebateUsed).HasColumnType("decimal(38, 8)");

                entity.Property(e => e.ReportEndDate).HasColumnType("datetime");

                entity.Property(e => e.ReportStartDate).HasColumnType("datetime");

                entity.Property(e => e.Ssno)
                    .IsRequired()
                    .HasMaxLength(27)
                    .IsUnicode(false)
                    .HasColumnName("SSNo");

                entity.Property(e => e.SupplierInvoiceValue).HasColumnType("money");

                entity.Property(e => e.SupplierName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TotalRebatePercent).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.VehicleRegNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UserCompanyRole>(entity =>
            {
                entity.HasKey(e => new { e.UserName, e.LuCompanyRole })
                    .HasName("PK_UserCompanyRole_1");

                entity.ToTable("UserCompanyRole");

                entity.Property(e => e.UserName).HasMaxLength(256);

                entity.Property(e => e.LuCompanyRole)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LU_CompanyRole");
            });

            modelBuilder.Entity<UserDetail>(entity =>
            {
                entity.HasKey(e => e.UserName);

                entity.ToTable("UserDetail");

                entity.Property(e => e.UserName).HasMaxLength(256);

                entity.Property(e => e.AssignedSystem)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.DisplayName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.EmailAddress)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.LuDepartment)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LU_Department");

                entity.Property(e => e.ReportsTo).HasMaxLength(256);
            });

            modelBuilder.Entity<UserFunctionAllocation>(entity =>
            {
                entity.Property(e => e.UserFunctionAllocationId)
                    .ValueGeneratedNever()
                    .HasColumnName("UserFunctionAllocationID");

                entity.Property(e => e.AllocationId).HasColumnName("AllocationID");

                entity.Property(e => e.FunctionType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .HasMaxLength(256)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UserLog>(entity =>
            {
                entity.ToTable("UserLog");

                entity.Property(e => e.UserLogId)
                    .ValueGeneratedNever()
                    .HasColumnName("UserLogID");

                entity.Property(e => e.Action)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Ipaddress)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("IPAddress");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Url)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<View2>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_2");

                entity.Property(e => e.AgeAnalysisNotesDefaultReason)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AllocationAmount).HasColumnType("money");

                entity.Property(e => e.AllocationReason)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.AodshortPayment)
                    .HasColumnType("money")
                    .HasColumnName("AODShortPayment");

                entity.Property(e => e.AuthoriseBy)
                    .HasMaxLength(75)
                    .IsUnicode(false)
                    .HasColumnName("authoriseBy");

                entity.Property(e => e.AuthoriseDate)
                    .HasColumnType("datetime")
                    .HasColumnName("authoriseDate");

                entity.Property(e => e.AuthorisedClaimAmount).HasColumnType("money");

                entity.Property(e => e.BankCharges).HasColumnType("money");

                entity.Property(e => e.BookInBy)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.BookInDate).HasColumnType("datetime");

                entity.Property(e => e.BordereauNumber)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.CancelConFirmBy)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.CancelConfirmDate).HasColumnType("datetime");

                entity.Property(e => e.CancelDeclinedBy)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.CancelDeclinedDate).HasColumnType("datetime");

                entity.Property(e => e.CancelReason)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.CancelRequestBy)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.CancelRequestDate).HasColumnType("datetime");

                entity.Property(e => e.ClaimAmount).HasColumnType("money");

                entity.Property(e => e.ClaimExcess).HasColumnType("money");

                entity.Property(e => e.ClaimId).HasColumnName("ClaimID");

                entity.Property(e => e.ClaimPartsValue).HasColumnType("money");

                entity.Property(e => e.ClaimStatus)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.ClaimStatusClient)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.ClosedBy)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.ClosedDate).HasColumnType("datetime");

                entity.Property(e => e.Codfee)
                    .HasColumnType("money")
                    .HasColumnName("CODFee");

                entity.Property(e => e.CollectionNotes)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ContingencyAmount).HasColumnType("money");

                entity.Property(e => e.ContingencyAmountFlat).HasColumnType("money");

                entity.Property(e => e.ContingencyPercent).HasColumnType("money");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DocsReceivedNotes)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.EstimatedBookInDate).HasColumnType("datetime");

                entity.Property(e => e.ExpectedPaymentDate).HasColumnType("datetime");

                entity.Property(e => e.Expr2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FactorerId).HasColumnName("FactorerID");

                entity.Property(e => e.FinalCostingApprovedBy)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.FinalCostingApprovedDate).HasColumnType("datetime");

                entity.Property(e => e.FinalCostingNote)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FinalCostingRequestedBy)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.FinalCostingRequestedDate).HasColumnType("datetime");

                entity.Property(e => e.FinalCostingUnderQueryBy)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.FinalCostingUnderQueryDate).HasColumnType("datetime");

                entity.Property(e => e.FinalInvoiceAmount).HasColumnType("money");

                entity.Property(e => e.FinalInvoiceAmountNett).HasColumnType("money");

                entity.Property(e => e.FinalInvoiceApprovalBy)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.FinalInvoiceApprovalDate).HasColumnType("datetime");

                entity.Property(e => e.FinalInvoiceAuthorisedAmount).HasColumnType("money");

                entity.Property(e => e.FinalInvoiceAuthorisedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FinalInvoiceAuthorisedDate).HasColumnType("datetime");

                entity.Property(e => e.FinalInvoiceBy)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.FinalInvoiceCalculatedBy)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.FinalInvoiceCalculatedDate).HasColumnType("datetime");

                entity.Property(e => e.FinalInvoiceCodfee)
                    .HasColumnType("money")
                    .HasColumnName("FinalInvoiceCODFee");

                entity.Property(e => e.FinalInvoiceDate).HasColumnType("datetime");

                entity.Property(e => e.FinalInvoiceNo)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.FinalInvoiceNote).IsUnicode(false);

                entity.Property(e => e.FinalInvoicePastelJournalDate).HasColumnType("datetime");

                entity.Property(e => e.FinalInvoiceRequestBy)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.FinalInvoiceRequestDate).HasColumnType("datetime");

                entity.Property(e => e.FinalInvoiceSupplierPartsAmount).HasColumnType("money");

                entity.Property(e => e.FundingAmount).HasColumnType("money");

                entity.Property(e => e.InitialClaimAmount).HasColumnType("money");

                entity.Property(e => e.InitialClaimExcess).HasColumnType("money");

                entity.Property(e => e.InsuredName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.InsuredPhoneNumber)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.InsurerClaimNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InsurerDiscountPercentage).HasColumnType("money");

                entity.Property(e => e.InsurerDiscountPercentageAmount).HasColumnType("money");

                entity.Property(e => e.InsurerId).HasColumnName("InsurerID");

                entity.Property(e => e.InsurerIdsecondary).HasColumnName("InsurerIDSecondary");

                entity.Property(e => e.InsurerLiaisonPerson)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InsurerScheme)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Interest).HasColumnType("money");

                entity.Property(e => e.InvoiceType)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.JobStartDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.NextExpectedFinalInvoiceDate).HasColumnType("datetime");

                entity.Property(e => e.NextExpectedPaymentDate).HasColumnType("datetime");

                entity.Property(e => e.PaidBy)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.PaidDate).HasColumnType("datetime");

                entity.Property(e => e.PaidDirectToPb)
                    .HasColumnType("money")
                    .HasColumnName("PaidDirectToPB");

                entity.Property(e => e.PartsPurchasedClosedJobs).HasColumnType("money");

                entity.Property(e => e.PartsPurchasedClosedJobsWip)
                    .HasColumnType("money")
                    .HasColumnName("PartsPurchasedClosedJobsWIP");

                entity.Property(e => e.PartsSummaryNotifiedDate).HasColumnType("datetime");

                entity.Property(e => e.PartsSummaryNotifiedPerson)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.PastelConfirmFinalInvoiceDatComments)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PastelConfirmFinalInvoiceDataDate).HasColumnType("datetime");

                entity.Property(e => e.PastelConfirmProjectCodeDate).HasColumnType("datetime");

                entity.Property(e => e.PastelConfirmSalesDataComments)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PastelConfirmSalesDataDate).HasColumnType("datetime");

                entity.Property(e => e.PastelCostCode)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PastelOiReceiptDate)
                    .HasColumnType("datetime")
                    .HasColumnName("PastelOI_ReceiptDate");

                entity.Property(e => e.PastelOiReceiptDateUpdateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("PastelOI_ReceiptDate_UpdateDate");

                entity.Property(e => e.PastelOiReceiptId).HasColumnName("PastelOI_ReceiptID");

                entity.Property(e => e.PastelOiReceiptedAmount)
                    .HasColumnType("money")
                    .HasColumnName("PastelOi_ReceiptedAmount");

                entity.Property(e => e.PaymentBatchId).HasColumnName("PaymentBatchID");

                entity.Property(e => e.PaymentDueToPb)
                    .HasColumnType("money")
                    .HasColumnName("PaymentDueToPB");

                entity.Property(e => e.PaymentRefNo)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.PbFinalInvoiceBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PB_FinalInvoiceBy");

                entity.Property(e => e.PbFinalInvoiceDate)
                    .HasColumnType("datetime")
                    .HasColumnName("PB_FinalInvoiceDate");

                entity.Property(e => e.PbPartsAuthorisedBy)
                    .HasMaxLength(75)
                    .IsUnicode(false)
                    .HasColumnName("PB_PartsAuthorisedBy");

                entity.Property(e => e.PbPartsAuthorisedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("PB_PartsAuthorisedDate");

                entity.Property(e => e.PbinvoiceToInsurerDate)
                    .HasColumnType("datetime")
                    .HasColumnName("PBInvoiceToInsurerDate");

                entity.Property(e => e.DemoNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProductDefinition).HasColumnType("money");

                entity.Property(e => e.ReceivedPbinsurerFinalInvoiceEmailDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ReceivedPBInsurerFinalInvoiceEmailDate");

                entity.Property(e => e.Reclaim).HasColumnType("money");

                entity.Property(e => e.ReferringBroker)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RejectNotes).IsUnicode(false);

                entity.Property(e => e.RejectReason)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.RequiresAuthorisation).HasColumnName("requiresAuthorisation");

                entity.Property(e => e.Ronumber)
                    .HasMaxLength(75)
                    .IsUnicode(false)
                    .HasColumnName("RONumber");

                entity.Property(e => e.ShortPayment).HasColumnType("money");

                entity.Property(e => e.VehicleMake)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.VehicleModel)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.VehicleRegistrationNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VehicleVin)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("VehicleVIN");

                entity.Property(e => e.WipaltRptFlaggedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("WIPAltRptFlaggedBy");

                entity.Property(e => e.WipaltRptFlaggedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("WIPAltRptFlaggedDate");

                entity.Property(e => e._7dayAltRptFlaggedBy)
                    .HasMaxLength(75)
                    .IsUnicode(false)
                    .HasColumnName("7DayAltRptFlaggedBy");

                entity.Property(e => e._7dayAltRptFlaggedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("7DayAltRptFlaggedDate");
            });

            modelBuilder.Entity<View3>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_3");

                entity.Property(e => e.Category)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ClaimId).HasColumnName("ClaimID");

                entity.Property(e => e.ClaimLogId).HasColumnName("ClaimLogID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(250);

                entity.Property(e => e.Notes).IsUnicode(false);
            });

            modelBuilder.Entity<VwAspnetApplication>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_aspnet_Applications");

                entity.Property(e => e.ApplicationName)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.Description).HasMaxLength(256);

                entity.Property(e => e.LoweredApplicationName)
                    .IsRequired()
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<VwAspnetMembershipUser>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_aspnet_MembershipUsers");

                entity.Property(e => e.Comment).HasColumnType("ntext");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.FailedPasswordAnswerAttemptWindowStart).HasColumnType("datetime");

                entity.Property(e => e.FailedPasswordAttemptWindowStart).HasColumnType("datetime");

                entity.Property(e => e.LastActivityDate).HasColumnType("datetime");

                entity.Property(e => e.LastLockoutDate).HasColumnType("datetime");

                entity.Property(e => e.LastLoginDate).HasColumnType("datetime");

                entity.Property(e => e.LastPasswordChangedDate).HasColumnType("datetime");

                entity.Property(e => e.LoweredEmail).HasMaxLength(256);

                entity.Property(e => e.MobileAlias).HasMaxLength(16);

                entity.Property(e => e.MobilePin)
                    .HasMaxLength(16)
                    .HasColumnName("MobilePIN");

                entity.Property(e => e.PasswordAnswer).HasMaxLength(128);

                entity.Property(e => e.PasswordQuestion).HasMaxLength(256);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<VwAspnetProfile>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_aspnet_Profiles");

                entity.Property(e => e.LastUpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<VwAspnetRole>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_aspnet_Roles");

                entity.Property(e => e.Description).HasMaxLength(256);

                entity.Property(e => e.LoweredRoleName)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.RoleName)
                    .IsRequired()
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<VwAspnetUser>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_aspnet_Users");

                entity.Property(e => e.LastActivityDate).HasColumnType("datetime");

                entity.Property(e => e.LoweredUserName)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.MobileAlias).HasMaxLength(16);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<VwAspnetUsersInRole>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_aspnet_UsersInRoles");
            });

            modelBuilder.Entity<VwAspnetWebPartStatePath>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_aspnet_WebPartState_Paths");

                entity.Property(e => e.LoweredPath)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.Path)
                    .IsRequired()
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<VwAspnetWebPartStateShared>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_aspnet_WebPartState_Shared");

                entity.Property(e => e.LastUpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<VwAspnetWebPartStateUser>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_aspnet_WebPartState_User");

                entity.Property(e => e.LastUpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<WcrdataExtract>(entity =>
            {
                entity.ToTable("WCRDataExtract");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.AccountingStartDate).HasColumnType("date");

                entity.Property(e => e.AggregateWcdays)
                    .HasColumnType("numeric(38, 6)")
                    .HasColumnName("AggregateWCDays");

                entity.Property(e => e.BookInDate).HasColumnType("datetime");

                entity.Property(e => e.CapitalDeployed).HasColumnType("numeric(38, 6)");

                entity.Property(e => e.CapitalDeployedPlusProfit).HasColumnType("numeric(38, 6)");

                entity.Property(e => e.CaptitalDeployedDevideErrorFix).HasColumnType("numeric(38, 6)");

                entity.Property(e => e.CashOut).HasColumnType("numeric(38, 6)");

                entity.Property(e => e.CashOutDate).HasColumnType("date");

                entity.Property(e => e.CashReceivedDate).HasColumnType("date");

                entity.Property(e => e.ClaimId).HasColumnName("ClaimID");

                entity.Property(e => e.ClaimStatus)
                    .IsRequired()
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.DateUpdated).HasColumnType("datetime");

                entity.Property(e => e.FinalInvoiceAuthorisedDate).HasColumnType("date");

                entity.Property(e => e.Insurer)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InsurerId).HasColumnName("InsurerID");

                entity.Property(e => e.InvoiceNumber)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceTotal).HasColumnType("money");

                entity.Property(e => e.InvoiceType)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.JobComponent)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.JobNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PanelBeater)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Pbefficiency).HasColumnName("PBEfficiency");

                entity.Property(e => e.DemoCostsCapital).HasColumnType("numeric(4, 2)");

                entity.Property(e => e.DemoCostsFunding).HasColumnType("numeric(38, 6)");

                entity.Property(e => e.DemoCostsRebateRefunds).HasColumnType("numeric(38, 6)");

                entity.Property(e => e.DemoCostsTotal).HasColumnType("numeric(38, 6)");

                entity.Property(e => e.DemoRevenueCodFee).HasColumnType("numeric(22, 6)");

                entity.Property(e => e.DemoRevenueFactoringCharge).HasColumnType("money");

                entity.Property(e => e.DemoRevenueLabour).HasColumnType("numeric(38, 6)");

                entity.Property(e => e.DemoRevenueParts).HasColumnType("numeric(38, 6)");

                entity.Property(e => e.DemoRevenuePenalties).HasColumnType("numeric(3, 2)");

                entity.Property(e => e.DemoRevenueTotal).HasColumnType("numeric(38, 6)");

                entity.Property(e => e.ProductDefinition).HasColumnType("money");

                entity.Property(e => e.Profit).HasColumnType("numeric(38, 6)");

                entity.Property(e => e.ProfitPercent).HasColumnType("numeric(38, 6)");

                entity.Property(e => e.RebateInsurer).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.RebatePb)
                    .HasColumnType("decimal(21, 4)")
                    .HasColumnName("RebatePB");

                entity.Property(e => e.RebateDemo).HasColumnType("decimal(20, 4)");

                entity.Property(e => e.RebateSupplier).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Supplier)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SupplierTerms)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.UniqueClaimsPerPb).HasColumnName("UniqueClaimsPerPB");

                entity.Property(e => e.WeightedAverageCashWccycle)
                    .HasColumnType("numeric(38, 6)")
                    .HasColumnName("WeightedAverageCashWCCycle");

                entity.Property(e => e.WeightedAverageCashWccycleDevideCalc)
                    .HasColumnType("numeric(38, 6)")
                    .HasColumnName("WeightedAverageCashWCCycleDevideCalc");

                entity.Property(e => e.WeightedDaysWip)
                    .HasColumnType("numeric(38, 6)")
                    .HasColumnName("WeightedDaysWIP");

                entity.Property(e => e.WeightedDebtorsDays).HasColumnType("numeric(38, 6)");

                entity.Property(e => e.WeightedReturnOnCapitalDeployed).HasColumnType("numeric(38, 6)");

                entity.Property(e => e.Wipdays).HasColumnName("WIPDays");

                entity.Property(e => e.WipdebtorDays).HasColumnName("WIPDebtorDays");

                entity.Property(e => e.Wipflag)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("WIPFlag");
            });

            modelBuilder.Entity<WcrdataExtractNew>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("WCRDataExtract_NEW");

                entity.Property(e => e.AccountingStartDate).HasColumnType("date");

                entity.Property(e => e.AggregateWcdays)
                    .HasColumnType("numeric(38, 6)")
                    .HasColumnName("AggregateWCDays");

                entity.Property(e => e.BookInDate).HasColumnType("datetime");

                entity.Property(e => e.CapitalDeployed).HasColumnType("numeric(38, 6)");

                entity.Property(e => e.CapitalDeployedPlusProfit).HasColumnType("numeric(38, 6)");

                entity.Property(e => e.CaptitalDeployedDevideErrorFix).HasColumnType("numeric(38, 6)");

                entity.Property(e => e.CashOut).HasColumnType("numeric(38, 6)");

                entity.Property(e => e.CashOutDate).HasColumnType("date");

                entity.Property(e => e.CashReceivedDate).HasColumnType("date");

                entity.Property(e => e.ClaimId).HasColumnName("ClaimID");

                entity.Property(e => e.ClaimStatus)
                    .IsRequired()
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.DateUpdated).HasColumnType("datetime");

                entity.Property(e => e.FinalInvoiceAuthorisedDate).HasColumnType("date");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Insurer)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InsurerId).HasColumnName("InsurerID");

                entity.Property(e => e.InvoiceNumber)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceTotal).HasColumnType("money");

                entity.Property(e => e.InvoiceType)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.JobComponent)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.JobNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PanelBeater)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Pbefficiency).HasColumnName("PBEfficiency");

                entity.Property(e => e.DemoCostsCapital).HasColumnType("numeric(4, 2)");

                entity.Property(e => e.DemoCostsFunding).HasColumnType("numeric(38, 6)");

                entity.Property(e => e.DemoCostsRebateRefunds).HasColumnType("numeric(38, 6)");

                entity.Property(e => e.DemoCostsTotal).HasColumnType("numeric(38, 6)");

                entity.Property(e => e.DemoRevenueCodFee).HasColumnType("numeric(22, 6)");

                entity.Property(e => e.DemoRevenueFactoringCharge).HasColumnType("money");

                entity.Property(e => e.DemoRevenueLabour).HasColumnType("numeric(38, 6)");

                entity.Property(e => e.DemoRevenueParts).HasColumnType("numeric(38, 6)");

                entity.Property(e => e.DemoRevenuePenalties).HasColumnType("numeric(3, 2)");

                entity.Property(e => e.DemoRevenueTotal).HasColumnType("numeric(38, 6)");

                entity.Property(e => e.ProductDefinition).HasColumnType("money");

                entity.Property(e => e.Profit).HasColumnType("numeric(38, 6)");

                entity.Property(e => e.ProfitPercent).HasColumnType("numeric(38, 6)");

                entity.Property(e => e.RebateInsurer).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.RebatePb)
                    .HasColumnType("decimal(21, 4)")
                    .HasColumnName("RebatePB");

                entity.Property(e => e.RebateDemo).HasColumnType("decimal(20, 4)");

                entity.Property(e => e.RebateSupplier).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Supplier)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SupplierTerms)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.UniqueClaimsPerPb).HasColumnName("UniqueClaimsPerPB");

                entity.Property(e => e.WeightedAverageCashWccycle)
                    .HasColumnType("numeric(38, 6)")
                    .HasColumnName("WeightedAverageCashWCCycle");

                entity.Property(e => e.WeightedAverageCashWccycleDevideCalc)
                    .HasColumnType("numeric(38, 6)")
                    .HasColumnName("WeightedAverageCashWCCycleDevideCalc");

                entity.Property(e => e.WeightedDaysWip)
                    .HasColumnType("numeric(38, 6)")
                    .HasColumnName("WeightedDaysWIP");

                entity.Property(e => e.WeightedDebtorsDays).HasColumnType("numeric(38, 6)");

                entity.Property(e => e.WeightedReturnOnCapitalDeployed).HasColumnType("numeric(38, 6)");

                entity.Property(e => e.Wipdays).HasColumnName("WIPDays");

                entity.Property(e => e.WipdebtorDays).HasColumnName("WIPDebtorDays");

                entity.Property(e => e.Wipflag)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("WIPFlag");
            });

            modelBuilder.Entity<WipPenaltyDatum>(entity =>
            {
                entity.HasKey(e => e.WippenaltyId)
                    .HasName("PK__WIP_Pena__78AAAFE9964BD223");

                entity.ToTable("WIP_Penalty_Data");

                entity.Property(e => e.WippenaltyId)
                    .ValueGeneratedNever()
                    .HasColumnName("WIPPenaltyID");

                entity.Property(e => e.BatchId).HasColumnName("BatchID");

                entity.Property(e => e.ClaimId).HasColumnName("ClaimID");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CurrentMonthsRebatePenalty).HasColumnType("money");

                entity.Property(e => e.InvoiceDate).HasColumnType("datetime");

                entity.Property(e => e.InvoiceValue).HasColumnType("money");

                entity.Property(e => e.NetRebateEarned).HasColumnType("money");

                entity.Property(e => e.PenaltyDue)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.DemoNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PriorMonthsRebatePenalty).HasColumnType("money");

                entity.Property(e => e.RebateEarned).HasColumnType("money");

                entity.Property(e => e.SupplierId).HasColumnName("SupplierID");

                entity.Property(e => e.Wipdays).HasColumnName("WIPDays");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
