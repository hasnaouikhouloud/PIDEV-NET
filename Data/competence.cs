namespace Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("pidev.competence")]
    public partial class competence
    {
        [Key]
        public int id_comp { get; set; }

        [StringLength(255)]
        public string description { get; set; }

        [StringLength(255)]
        public string niveau { get; set; }

        public int? categorie_id_cat { get; set; }

        public virtual categorie categorie { get; set; }
    }
}
