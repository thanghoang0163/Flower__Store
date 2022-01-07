namespace RDLCDesign
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("INVOICE")]
    public partial class INVOICE
    {
        [Key]
        public int IDINV { get; set; }

        public int IDCUS { get; set; }

        [StringLength(50)]
        public string CUSTOMER { get; set; }

        public int IDOD { get; set; }

        public int IDEMP { get; set; }

        public int? TOTAL { get; set; }

        [StringLength(50)]
        public string INVOICEDATE { get; set; }
    }
}
