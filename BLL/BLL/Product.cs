using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace BLL
{
    public class Product : BLL.ProductBase
    {

        public Product (Int32 productid, string productcode, string productname, decimal price, Boolean isdisabled) : base(productid, productcode, productname, price, isdisabled)
        {
			ProductID = productid;
			ProductCode = productcode;
			ProductName = productname;
			Price = price;
			IsDisabled = isdisabled;
        }

        public Product() : base()
        {
        }
        public override string ProductCode 
        {
            get
            {
                return base.ProductCode;
            }
            set
            {
                base.ProductCode = value.ToEnglishNumbers();
            }
        }
        public override string ProductName
        {
            get
            {
                return base.ProductName;
            }
            set
            {
                base.ProductName = value.ToEnglishNumbers();
            }
        }
        
        public static ProductS GetProductSById(Int32 Id )
        {
             SqlDataReader reader;
             ProductS productS = new ProductS();

             bool CanCloseConnection = DBHelper.DbHelper.OpenConnection();
             reader = DBHelper.DbHelper.ExecuteReader("exec Product_Search 'ProductID="+ Id +"'");
             Product product;
             while (reader.Read())
             {
                 product = new Product(
                        (Int32)reader["ProductID"],
                        reader["ProductCode"].ToString(),
                        reader["ProductName"].ToString(),
                        (decimal)reader["Price"],
                        (Boolean)reader["IsDisabled"]);

                productS.AddObject(product);
             }
              reader.Close();
              if (CanCloseConnection)
                  DBHelper.DbHelper.CloseConnection();
              return productS;
        }

        private bool AddNew { get; set; }

        public void UpdateObject()
        {
            try
            {

                onUpdate();
                DBHelper.DbHelper.BeginTransaction();

                if (ProductID == 0)
                {
                    AddNew = true;
                    this.ProductID = this.Insert();
                }
                else
                {
                    Update();
                }
               

                DBHelper.DbHelper.CommitTransaction();
                AddNew = false;
            }
            catch (Exception ex)
            {
                DBHelper.DbHelper.RollBackTransaction();
                if (AddNew)
                {
                    ProductID = 0;
                }
                throw ex;
            }
        }

        private void onUpdate()
        {
            if (ProductID > 0 && !Permission.Product_Edit)
            {
                throw new Exception("شما دسترسی ویرایش ندارید");
            }
            if (ProductID == 0 && !Permission.Product_Save)
            {
                throw new Exception("شما دسترسی افزودن کالا را ندارید");
            }
            if (string.IsNullOrEmpty(ProductName))
            {
                throw new Exception("لطفا عنوان نام کالا را وارد کنید");
            }

            if (string.IsNullOrEmpty(ProductCode))
            {

                throw new Exception("لطفا کد کالا را وارد کنید");

            }
            if (Price==0)
            {

                throw new Exception("لطفا قیمت کالا را وارد کنید");

            }
        }

        public bool DeleteObject()
        {
            try
            {
                OnDelete();
                if (ProductID > 0)
                {
                    if (DBHelper.StandardMessages.ConfirmDelete())
                    {
                        Delete();
                        return true;
                    }
                }
                return false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }

        private void OnDelete()
        {
            if (!Permission.Product_Del)
                throw new Exception("شما مجوز حذف کالا را ندارید");
        }
    }
}
