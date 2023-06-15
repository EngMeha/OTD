namespace OTD.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ListServerOfOrder")]
    public partial class ListServerOfOrder
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public int IdOrder { get; set; }

        public int IdService { get; set; }

        public int IdStatus { get; set; }

        public virtual Order Order { get; set; }

        public virtual Service Service { get; set; }

        public virtual StatusService StatusService { get; set; }
    }
}
