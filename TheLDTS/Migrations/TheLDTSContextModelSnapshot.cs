// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TheLDTS.Data;

#nullable disable

namespace TheLDTS.Migrations
{
    [DbContext(typeof(TheLDTSContext))]
    partial class TheLDTSContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("TheLDTS.Models.Landlord", b =>
                {
                    b.Property<int>("LandlordId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LandlordId"), 1L, 1);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.HasKey("LandlordId");

                    b.ToTable("Landlord");
                });

            modelBuilder.Entity("TheLDTS.Models.Property", b =>
                {
                    b.Property<int>("PropertyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PropertyId"), 1L, 1);

                    b.Property<bool>("Available")
                        .HasColumnType("bit");

                    b.Property<DateTime>("CP12")
                        .HasColumnType("datetime2");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EICR")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("EPC")
                        .HasColumnType("datetime2");

                    b.Property<int>("HouseNumber")
                        .HasColumnType("int");

                    b.Property<int>("LandlordID")
                        .HasColumnType("int");

                    b.Property<DateTime>("LegionellaTest")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("PAT")
                        .HasColumnType("datetime2");

                    b.Property<int>("Rent")
                        .HasColumnType("int");

                    b.Property<string>("StreetName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");


                    b.HasKey("PropertyId");

                    b.HasIndex("LandlordID");

                    b.ToTable("Property");
                });

            modelBuilder.Entity("TheLDTS.Models.Property", b =>
                {
                    b.HasOne("TheLDTS.Models.Landlord", "Landlord")
                        .WithMany("Properties")
                        .HasForeignKey("LandlordID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Landlord");
                });

            modelBuilder.Entity("TheLDTS.Models.Landlord", b =>
                {
                    b.Navigation("Properties");
                });
#pragma warning restore 612, 618
        }
    }
}
