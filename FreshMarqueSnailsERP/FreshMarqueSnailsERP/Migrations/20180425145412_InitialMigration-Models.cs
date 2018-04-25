using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace FreshMarqueSnailsERP.Migrations
{
    public partial class InitialMigrationModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DispatchRiders",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Company = table.Column<string>(nullable: false),
                    Contact = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Supervisor = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DispatchRiders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Comment = table.Column<string>(nullable: true),
                    Contact = table.Column<string>(nullable: false),
                    Cost = table.Column<decimal>(nullable: false),
                    CustomerName = table.Column<string>(maxLength: 50, nullable: false),
                    DeliveryDate = table.Column<DateTime>(nullable: false),
                    DeliveryStatus = table.Column<string>(maxLength: 50, nullable: false),
                    JumboSize = table.Column<int>(nullable: false),
                    JumboSizeQuantity = table.Column<int>(nullable: false),
                    LargeSize = table.Column<int>(nullable: false),
                    LargeSizeQuantity = table.Column<int>(nullable: false),
                    Location = table.Column<string>(maxLength: 50, nullable: false),
                    MediumSize = table.Column<int>(nullable: false),
                    MediumSizeQuantity = table.Column<int>(nullable: false),
                    OrderDate = table.Column<DateTime>(nullable: false),
                    PaymentMethod = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Retailers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Contact = table.Column<int>(nullable: false),
                    Location = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Type = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Retailers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RetailSupplies",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Comment = table.Column<string>(nullable: true),
                    Cost = table.Column<decimal>(nullable: false),
                    JumboSize = table.Column<int>(nullable: false),
                    JumboSizeQuantity = table.Column<int>(nullable: false),
                    LargeSize = table.Column<int>(nullable: false),
                    LargeSizeQuantity = table.Column<int>(nullable: false),
                    MediumSize = table.Column<int>(nullable: false),
                    MediumSizeQuantity = table.Column<int>(nullable: false),
                    SupplyDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RetailSupplies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SnailPurchases",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Comment = table.Column<string>(nullable: true),
                    Cost = table.Column<decimal>(nullable: false),
                    PurchaseDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SnailPurchases", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SnailSpecifications",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(nullable: false),
                    Height = table.Column<decimal>(nullable: false),
                    Size = table.Column<string>(nullable: false),
                    Width = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SnailSpecifications", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SnailTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Type = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SnailTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Suppliers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Contact = table.Column<int>(nullable: false),
                    LastSupply = table.Column<DateTime>(nullable: false),
                    Location = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Reliability = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suppliers", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DispatchRiders");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Retailers");

            migrationBuilder.DropTable(
                name: "RetailSupplies");

            migrationBuilder.DropTable(
                name: "SnailPurchases");

            migrationBuilder.DropTable(
                name: "SnailSpecifications");

            migrationBuilder.DropTable(
                name: "SnailTypes");

            migrationBuilder.DropTable(
                name: "Suppliers");
        }
    }
}
