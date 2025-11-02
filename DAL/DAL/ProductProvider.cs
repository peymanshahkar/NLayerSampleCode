using System;
using System.Collections.Generic;
using System.Data;

namespace DAL
{
    public abstract class ProductProvider : DataAccess
    {

      protected virtual List<ProductDetail> GetProductCollectionFromReader(IDataReader reader)
      {
            List<ProductDetail> items = new List<ProductDetail>();
            while (reader.Read())
                items.Add(GetProductFromReader(reader));
            reader.Close();
            return items;
      }

      protected virtual ProductDetail GetProductFromReader(IDataReader reader)
      {
            return new ProductDetail(reader);
      }


      public abstract List<ProductDetail> GetAllProduct();


      public abstract ProductDetail GetProductById(Int32 ProductID);


      public abstract Int32 InsertProduct(ProductDetail product);


      public abstract Int32 UpdateProduct(ProductDetail product);


      public abstract Int32 DeleteProduct(Int32 ProductID);


      public abstract List<ProductDetail> Search(string filter);


      public abstract Int32 Product_GetMaxId();

    }
}
