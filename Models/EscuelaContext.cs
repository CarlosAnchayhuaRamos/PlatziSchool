using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using HolaMundoMVC.Models;

    public class EscuelaContext: DbContext
    {
        public DbSet<Escuela> Escuelass { get; set; }
        public DbSet<Asignatura> Asignaturass { get; set; }
        public DbSet<Alumno> Alumnoss { get; set; }
        public DbSet<Curso> Cursoss { get; set; }
        
        public EscuelaContext (DbContextOptions <EscuelaContext> options): base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder){
            base.OnModelCreating(modelBuilder);

            var escuela = new Escuela();
            escuela.AñoDeCreación=2005;
            escuela.UniqueId = "123";
            escuela.Nombre = "Platzi School";
            escuela.Pais = "Perù";
            escuela.Ciudad = "Lima";
            escuela.Dirección = "Jr. Los Jacintos 1334";
            escuela.TipoEscuela = TiposEscuela.Secundaria;

            modelBuilder.Entity<Escuela>().HasData(escuela);
            modelBuilder.Entity<Asignatura>().HasData(
                new Asignatura {
                Nombre = "Matemáticas",
                UniqueId = Guid.NewGuid ().ToString ()
                },
                new Asignatura {
                Nombre = "Educación Física",
                UniqueId = Guid.NewGuid ().ToString ()
                },
                new Asignatura {
                Nombre = "Castellano",
                UniqueId = Guid.NewGuid ().ToString ()
                },
                new Asignatura {
                Nombre = "Ciencias Naturales",
                UniqueId = Guid.NewGuid ().ToString ()
                },
                new Asignatura {
                Nombre = "Programacion",
                UniqueId = Guid.NewGuid ().ToString ()
                }
            );
        }
    }
