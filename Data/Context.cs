namespace Data
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Context : DbContext
    {
        public Context()
            : base("name=Context2")
        {
        }

        public virtual DbSet<activity> activities { get; set; }
        public virtual DbSet<categorie> categories { get; set; }
        public virtual DbSet<competence> competences { get; set; }
        public virtual DbSet<cv> cvs { get; set; }
        public virtual DbSet<employee> employees { get; set; }
        public virtual DbSet<evaluation> evaluations { get; set; }
        public virtual DbSet<note> notes { get; set; }
        public virtual DbSet<timesheet> timesheets { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<activity>()
                .Property(e => e.category)
                .IsUnicode(false);

            modelBuilder.Entity<activity>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<activity>()
                .Property(e => e.status)
                .IsUnicode(false);

            modelBuilder.Entity<categorie>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<categorie>()
                .Property(e => e.nom)
                .IsUnicode(false);

            modelBuilder.Entity<categorie>()
                .HasMany(e => e.competences)
                .WithOptional(e => e.categorie)
                .HasForeignKey(e => e.categorie_id_cat);

            modelBuilder.Entity<competence>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<competence>()
                .Property(e => e.niveau)
                .IsUnicode(false);

            modelBuilder.Entity<cv>()
                .Property(e => e.language)
                .IsUnicode(false);

            modelBuilder.Entity<cv>()
                .Property(e => e.nomCv)
                .IsUnicode(false);

            modelBuilder.Entity<cv>()
                .Property(e => e.project)
                .IsUnicode(false);

            modelBuilder.Entity<cv>()
                .Property(e => e.skills)
                .IsUnicode(false);

            modelBuilder.Entity<cv>()
                .HasMany(e => e.employees)
                .WithOptional(e => e.cv)
                .HasForeignKey(e => e.cv_id);

            modelBuilder.Entity<employee>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<employee>()
                .Property(e => e.nom)
                .IsUnicode(false);

            modelBuilder.Entity<employee>()
                .Property(e => e.password)
                .IsUnicode(false);

            modelBuilder.Entity<employee>()
                .Property(e => e.prenom)
                .IsUnicode(false);

            modelBuilder.Entity<employee>()
                .Property(e => e.role)
                .IsUnicode(false);

            modelBuilder.Entity<employee>()
                .Property(e => e.team)
                .IsUnicode(false);

            modelBuilder.Entity<employee>()
                .HasMany(e => e.activities)
                .WithOptional(e => e.employee)
                .HasForeignKey(e => e.employee_id);

            modelBuilder.Entity<employee>()
                .HasMany(e => e.evaluations)
                .WithOptional(e => e.employee)
                .HasForeignKey(e => e.employees_id);

            modelBuilder.Entity<employee>()
                .HasMany(e => e.timesheets)
                .WithOptional(e => e.employee)
                .HasForeignKey(e => e.employees_id);

            modelBuilder.Entity<employee>()
                .HasMany(e => e.categories)
                .WithMany(e => e.employees)
                .Map(m => m.ToTable("categorie_employee").MapLeftKey("employe_id"));

            modelBuilder.Entity<evaluation>()
                .Property(e => e.Question1)
                .IsUnicode(false);

            modelBuilder.Entity<evaluation>()
                .Property(e => e.Question2)
                .IsUnicode(false);

            modelBuilder.Entity<evaluation>()
                .Property(e => e.Question3)
                .IsUnicode(false);

            modelBuilder.Entity<evaluation>()
                .Property(e => e.Question4)
                .IsUnicode(false);

            modelBuilder.Entity<evaluation>()
                .Property(e => e.Question5)
                .IsUnicode(false);

            modelBuilder.Entity<evaluation>()
                .Property(e => e.Type_comptence)
                .IsUnicode(false);

            modelBuilder.Entity<evaluation>()
                .Property(e => e.note1)
                .IsUnicode(false);

            modelBuilder.Entity<evaluation>()
                .Property(e => e.note2)
                .IsUnicode(false);

            modelBuilder.Entity<evaluation>()
                .Property(e => e.note3)
                .IsUnicode(false);

            modelBuilder.Entity<evaluation>()
                .Property(e => e.note4)
                .IsUnicode(false);

            modelBuilder.Entity<evaluation>()
                .Property(e => e.note5)
                .IsUnicode(false);

            modelBuilder.Entity<note>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<note>()
                .Property(e => e.nom)
                .IsUnicode(false);

            modelBuilder.Entity<note>()
                .Property(e => e.password)
                .IsUnicode(false);

            modelBuilder.Entity<note>()
                .Property(e => e.prenom)
                .IsUnicode(false);

            modelBuilder.Entity<note>()
                .Property(e => e.role)
                .IsUnicode(false);

            modelBuilder.Entity<timesheet>()
                .Property(e => e.valid)
                .IsUnicode(false);
        }
    }
}
