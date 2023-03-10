// <auto-generated />
using System;
using Exercicio01.Infraestructure.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Exercicio01.Migrations
{
    [DbContext(typeof(MyContext))]
    partial class MyContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Exercicio01.Domain.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Created_at")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("users", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Created_at = new DateTime(2023, 2, 17, 18, 11, 28, 488, DateTimeKind.Local).AddTicks(1710),
                            Name = "Abner Da Silva De Moraes "
                        },
                        new
                        {
                            Id = 2,
                            Created_at = new DateTime(2023, 2, 17, 18, 11, 28, 488, DateTimeKind.Local).AddTicks(1724),
                            Name = "Adriana De Jesus Amorim"
                        },
                        new
                        {
                            Id = 3,
                            Created_at = new DateTime(2023, 2, 17, 18, 11, 28, 488, DateTimeKind.Local).AddTicks(1730),
                            Name = "Heitor Peres Trevisan Filho"
                        },
                        new
                        {
                            Id = 4,
                            Created_at = new DateTime(2023, 2, 17, 18, 11, 28, 488, DateTimeKind.Local).AddTicks(1731),
                            Name = "Klaus Kartanas Palhas"
                        },
                        new
                        {
                            Id = 5,
                            Created_at = new DateTime(2023, 2, 17, 18, 11, 28, 488, DateTimeKind.Local).AddTicks(1733),
                            Name = "Mary Hellen Oliveira Botelho"
                        },
                        new
                        {
                            Id = 6,
                            Created_at = new DateTime(2023, 2, 17, 18, 11, 28, 488, DateTimeKind.Local).AddTicks(1735),
                            Name = "Roberto Sidney Fahl De Oliveira"
                        },
                        new
                        {
                            Id = 7,
                            Created_at = new DateTime(2023, 2, 17, 18, 11, 28, 488, DateTimeKind.Local).AddTicks(1737),
                            Name = "Vanessa Cristina Lourenço Yasuhara"
                        },
                        new
                        {
                            Id = 8,
                            Created_at = new DateTime(2023, 2, 17, 18, 11, 28, 488, DateTimeKind.Local).AddTicks(1738),
                            Name = "Yngrid De Brito Oliveira"
                        },
                        new
                        {
                            Id = 9,
                            Created_at = new DateTime(2023, 2, 17, 18, 11, 28, 488, DateTimeKind.Local).AddTicks(1740),
                            Name = "Sérgio Rômulo Alves Dos Santos Júnior"
                        },
                        new
                        {
                            Id = 10,
                            Created_at = new DateTime(2023, 2, 17, 18, 11, 28, 488, DateTimeKind.Local).AddTicks(1741),
                            Name = "Wagner Moises Costa"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
