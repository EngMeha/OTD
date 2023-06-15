using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace OTD.Entity
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Context")
        {
        }

        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<ListServerOfOrder> ListServerOfOrder { get; set; }
        public virtual DbSet<ListServiceOfEmployee> ListServiceOfEmployee { get; set; }
        public virtual DbSet<LoyerFace> LoyerFace { get; set; }
        public virtual DbSet<Order> Order { get; set; }
        public virtual DbSet<PhisicalFace> PhisicalFace { get; set; }
        public virtual DbSet<Position> Position { get; set; }
        public virtual DbSet<Service> Service { get; set; }
        public virtual DbSet<StatusOrder> StatusOrder { get; set; }
        public virtual DbSet<StatusService> StatusService { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>()
                .HasOptional(e => e.Customer1)
                .WithRequired(e => e.Customer2);

            modelBuilder.Entity<Customer>()
                .HasOptional(e => e.LoyerFace)
                .WithRequired(e => e.Customer);

            modelBuilder.Entity<Customer>()
                .HasOptional(e => e.PhisicalFace)
                .WithRequired(e => e.Customer);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.ListServiceOfEmployee)
                .WithRequired(e => e.Employee)
                .HasForeignKey(e => e.idEmployer)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.Order)
                .WithRequired(e => e.Employee)
                .HasForeignKey(e => e.idEmployee)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Order>()
                .HasMany(e => e.ListServerOfOrder)
                .WithRequired(e => e.Order)
                .HasForeignKey(e => e.IdOrder)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Position>()
                .HasMany(e => e.Employee)
                .WithRequired(e => e.Position)
                .HasForeignKey(e => e.idPosition)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Service>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Service>()
                .Property(e => e.PriceRussianCosmetic)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Service>()
                .HasMany(e => e.ListServerOfOrder)
                .WithRequired(e => e.Service)
                .HasForeignKey(e => e.IdService)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Service>()
                .HasMany(e => e.ListServiceOfEmployee)
                .WithRequired(e => e.Service)
                .HasForeignKey(e => e.IdService)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<StatusOrder>()
                .HasMany(e => e.Order)
                .WithRequired(e => e.StatusOrder)
                .HasForeignKey(e => e.idstatus)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<StatusService>()
                .HasMany(e => e.ListServerOfOrder)
                .WithRequired(e => e.StatusService)
                .HasForeignKey(e => e.IdStatus)
                .WillCascadeOnDelete(false);
        }
    }
}
