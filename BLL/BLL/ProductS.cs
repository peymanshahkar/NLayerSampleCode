using System;
using System.Collections.Generic;

namespace BLL
{
    public class ProductS: System.ComponentModel.BindingList<Product>
    {

        List<Product> RemovedProductS = new List<Product>();

        public ProductS()
        {
        }


        public void UpdateObjects()
        {
             try
             {
                  foreach (Product item in this)
                  {
                      item.UpdateObject();
                  }
                  foreach (Product item in RemovedProductS)
                  {
                      item.DeleteObject();
                  }
                  RemovedProductS.Clear();
             }
             catch (Exception ex)
             {
                  throw ex;
             }
        }


        public bool RemoveObject(Product item)
        {
             try
             {
                  bool result = this.Remove(item);
                  RemovedProductS.Add(item);
                  return result;
             }
             catch (Exception ex)
             {
                  throw ex;
             }
        }


        public void AddObject(Product item)
        {
             this.Add(item);
        }

    }
}
