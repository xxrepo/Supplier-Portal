using System;
using System.ComponentModel.DataAnnotations;
using com.Sconit.Entity.SYS;

namespace com.Sconit.Entity.ORD
{
    [Serializable]
    public partial class OrderMaster : EntityBase, IAuditable
    {
        #region O/R Mapping Properties
        [Export(ExportName = "ExportSeqOrder", ExportSeq = 10)]
        [Export(ExportName = "ExportVanOrder", ExportSeq = 10)]
        [Export(ExportName = "VanProductionOrder", ExportSeq = 10)]
        [Export(ExportName = "ProductionOrder", ExportSeq = 10)]
        [Required(AllowEmptyStrings = false, ErrorMessageResourceName = "Errors_Common_FieldRequired", ErrorMessageResourceType = typeof(Resources.ErrorMessage))]
        [StringLength(50, ErrorMessageResourceName = "Errors_Common_FieldLengthExceed", ErrorMessageResourceType = typeof(Resources.ErrorMessage))]
        [Display(Name = "OrderMaster_OrderNo", ResourceType = typeof(Resources.ORD.OrderMaster))]
        public string OrderNo { get; set; }

        [Export(ExportName = "ExportSeqOrder", ExportSeq = 20)]
        [Export(ExportName = "ExportVanOrder", ExportSeq = 20, ExportTitle = "OrderMaster_Flow_Production", ExportTitleResourceType = typeof(Resources.ORD.OrderMaster))]
        [Export(ExportName = "VanProductionOrder", ExportSeq = 20, ExportTitle = "OrderMaster_Flow_Production", ExportTitleResourceType = typeof(Resources.ORD.OrderMaster))]
        [Export(ExportName = "ProductionOrder", ExportSeq = 20, ExportTitle = "OrderMaster_Flow_Production", ExportTitleResourceType = typeof(Resources.ORD.OrderMaster))]
        [Required(AllowEmptyStrings = false, ErrorMessageResourceName = "Errors_Common_FieldRequired", ErrorMessageResourceType = typeof(Resources.ErrorMessage))]
        [StringLength(50, ErrorMessageResourceName = "Errors_Common_FieldLengthExceed", ErrorMessageResourceType = typeof(Resources.ErrorMessage))]
        [Display(Name = "OrderMaster_Flow", ResourceType = typeof(Resources.ORD.OrderMaster))]
        public string Flow { get; set; }
        [Export(ExportName = "ExportSeqOrder", ExportSeq = 30)]
        [Export(ExportName = "ExportVanOrder", ExportSeq = 30, ExportTitle = "OrderMaster_FlowDescription_Production", ExportTitleResourceType = typeof(Resources.ORD.OrderMaster))]
        [Export(ExportName = "VanProductionOrder", ExportSeq = 30, ExportTitle = "OrderMaster_FlowDescription_Production", ExportTitleResourceType = typeof(Resources.ORD.OrderMaster))]
        [Export(ExportName = "ProductionOrder", ExportSeq = 30, ExportTitle = "OrderMaster_FlowDescription_Production", ExportTitleResourceType = typeof(Resources.ORD.OrderMaster))]
        [Display(Name = "OrderMaster_FlowDescription", ResourceType = typeof(Resources.ORD.OrderMaster))]
        public string FlowDescription { get; set; }

        [Export(ExportName = "ExportSeqOrder", ExportSeq = 40)]
        [Export(ExportName = "ExportVanOrder", ExportSeq = 50)]
        [Export(ExportName = "VanProductionOrder", ExportSeq = 50)]
        [Export(ExportName = "ProductionOrder", ExportSeq = 170)]
        [Display(Name = "OrderMaster_TraceCode", ResourceType = typeof(Resources.ORD.OrderMaster))]
        public string TraceCode { get; set; }

        [Display(Name = "OrderMaster_ProductLineFacility", ResourceType = typeof(Resources.ORD.OrderMaster))]
        public string ProductLineFacility { get; set; }

        [Export(ExportName = "ExportSeqOrder", ExportSeq = 50)]
        [Export(ExportName = "ProductionOrder", ExportSeq = 60)]
        [Display(Name = "OrderMaster_ReferenceOrderNo", ResourceType = typeof(Resources.ORD.OrderMaster))]
        public string ReferenceOrderNo { get; set; }

