using Exercicio01.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01.Infraestructure.Context
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions<MyContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("users");
            modelBuilder.Entity<User>().HasData(new User(1, "Abner Da Silva De Moraes "),
                new User(2, "Adriana De Jesus Amorim"),
                new User(3, "Heitor Peres Trevisan Filho"),
                new User(4, "Klaus Kartanas Palhas"),
                new User(5, "Mary Hellen Oliveira Botelho"),
                new User(6, "Roberto Sidney Fahl De Oliveira"),
                new User(7, "Vanessa Cristina Lourenço Yasuhara"),
                new User(8, "Yngrid De Brito Oliveira"),
                new User(9, "Sérgio Rômulo Alves Dos Santos Júnior"),
                new User(10, "Wagner Moises Costa")
                );

            base.OnModelCreating(modelBuilder);
        }
    }
}
