using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;

namespace BLL
{
    public class ProductBase : DAL.ProductDetail,INotifyPropertyChanged
    {

        public ProductBase (Int32 productid, string productcode, string productname, decimal price, Boolean isdisabled)
        {
			ProductID = productid;
			ProductCode = productcode;
			ProductName = productname;
			Price = price;
			IsDisabled = isdisabled;
        }

        public ProductBase ()
        {
        }

        public virtual Int32 Insert()
        {
             return ProductAdapter.Insert(ProductID, ProductCode, ProductName, Price, IsDisabled);
        }

        public virtual Boolean Update()
        {
             if (ProductAdapter.Update(ProductID, ProductCode, ProductName, Price, IsDisabled))
                  return true;
             return false;
        }

        public virtual Boolean Delete()
        {
             if (ProductAdapter.Delete(ProductID))
                 return true;
             return false;
        }

        public virtual event PropertyChangedEventHandler PropertyChanged;

        public virtual void InvokePropertyChanged(PropertyChangedEventArgs e)
        {
             PropertyChangedEventHandler handler = PropertyChanged;
             if (handler != null) handler(this, e);
        }

        public virtual void ValidateDelete()
        {
        }

        public virtual void ValidateInsertUpdate()
        {
              if (String.IsNullOrEmpty(ProductCode))
                throw new Exception("مقداری برای ProductCode وارد نشده است");
              if (String.IsNullOrEmpty(ProductName))
                throw new Exception("مقداری برای ProductName وارد نشده است");
              if (Price == 0)
                throw new Exception("مقداری برای Price وارد نشده است");
        }

    }
}
