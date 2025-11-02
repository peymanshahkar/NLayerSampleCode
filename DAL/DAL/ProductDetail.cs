using System;
using System.Data;

namespace DAL
{
    public class ProductDetail
    {

        public ProductDetail(Int32 productid, string productcode, string productname, decimal price, Boolean isdisabled)
        {
			ProductID = productid;
			ProductCode = productcode;
			ProductName = productname;
			Price = price;
			IsDisabled = isdisabled;
        }

        public ProductDetail(IDataReader reader)
        {
			ProductID = (Int32)reader["ProductID"];
			ProductCode = (string)reader["ProductCode"];
			ProductName = (string)reader["ProductName"];
			Price = (decimal)reader["Price"];
			IsDisabled = (Boolean)reader["IsDisabled"];
        }

        public ProductDetail()
        {
        }


        public virtual Int32 ProductID { get; set; } 

        public virtual string ProductCode { get; set; } 

        public virtual string ProductName { get; set; } 

        public virtual decimal Price { get; set; } 

        public virtual Boolean IsDisabled { get; set; } 

    }
}
