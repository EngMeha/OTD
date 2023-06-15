namespace OTD.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Customer")]
    public partial class Customer
    {
        [StringLength(50)]
        public string Id { get; set; }

        public virtual Customer Customer1 { get; set; }

        public virtual Customer Customer2 { get; set; }

        public virtual LoyerFace LoyerFace { get; set; }

        public virtual PhisicalFace PhisicalFace { get; set; }
    }
}
