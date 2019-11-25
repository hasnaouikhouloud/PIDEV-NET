namespace Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("pidev.cv")]
    public partial class cv
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public cv()
        {
            employees = new HashSet<employee>();
        }

        public int id { get; set; }

        [StringLength(255)]
        public string language { get; set; }

        [StringLength(255)]
        public string nomCv { get; set; }

        [StringLength(255)]
        public string project { get; set; }

        [StringLength(255)]
        public string skills { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<employee> employees { get; set; }
    }
}
