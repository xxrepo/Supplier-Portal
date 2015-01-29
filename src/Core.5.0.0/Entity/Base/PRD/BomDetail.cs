using System;
using System.ComponentModel.DataAnnotations;

namespace com.Sconit.Entity.PRD
{
    [Serializable]
    public partial class BomDetail : EntityBase, IAuditable
    {
        #region O/R Mapping Properties

        [Display(Name = "BomDetail_Id", ResourceType = typeof(Resources.PRD.Bom))]
        public Int32 Id { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessageResourceName = "Errors_Common_FieldRequired", ErrorMessageResourceType = typeof(Resources.ErrorMessage))]
        [StringLength(50, ErrorMessageResourceName = "Errors_Common_FieldLengthExceed", ErrorMessageResourceType = typeof(Resources.ErrorMessage))]
        [Display(Name = "BomDetail_Bom", ResourceType = typeof(Resources.PRD.Bom))]
        public string Bom { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessageResourceName = "Errors_Common_FieldRequired", ErrorMessageResourceType = typeof(Resources.ErrorMessage))]
        [Display(Name = "BomDetail_Item", ResourceType = typeof(Resources.PRD.Bom))]
        public string Item { get; set; }

        [Display(Name = "BomDetail_OpReference", ResourceType = typeof(Resources.PRD.Bom))]
        [Required(AllowEmptyStrings = false, ErrorMessageResourceName = "Errors_Common_FieldRequired", ErrorMessageResourceType = typeof(Resources.ErrorMessage))]
        public string OpReference { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessageResourceName = "Errors_Common_FieldRequired", ErrorMessageResourceType = typeof(Resources.ErrorMessage))]
        [StringLength(50, ErrorMessageResourceName = "Errors_Common_FieldLengthExceed", ErrorMessageResourceType = typeof(Resources.ErrorMessage))]
        [Display(Name = "BomDetail_Uom", ResourceType = typeof(Resources.PRD.Bom))]
        public string Uom { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessageResourceName = "Errors_Common_FieldRequired", ErrorMessageResourceType = typeof(Resources.ErrorMessage))]
        [Display(Name = "BomDetail_Operation", ResourceType = typeof(Resources.PRD.Bom))]
        public Int32 Operation { get; set; }

        [Display(Name = "BomDetail_StructureType", ResourceType = typeof(Resources.PRD.Bom))]
        public com.Sconit.CodeMaster.BomStructureType StructureType { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessageResourceName = "Errors_Common_FieldRequired", ErrorMessageResourceType = typeof(Resources.ErrorMessage))]
        [Display(Name = "BomDetail_StartDate", ResourceType = typeof(Resources.PRD.Bom))]
        public DateTime StartDate { get; set; }

        [Display(Name = "BomDetail_EndDate", ResourceType = typeof(Resources.PRD.Bom))]
        public DateTime? EndDate { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessageResourceName = "Errors_Common_FieldRequired", ErrorMessageResourceType = typeof(Resources.ErrorMessage))]
        [Display(Name = "BomDetail_RateQty", ResourceType = typeof(Resources.PRD.Bom))]
        public Decimal RateQty { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessageResourceName = "Errors_Common_FieldRequired", ErrorMessageResourceType = typeof(Resources.ErrorMessage))]
        [Display(Name = "BomDetail_ScrapPercentage", ResourceType = typeof(Resources.PRD.Bom))]
        public Decimal ScrapPercentage { get; set; }

        [Display(Name = "BomDetail_BackFlushStrategy", ResourceType = typeof(Resources.PRD.Bom))]
        public string BackFlushStrategy { get; set; }

        [Display(Name = "BomDetail_BackFlushMethod", ResourceType = typeof(Resources.PRD.Bom))]
        public com.Sconit.CodeMaster.BackFlushMethod BackFlushMethod { get; set; }

        [Display(Name = "BomDetail_FeedMethod", ResourceType = typeof(Resources.PRD.Bom))]
        public com.Sconit.CodeMaster.FeedMethod FeedMethod { get; set; }
        //public Boolean IsScanHu { get; set; }

        [Display(Name = "BomDetail_IsAutoFeed", ResourceType = typeof(Resources.PRD.Bom))]
        public Boolean IsAutoFeed { get; set; }

        [StringLength(50, ErrorMessageResourceName = "Errors_Common_FieldLengthExceed", ErrorMessageResourceType = typeof(Resources.ErrorMessage))]
        [Display(Name = "BomDetail_Location", ResourceType = typeof(Resources.PRD.Bom))]
        public string Location { get; set; }

        [Display(Name = "BomDetail_IsPrint", ResourceType = typeof(Resources.PRD.Bom))]
        public Boolean IsPrint { get; set; }

        public Int32 CreateUserId { get; set; }
        public string CreateUserName { get; set; }
        public DateTime CreateDate { get; set; }
        public Int32 LastModifyUserId { get; set; }
        public string LastModifyUserName { get; set; }
        public DateTime LastModifyDate { get; set; }

        #endregion

        public override int GetHashCode()
        {
            if (Id != 0)
            {
                return Id.GetHashCode();
            }
            else
            {
                return base.GetHashCode();
            }
        }

        public override bool Equals(object obj)
        {
            BomDetail another = obj as BomDetail;

            if (another == null)
            {
                return false;
            }
            else
            {
                return (this.Id == another.Id);
            }
        }
    }

}
