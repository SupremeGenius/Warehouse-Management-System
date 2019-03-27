﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WMS.Data;

namespace WMS.Migrations
{
    [DbContext(typeof(WarehouseDBContext))]
    partial class WarehouseDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.3-servicing-35854")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WMS.Data.Models.Client", b =>
                {
                    b.Property<int>("Client_Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("First_Name")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("Is_VIP")
                        .IsRequired();

                    b.Property<string>("Last_Name")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<decimal>("Spent_Money");

                    b.HasKey("Client_Id");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("WMS.Data.Models.Employee", b =>
                {
                    b.Property<int>("Employee_Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Age");

                    b.Property<string>("First_Name")
                        .IsRequired();

                    b.Property<string>("Last_Name")
                        .IsRequired();

                    b.Property<string>("Position")
                        .IsRequired();

                    b.Property<decimal>("Salary");

                    b.Property<int>("Years_Of_Service");

                    b.HasKey("Employee_Id");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("WMS.Data.Models.Item", b =>
                {
                    b.Property<int>("Item_Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Date_Added")
                        .IsRequired();

                    b.Property<string>("Expiration_Date");

                    b.Property<string>("Name_Of_Item")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<decimal>("Price");

                    b.Property<int>("Quantity");

                    b.Property<int>("Stored_By");

                    b.HasKey("Item_Id");

                    b.HasIndex("Stored_By");

                    b.ToTable("Items");
                });

            modelBuilder.Entity("WMS.Data.Models.Item", b =>
                {
                    b.HasOne("WMS.Data.Models.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("Stored_By")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