        [Export(ExportName = "ExportSeqOrder", ExportSeq = 60)]
        [Export(ExportName = "ExportVanOrder", ExportSeq = 60)]
        [Export(ExportName = "VanProductionOrder", ExportSeq = 60)]
        [Export(ExportName = "ProductionOrder", ExportSeq = 70)]
        [Display(Name = "OrderMaster_ExternalOrderNo", ResourceType = typeof(Resources.ORD.OrderMaster))]
        public string ExternalOrderNo { get; set; }

        [Display(Name = "OrderMaster_Type", ResourceType = typeof(Resources.ORD.OrderMaster))]
        public com.Sconit.CodeMaster.OrderType Type { get; set; }

        [Display(Name = "OrderMaster_SubType", ResourceType = typeof(Resources.ORD.OrderMaster))]
        public com.Sconit.CodeMaster.OrderSubType SubType { get; set; }

        public com.Sconit.CodeMaster.QualityType QualityType { get; set; }

        [Export(ExportName = "VanProductionOrder", ExportSeq = 80)]
        [Display(Name = "OrderMaster_StartTime", ResourceType = typeof(Resources.ORD.OrderMaster))]
        public DateTime StartTime { get; set; }

        [Export(ExportName = "ExportSeqOrder", ExportSeq = 110)]
        [Export(ExportName = "VanProductionOrder", ExportSeq = 90)]
        [Display(Name = "OrderMaster_WindowTime", ResourceType = typeof(Resources.ORD.OrderMaster))]
        public DateTime WindowTime { get; set; }

        [Export(ExportName = "ExportVanOrder", ExportSeq = 150)]
        [Export(ExportName = "VanProductionOrder", ExportSeq = 160)]
        [Display(Name = "OrderMaster_PauseTime", ResourceType = typeof(Resources.ORD.OrderMaster))]
        public DateTime? PauseTime { get; set; }

        [Display(Name = "OrderMaster_EffectiveDate", ResourceType = typeof(Resources.ORD.OrderMaster))]
        public DateTime? EffectiveDate { get; set; }

        [Display(Name = "OrderMaster_Priority", ResourceType = typeof(Resources.ORD.OrderMaster))]
        public com.Sconit.CodeMaster.OrderPriority Priority { get; set; }

        [Display(Name = "OrderMaster_Status", ResourceType = typeof(Resources.ORD.OrderMaster))]
        public com.Sconit.CodeMaster.OrderStatus Status { get; set; }

        [Display(Name = "OrderMaster_Sequence", ResourceType = typeof(Resources.ORD.OrderMaster))]
        public Int64 Sequence { get; set; }

        public Int64 SapSequence { get; set; }

        [Display(Name = "OrderMaster_PartyFrom", ResourceType = typeof(Resources.ORD.OrderMaster))]
        public string PartyFrom { get; set; }

        [Export(ExportName = "ExportSeqOrder", ExportSeq = 90)]
        [Export(ExportName = "ProductionOrder", ExportSeq = 80, ExportTitle = "OrderMaster_PartyFromName_Production", ExportTitleResourceType = typeof(Resources.ORD.OrderMaster))]
        [Export(ExportName = "ExportVanOrder", ExportSeq = 70, ExportTitle = "OrderMaster_PartyFromName_Production", ExportTitleResourceType = typeof(Resources.ORD.OrderMaster))]
        [Display(Name = "OrderMaster_PartyFromName", ResourceType = typeof(Resources.ORD.OrderMaster))]
        public string PartyFromName { get; set; }

        [Display(Name = "OrderMaster_PartyTo", ResourceType = typeof(Resources.ORD.OrderMaster))]
        public string PartyTo { get; set; }

        [Export(ExportName = "ExportSeqOrder", ExportSeq = 100)]
        [Display(Name = "OrderMaster_PartyToName", ResourceType = typeof(Resources.ORD.OrderMaster))]
        public string PartyToName { get; set; }

        [Display(Name = "OrderMaster_ShipFrom", ResourceType = typeof(Resources.ORD.OrderMaster))]
        public string ShipFrom { get; set; }

        [Display(Name = "OrderMaster_ShipFromAddress", ResourceType = typeof(Resources.ORD.OrderMaster))]
        public string ShipFromAddress { get; set; }

        [Display(Name = "OrderMaster_ShipFromTel", ResourceType = typeof(Resources.ORD.OrderMaster))]
        public string ShipFromTel { get; set; }

        [Display(Name = "OrderMaster_ShipFromCell", ResourceType = typeof(Resources.ORD.OrderMaster))]
        public string ShipFromCell { get; set; }

