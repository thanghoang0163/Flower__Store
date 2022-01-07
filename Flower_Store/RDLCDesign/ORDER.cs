namespace RDLCDesign
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ORDERS")]
    public partial class ORDER
    {
        [Key]
        public int IDOD { get; set; }

        public int IDCUS { get; set; }

        [StringLength(50)]
        public string CUSTOMER { get; set; }

        public int IDPROD { get; set; }

        [StringLength(50)]
        public string PRODUCT { get; set; }

        public int QUANTITY { get; set; }

        public int UNITPRICE { get; set; }

        public int? TOTALPRICE { get; set; }
    }
}
