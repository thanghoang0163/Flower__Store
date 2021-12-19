namespace Report
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CUSTOMER")]
    public partial class CUSTOMER
    {
        [Key]
        [StringLength(50)]
        public string IDCUS { get; set; }

        [Required]
        [StringLength(50)]
        public string NAMECUS { get; set; }

        [StringLength(50)]
        public string GENDER { get; set; }

        [StringLength(50)]
        public string PHONE { get; set; }

        [StringLength(50)]
        public string ADDRESSCUS { get; set; }

        [Required]
        [StringLength(50)]
        public string PRODUCT { get; set; }

        public int QUANTITY { get; set; }

        public int UNITPRICE { get; set; }

        [StringLength(50)]
        public string PURCHASEDATE { get; set; }
    }
}
