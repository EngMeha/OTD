namespace OTD.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Order")]
    public partial class Order
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Order()
        {
            ListServerOfOrder = new HashSet<ListServerOfOrder>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [Required]
        [StringLength(50)]
        public string NumberOrder { get; set; }

        [Column(TypeName = "date")]
        public DateTime DataCreate { get; set; }

        [Required]
        [StringLength(50)]
        public string idCustomer { get; set; }

        public int idstatus { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DateClose { get; set; }

        public int idEmployee { get; set; }

        public int TimeHourWork { get; set; }

        public virtual Employee Employee { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ListServerOfOrder> ListServerOfOrder { get; set; }

        public virtual StatusOrder StatusOrder { get; set; }
    }
}