        [Display(Name = "OrderMaster_ShipFromCell", ResourceType = typeof(Resources.ORD.OrderMaster))]
        public string ShipFromFax { get; set; }

        [Export(ExportName = "VanProductionOrder", ExportSeq = 40, ExportTitle = "OrderDetail_Item", ExportTitleResourceType = typeof(Resources.ORD.OrderDetail))]
        [Display(Name = "OrderMaster_ShipFromContact", ResourceType = typeof(Resources.ORD.OrderMaster))]
        public string ShipFromContact { get; set; }

        [Display(Name = "OrderMaster_ShipToAddress", ResourceType = typeof(Resources.ORD.OrderMaster))]
        public string ShipToAddress { get; set; }

        [Display(Name = "OrderMaster_ShipTo", ResourceType = typeof(Resources.ORD.OrderMaster))]
        public string ShipTo { get; set; }

        [Display(Name = "OrderMaster_ShipToTel", ResourceType = typeof(Resources.ORD.OrderMaster))]
        public string ShipToTel { get; set; }

        [Display(Name = "OrderMaster_ShipToCell", ResourceType = typeof(Resources.ORD.OrderMaster))]
        public string ShipToCell { get; set; }

        [Display(Name = "OrderMaster_ShipToFax", ResourceType = typeof(Resources.ORD.OrderMaster))]
        public string ShipToFax { get; set; }

        [Display(Name = "OrderMaster_ShipToContact", ResourceType = typeof(Resources.ORD.OrderMaster))]
        public string ShipToContact { get; set; }

        [Display(Name = "OrderMaster_Shift", ResourceType = typeof(Resources.ORD.OrderMaster))]
        public string Shift { get; set; }


        [Display(Name = "OrderMaster_LocationFrom", ResourceType = typeof(Resources.ORD.OrderMaster))]
        public string LocationFrom { get; set; }

        [Display(Name = "OrderMaster_LocationFromName", ResourceType = typeof(Resources.ORD.OrderMaster))]
        public string LocationFromName { get; set; }

        [Display(Name = "OrderMaster_LocationTo", ResourceType = typeof(Resources.ORD.OrderMaster))]
        public string LocationTo { get; set; }

        [Display(Name = "OrderMaster_LocationToName", ResourceType = typeof(Resources.ORD.OrderMaster))]
        public string LocationToName { get; set; }

        [Display(Name = "OrderMaster_IsInspect", ResourceType = typeof(Resources.ORD.OrderMaster))]
        public Boolean IsInspect { get; set; }

        //[Display(Name = "OrderMaster_InspectLocation", ResourceType = typeof(Resources.ORD.OrderMaster))]
        //public string InspectLocation { get; set; }

        //[Display(Name = "OrderMaster_InspectLocationName", ResourceType = typeof(Resources.ORD.OrderMaster))]
        //public string InspectLocationName { get; set; }

        //[Display(Name = "OrderMaster_RejectLocation", ResourceType = typeof(Resources.ORD.OrderMaster))]
        //public string RejectLocation { get; set; }
        [Display(Name = "OrderMaster_Audit", ResourceType = typeof(Resources.ORD.OrderMaster))]
        public string OrderMaster_Audit { get; set; }



        [Display(Name = "OrderMaster_BillAddress", ResourceType = typeof(Resources.ORD.OrderMaster))]
        public string BillAddress { get; set; }

        [Display(Name = "OrderMaster_BillAddressDescription", ResourceType = typeof(Resources.ORD.OrderMaster))]
        public string BillAddressDescription { get; set; }

        [Display(Name = "OrderMaster_PriceList", ResourceType = typeof(Resources.ORD.OrderMaster))]
        public string PriceList { get; set; }

        [Display(Name = "OrderMaster_Currency", ResourceType = typeof(Resources.ORD.OrderMaster))]
        public string Currency { get; set; }

        [Export(ExportName = "ExportSeqOrder", ExportSeq = 120)]
        [Display(Name = "OrderMaster_Dock", ResourceType = typeof(Resources.ORD.OrderMaster))]
        public string Dock { get; set; }

        [Display(Name = "OrderMaster_Routing", ResourceType = typeof(Resources.ORD.OrderMaster))]
        public string Routing { get; set; }
        [Export(ExportName = "ExportVanOrder", ExportSeq = 130)]
        [Export(ExportName = "VanProductionOrder", ExportSeq = 130)]
        [Export(ExportName = "ProductionOrder", ExportSeq = 160)]
        [Display(Name = "OrderMaster_CurrentOperation", ResourceType = typeof(Resources.ORD.OrderMaster))]
        public Int32? CurrentOperation { get; set; }

