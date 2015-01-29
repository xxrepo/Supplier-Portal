using System;
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace com.Sconit.PrintModel.ORD
{
    [Serializable]
    [DataContract]
    public partial class PrintOrderDetail: PrintBase
    {
        #region O/R Mapping Properties
        [DataMember]
        public Int32 Id { get; set; }

        [DataMember]
        public string OrderNo { get; set; }

        [DataMember]
        public Int32 Sequence { get; set; }

        [DataMember]
        public string Item { get; set; }

        [DataMember]
        public string ItemDescription { get; set; }

        [DataMember]
        public string ReferenceItemCode { get; set; }

        [DataMember]
        public string Uom { get; set; }

        [DataMember]
        public Decimal UnitCount { get; set; }

        [DataMember]
        public Int16 QualityType { get; set; }
        //public com.Sconit.CodeMaster.QualityType QualityType { get; set; }

        [DataMember]
        public string ManufactureParty { get; set; }

        [DataMember]
        public Decimal OrderedQty { get; set; }

        [DataMember]
        public Decimal ReceivedQty { get; set; }

        [DataMember]
        public Decimal ShippedQty { get; set; }

        [DataMember]
        public string LocationFrom { get; set; }

        [DataMember]
        public string LocationFromName { get; set; }

        [DataMember]
        public string LocationTo { get; set; }

        [DataMember]
        public string LocationToName { get; set; }

        [DataMember]
        public Boolean IsInspect { get; set; }

        [DataMember]
        public Boolean IsScanHu { get; set; }

        [DataMember]
        public string CreateUserName { get; set; }

        [DataMember]
        public DateTime CreateDate { get; set; }

        [DataMember]
        public string ZOPID { get; set; }

        [DataMember]
        public string ZOPDS { get; set; }

        [DataMember]
        public IList<PrintOrderBomDetail> OrderBomDetails { get; set; }

        [DataMember]
        public string BinTo { get; set; }

        [DataMember]
        public DateTime? StartDate { get; set; }

        [DataMember]
        public string ExternalOrderNo { get; set; }

        [DataMember]
        public string ReserveNo { get; set; }

        [DataMember]
        public string ReserveLine { get; set; }


        [DataMember]
        public string StartDateFormat { get; set; }


        [DataMember]
        public string ICHARG { get; set; }

        [DataMember]
        public string ZENGINE { get; set; }

        [DataMember]
        public string Routing { get; set; }

        #endregion
    }

}
