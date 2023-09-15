using Microsoft.EntityFrameworkCore;

namespace dotnet_ef_core_example
{
    public class DatabaseContext : DbContext
    {

        public DbSet<Contact> Contacts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Contact>(entity =>
            {
                entity.ToTable("contact");
                entity.HasKey(e => e.Id);
                entity.Property(e => e.FirstName)

                .HasColumnType("varchar(255)")
                .HasColumnName("first_name")
                .IsRequired();
                entity.Property(e => e.LastName)
                .HasColumnType("varchar(255)")
                .HasColumnName("last_name")
                .IsRequired(false);
                entity.Property(e => e.Description)
                .HasColumnType("varchar(255)")
                .HasColumnName("description")
                .IsRequired(false);
                entity.Property(e => e.Dob)
                .HasColumnType("date")
                .HasColumnName("dob")
                .IsRequired(false);
                entity.Property(e => e.Phone)
                .HasColumnType("varchar(255)")
                .HasColumnName("phone")
                .IsRequired(false);
                entity.Property(e => e.Address)
                .HasColumnType("varchar(255)")
                .HasColumnName("address")
                .IsRequired(false);
                entity.Property(e => e.Email)
                .HasColumnType("varchar(255)")
                .HasColumnName("email")
                .IsRequired(false);
                entity.Property(e => e.Gender)
                .HasColumnType("varchar(255)")
                .HasColumnName("gender")
                .IsRequired(false);
                entity.Property(e => e.CountryId)
                .HasColumnType("int")
                .HasColumnName("country_id")
                .IsRequired(false);
            });
        }
    }
}
