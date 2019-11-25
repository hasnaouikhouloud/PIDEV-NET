namespace Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("pidev.activity")]
    public partial class activity
    {
        public int id { get; set; }

        [StringLength(255)]
        public string category { get; set; }

        [StringLength(255)]
        public string description { get; set; }

        [Column(TypeName = "date")]
        public DateTime? finishDate { get; set; }

        public int hours { get; set; }

        [Column(TypeName = "date")]
        public DateTime? startDate { get; set; }

        [StringLength(255)]
        public string status { get; set; }

        public int? employee_id { get; set; }

        public virtual employee employee { get; set; }
    }
}
