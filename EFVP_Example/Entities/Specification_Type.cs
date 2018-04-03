namespace EFVP_Example
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Specification_Type
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Specification_Type()
        {
            specifications = new HashSet<specification>();
        }

        [Key]
        public int SpecTypeID { get; set; }

        [Required]
        [StringLength(50)]
        public string SpecType { get; set; }

        [Required]
        [StringLength(50)]
        public string Created { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<specification> specifications { get; set; }
    }
}