        [Display(Name = "OrderMaster_IsAutoRelease", ResourceType = typeof(Resources.ORD.OrderMaster))]
        public Boolean IsAutoRelease { get; set; }

        [Display(Name = "OrderMaster_IsAutoStart", ResourceType = typeof(Resources.ORD.OrderMaster))]
        public Boolean IsAutoStart { get; set; }

        [Display(Name = "OrderMaster_IsAutoShip", ResourceType = typeof(Resources.ORD.OrderMaster))]
        public Boolean IsAutoShip { get; set; }

        [Display(Name = "OrderMaster_IsAutoReceive", ResourceType = typeof(Resources.ORD.OrderMaster))]
        public Boolean IsAutoReceive { get; set; }

        [Display(Name = "OrderMaster_IsAutoBill", ResourceType = typeof(Resources.ORD.OrderMaster))]
        public Boolean IsAutoBill { get; set; }

        [Display(Name = "OrderMaster_IsManualCreateDetail", ResourceType = typeof(Resources.ORD.OrderMaster))]
        public Boolean IsManualCreateDetail { get; set; }

        [Display(Name = "OrderMaster_IsListPrice", ResourceType = typeof(Resources.ORD.OrderMaster))]
        public Boolean IsListPrice { get; set; }

        [Export(ExportName = "ExportSeqOrder", ExportSeq = 160)]
        [Display(Name = "OrderMaster_IsPrintOrder", ResourceType = typeof(Resources.ORD.OrderMaster))]
        public Boolean IsPrintOrder { get; set; }

        [Display(Name = "OrderMaster_IsOrderPrinted", ResourceType = typeof(Resources.ORD.OrderMaster))]
        public Boolean IsOrderPrinted { get; set; }

        [Display(Name = "OrderMaster_IsPrintAsn", ResourceType = typeof(Resources.ORD.OrderMaster))]
        public Boolean IsPrintAsn { get; set; }

        [Display(Name = "OrderMaster_IsPrintReceipt", ResourceType = typeof(Resources.ORD.OrderMaster))]
        public Boolean IsPrintReceipt { get; set; }

        [Display(Name = "OrderMaster_IsShipExceed", ResourceType = typeof(Resources.ORD.OrderMaster))]
        public Boolean IsShipExceed { get; set; }

        [Display(Name = "OrderMaster_IsReceiveExceed", ResourceType = typeof(Resources.ORD.OrderMaster))]
        public Boolean IsReceiveExceed { get; set; }

        [Display(Name = "OrderMaster_IsOrderFulfillUC", ResourceType = typeof(Resources.ORD.OrderMaster))]
        public Boolean IsOrderFulfillUC { get; set; }

        [Display(Name = "OrderMaster_IsShipFulfillUC", ResourceType = typeof(Resources.ORD.OrderMaster))]
        public Boolean IsShipFulfillUC { get; set; }

        [Display(Name = "OrderMaster_IsReceiveFulfillUC", ResourceType = typeof(Resources.ORD.OrderMaster))]
        public Boolean IsReceiveFulfillUC { get; set; }

        [Display(Name = "OrderMaster_IsShipScanHu", ResourceType = typeof(Resources.ORD.OrderMaster))]
        public Boolean IsShipScanHu { get; set; }

        [Display(Name = "OrderMaster_IsReceiveScanHu", ResourceType = typeof(Resources.ORD.OrderMaster))]
        public Boolean IsReceiveScanHu { get; set; }

        [Display(Name = "OrderMaster_IsCreatePickList", ResourceType = typeof(Resources.ORD.OrderMaster))]
        public Boolean IsCreatePickList { get; set; }

        //[Display(Name = "OrderMaster_IsPickFromBin", ResourceType = typeof(Resources.ORD.OrderMaster))]
        //public Boolean IsPickFromBin { get; set; }

        [Display(Name = "OrderMaster_IsPickListCreated", ResourceType = typeof(Resources.ORD.OrderMaster))]
        public Boolean IsPickListCreated { get; set; }

        [Display(Name = "OrderMaster_IsReceiveFifo", ResourceType = typeof(Resources.ORD.OrderMaster))]
        public Boolean IsReceiveFifo { get; set; }

