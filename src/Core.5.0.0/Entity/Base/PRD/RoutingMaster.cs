using System;
using System.ComponentModel.DataAnnotations;
namespace com.Sconit.Entity.PRD
{
    [Serializable]
    public partial class RoutingMaster : EntityBase, IAuditable
    {
        #region O/R Mapping Properties

        [Required(AllowEmptyStrings = false, ErrorMessageResourceName = "Errors_Common_FieldRequired", ErrorMessageResourceType = typeof(Resources.ErrorMessage))]
        [StringLength(50, ErrorMessageResourceName = "Errors_Common_FieldLengthExceed", ErrorMessageResourceType = typeof(Resources.ErrorMessage))]
        [Display(Name = "RoutingMaster_Code", ResourceType = typeof(Resources.PRD.Routing))]
        public string Code { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessageResourceName = "Errors_Common_FieldRequired", ErrorMessageResourceType = typeof(Resources.ErrorMessage))]
        [StringLength(100, ErrorMessageResourceName = "Errors_Common_FieldLengthExceed", ErrorMessageResourceType = typeof(Resources.ErrorMessage))]
        [Display(Name = "RoutingMaster_Name", ResourceType = typeof(Resources.PRD.Routing))]
        public string Name { get; set; }

        [Display(Name = "RoutingMaster_IsActive", ResourceType = typeof(Resources.PRD.Routing))]
        public Boolean IsActive { get; set; }

        public Int32 CreateUserId { get; set; }
        public string CreateUserName { get; set; }
        public DateTime CreateDate { get; set; }
        public Int32 LastModifyUserId { get; set; }
        public string LastModifyUserName { get; set; }
        public DateTime LastModifyDate { get; set; }

        #endregion

        public override int GetHashCode()
        {
            if (Code != null)
            {
                return Code.GetHashCode();
            }
            else
            {
                return base.GetHashCode();
            }
        }

        public override bool Equals(object obj)
        {
            RoutingMaster another = obj as RoutingMaster;

            if (another == null)
            {
                return false;
            }
            else
            {
                return (this.Code == another.Code);
            }
        }
    }

}
