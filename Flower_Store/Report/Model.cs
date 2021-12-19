using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Report
{
    public partial class Model : DbContext
    {
        public Model()
            : base("name=FlowerStore")
        {
        }

        public virtual DbSet<CUSTOMER> CUSTOMERs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
