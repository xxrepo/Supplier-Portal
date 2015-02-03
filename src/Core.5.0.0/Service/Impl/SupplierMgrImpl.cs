using System;
using System.Collections;
using System.Collections.Generic;
using com.Sconit.Entity.MD;
using System.Linq;
using Castle.Services.Transaction;
using com.Sconit.Entity.ACC;
using com.Sconit.Entity;

namespace com.Sconit.Service.Impl
{
    [Transactional]
    public class SupplierMgrImpl : BaseMgr, ISupplierMgr
    {

        public IGenericMgr genericMgr { get; set; }

        #region public methods

        public IList<Supplier> GetOrderFromSupplier(com.Sconit.CodeMaster.OrderType type)
        {
            return GetOrderSupplier(type, "From");
        }

        public IList<Supplier> GetOrderToSupplier(com.Sconit.CodeMaster.OrderType type)
        {
            return GetOrderSupplier(type, "To");
        }

        [Transaction(TransactionMode.Requires)]
        public void Create(Supplier supplier)
        {
            genericMgr.Create(supplier);

            #region ��Ȩ��
            Permission permission = new Permission();
            permission.Code = supplier.Code;
            permission.Description = supplier.Name;
            permission.PermissionCategory = supplier.GetType().Name;
            genericMgr.Create(permission);
            #endregion

            #region ���û�Ȩ��
            UserPermission up = new UserPermission();
            up.Permission = permission;
            up.User = SecurityContextHolder.Get();
            genericMgr.Create(up);
            #endregion
        }

        //[Transaction(TransactionMode.Requires)]
        //public void AddSupplierAddress(SupplierAddress SupplierAddress)
        //{
        //    if (SupplierAddress.IsPrimary)
        //    {
        //        this.genericMgr.Update("update from SupplierAddress set IsPrimary = ? where Supplier = ?", new object[] { false, SupplierAddress.Supplier });
        //        this.genericMgr.FlushSession();
        //    }

        //    genericMgr.Create(SupplierAddress);
        //}

        //[Transaction(TransactionMode.Requires)]
        //public void UpdateSupplierAddress(Partyaddress SupplierAddress)
        //{
        //    if (SupplierAddress.IsPrimary)
        //    {
        //        this.genericMgr.Update("update from SupplierAddress set IsPrimary = ? where Supplier = ?", new object[] { false, SupplierAddress.Supplier });
        //        this.genericMgr.FlushSession();
        //    }

        //    genericMgr.Update(SupplierAddress);
        //}
        #endregion

        #region private methods
        private IList<Supplier> GetOrderSupplier(com.Sconit.CodeMaster.OrderType type, string fromTo)
        {
            IList<Supplier> supplierList = genericMgr.FindAll<Supplier>();

            return supplierList;
        }

        #endregion
    }
}