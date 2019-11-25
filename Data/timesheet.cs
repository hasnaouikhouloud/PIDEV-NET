namespace Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("pidev.timesheet")]
    public partial class timesheet
    {
        public int id { get; set; }

        public int activityID { get; set; }

        [Column(TypeName = "date")]
        public DateTime? date { get; set; }

        [StringLength(255)]
        public string valid { get; set; }

        public int workingHours { get; set; }

        public int? employees_id { get; set; }

        public virtual employee employee { get; set; }
    }
}
