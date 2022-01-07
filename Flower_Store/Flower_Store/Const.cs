using System;
using System.Collections.Generic;
using System.Text;

namespace Flower_Store
{
    public class glbVar
    {
        public static int id;
        public static string product;
        public static int idProduct;
        public static string customer;
        public static int idCustomer;
        public static bool isGetProductForInvoice = false;
        public static bool isGetProductForOrders = false;
        public static bool isGetCustomerForInvoice = false;
        //public static string getQuantity;
        //public static string getUnitprice;
        public static bool isGetCustomer = false;

        //Order 
        public static string getQuantity;
        public static string getUnitprice;
        public void setDefaultvalue()
        {
            idProduct = 0;
            product = null;
            idCustomer = 0;
            customer = null;
            getQuantity = null;
            getUnitprice = null;
            isGetProductForOrders = false;
            isGetProductForInvoice = false;
            isGetCustomer = false;
    }
    }

   
}
