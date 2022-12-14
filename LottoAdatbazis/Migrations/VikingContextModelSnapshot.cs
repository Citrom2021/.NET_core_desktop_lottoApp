// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VikingAdatbazis;

namespace LottoAdatbazis.Migrations
{
    [DbContext(typeof(VikingContext))]
    partial class VikingContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.16")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("LottoAdatbazis.LottoSzam", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Szam1")
                        .HasColumnType("int");

                    b.Property<int>("Szam2")
                        .HasColumnType("int");

                    b.Property<int>("Szam3")
                        .HasColumnType("int");

                    b.Property<int>("Szam4")
                        .HasColumnType("int");

                    b.Property<int>("Szam5")
                        .HasColumnType("int");

                    b.Property<int>("Szam6")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("LottoSzamok");
                });
#pragma warning restore 612, 618
        }
    }
}
