namespace Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("pidev.evaluation")]
    public partial class evaluation
    {
        public int id { get; set; }

        [StringLength(255)]
        public string Question1 { get; set; }

        [StringLength(255)]
        public string Question2 { get; set; }

        [StringLength(255)]
        public string Question3 { get; set; }

        [StringLength(255)]
        public string Question4 { get; set; }

        [StringLength(255)]
        public string Question5 { get; set; }

        [StringLength(255)]
        public string Type_comptence { get; set; }

        [Column(TypeName = "date")]
        public DateTime? date { get; set; }

        [Column(TypeName = "bit")]
        public bool isvalid { get; set; }

        [StringLength(255)]
        public string note1 { get; set; }

        [StringLength(255)]
        public string note2 { get; set; }

        [StringLength(255)]
        public string note3 { get; set; }

        [StringLength(255)]
        public string note4 { get; set; }

        [StringLength(255)]
        public string note5 { get; set; }

        public int? employees_id { get; set; }

        public virtual employee employee { get; set; }
    }
}
