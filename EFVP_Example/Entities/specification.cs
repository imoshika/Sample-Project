namespace EFVP_Example
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("specification")]
    public partial class specification
    {
        [Key]
        public int SpecificationID { get; set; }

        [Column("specification")]
        [StringLength(50)]
        public string Specification { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? Created { get; set; }

        public int SpecTypeID { get; set; }

        public int? productID { get; set; }

        public virtual product Product { get; set; }

        public virtual Specification_Type Specification_Type { get; set; }
    }
}
