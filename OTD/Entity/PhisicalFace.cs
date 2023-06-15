namespace OTD.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PhisicalFace")]
    public partial class PhisicalFace
    {
        [StringLength(50)]
        public string id { get; set; }

        [Required]
        [StringLength(50)]
        public string FIO { get; set; }

        public int SerialPassport { get; set; }

        public int NumberPassport { get; set; }

        [Column(TypeName = "date")]
        public DateTime DataBirth { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        [StringLength(50)]
        public string Email { get; set; }

        [Required]
        [StringLength(50)]
        public string Password { get; set; }

        public virtual Customer Customer { get; set; }
    }
}
