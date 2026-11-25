using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
#nullable disable
public partial class PbClaimPartSupplier
{
    [Key]
    public Guid ClaimPartSupplierId { get; set; }
    public Guid? ClaimId { get; set; }
    public Guid? SupplierId { get; set; }
    public decimal? SupplierTotal { get; set; }
    public string CreatedBy { get; set; }
    public DateTime? CreatedDate { get; set; }
    public string ModifiedBy { get; set; }
    public DateTime? ModifiedDate { get; set; }
    public bool IsDeleted { get; set; }
    public string DeletedBy { get; set; }
    public DateTime? DeletedDate { get; set; }
}