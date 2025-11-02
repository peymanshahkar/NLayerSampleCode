using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class Product : ProductProvider
    {

///////Product درج رکورد جدید در جدول 

      public override Int32 InsertProduct(ProductDetail product)
      {
            using (SqlCommand command = new SqlCommand("Product_Insert", DBHelper.DbHelper.Connection))
            {
				 command.CommandType = CommandType.StoredProcedure;

				 command.Parameters.Add("@ProductCode", SqlDbType.NVarChar).Value = product.ProductCode;
				 command.Parameters.Add("@ProductName", SqlDbType.NVarChar).Value = product.ProductName;
				 command.Parameters.Add("@Price", SqlDbType.Money).Value = product.Price;
				 command.Parameters.Add("@IsDisabled", SqlDbType.Bit).Value = product.IsDisabled;

                 Int32 result = (Int32)DBHelper.DbHelper.ExecuteScalar(command);
                 return result;
            }
      }

///////Product به روز رسانی یک رکورد در جدول 

      public override Int32 UpdateProduct(ProductDetail product)
      {
            using (SqlCommand command = new SqlCommand("Product_Update", DBHelper.DbHelper.Connection))
            {
				 command.CommandType = CommandType.StoredProcedure;

				 command.Parameters.Add("@ProductID", SqlDbType.Int).Value = product.ProductID;
				 command.Parameters.Add("@ProductCode", SqlDbType.NVarChar).Value = product.ProductCode;
				 command.Parameters.Add("@ProductName", SqlDbType.NVarChar).Value = product.ProductName;
				 command.Parameters.Add("@Price", SqlDbType.Money).Value = product.Price;
				 command.Parameters.Add("@IsDisabled", SqlDbType.Bit).Value = product.IsDisabled;

                 Int32 result = DBHelper.DbHelper.Execute(command);
                 return result;
            }
      }

///////Product حذف رکورد از جدول 

      public override Int32 DeleteProduct(Int32 productid)
      {
            using (SqlCommand command = new SqlCommand("Product_DeleteRow", DBHelper.DbHelper.Connection))
            {
				 command.CommandType = CommandType.StoredProcedure;

				 command.Parameters.Add("@ProductID", SqlDbType.Int).Value = productid;

                 Int32 result = DBHelper.DbHelper.Execute(command);
                 return result;
            }
      }

///////Product جستجو رکورد از جدول 

      public override List<ProductDetail> Search(string filter)
      {
	            using (SqlCommand command = new SqlCommand("Product_Search", DBHelper.DbHelper.Connection))
	            {
					 command.CommandType = CommandType.StoredProcedure;

					 command.Parameters.Add("@FilterString", SqlDbType.NVarChar).Value = filter;

	                 return GetProductCollectionFromReader(DBHelper.DbHelper.ExecuteReader(command));
	            }
      }

///////Product بدست آوردن بیشترین مقدار فیلد کلید از جدول

      public override Int32 Product_GetMaxId()
      {
            using (SqlCommand command = new SqlCommand("Product_GetMaxId", DBHelper.DbHelper.Connection))
            {
				 command.CommandType = CommandType.StoredProcedure;

                 Object result = DBHelper.DbHelper.ExecuteScalar(command);
                 return (Int32)result;
            }
      }

///////Product انتخاب همه رکوردهای جدول 

      public override List<ProductDetail> GetAllProduct()
      {
            try
            {
	            using (SqlCommand command = new SqlCommand("Product_GetAll", DBHelper.DbHelper.Connection))
	            {
					 command.CommandType = CommandType.StoredProcedure;

	                 return GetProductCollectionFromReader(DBHelper.DbHelper.ExecuteReader(command));
	            }
            }
            catch (Exception ex)
            {
	            throw new Exception(ex.Message);
            }
            finally
            {
	            DBHelper.DbHelper.CloseConnection();
            }
      }

///////Product انتخاب یک رکورد براساس شناسه از جدول 

      public override ProductDetail GetProductById(Int32  productid)
      {
	            using (SqlCommand command = new SqlCommand("Product_GetById", DBHelper.DbHelper.Connection))
	            {
					 ProductDetail productDetail = null;
					 command.CommandType = CommandType.StoredProcedure;

					 command.Parameters.Add("@ProductID", SqlDbType.Int).Value = productid;

	                 SqlDataReader reader = DBHelper.DbHelper.ExecuteReader(command);
	                 if (reader.Read())
	                 productDetail =  GetProductFromReader(reader);
	                 reader.Close();
	                 return productDetail;
	            }
      }

    }
}
