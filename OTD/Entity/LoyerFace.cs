namespace OTD.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LoyerFace")]
    public partial class LoyerFace
    {
        [StringLength(50)]
        public string id { get; set; }

        [Required]
        [StringLength(50)]
        public string TitleCompany { get; set; }

        [Required]
        [StringLength(50)]
        public string adress { get; set; }

        [Required]
        [StringLength(50)]
        public string INN { get; set; }

        [Required]
        [StringLength(50)]
        public string rs { get; set; }

        [Required]
        [StringLength(50)]
        public string BIC { get; set; }

        [Required]
        [StringLength(50)]
        public string FIOBoss { get; set; }

        [Required]
        [StringLength(50)]
        public string FIOContactFace { get; set; }

        [Required]
        [StringLength(50)]
        public string Phone { get; set; }

        [Required]
        [StringLength(50)]
        public string Email { get; set; }

        [Required]
        [StringLength(50)]
        public string password { get; set; }

        public virtual Customer Customer { get; set; }
    }
}
