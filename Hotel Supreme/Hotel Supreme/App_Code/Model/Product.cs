
using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
	

namespace Model
{
    
    public class Product
    {
     	private int _productID;
        private string _name;
        private string _description;
        private int _supplierID;
        private string _productCategoryID;
        private int _quantity;
        private double _unitPrice;
        
     	
     	
        

         public Product()
        {

        }

        public int ProductID
        {
            set { _productID = value; }
            get { return _productID; }
        }

        public string Name
        {
            set { _name = value; }
            get { return _name; }
        }

        public string Description
        {
            set { _description = value; }
            get { return _description; }
        }

        public int SupplierID
        {
            set { _supplierID = value; }
            get { return _supplierID; }
        }

        public string ProductCategoryID
        {
            set { _productCategoryID = value; }
            get { return _productCategoryID; }
        }

        public int Quantity
        {
            set { _quantity = value; }
            get { return _quantity; }
        }

        public double UnitPrice
        {
            set { _unitPrice = value; }
            get { return _unitPrice; }
        }

        
    
    	
    }
    
  
 }
	