        [Display(Name = "OrderMaster_IsShipByOrder", ResourceType = typeof(Resources.ORD.OrderMaster))]
        public Boolean IsShipByOrder { get; set; }

        [Display(Name = "OrderMaster_IsOpenOrder", ResourceType = typeof(Resources.ORD.OrderMaster))]
        public Boolean IsOpenOrder { get; set; }

        [Display(Name = "OrderMaster_IsAsnUniqueReceive", ResourceType = typeof(Resources.ORD.OrderMaster))]
        public Boolean IsAsnUniqueReceive { get; set; }

        [Display(Name = "OrderMaster_ReceiveGapTo", ResourceType = typeof(Resources.ORD.OrderMaster))]
        public com.Sconit.CodeMaster.ReceiveGapTo ReceiveGapTo { get; set; }

        [Display(Name = "OrderMaster_ReceiptTemplate", ResourceType = typeof(Resources.ORD.OrderMaster))]
        public string ReceiptTemplate { get; set; }

        [Display(Name = "OrderMaster_OrderTemplate", ResourceType = typeof(Resources.ORD.OrderMaster))]
        public string OrderTemplate { get; set; }

        [Display(Name = "OrderMaster_AsnTemplate", ResourceType = typeof(Resources.ORD.OrderMaster))]
        public string AsnTemplate { get; set; }

        [Display(Name = "OrderMaster_HuTemplate", ResourceType = typeof(Resources.ORD.OrderMaster))]
        public string HuTemplate { get; set; }

        [Display(Name = "OrderMaster_BillTerm", ResourceType = typeof(Resources.ORD.OrderMaster))]
        public com.Sconit.CodeMaster.OrderBillTerm BillTerm { get; set; }

        [Display(Name = "OrderMaster_CreateHuOption", ResourceType = typeof(Resources.ORD.OrderMaster))]
        public com.Sconit.CodeMaster.CreateHuOption CreateHuOption { get; set; }

        [Display(Name = "OrderMaster_ReCalculatePriceOption", ResourceType = typeof(Resources.ORD.OrderMaster))]
        public com.Sconit.CodeMaster.ReCalculatePriceOption ReCalculatePriceOption { get; set; }


        public Int32 CreateUserId { get; set; }

        [Export(ExportName = "ExportVanOrder", ExportSeq = 110)]
        [Export(ExportName = "VanProductionOrder", ExportSeq = 110)]
        [Export(ExportName = "ProductionOrder", ExportSeq = 140)]
        [Display(Name = "OrderMaster_CreateUserName", ResourceType = typeof(Resources.ORD.OrderMaster))]
        public string CreateUserName { get; set; }

        [Export(ExportName = "ExportSeqOrder", ExportSeq = 160)]
        [Export(ExportName = "ExportVanOrder", ExportSeq = 120)]
        [Export(ExportName = "VanProductionOrder", ExportSeq = 120)]
        [Export(ExportName = "ProductionOrder", ExportSeq = 150)]
        [Display(Name = "OrderMaster_CreateDate", ResourceType = typeof(Resources.ORD.OrderMaster))]
        public DateTime CreateDate { get; set; }


        public Int32 LastModifyUserId { get; set; }

        [Display(Name = "OrderMaster_LastModifyUserName", ResourceType = typeof(Resources.ORD.OrderMaster))]
        public string LastModifyUserName { get; set; }

        [Display(Name = "OrderMaster_LastModifyDate", ResourceType = typeof(Resources.ORD.OrderMaster))]
        public DateTime LastModifyDate { get; set; }

        [Display(Name = "OrderMaster_ReleaseDate", ResourceType = typeof(Resources.ORD.OrderMaster))]
        public DateTime? ReleaseDate { get; set; }


        public Int32? ReleaseUserId { get; set; }

        [Display(Name = "OrderMaster_ReleaseUserName", ResourceType = typeof(Resources.ORD.OrderMaster))]
        public string ReleaseUserName { get; set; }

        [Export(ExportName = "ExportVanOrder", ExportSeq = 80)]
        [Export(ExportName = "VanProductionOrder", ExportSeq = 121)]
        [Export(ExportName = "ProductionOrder", ExportSeq = 100)]
        [Display(Name = "OrderMaster_StartDate", ResourceType = typeof(Resources.ORD.OrderMaster))]
        public DateTime? StartDate { get; set; }

        public Int32? StartUserId { get; set; }

