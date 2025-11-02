

namespace SampleCode
{
    public class FormGetter
    {

     private static FrmProductList frmproductlist ;
        private static FrmProduct frmproduct; 
        public static System.Windows.Forms.Form GetFormByName(string formname)
        {
            switch (formname)
            {
                case "ProductList":
                    if (frmproductlist == null || frmproductlist.IsDisposed) frmproductlist = new FrmProductList();
                    return frmproductlist;
                case "Product":
                    if (frmproduct == null || frmproduct.IsDisposed) frmproduct = new FrmProduct();
                    return frmproduct;
            }
           return null;
        }
       

    }
}
