namespace Export_invoice
{


    
    public partial class INVOICE
    {
       
        public int IDINV { get; set; }

        public int IDCUS { get; set; }

        
        public string CUSTOMER { get; set; }

        public int IDOD { get; set; }

        public int IDEMP { get; set; }

        public int? TOTAL { get; set; }

       
        public string INVOICEDATE { get; set; }
    }
}
