using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;

namespace BLL
{
    public partial class ProductAdapter
    {

        private static List<Product> GetProductCollectionFromProductDAL(List<DAL.ProductDetail> records)
        {
             List<Product> items = new List<Product>();
             foreach (DAL.ProductDetail item in records)
                items.Add(GetProductFromProductDAL(item));
             return items;
        }

        private static Product GetProductFromProductDAL(DAL.ProductDetail record)
        {
             if (record != null)
                 return new Product(
							record.ProductID, 
							record.ProductCode, 
							record.ProductName, 
							record.Price, 
							record.IsDisabled);
             return null;
        }

        public static Product GetProductById(int productid)
        {
             Product items;
             DAL.Product u = new DAL.Product();
             bool CanCloseConnection= DBHelper.DbHelper.OpenConnection();
             DAL.ProductDetail recordSet = u.GetProductById(productid);
             items = GetProductFromProductDAL(recordSet);
             if (CanCloseConnection)
	             DBHelper.DbHelper.CloseConnection();
             return items;
        }

        public virtual Int32 GetProductMaxID()
        {
             return GetProductMaxID_Static();
        }

        public static Int32 GetProductMaxID_Static()
        {
             DAL.Product u = new DAL.Product();
             return u.Product_GetMaxId();
        }

        public static List<Product> SelectAll()
        {
             List<Product> items;
             DAL.Product u = new DAL.Product();
             bool CanCloseConnection= DBHelper.DbHelper.OpenConnection();
             List<DAL.ProductDetail> recordSet = u.GetAllProduct();
             items = GetProductCollectionFromProductDAL(recordSet);
             if (CanCloseConnection)
	             DBHelper.DbHelper.CloseConnection();
             return items;
        }

        public static Int32 Insert(Int32 productid, string productcode, string productname, decimal price, Boolean isdisabled)
        {
             DAL.ProductDetail productDetail = new DAL.ProductDetail(productid, productcode, productname, price, isdisabled);
             DAL.Product u = new DAL.Product();
             return u.InsertProduct(productDetail);
        }

        public static Boolean Update(Int32 productid, string productcode, string productname, decimal price, Boolean isdisabled)
        {
             DAL.ProductDetail productDetail = new DAL.ProductDetail(productid, productcode, productname, price, isdisabled);
             DAL.Product u = new DAL.Product();
             if (u.UpdateProduct(productDetail) > 0)
                 return true;
             return false;
        }

        public static Boolean Delete(Int32 productid)
        {
             DAL.Product u = new DAL.Product();
             if (u.DeleteProduct(productid) > 0)
                 return true;
             return false;
        }

        public static List<Product> Search(string Filter)
        {
             List<Product> items;
             DAL.Product u = new DAL.Product();
             bool CanCloseConnection= DBHelper.DbHelper.OpenConnection();
             List<DAL.ProductDetail> recordSet = u.Search(Filter);
             items = GetProductCollectionFromProductDAL(recordSet);
             if (CanCloseConnection)
	             DBHelper.DbHelper.CloseConnection();
             return items;
        }

    }
}