        [Export(ExportName = "ProductionOrder", ExportSeq = 90)]
        [Export(ExportName = "ExportVanOrder", ExportSeq = 85)]
        [Display(Name = "OrderMaster_StartUserName", ResourceType = typeof(Resources.ORD.OrderMaster))]
        public string StartUserName { get; set; }

        [Export(ExportName = "ExportVanOrder", ExportSeq = 90)]
        [Export(ExportName = "VanProductionOrder", ExportSeq = 122)]
        [Export(ExportName = "ProductionOrder", ExportSeq = 120)]
        [Display(Name = "OrderMaster_CompleteDate", ResourceType = typeof(Resources.ORD.OrderMaster))]
        public DateTime? CompleteDate { get; set; }

        public Int32? CompleteUserId { get; set; }

        [Export(ExportName = "ProductionOrder", ExportSeq = 110)]
        [Export(ExportName = "ExportVanOrder", ExportSeq = 95)]
        [Display(Name = "OrderMaster_CompleteUserName", ResourceType = typeof(Resources.ORD.OrderMaster))]
        public string CompleteUserName { get; set; }

        [Display(Name = "OrderMaster_CloseDate", ResourceType = typeof(Resources.ORD.OrderMaster))]
        public DateTime? CloseDate { get; set; }

        public Int32? CloseUserId { get; set; }

        [Display(Name = "OrderMaster_CloseUserName", ResourceType = typeof(Resources.ORD.OrderMaster))]
        public string CloseUserName { get; set; }

        [Display(Name = "OrderMaster_CancelDate", ResourceType = typeof(Resources.ORD.OrderMaster))]
        public DateTime? CancelDate { get; set; }

        public Int32? CancelUserId { get; set; }

        [Display(Name = "OrderMaster_CancelUserName", ResourceType = typeof(Resources.ORD.OrderMaster))]
        public string CancelUserName { get; set; }

        [Display(Name = "OrderMaster_CancelReason", ResourceType = typeof(Resources.ORD.OrderMaster))]
        public string CancelReason { get; set; }

        [Display(Name = "OrderMaster_Version", ResourceType = typeof(Resources.ORD.OrderMaster))]
        public Int32 Version { get; set; }

        public Boolean IsCheckPartyFromAuthority { get; set; }

        public Boolean IsCheckPartyToAuthority { get; set; }

        public Boolean IsShipFifo { get; set; }

        //public Boolean IsPlanPause { get; set; }

        [Display(Name = "OrderMaster_PauseStatus", ResourceType = typeof(Resources.ORD.OrderMaster))]
        public CodeMaster.PauseStatus PauseStatus { get; set; }

        [Export(ExportName = "ExportVanOrder", ExportSeq = 140)]
        [Export(ExportName = "VanProductionOrder", ExportSeq = 150)]
        [Display(Name = "OrderMaster_PauseSequence", ResourceType = typeof(Resources.ORD.OrderMaster))]
        public Int32 PauseSequence { get; set; }

        //[Display(Name = "OrderMaster_IsPause", ResourceType = typeof(Resources.ORD.OrderMaster))]
        //public Boolean IsPause { get; set; }

        //[Display(Name = "OrderMaster_IsProductLinePause", ResourceType = typeof(Resources.ORD.OrderMaster))]
        //public Boolean IsProductLinePause { get; set; }

        [Display(Name = "OrderMaster_OrderStrategy", ResourceType = typeof(Resources.ORD.OrderMaster))]
        public com.Sconit.CodeMaster.FlowStrategy OrderStrategy { get; set; }

        public Boolean IsQuick { get; set; }

        public string PickStrategy { get; set; }

        public string ExtraDemandSource { get; set; }

        [Display(Name = "OrderMaster_WMSNO", ResourceType = typeof(Resources.ORD.OrderMaster))]
        public string WMSNo { get; set; }

        public CodeMaster.ProdLineType ProdLineType { get; set; }

        [Export(ExportName = "ExportSeqOrder", ExportSeq = 35)]
        [Display(Name = "OrderMaster_SequenceGroup", ResourceType = typeof(Resources.ORD.OrderMaster))]
        public string SequenceGroup { get; set; }

        #endregion

        public override int GetHashCode()
        {
            if (OrderNo != null)
            {
                return OrderNo.GetHashCode();
            }
            else
            {
                return base.GetHashCode();
            }
        }

        public override bool Equals(object obj)
        {
            OrderMaster another = obj as OrderMaster;

            if (another == null)
            {
                return false;
            }
            else
            {
                return (this.OrderNo == another.OrderNo);
            }
        }
    }

}
