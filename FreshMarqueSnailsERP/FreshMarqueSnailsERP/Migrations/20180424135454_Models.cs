using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace FreshMarqueSnailsERP.Migrations
{
    public partial class Models : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DispatchRiders",
                columns: table => new
                {
                    DispatchRiderId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Company = table.Column<string>(nullable: false),
                    Contact = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    OrderId = table.Column<int>(nullable: false),
                    Supervisor = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DispatchRiders", x => x.DispatchRiderId);
                });

            migrationBuilder.CreateTable(
                name: "Retailers",
                columns: table => new
                {
                    RetailerId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Contact = table.Column<int>(nullable: false),
                    Location = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Type = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Retailers", x => x.RetailerId);
                });

            migrationBuilder.CreateTable(
                name: "SnailPurchases",
                columns: table => new
                {
                    SnailPurchaseId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Comment = table.Column<string>(nullable: true),
                    Cost = table.Column<decimal>(nullable: false),
                    PurchaseDate = table.Column<DateTime>(nullable: false),
                    SupplierId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SnailPurchases", x => x.SnailPurchaseId);
                });

            migrationBuilder.CreateTable(
                name: "SnailSpecifications",
                columns: table => new
                {
                    SnailSpecificationId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(nullable: false),
                    Height = table.Column<decimal>(nullable: false),
                    Size = table.Column<string>(nullable: false),
                    SnailTypeId = table.Column<int>(nullable: false),
                    Width = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SnailSpecifications", x => x.SnailSpecificationId);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderId = table.Column<int>(nullable: false),
                    Comment = table.Column<string>(nullable: true),
                    Contact = table.Column<int>(nullable: false),
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
                    table.PrimaryKey("PK_Orders", x => x.OrderId);
                    table.ForeignKey(
                        name: "FK_Orders_DispatchRiders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "DispatchRiders",
                        principalColumn: "DispatchRiderId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RetailSupplies",
                columns: table => new
                {
                    RetailSupplyId = table.Column<int>(nullable: false),
                    Comment = table.Column<string>(nullable: true),
                    Cost = table.Column<decimal>(nullable: false),
                    JumboSize = table.Column<int>(nullable: false),
                    JumboSizeQuantity = table.Column<int>(nullable: false),
                    LargeSize = table.Column<int>(nullable: false),
                    LargeSizeQuantity = table.Column<int>(nullable: false),
                    MediumSize = table.Column<int>(nullable: false),
                    MediumSizeQuantity = table.Column<int>(nullable: false),
                    RetailerId = table.Column<int>(nullable: false),
                    SupplyDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RetailSupplies", x => x.RetailSupplyId);
                    table.ForeignKey(
                        name: "FK_RetailSupplies_Retailers_RetailSupplyId",
                        column: x => x.RetailSupplyId,
                        principalTable: "Retailers",
                        principalColumn: "RetailerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Suppliers",
                columns: table => new
                {
                    SupplierId = table.Column<int>(nullable: false),
                    Contact = table.Column<int>(nullable: false),
                    LastSupply = table.Column<DateTime>(nullable: false),
                    Location = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Reliability = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suppliers", x => x.SupplierId);
                    table.ForeignKey(
                        name: "FK_Suppliers_SnailPurchases_SupplierId",
                        column: x => x.SupplierId,
                        principalTable: "SnailPurchases",
                        principalColumn: "SnailPurchaseId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SnailTypes",
                columns: table => new
                {
                    SnailTypeId = table.Column<int>(nullable: false),
                    Type = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SnailTypes", x => x.SnailTypeId);
                    table.ForeignKey(
                        name: "FK_SnailTypes_SnailSpecifications_SnailTypeId",
                        column: x => x.SnailTypeId,
                        principalTable: "SnailSpecifications",
                        principalColumn: "SnailSpecificationId",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "RetailSupplies");

            migrationBuilder.DropTable(
                name: "SnailTypes");

            migrationBuilder.DropTable(
                name: "Suppliers");

            migrationBuilder.DropTable(
                name: "DispatchRiders");

            migrationBuilder.DropTable(
                name: "Retailers");

            migrationBuilder.DropTable(
                name: "SnailSpecifications");

            migrationBuilder.DropTable(
                name: "SnailPurchases");
        }
    }
}
