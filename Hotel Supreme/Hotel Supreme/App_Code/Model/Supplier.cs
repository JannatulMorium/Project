
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

    public class Supplier
    {
        private int _supplierID;
        private string _name;
        private string _address;
        private string _phone;
        private string _cell;



        public Supplier()
        {

        }

        public int SupplierID
        {
            set { _supplierID = value; }
            get { return _supplierID; }
        }

        public string Name
        {
            set { _name = value; }
            get { return _name; }
        }

        public string Address
        {
            set { _address = value; }
            get { return _address; }
        }

        public string Phone
        {
            set { _cell = value; }
            get { return _cell; }
        }

        public string Cell
        {
            set { _phone = value; }
            get { return _phone; }
        }
    }


}

