using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntities.Models;
using BusinessEntities.Contexts.Junction;

namespace DataLayer.Contexts
{
    public class DatabaseContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseSqlServer(@"Server=localhost\SQLEXPRESS;Database=OOSU2Lab2TestProject;Trusted_Connection=True; Integrated Security=True;MultipleActiveResultSets=true");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //AlumnProgram
            modelBuilder.Entity<AlumnProgram>()
                .HasKey(a => new { a.AlumnID, a.ProgramID });

            modelBuilder.Entity<AlumnProgram>()
                .HasOne(ap => ap.Alumn)
                .WithMany(a => a.AlumnPrograms)
                .HasForeignKey(ap => ap.AlumnID);

            modelBuilder.Entity<AlumnProgram>()
                .HasOne(ap => ap.Program)
                .WithMany(p => p.AlumnPrograms)
                .HasForeignKey(ap => ap.ProgramID);


            //AlumnKompetens
            modelBuilder.Entity<AlumnKompetens>()
                .HasKey(a => new { a.AlumnID, a.KompetensID });

            modelBuilder.Entity<AlumnKompetens>()
                .HasOne(ak => ak.Alumn)
                .WithMany(a => a.AlumnKompetenser)
                .HasForeignKey(ak => ak.AlumnID);

            modelBuilder.Entity<AlumnKompetens>()
                .HasOne(ak => ak.Kompetens)
                .WithMany(k => k.AlumnKompetenser)
                .HasForeignKey(ak => ak.KompetensID);

            //AlumnAktivitet
            modelBuilder.Entity<AlumnAktivitet>()
                .HasKey(i => new { i.AlumnID, i.AktivitetID });

            modelBuilder.Entity<AlumnAktivitet>()
                .HasOne(aa => aa.Alumn)
                .WithMany(i => i.AlumnAktiviteter)
                .HasForeignKey(aa => aa.AlumnID);

            modelBuilder.Entity<AlumnAktivitet>()
                .HasOne(pi => pi.Aktivitet)
                .WithMany(i => i.AlumnAktiviteter)
                .HasForeignKey(pi => pi.AktivitetID);

            //InformationsutskickAlumn
            modelBuilder.Entity<InformationsutskickAlumn>()
                .HasKey(a => new { a.AlumnID, a.InformationsutskickID });

            modelBuilder.Entity<InformationsutskickAlumn>()
                .HasOne(ia => ia.Alumn)
                .WithMany(i => i.InformationsutskickAlumn)
                .HasForeignKey(ia => ia.AlumnID);

            modelBuilder.Entity<InformationsutskickAlumn>()
                .HasOne(ia => ia.Informationsutskick)
                .WithMany(i => i.InformationsutskickAlumn)
                .HasForeignKey(ia => ia.InformationsutskickID);


            //PersonalInformationsutskick
            modelBuilder.Entity<PersonalInformationsutskick>()
                .HasKey(p => new { p.PersonalID, p.InformationsutskickID });

            modelBuilder.Entity<PersonalInformationsutskick>()
                .HasOne(pi => pi.Personal)
                .WithMany(i => i.PersonalInformationsutskick)
                .HasForeignKey(pi => pi.PersonalID);

            modelBuilder.Entity<PersonalInformationsutskick>()
                .HasOne(pi => pi.Informationsutskick)
                .WithMany(i => i.PersonalInformationsutskick)
                .HasForeignKey(pi => pi.InformationsutskickID);


            //InformationsutskickAktivitet
            modelBuilder.Entity<InformationsutskickAktivitet>()
                .HasKey(i => new { i.InformationsutskickID, i.AktivitetID });

            modelBuilder.Entity<InformationsutskickAktivitet>()
                .HasOne(ia => ia.Informationsutskick)
                .WithMany(i => i.InformationsutskickAktivitet)
                .HasForeignKey(ia => ia.InformationsutskickID);

            modelBuilder.Entity<InformationsutskickAktivitet>()
                .HasOne(pi => pi.Aktivitet)
                .WithMany(i => i.InformationsutskickAktivitet)
                .HasForeignKey(pi => pi.AktivitetID);

            base.OnModelCreating(modelBuilder);
        }


        public DbSet<Alumn> Alumner { get; set; }
        public DbSet<Program> Programs { get; set; }
        public DbSet<Personal> Personal { get; set; }
        public DbSet<AlumnProgram> AlumnPrograms { get; set; }
        public DbSet<Aktivitet> Aktiviteter { get; set; }
        public DbSet<Informationsutskick> Informationsutskick { get; set; }
        public DbSet<Kompetens> Kompetenser { get; set; }
        public DbSet<Program> Program { get; set; }
        public DbSet<AlumnKompetens> AlumnKompetens { get; set; }
        public DbSet<InformationsutskickAlumn> InformationsutskickAlumn { get; set; }
        public DbSet<PersonalInformationsutskick> PersonalInformationsutskick { get; set; }
        public DbSet<InformationsutskickAktivitet> InformationsutskickAktivitet { get; set; }

    }
}
