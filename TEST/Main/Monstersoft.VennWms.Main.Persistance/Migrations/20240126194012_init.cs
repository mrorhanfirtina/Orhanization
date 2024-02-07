using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Monstersoft.VennWms.Main.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AttributeInputTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AttributeInputTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Barcodes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Copy = table.Column<int>(type: "int", nullable: false),
                    Query = table.Column<string>(type: "NVARCHAR(MAX)", nullable: false),
                    Text = table.Column<string>(type: "NVARCHAR(MAX)", nullable: false),
                    DepositorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Barcodes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Buildings",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false),
                    Province = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    City = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Country = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    ZipCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Buildings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    TaxOffice = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    TaxNumber = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    FaxNumber = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ContainerUnits",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    FirstDigit = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    CountryCode = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false),
                    ProducerCode = table.Column<string>(type: "nvarchar(7)", maxLength: 7, nullable: false),
                    Counter = table.Column<string>(type: "nvarchar(7)", maxLength: 7, nullable: false),
                    DepositorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContainerUnits", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DepositorCompanies",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    TaxOffice = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    TaxNumber = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    FaxNumber = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DepositorCompanies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OperationClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OperationClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrderTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    IsCodeGenerate = table.Column<bool>(type: "bit", nullable: false),
                    Format = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    DepositorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Counter = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PoTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    IsCodeGenerate = table.Column<bool>(type: "bit", nullable: false),
                    Format = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Counter = table.Column<int>(type: "int", nullable: false),
                    DepositorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PoTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false),
                    AlternativeCode = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    DepositorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProgressStatuses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProgressStatuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ReceiptTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    IsCodeGenerate = table.Column<bool>(type: "bit", nullable: false),
                    Format = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Counter = table.Column<int>(type: "int", nullable: false),
                    DepositorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReceiptTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ReserveReasons",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    DepositorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsBlocked = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReserveReasons", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ReturnTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    DepositorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsCodeGenerate = table.Column<bool>(type: "bit", nullable: false),
                    Counter = table.Column<int>(type: "int", nullable: false),
                    Format = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReturnTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ShipmentTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    IsCodeGenerate = table.Column<bool>(type: "bit", nullable: false),
                    Format = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Counter = table.Column<int>(type: "int", nullable: false),
                    DepositorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShipmentTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Status",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Status", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TaskLists",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    DepositorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaskLists", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TransactionTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Format = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Counter = table.Column<int>(type: "int", nullable: false),
                    IsLogging = table.Column<bool>(type: "bit", nullable: false),
                    DepositorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransactionTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Units",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    DepositorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Units", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UnsuitReasons",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    DepositorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsBlocked = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnsuitReasons", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PasswordSalt = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    PasswordHash = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    LocalityId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    AuthenticatorType = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrderAttributes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    AttributeInputTypeId = table.Column<int>(type: "int", nullable: false),
                    IsNecessary = table.Column<bool>(type: "bit", nullable: false),
                    IsItemAttribte = table.Column<bool>(type: "bit", nullable: false),
                    DepositorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderAttributes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderAttributes_AttributeInputTypes_AttributeInputTypeId",
                        column: x => x.AttributeInputTypeId,
                        principalTable: "AttributeInputTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PoAttributes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    AttributeInputTypeId = table.Column<int>(type: "int", nullable: false),
                    DepositorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsNecessary = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PoAttributes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PoAttributes_AttributeInputTypes_AttributeInputTypeId",
                        column: x => x.AttributeInputTypeId,
                        principalTable: "AttributeInputTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductAttributes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    AttributeInputTypeId = table.Column<int>(type: "int", nullable: false),
                    IsNecessary = table.Column<bool>(type: "bit", nullable: false),
                    DepositorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductAttributes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductAttributes_AttributeInputTypes_AttributeInputTypeId",
                        column: x => x.AttributeInputTypeId,
                        principalTable: "AttributeInputTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ReceiptAttributes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    AttributeInputTypeId = table.Column<int>(type: "int", nullable: false),
                    DepositorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsNecessary = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReceiptAttributes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ReceiptAttributes_AttributeInputTypes_AttributeInputTypeId",
                        column: x => x.AttributeInputTypeId,
                        principalTable: "AttributeInputTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ReturnAttributes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    AttributeInputTypeId = table.Column<int>(type: "int", nullable: false),
                    DepositorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsNecessary = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReturnAttributes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ReturnAttributes_AttributeInputTypes_AttributeInputTypeId",
                        column: x => x.AttributeInputTypeId,
                        principalTable: "AttributeInputTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ShipmentAttributes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    AttributeInputTypeId = table.Column<int>(type: "int", nullable: false),
                    IsNecessary = table.Column<bool>(type: "bit", nullable: false),
                    DepositorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShipmentAttributes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShipmentAttributes_AttributeInputTypes_AttributeInputTypeId",
                        column: x => x.AttributeInputTypeId,
                        principalTable: "AttributeInputTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StockAttributes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    AttributeInputTypeId = table.Column<int>(type: "int", nullable: false),
                    DepositorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsNecessary = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StockAttributes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StockAttributes_AttributeInputTypes_AttributeInputTypeId",
                        column: x => x.AttributeInputTypeId,
                        principalTable: "AttributeInputTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BarcodeAreas",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BarcodeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    QueryField = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    TextField = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BarcodeAreas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BarcodeAreas_Barcodes_BarcodeId",
                        column: x => x.BarcodeId,
                        principalTable: "Barcodes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Printers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    BarcodeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PrinterAddress = table.Column<string>(type: "nvarchar(600)", maxLength: 600, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Printers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Printers_Barcodes_BarcodeId",
                        column: x => x.BarcodeId,
                        principalTable: "Barcodes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Receivers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false),
                    BuildingId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CustomerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Receivers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Receivers_Buildings_BuildingId",
                        column: x => x.BuildingId,
                        principalTable: "Buildings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Sites",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false),
                    BuildingId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sites", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sites_Buildings_BuildingId",
                        column: x => x.BuildingId,
                        principalTable: "Buildings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    BuildingId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DepositorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Customers_Buildings_BuildingId",
                        column: x => x.BuildingId,
                        principalTable: "Buildings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Customers_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Disturbitors",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    BuildingId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DepositorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Disturbitors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Disturbitors_Buildings_BuildingId",
                        column: x => x.BuildingId,
                        principalTable: "Buildings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Disturbitors_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Suppliers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    BuildingId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DepositorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suppliers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Suppliers_Buildings_BuildingId",
                        column: x => x.BuildingId,
                        principalTable: "Buildings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Suppliers_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StockContainers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Sscc = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    ContainerUnitId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ContainerUnitId1 = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StockContainers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StockContainers_ContainerUnits_ContainerUnitId1",
                        column: x => x.ContainerUnitId1,
                        principalTable: "ContainerUnits",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Depositors",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    BuildingId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DepositorCompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Depositors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Depositors_Buildings_BuildingId",
                        column: x => x.BuildingId,
                        principalTable: "Buildings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Depositors_DepositorCompanies_DepositorCompanyId",
                        column: x => x.DepositorCompanyId,
                        principalTable: "DepositorCompanies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmailAuthenticators",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ActivationKey = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsVerified = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmailAuthenticators", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmailAuthenticators_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OtpAuthenticators",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    SecretKey = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    IsVerified = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OtpAuthenticators", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OtpAuthenticators_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RefreshTokens",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    Token = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Expires = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedByIp = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Revoked = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RevokedByIp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReplacedByToken = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReasonRevoked = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RefreshTokens", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RefreshTokens_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserOperationClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    OperationClaimId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserOperationClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserOperationClaims_OperationClaims_OperationClaimId",
                        column: x => x.OperationClaimId,
                        principalTable: "OperationClaims",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserOperationClaims_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductAttributeValues",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductAttributeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductAttributeValues", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductAttributeValues_ProductAttributes_ProductAttributeId",
                        column: x => x.ProductAttributeId,
                        principalTable: "ProductAttributes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductAttributeValues_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StorageSystems",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    SiteId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StorageSystems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StorageSystems_Sites_SiteId",
                        column: x => x.SiteId,
                        principalTable: "Sites",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    DepositorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    InputDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExpectedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ActualDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CustomerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ReceiverId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OrderTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StatusId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Orders_OrderTypes_OrderTypeId",
                        column: x => x.OrderTypeId,
                        principalTable: "OrderTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Orders_Status_StatusId",
                        column: x => x.StatusId,
                        principalTable: "Status",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Returns",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    CustomerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StatusId = table.Column<int>(type: "int", nullable: false),
                    DepositorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ReturnTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    InputDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExpectedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ReceiveDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Returns", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Returns_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Returns_ReturnTypes_ReturnTypeId",
                        column: x => x.ReturnTypeId,
                        principalTable: "ReturnTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Branchs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false),
                    BuildingId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CustomerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DisturbitorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Branchs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Branchs_Buildings_BuildingId",
                        column: x => x.BuildingId,
                        principalTable: "Buildings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Branchs_Disturbitors_DisturbitorId",
                        column: x => x.DisturbitorId,
                        principalTable: "Disturbitors",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PurchaseOrders",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    SupplierId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DepositorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PoTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StatusId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchaseOrders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PurchaseOrders_PoTypes_PoTypeId",
                        column: x => x.PoTypeId,
                        principalTable: "PoTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PurchaseOrders_Suppliers_SupplierId",
                        column: x => x.SupplierId,
                        principalTable: "Suppliers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false),
                    StorageSystemId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Locations_StorageSystems_StorageSystemId",
                        column: x => x.StorageSystemId,
                        principalTable: "StorageSystems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderAttributeValues",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OrderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OrderAttributeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderAttributeValues", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderAttributeValues_OrderAttributes_OrderAttributeId",
                        column: x => x.OrderAttributeId,
                        principalTable: "OrderAttributes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderAttributeValues_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderItems",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OrderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Quantity = table.Column<decimal>(type: "DECIMAL(18,6)", nullable: false),
                    UnitId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderItems_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderItems_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderItems_Units_UnitId",
                        column: x => x.UnitId,
                        principalTable: "Units",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderMemos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OrderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Text = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    InputDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EditDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderMemos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderMemos_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderShipments",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    OrderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ShipmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastMoveDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ProgressStatusId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderShipments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderShipments_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderShipments_ProgressStatuses_ProgressStatusId",
                        column: x => x.ProgressStatusId,
                        principalTable: "ProgressStatuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ReturnAttributeValues",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ReturnId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ReturnAttributeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReturnAttributeValues", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ReturnAttributeValues_ReturnAttributes_ReturnAttributeId",
                        column: x => x.ReturnAttributeId,
                        principalTable: "ReturnAttributes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ReturnAttributeValues_Returns_ReturnId",
                        column: x => x.ReturnId,
                        principalTable: "Returns",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ReturnItems",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ReturnId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UnitId = table.Column<int>(type: "int", nullable: false),
                    ExpectedQuantity = table.Column<decimal>(type: "DECIMAL(18,6)", nullable: false),
                    ActualQuantity = table.Column<decimal>(type: "DECIMAL(18,6)", nullable: false),
                    StatusId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReturnItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ReturnItems_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ReturnItems_Returns_ReturnId",
                        column: x => x.ReturnId,
                        principalTable: "Returns",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ReturnItems_Units_UnitId",
                        column: x => x.UnitId,
                        principalTable: "Units",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ReturnMemos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ReturnId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Text = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    InputDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EditDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReturnMemos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ReturnMemos_Returns_ReturnId",
                        column: x => x.ReturnId,
                        principalTable: "Returns",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Shipments",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    DepositorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DistirbutorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BranchId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ShipmentTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    InputDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExpectedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ActualDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DisturbitorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shipments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Shipments_Branchs_BranchId",
                        column: x => x.BranchId,
                        principalTable: "Branchs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Shipments_Disturbitors_DisturbitorId",
                        column: x => x.DisturbitorId,
                        principalTable: "Disturbitors",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Shipments_ShipmentTypes_ShipmentTypeId",
                        column: x => x.ShipmentTypeId,
                        principalTable: "ShipmentTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PoAttributeValues",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PurchaseOrderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PoAttributeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PoAttributeValues", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PoAttributeValues_PoAttributes_PoAttributeId",
                        column: x => x.PoAttributeId,
                        principalTable: "PoAttributes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PoAttributeValues_PurchaseOrders_PurchaseOrderId",
                        column: x => x.PurchaseOrderId,
                        principalTable: "PurchaseOrders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PoMemos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PurchaseOrderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Text = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    InputDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EditDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PoMemos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PoMemos_PurchaseOrders_PurchaseOrderId",
                        column: x => x.PurchaseOrderId,
                        principalTable: "PurchaseOrders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Receipts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    DepositorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    InputDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExpectedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ReceiveDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PurchaseOrderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ReceiptTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StatusId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Receipts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Receipts_PurchaseOrders_PurchaseOrderId",
                        column: x => x.PurchaseOrderId,
                        principalTable: "PurchaseOrders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Receipts_ReceiptTypes_ReceiptTypeId",
                        column: x => x.ReceiptTypeId,
                        principalTable: "ReceiptTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderItemMemos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OrderItemId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Text = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    InputDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EditDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItemMemos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderItemMemos_OrderItems_OrderItemId",
                        column: x => x.OrderItemId,
                        principalTable: "OrderItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderItemStockAttrValues",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OrderItemId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StockAttributeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItemStockAttrValues", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderItemStockAttrValues_OrderItems_OrderItemId",
                        column: x => x.OrderItemId,
                        principalTable: "OrderItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderItemStockAttrValues_StockAttributes_StockAttributeId",
                        column: x => x.StockAttributeId,
                        principalTable: "StockAttributes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderShipItems",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OrderItemId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OrderShipmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProgressStatusId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Quantity = table.Column<decimal>(type: "DECIMAL(18,6)", nullable: false),
                    ProgressStatusId1 = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderShipItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderShipItems_OrderItems_OrderItemId",
                        column: x => x.OrderItemId,
                        principalTable: "OrderItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderShipItems_ProgressStatuses_ProgressStatusId1",
                        column: x => x.ProgressStatusId1,
                        principalTable: "ProgressStatuses",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ReturnItemMemos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ReturnItemId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Text = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    InputDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EditDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReturnItemMemos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ReturnItemMemos_ReturnItems_ReturnItemId",
                        column: x => x.ReturnItemId,
                        principalTable: "ReturnItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ReturnItmStockAttrValues",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ReturnItemId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StockAttributeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReturnItmStockAttrValues", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ReturnItmStockAttrValues_ReturnItems_ReturnItemId",
                        column: x => x.ReturnItemId,
                        principalTable: "ReturnItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ReturnItmStockAttrValues_StockAttributes_StockAttributeId",
                        column: x => x.StockAttributeId,
                        principalTable: "StockAttributes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ShipmentAttributeValues",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ShipmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ShipmentAttributeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShipmentAttributeValues", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShipmentAttributeValues_ShipmentAttributes_ShipmentAttributeId",
                        column: x => x.ShipmentAttributeId,
                        principalTable: "ShipmentAttributes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ShipmentAttributeValues_Shipments_ShipmentId",
                        column: x => x.ShipmentId,
                        principalTable: "Shipments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ShipmentMemos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ShipmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Text = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    InputDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EditDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShipmentMemos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShipmentMemos_Shipments_ShipmentId",
                        column: x => x.ShipmentId,
                        principalTable: "Shipments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ReceiptAttributeValues",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ReceiptId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ReceiptAttributeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReceiptAttributeValues", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ReceiptAttributeValues_ReceiptAttributes_ReceiptAttributeId",
                        column: x => x.ReceiptAttributeId,
                        principalTable: "ReceiptAttributes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ReceiptAttributeValues_Receipts_ReceiptId",
                        column: x => x.ReceiptId,
                        principalTable: "Receipts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ReceiptItems",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ReceiptId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UnitId = table.Column<int>(type: "int", nullable: false),
                    ExpectedQuantity = table.Column<decimal>(type: "DECIMAL(18,6)", nullable: false),
                    ActualQuantity = table.Column<decimal>(type: "DECIMAL(18,6)", nullable: false),
                    StatusId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReceiptItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ReceiptItems_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ReceiptItems_Receipts_ReceiptId",
                        column: x => x.ReceiptId,
                        principalTable: "Receipts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ReceiptItems_Units_UnitId",
                        column: x => x.UnitId,
                        principalTable: "Units",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ReceiptMemos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ReceiptId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Text = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    InputDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EditDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReceiptMemos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ReceiptMemos_Receipts_ReceiptId",
                        column: x => x.ReceiptId,
                        principalTable: "Receipts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Stocks",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StockContainerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DepositorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Quantity = table.Column<decimal>(type: "DECIMAL(18,6)", nullable: false),
                    FreeQuantity = table.Column<decimal>(type: "DECIMAL(18,6)", nullable: false),
                    LocationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UnitId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ReceiptId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ReturnId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UnitId1 = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stocks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Stocks_Locations_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Locations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Stocks_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Stocks_Receipts_ReceiptId",
                        column: x => x.ReceiptId,
                        principalTable: "Receipts",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Stocks_Returns_ReturnId",
                        column: x => x.ReturnId,
                        principalTable: "Returns",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Stocks_StockContainers_StockContainerId",
                        column: x => x.StockContainerId,
                        principalTable: "StockContainers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Stocks_Units_UnitId1",
                        column: x => x.UnitId1,
                        principalTable: "Units",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "OrderShipItemTasks",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OrderShipItemId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    WorkTaskId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Quantity = table.Column<decimal>(type: "DECIMAL(18,6)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderShipItemTasks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderShipItemTasks_OrderShipItems_OrderShipItemId",
                        column: x => x.OrderShipItemId,
                        principalTable: "OrderShipItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ReceiptItemMemos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ReceiptItemId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Text = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    InputDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EditDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReceiptItemMemos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ReceiptItemMemos_ReceiptItems_ReceiptItemId",
                        column: x => x.ReceiptItemId,
                        principalTable: "ReceiptItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ReceiptItmStockAttrValues",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ReceiptItemId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StockAttributeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false),
                    ReceiptId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReceiptItmStockAttrValues", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ReceiptItmStockAttrValues_ReceiptItems_ReceiptItemId",
                        column: x => x.ReceiptItemId,
                        principalTable: "ReceiptItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ReceiptItmStockAttrValues_Receipts_ReceiptId",
                        column: x => x.ReceiptId,
                        principalTable: "Receipts",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ReceiptItmStockAttrValues_StockAttributes_StockAttributeId",
                        column: x => x.StockAttributeId,
                        principalTable: "StockAttributes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StockAttributeValues",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StockId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StockAttributeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StockAttributeValues", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StockAttributeValues_StockAttributes_StockAttributeId",
                        column: x => x.StockAttributeId,
                        principalTable: "StockAttributes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StockAttributeValues_Stocks_StockId",
                        column: x => x.StockId,
                        principalTable: "Stocks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StockMemos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StockId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Text = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    InputDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EditDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StockMemos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StockMemos_Stocks_StockId",
                        column: x => x.StockId,
                        principalTable: "Stocks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StockReserveReasons",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StockId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ReserveReasonId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StockReserveReasons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StockReserveReasons_ReserveReasons_ReserveReasonId",
                        column: x => x.ReserveReasonId,
                        principalTable: "ReserveReasons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StockReserveReasons_Stocks_StockId",
                        column: x => x.StockId,
                        principalTable: "Stocks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StockUnsuitReason",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StockId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UnsuitReasonId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StockUnsuitReason", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StockUnsuitReason_Stocks_StockId",
                        column: x => x.StockId,
                        principalTable: "Stocks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StockUnsuitReason_UnsuitReasons_UnsuitReasonId",
                        column: x => x.UnsuitReasonId,
                        principalTable: "UnsuitReasons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TaskStocks",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    WorkTaskId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StockId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Quantity = table.Column<decimal>(type: "DECIMAL(18,6)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaskStocks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TaskStocks_Stocks_StockId",
                        column: x => x.StockId,
                        principalTable: "Stocks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WorkTasks",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    TaskListId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StockId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FromLocationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ToLocaitonId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StatusId = table.Column<int>(type: "int", nullable: false),
                    TransactionTypeId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<decimal>(type: "DECIMAL(18,6)", nullable: false),
                    DepositorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkTasks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WorkTasks_Status_StatusId",
                        column: x => x.StatusId,
                        principalTable: "Status",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WorkTasks_Stocks_StockId",
                        column: x => x.StockId,
                        principalTable: "Stocks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WorkTasks_TaskLists_TaskListId",
                        column: x => x.TaskListId,
                        principalTable: "TaskLists",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WorkTasks_TransactionTypes_TransactionTypeId",
                        column: x => x.TransactionTypeId,
                        principalTable: "TransactionTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderShipItemStocks",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OrderShipItemId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OrderShipItemTaskId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StockId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Quantity = table.Column<decimal>(type: "DECIMAL(18,6)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderShipItemStocks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderShipItemStocks_OrderShipItemTasks_OrderShipItemTaskId",
                        column: x => x.OrderShipItemTaskId,
                        principalTable: "OrderShipItemTasks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TransactionLogs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LogDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OrderId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ReturnId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ReceiptId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    WorkTaskId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DepositorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransactionLogs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TransactionLogs_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TransactionLogs_Receipts_ReceiptId",
                        column: x => x.ReceiptId,
                        principalTable: "Receipts",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TransactionLogs_Returns_ReturnId",
                        column: x => x.ReturnId,
                        principalTable: "Returns",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TransactionLogs_WorkTasks_WorkTaskId",
                        column: x => x.WorkTaskId,
                        principalTable: "WorkTasks",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "LogStocks",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TransactionLogId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StockId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FromLocaitonId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ToLocationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Quantity = table.Column<decimal>(type: "DECIMAL(18,6)", nullable: false),
                    TransactionTypeId = table.Column<int>(type: "int", nullable: false),
                    FromLocationId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LocationId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LogStocks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LogStocks_Locations_FromLocationId",
                        column: x => x.FromLocationId,
                        principalTable: "Locations",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_LogStocks_Locations_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Locations",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_LogStocks_Locations_ToLocationId",
                        column: x => x.ToLocationId,
                        principalTable: "Locations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LogStocks_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LogStocks_TransactionLogs_TransactionLogId",
                        column: x => x.TransactionLogId,
                        principalTable: "TransactionLogs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LogStocks_TransactionTypes_TransactionTypeId",
                        column: x => x.TransactionTypeId,
                        principalTable: "TransactionTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LogStockAttributeValues",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LogStockId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StockAttributeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FromValue = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    ToValue = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LogStockAttributeValues", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LogStockAttributeValues_LogStocks_LogStockId",
                        column: x => x.LogStockId,
                        principalTable: "LogStocks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LogStockAttributeValues_StockAttributes_StockAttributeId",
                        column: x => x.StockAttributeId,
                        principalTable: "StockAttributes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LogStockContainers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LogStockId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FromContainerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ToContainerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FromContainerSSCC = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    ToContainerSSCC = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LogStockContainers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LogStockContainers_LogStocks_LogStockId",
                        column: x => x.LogStockId,
                        principalTable: "LogStocks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LogStockReserveReasons",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LogStockId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FromReasaonId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ToReasaonId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    FromReasonId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ToReasonId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ReserveReasonId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LogStockReserveReasons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LogStockReserveReasons_LogStocks_LogStockId",
                        column: x => x.LogStockId,
                        principalTable: "LogStocks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LogStockReserveReasons_ReserveReasons_FromReasonId",
                        column: x => x.FromReasonId,
                        principalTable: "ReserveReasons",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_LogStockReserveReasons_ReserveReasons_ReserveReasonId",
                        column: x => x.ReserveReasonId,
                        principalTable: "ReserveReasons",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_LogStockReserveReasons_ReserveReasons_ToReasonId",
                        column: x => x.ToReasonId,
                        principalTable: "ReserveReasons",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "LogStockUnsuitReasons",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LogStockId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FromResaonId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ToResaonId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FromReasonId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UnsuitReasonId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LogStockUnsuitReasons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LogStockUnsuitReasons_LogStocks_LogStockId",
                        column: x => x.LogStockId,
                        principalTable: "LogStocks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LogStockUnsuitReasons_UnsuitReasons_FromReasonId",
                        column: x => x.FromReasonId,
                        principalTable: "UnsuitReasons",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_LogStockUnsuitReasons_UnsuitReasons_ToResaonId",
                        column: x => x.ToResaonId,
                        principalTable: "UnsuitReasons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LogStockUnsuitReasons_UnsuitReasons_UnsuitReasonId",
                        column: x => x.UnsuitReasonId,
                        principalTable: "UnsuitReasons",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "AttributeInputTypes",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "Description", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 1, 26, 22, 40, 12, 332, DateTimeKind.Local).AddTicks(1416), null, "Text", null },
                    { 2, new DateTime(2024, 1, 26, 22, 40, 12, 332, DateTimeKind.Local).AddTicks(1427), null, "Bool", null },
                    { 3, new DateTime(2024, 1, 26, 22, 40, 12, 332, DateTimeKind.Local).AddTicks(1429), null, "Numeric", null },
                    { 4, new DateTime(2024, 1, 26, 22, 40, 12, 332, DateTimeKind.Local).AddTicks(1431), null, "Date", null },
                    { 5, new DateTime(2024, 1, 26, 22, 40, 12, 332, DateTimeKind.Local).AddTicks(1433), null, "DateTime", null }
                });

            migrationBuilder.InsertData(
                table: "Buildings",
                columns: new[] { "Id", "Address", "City", "Code", "Country", "CreatedDate", "DeletedDate", "Description", "Province", "UpdatedDate", "ZipCode" },
                values: new object[] { new Guid("6b94bdfe-4158-4e98-816e-a3422816b2a3"), "Deri Org. San. Bolgesi No:26", "Istanbul", "MAIN", "Turkey", new DateTime(2024, 1, 26, 22, 40, 12, 332, DateTimeKind.Local).AddTicks(1613), null, "Main Factory", "Tuzla", null, "34953" });

            migrationBuilder.InsertData(
                table: "ContainerUnits",
                columns: new[] { "Id", "Code", "Counter", "CountryCode", "CreatedDate", "DeletedDate", "DepositorId", "Description", "FirstDigit", "ProducerCode", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "PAL", "101", "40", new DateTime(2024, 1, 26, 22, 40, 12, 332, DateTimeKind.Local).AddTicks(1687), null, new Guid("202d64f3-4474-4b55-b30d-61c430799efa"), "Pallet", "P", "1234567", null },
                    { 2, "EUR", "201", "40", new DateTime(2024, 1, 26, 22, 40, 12, 332, DateTimeKind.Local).AddTicks(1690), null, new Guid("202d64f3-4474-4b55-b30d-61c430799efa"), "Euro Pallet", "E", "1234567", null },
                    { 3, "PCK", "301", "40", new DateTime(2024, 1, 26, 22, 40, 12, 332, DateTimeKind.Local).AddTicks(1692), null, new Guid("202d64f3-4474-4b55-b30d-61c430799efa"), "Packing Pallet", "C", "1234567", null },
                    { 4, "AMR", "401", "40", new DateTime(2024, 1, 26, 22, 40, 12, 332, DateTimeKind.Local).AddTicks(1694), null, new Guid("202d64f3-4474-4b55-b30d-61c430799efa"), "American Pallet", "A", "1234567", null }
                });

            migrationBuilder.InsertData(
                table: "DepositorCompanies",
                columns: new[] { "Id", "Code", "CreatedDate", "DeletedDate", "Description", "FaxNumber", "Name", "PhoneNumber", "TaxNumber", "TaxOffice", "UpdatedDate" },
                values: new object[] { new Guid("dd4d5460-8146-4e62-ac19-a74d89955dd7"), "MAIN", new DateTime(2024, 1, 26, 22, 40, 12, 332, DateTimeKind.Local).AddTicks(1772), null, "Main Company", "123456789101", "Main Company LTD.", "905432044767", "123456789", "Istanbul Anadolu Kurumlar VD", null });

            migrationBuilder.InsertData(
                table: "OperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 1, 26, 22, 40, 12, 332, DateTimeKind.Local).AddTicks(1977), null, "Admin", null },
                    { 2, new DateTime(2024, 1, 26, 22, 40, 12, 332, DateTimeKind.Local).AddTicks(1978), null, "User", null },
                    { 3, new DateTime(2024, 1, 26, 22, 40, 12, 332, DateTimeKind.Local).AddTicks(1979), null, "Read", null },
                    { 4, new DateTime(2024, 1, 26, 22, 40, 12, 332, DateTimeKind.Local).AddTicks(1980), null, "Write", null },
                    { 5, new DateTime(2024, 1, 26, 22, 40, 12, 332, DateTimeKind.Local).AddTicks(1981), null, "Add", null },
                    { 6, new DateTime(2024, 1, 26, 22, 40, 12, 332, DateTimeKind.Local).AddTicks(1982), null, "Update", null },
                    { 7, new DateTime(2024, 1, 26, 22, 40, 12, 332, DateTimeKind.Local).AddTicks(1984), null, "Delete", null }
                });

            migrationBuilder.InsertData(
                table: "ProgressStatuses",
                columns: new[] { "Id", "Code", "CreatedDate", "DeletedDate", "Description", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "01", new DateTime(2024, 1, 26, 22, 40, 12, 332, DateTimeKind.Local).AddTicks(2054), null, "Pending", null },
                    { 2, "02", new DateTime(2024, 1, 26, 22, 40, 12, 332, DateTimeKind.Local).AddTicks(2056), null, "ToPick", null },
                    { 3, "03", new DateTime(2024, 1, 26, 22, 40, 12, 332, DateTimeKind.Local).AddTicks(2057), null, "InPick", null },
                    { 4, "04", new DateTime(2024, 1, 26, 22, 40, 12, 332, DateTimeKind.Local).AddTicks(2058), null, "Picked", null },
                    { 5, "05", new DateTime(2024, 1, 26, 22, 40, 12, 332, DateTimeKind.Local).AddTicks(2059), null, "InSorting", null },
                    { 6, "06", new DateTime(2024, 1, 26, 22, 40, 12, 332, DateTimeKind.Local).AddTicks(2061), null, "Sorted", null },
                    { 7, "07", new DateTime(2024, 1, 26, 22, 40, 12, 332, DateTimeKind.Local).AddTicks(2062), null, "InPacking", null },
                    { 8, "08", new DateTime(2024, 1, 26, 22, 40, 12, 332, DateTimeKind.Local).AddTicks(2063), null, "Packed", null },
                    { 9, "09", new DateTime(2024, 1, 26, 22, 40, 12, 332, DateTimeKind.Local).AddTicks(2064), null, "InLoading", null },
                    { 10, "10", new DateTime(2024, 1, 26, 22, 40, 12, 332, DateTimeKind.Local).AddTicks(2065), null, "Completed", null },
                    { 11, "11", new DateTime(2024, 1, 26, 22, 40, 12, 332, DateTimeKind.Local).AddTicks(2066), null, "Cancelled", null }
                });

            migrationBuilder.InsertData(
                table: "Status",
                columns: new[] { "Id", "Code", "CreatedDate", "DeletedDate", "Description", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "01", new DateTime(2024, 1, 26, 22, 40, 12, 332, DateTimeKind.Local).AddTicks(2143), null, "Pending", null },
                    { 2, "02", new DateTime(2024, 1, 26, 22, 40, 12, 332, DateTimeKind.Local).AddTicks(2145), null, "Executing", null },
                    { 3, "03", new DateTime(2024, 1, 26, 22, 40, 12, 332, DateTimeKind.Local).AddTicks(2146), null, "Completed", null },
                    { 4, "04", new DateTime(2024, 1, 26, 22, 40, 12, 332, DateTimeKind.Local).AddTicks(2147), null, "Cancelled", null }
                });

            migrationBuilder.InsertData(
                table: "Units",
                columns: new[] { "Id", "Code", "CreatedDate", "DeletedDate", "DepositorId", "Description", "UpdatedDate" },
                values: new object[] { 1, "EA", new DateTime(2024, 1, 26, 22, 40, 12, 332, DateTimeKind.Local).AddTicks(2223), null, new Guid("202d64f3-4474-4b55-b30d-61c430799efa"), "Adet", null });

            migrationBuilder.InsertData(
                table: "Depositors",
                columns: new[] { "Id", "BuildingId", "Code", "CreatedDate", "DeletedDate", "DepositorCompanyId", "UpdatedDate" },
                values: new object[] { new Guid("202d64f3-4474-4b55-b30d-61c430799efa"), new Guid("6b94bdfe-4158-4e98-816e-a3422816b2a3"), "MAIN", new DateTime(2024, 1, 26, 22, 40, 12, 332, DateTimeKind.Local).AddTicks(1846), null, new Guid("dd4d5460-8146-4e62-ac19-a74d89955dd7"), null });

            migrationBuilder.CreateIndex(
                name: "UK_AttributeInputTypes_Description",
                table: "AttributeInputTypes",
                column: "Description",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_BarcodeAreas_BarcodeId",
                table: "BarcodeAreas",
                column: "BarcodeId");

            migrationBuilder.CreateIndex(
                name: "IX_Branchs_BuildingId",
                table: "Branchs",
                column: "BuildingId");

            migrationBuilder.CreateIndex(
                name: "IX_Branchs_DisturbitorId",
                table: "Branchs",
                column: "DisturbitorId");

            migrationBuilder.CreateIndex(
                name: "UK_Branchs_Code",
                table: "Branchs",
                column: "Code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UK_Branchs_Name",
                table: "Branchs",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UK_Buildings_Code",
                table: "Buildings",
                column: "Code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UK_Buildings_Description",
                table: "Buildings",
                column: "Description",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UK_Companies_Code",
                table: "Companies",
                column: "Code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UK_Companies_Name",
                table: "Companies",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Customers_BuildingId",
                table: "Customers",
                column: "BuildingId");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_CompanyId",
                table: "Customers",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "UK_Customers_Code",
                table: "Customers",
                column: "Code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UK_DepositorCompanies_Code",
                table: "DepositorCompanies",
                column: "Code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UK_DepositorCompanies_Name",
                table: "DepositorCompanies",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Depositors_BuildingId",
                table: "Depositors",
                column: "BuildingId");

            migrationBuilder.CreateIndex(
                name: "IX_Depositors_DepositorCompanyId",
                table: "Depositors",
                column: "DepositorCompanyId");

            migrationBuilder.CreateIndex(
                name: "UK_Depositors_Code",
                table: "Depositors",
                column: "Code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Disturbitors_BuildingId",
                table: "Disturbitors",
                column: "BuildingId");

            migrationBuilder.CreateIndex(
                name: "IX_Disturbitors_CompanyId",
                table: "Disturbitors",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "UK_Disturbitors_Code",
                table: "Disturbitors",
                column: "Code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_EmailAuthenticators_UserId",
                table: "EmailAuthenticators",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Locations_StorageSystemId",
                table: "Locations",
                column: "StorageSystemId");

            migrationBuilder.CreateIndex(
                name: "UK_Locations_Code",
                table: "Locations",
                column: "Code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UK_Locations_Description",
                table: "Locations",
                column: "Description",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_LogStockAttributeValues_LogStockId",
                table: "LogStockAttributeValues",
                column: "LogStockId");

            migrationBuilder.CreateIndex(
                name: "IX_LogStockAttributeValues_StockAttributeId",
                table: "LogStockAttributeValues",
                column: "StockAttributeId");

            migrationBuilder.CreateIndex(
                name: "IX_LogStockContainers_LogStockId",
                table: "LogStockContainers",
                column: "LogStockId");

            migrationBuilder.CreateIndex(
                name: "IX_LogStockReserveReasons_FromReasonId",
                table: "LogStockReserveReasons",
                column: "FromReasonId");

            migrationBuilder.CreateIndex(
                name: "IX_LogStockReserveReasons_LogStockId",
                table: "LogStockReserveReasons",
                column: "LogStockId");

            migrationBuilder.CreateIndex(
                name: "IX_LogStockReserveReasons_ReserveReasonId",
                table: "LogStockReserveReasons",
                column: "ReserveReasonId");

            migrationBuilder.CreateIndex(
                name: "IX_LogStockReserveReasons_ToReasonId",
                table: "LogStockReserveReasons",
                column: "ToReasonId");

            migrationBuilder.CreateIndex(
                name: "IX_LogStocks_FromLocationId",
                table: "LogStocks",
                column: "FromLocationId");

            migrationBuilder.CreateIndex(
                name: "IX_LogStocks_LocationId",
                table: "LogStocks",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_LogStocks_ProductId",
                table: "LogStocks",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_LogStocks_ToLocationId",
                table: "LogStocks",
                column: "ToLocationId");

            migrationBuilder.CreateIndex(
                name: "IX_LogStocks_TransactionLogId",
                table: "LogStocks",
                column: "TransactionLogId");

            migrationBuilder.CreateIndex(
                name: "IX_LogStocks_TransactionTypeId",
                table: "LogStocks",
                column: "TransactionTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_LogStockUnsuitReasons_FromReasonId",
                table: "LogStockUnsuitReasons",
                column: "FromReasonId");

            migrationBuilder.CreateIndex(
                name: "IX_LogStockUnsuitReasons_LogStockId",
                table: "LogStockUnsuitReasons",
                column: "LogStockId");

            migrationBuilder.CreateIndex(
                name: "IX_LogStockUnsuitReasons_ToResaonId",
                table: "LogStockUnsuitReasons",
                column: "ToResaonId");

            migrationBuilder.CreateIndex(
                name: "IX_LogStockUnsuitReasons_UnsuitReasonId",
                table: "LogStockUnsuitReasons",
                column: "UnsuitReasonId");

            migrationBuilder.CreateIndex(
                name: "UK_OperationClaims_Name",
                table: "OperationClaims",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_OrderAttributes_AttributeInputTypeId",
                table: "OrderAttributes",
                column: "AttributeInputTypeId");

            migrationBuilder.CreateIndex(
                name: "UK_OrderAttributes_Code",
                table: "OrderAttributes",
                column: "Code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UK_OrderAttributes_Description",
                table: "OrderAttributes",
                column: "Description",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_OrderAttributeValues_OrderAttributeId",
                table: "OrderAttributeValues",
                column: "OrderAttributeId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderAttributeValues_OrderId",
                table: "OrderAttributeValues",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItemMemos_OrderItemId",
                table: "OrderItemMemos",
                column: "OrderItemId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_OrderId",
                table: "OrderItems",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_ProductId",
                table: "OrderItems",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_UnitId",
                table: "OrderItems",
                column: "UnitId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItemStockAttrValues_OrderItemId",
                table: "OrderItemStockAttrValues",
                column: "OrderItemId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItemStockAttrValues_StockAttributeId",
                table: "OrderItemStockAttrValues",
                column: "StockAttributeId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderMemos_OrderId",
                table: "OrderMemos",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CustomerId",
                table: "Orders",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_OrderTypeId",
                table: "Orders",
                column: "OrderTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_StatusId",
                table: "Orders",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "UK_Orders_Code",
                table: "Orders",
                column: "Code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_OrderShipItems_OrderItemId",
                table: "OrderShipItems",
                column: "OrderItemId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderShipItems_ProgressStatusId1",
                table: "OrderShipItems",
                column: "ProgressStatusId1");

            migrationBuilder.CreateIndex(
                name: "IX_OrderShipItemStocks_OrderShipItemTaskId",
                table: "OrderShipItemStocks",
                column: "OrderShipItemTaskId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderShipItemTasks_OrderShipItemId",
                table: "OrderShipItemTasks",
                column: "OrderShipItemId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderShipments_OrderId",
                table: "OrderShipments",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderShipments_ProgressStatusId",
                table: "OrderShipments",
                column: "ProgressStatusId");

            migrationBuilder.CreateIndex(
                name: "UK_OrderShipments_Code",
                table: "OrderShipments",
                column: "Code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UK_OrderTypes_Code",
                table: "OrderTypes",
                column: "Code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UK_OrderTypes_Description",
                table: "OrderTypes",
                column: "Description",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_OtpAuthenticators_UserId",
                table: "OtpAuthenticators",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_PoAttributes_AttributeInputTypeId",
                table: "PoAttributes",
                column: "AttributeInputTypeId");

            migrationBuilder.CreateIndex(
                name: "UK_PoAttributes_Code",
                table: "PoAttributes",
                column: "Code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UK_PoAttributes_Description",
                table: "PoAttributes",
                column: "Description",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PoAttributeValues_PoAttributeId",
                table: "PoAttributeValues",
                column: "PoAttributeId");

            migrationBuilder.CreateIndex(
                name: "IX_PoAttributeValues_PurchaseOrderId",
                table: "PoAttributeValues",
                column: "PurchaseOrderId");

            migrationBuilder.CreateIndex(
                name: "IX_PoMemos_PurchaseOrderId",
                table: "PoMemos",
                column: "PurchaseOrderId");

            migrationBuilder.CreateIndex(
                name: "UK_PoTypes_Code",
                table: "PoTypes",
                column: "Code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UK_PoTypes_Description",
                table: "PoTypes",
                column: "Description",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Printers_BarcodeId",
                table: "Printers",
                column: "BarcodeId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductAttributes_AttributeInputTypeId",
                table: "ProductAttributes",
                column: "AttributeInputTypeId");

            migrationBuilder.CreateIndex(
                name: "UK_ProductAttributes_Code",
                table: "ProductAttributes",
                column: "Code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UK_ProductAttributes_Description",
                table: "ProductAttributes",
                column: "Description",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProductAttributeValues_ProductAttributeId",
                table: "ProductAttributeValues",
                column: "ProductAttributeId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductAttributeValues_ProductId",
                table: "ProductAttributeValues",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "UK_ProgressStatuses_Code",
                table: "ProgressStatuses",
                column: "Code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UK_ProgressStatuses_Description",
                table: "ProgressStatuses",
                column: "Description",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseOrders_PoTypeId",
                table: "PurchaseOrders",
                column: "PoTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseOrders_SupplierId",
                table: "PurchaseOrders",
                column: "SupplierId");

            migrationBuilder.CreateIndex(
                name: "UK_PurchaseOrders_Code",
                table: "PurchaseOrders",
                column: "Code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ReceiptAttributes_AttributeInputTypeId",
                table: "ReceiptAttributes",
                column: "AttributeInputTypeId");

            migrationBuilder.CreateIndex(
                name: "UK_ReceiptAttributes_Code",
                table: "ReceiptAttributes",
                column: "Code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UK_ReceiptAttributes_Description",
                table: "ReceiptAttributes",
                column: "Description",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ReceiptAttributeValues_ReceiptAttributeId",
                table: "ReceiptAttributeValues",
                column: "ReceiptAttributeId");

            migrationBuilder.CreateIndex(
                name: "IX_ReceiptAttributeValues_ReceiptId",
                table: "ReceiptAttributeValues",
                column: "ReceiptId");

            migrationBuilder.CreateIndex(
                name: "IX_ReceiptItemMemos_ReceiptItemId",
                table: "ReceiptItemMemos",
                column: "ReceiptItemId");

            migrationBuilder.CreateIndex(
                name: "IX_ReceiptItems_ProductId",
                table: "ReceiptItems",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ReceiptItems_ReceiptId",
                table: "ReceiptItems",
                column: "ReceiptId");

            migrationBuilder.CreateIndex(
                name: "IX_ReceiptItems_UnitId",
                table: "ReceiptItems",
                column: "UnitId");

            migrationBuilder.CreateIndex(
                name: "IX_ReceiptItmStockAttrValues_ReceiptId",
                table: "ReceiptItmStockAttrValues",
                column: "ReceiptId");

            migrationBuilder.CreateIndex(
                name: "IX_ReceiptItmStockAttrValues_ReceiptItemId",
                table: "ReceiptItmStockAttrValues",
                column: "ReceiptItemId");

            migrationBuilder.CreateIndex(
                name: "IX_ReceiptItmStockAttrValues_StockAttributeId",
                table: "ReceiptItmStockAttrValues",
                column: "StockAttributeId");

            migrationBuilder.CreateIndex(
                name: "IX_ReceiptMemos_ReceiptId",
                table: "ReceiptMemos",
                column: "ReceiptId");

            migrationBuilder.CreateIndex(
                name: "IX_Receipts_PurchaseOrderId",
                table: "Receipts",
                column: "PurchaseOrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Receipts_ReceiptTypeId",
                table: "Receipts",
                column: "ReceiptTypeId");

            migrationBuilder.CreateIndex(
                name: "UK_Receipts_Code",
                table: "Receipts",
                column: "Code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UK_ReceiptTypes_Code",
                table: "ReceiptTypes",
                column: "Code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UK_ReceiptTypes_Description",
                table: "ReceiptTypes",
                column: "Description",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Receivers_BuildingId",
                table: "Receivers",
                column: "BuildingId");

            migrationBuilder.CreateIndex(
                name: "UK_Receivers_Code",
                table: "Receivers",
                column: "Code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UK_Receivers_Name",
                table: "Receivers",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_RefreshTokens_UserId",
                table: "RefreshTokens",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "UK_ReserveReasons_Code",
                table: "ReserveReasons",
                column: "Code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UK_ReserveReasons_Description",
                table: "ReserveReasons",
                column: "Description",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ReturnAttributes_AttributeInputTypeId",
                table: "ReturnAttributes",
                column: "AttributeInputTypeId");

            migrationBuilder.CreateIndex(
                name: "UK_ReturnAttributes_Code",
                table: "ReturnAttributes",
                column: "Code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UK_ReturnAttributes_Description",
                table: "ReturnAttributes",
                column: "Description",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ReturnAttributeValues_ReturnAttributeId",
                table: "ReturnAttributeValues",
                column: "ReturnAttributeId");

            migrationBuilder.CreateIndex(
                name: "IX_ReturnAttributeValues_ReturnId",
                table: "ReturnAttributeValues",
                column: "ReturnId");

            migrationBuilder.CreateIndex(
                name: "IX_ReturnItemMemos_ReturnItemId",
                table: "ReturnItemMemos",
                column: "ReturnItemId");

            migrationBuilder.CreateIndex(
                name: "IX_ReturnItems_ProductId",
                table: "ReturnItems",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ReturnItems_ReturnId",
                table: "ReturnItems",
                column: "ReturnId");

            migrationBuilder.CreateIndex(
                name: "IX_ReturnItems_UnitId",
                table: "ReturnItems",
                column: "UnitId");

            migrationBuilder.CreateIndex(
                name: "IX_ReturnItmStockAttrValues_ReturnItemId",
                table: "ReturnItmStockAttrValues",
                column: "ReturnItemId");

            migrationBuilder.CreateIndex(
                name: "IX_ReturnItmStockAttrValues_StockAttributeId",
                table: "ReturnItmStockAttrValues",
                column: "StockAttributeId");

            migrationBuilder.CreateIndex(
                name: "IX_ReturnMemos_ReturnId",
                table: "ReturnMemos",
                column: "ReturnId");

            migrationBuilder.CreateIndex(
                name: "IX_Returns_CustomerId",
                table: "Returns",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Returns_ReturnTypeId",
                table: "Returns",
                column: "ReturnTypeId");

            migrationBuilder.CreateIndex(
                name: "UK_Returns_Code",
                table: "Returns",
                column: "Code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UK_ReturnTypes_Code",
                table: "ReturnTypes",
                column: "Code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UK_ReturnTypes_Description",
                table: "ReturnTypes",
                column: "Description",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ShipmentAttributes_AttributeInputTypeId",
                table: "ShipmentAttributes",
                column: "AttributeInputTypeId");

            migrationBuilder.CreateIndex(
                name: "UK_ShipmentAttributes_Code",
                table: "ShipmentAttributes",
                column: "Code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UK_ShipmentAttributes_Description",
                table: "ShipmentAttributes",
                column: "Description",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ShipmentAttributeValues_ShipmentAttributeId",
                table: "ShipmentAttributeValues",
                column: "ShipmentAttributeId");

            migrationBuilder.CreateIndex(
                name: "IX_ShipmentAttributeValues_ShipmentId",
                table: "ShipmentAttributeValues",
                column: "ShipmentId");

            migrationBuilder.CreateIndex(
                name: "IX_ShipmentMemos_ShipmentId",
                table: "ShipmentMemos",
                column: "ShipmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Shipments_BranchId",
                table: "Shipments",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_Shipments_DisturbitorId",
                table: "Shipments",
                column: "DisturbitorId");

            migrationBuilder.CreateIndex(
                name: "IX_Shipments_ShipmentTypeId",
                table: "Shipments",
                column: "ShipmentTypeId");

            migrationBuilder.CreateIndex(
                name: "UK_Shipments_Code",
                table: "Shipments",
                column: "Code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UK_ShipmentTypes_Code",
                table: "ShipmentTypes",
                column: "Code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UK_ShipmentTypes_Description",
                table: "ShipmentTypes",
                column: "Description",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Sites_BuildingId",
                table: "Sites",
                column: "BuildingId");

            migrationBuilder.CreateIndex(
                name: "UK_Sites_Code",
                table: "Sites",
                column: "Code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UK_Sites_Description",
                table: "Sites",
                column: "Description",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UK_Status_Code",
                table: "Status",
                column: "Code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UK_Status_Description",
                table: "Status",
                column: "Description",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_StockAttributes_AttributeInputTypeId",
                table: "StockAttributes",
                column: "AttributeInputTypeId");

            migrationBuilder.CreateIndex(
                name: "UK_StockAttributes_Code",
                table: "StockAttributes",
                column: "Code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UK_StockAttributes_Description",
                table: "StockAttributes",
                column: "Description",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_StockAttributeValues_StockAttributeId",
                table: "StockAttributeValues",
                column: "StockAttributeId");

            migrationBuilder.CreateIndex(
                name: "IX_StockAttributeValues_StockId",
                table: "StockAttributeValues",
                column: "StockId");

            migrationBuilder.CreateIndex(
                name: "IX_StockContainers_ContainerUnitId1",
                table: "StockContainers",
                column: "ContainerUnitId1");

            migrationBuilder.CreateIndex(
                name: "IX_StockMemos_StockId",
                table: "StockMemos",
                column: "StockId");

            migrationBuilder.CreateIndex(
                name: "IX_StockReserveReasons_ReserveReasonId",
                table: "StockReserveReasons",
                column: "ReserveReasonId");

            migrationBuilder.CreateIndex(
                name: "IX_StockReserveReasons_StockId",
                table: "StockReserveReasons",
                column: "StockId");

            migrationBuilder.CreateIndex(
                name: "IX_Stocks_LocationId",
                table: "Stocks",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_Stocks_ProductId",
                table: "Stocks",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Stocks_ReceiptId",
                table: "Stocks",
                column: "ReceiptId");

            migrationBuilder.CreateIndex(
                name: "IX_Stocks_ReturnId",
                table: "Stocks",
                column: "ReturnId");

            migrationBuilder.CreateIndex(
                name: "IX_Stocks_StockContainerId",
                table: "Stocks",
                column: "StockContainerId");

            migrationBuilder.CreateIndex(
                name: "IX_Stocks_UnitId1",
                table: "Stocks",
                column: "UnitId1");

            migrationBuilder.CreateIndex(
                name: "IX_StockUnsuitReason_StockId",
                table: "StockUnsuitReason",
                column: "StockId");

            migrationBuilder.CreateIndex(
                name: "IX_StockUnsuitReason_UnsuitReasonId",
                table: "StockUnsuitReason",
                column: "UnsuitReasonId");

            migrationBuilder.CreateIndex(
                name: "IX_StorageSystems_SiteId",
                table: "StorageSystems",
                column: "SiteId");

            migrationBuilder.CreateIndex(
                name: "UK_StorageSystems_Code",
                table: "StorageSystems",
                column: "Code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UK_StorageSystems_Description",
                table: "StorageSystems",
                column: "Description",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Suppliers_BuildingId",
                table: "Suppliers",
                column: "BuildingId");

            migrationBuilder.CreateIndex(
                name: "IX_Suppliers_CompanyId",
                table: "Suppliers",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "UK_Suppliers_Code",
                table: "Suppliers",
                column: "Code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UK_TaskLists_Code",
                table: "TaskLists",
                column: "Code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TaskStocks_StockId",
                table: "TaskStocks",
                column: "StockId");

            migrationBuilder.CreateIndex(
                name: "IX_TransactionLogs_OrderId",
                table: "TransactionLogs",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_TransactionLogs_ReceiptId",
                table: "TransactionLogs",
                column: "ReceiptId");

            migrationBuilder.CreateIndex(
                name: "IX_TransactionLogs_ReturnId",
                table: "TransactionLogs",
                column: "ReturnId");

            migrationBuilder.CreateIndex(
                name: "IX_TransactionLogs_WorkTaskId",
                table: "TransactionLogs",
                column: "WorkTaskId");

            migrationBuilder.CreateIndex(
                name: "UK_TransactionTypes_Code",
                table: "TransactionTypes",
                column: "Code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UK_Units_Code",
                table: "Units",
                column: "Code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UK_Units_Description",
                table: "Units",
                column: "Description",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UK_UnsuitReasons_Code",
                table: "UnsuitReasons",
                column: "Code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UK_UnsuitReasons_Description",
                table: "UnsuitReasons",
                column: "Description",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserOperationClaims_OperationClaimId",
                table: "UserOperationClaims",
                column: "OperationClaimId");

            migrationBuilder.CreateIndex(
                name: "UK_UserOperationClaims_UserId_OperationClaimId",
                table: "UserOperationClaims",
                columns: new[] { "UserId", "OperationClaimId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UK_Users_Email",
                table: "Users",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_WorkTasks_StatusId",
                table: "WorkTasks",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkTasks_StockId",
                table: "WorkTasks",
                column: "StockId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkTasks_TaskListId",
                table: "WorkTasks",
                column: "TaskListId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkTasks_TransactionTypeId",
                table: "WorkTasks",
                column: "TransactionTypeId");

            migrationBuilder.CreateIndex(
                name: "UK_WorkTasks_Code",
                table: "WorkTasks",
                column: "Code",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BarcodeAreas");

            migrationBuilder.DropTable(
                name: "Depositors");

            migrationBuilder.DropTable(
                name: "EmailAuthenticators");

            migrationBuilder.DropTable(
                name: "LogStockAttributeValues");

            migrationBuilder.DropTable(
                name: "LogStockContainers");

            migrationBuilder.DropTable(
                name: "LogStockReserveReasons");

            migrationBuilder.DropTable(
                name: "LogStockUnsuitReasons");

            migrationBuilder.DropTable(
                name: "OrderAttributeValues");

            migrationBuilder.DropTable(
                name: "OrderItemMemos");

            migrationBuilder.DropTable(
                name: "OrderItemStockAttrValues");

            migrationBuilder.DropTable(
                name: "OrderMemos");

            migrationBuilder.DropTable(
                name: "OrderShipItemStocks");

            migrationBuilder.DropTable(
                name: "OrderShipments");

            migrationBuilder.DropTable(
                name: "OtpAuthenticators");

            migrationBuilder.DropTable(
                name: "PoAttributeValues");

            migrationBuilder.DropTable(
                name: "PoMemos");

            migrationBuilder.DropTable(
                name: "Printers");

            migrationBuilder.DropTable(
                name: "ProductAttributeValues");

            migrationBuilder.DropTable(
                name: "ReceiptAttributeValues");

            migrationBuilder.DropTable(
                name: "ReceiptItemMemos");

            migrationBuilder.DropTable(
                name: "ReceiptItmStockAttrValues");

            migrationBuilder.DropTable(
                name: "ReceiptMemos");

            migrationBuilder.DropTable(
                name: "Receivers");

            migrationBuilder.DropTable(
                name: "RefreshTokens");

            migrationBuilder.DropTable(
                name: "ReturnAttributeValues");

            migrationBuilder.DropTable(
                name: "ReturnItemMemos");

            migrationBuilder.DropTable(
                name: "ReturnItmStockAttrValues");

            migrationBuilder.DropTable(
                name: "ReturnMemos");

            migrationBuilder.DropTable(
                name: "ShipmentAttributeValues");

            migrationBuilder.DropTable(
                name: "ShipmentMemos");

            migrationBuilder.DropTable(
                name: "StockAttributeValues");

            migrationBuilder.DropTable(
                name: "StockMemos");

            migrationBuilder.DropTable(
                name: "StockReserveReasons");

            migrationBuilder.DropTable(
                name: "StockUnsuitReason");

            migrationBuilder.DropTable(
                name: "TaskStocks");

            migrationBuilder.DropTable(
                name: "UserOperationClaims");

            migrationBuilder.DropTable(
                name: "DepositorCompanies");

            migrationBuilder.DropTable(
                name: "LogStocks");

            migrationBuilder.DropTable(
                name: "OrderAttributes");

            migrationBuilder.DropTable(
                name: "OrderShipItemTasks");

            migrationBuilder.DropTable(
                name: "PoAttributes");

            migrationBuilder.DropTable(
                name: "Barcodes");

            migrationBuilder.DropTable(
                name: "ProductAttributes");

            migrationBuilder.DropTable(
                name: "ReceiptAttributes");

            migrationBuilder.DropTable(
                name: "ReceiptItems");

            migrationBuilder.DropTable(
                name: "ReturnAttributes");

            migrationBuilder.DropTable(
                name: "ReturnItems");

            migrationBuilder.DropTable(
                name: "ShipmentAttributes");

            migrationBuilder.DropTable(
                name: "Shipments");

            migrationBuilder.DropTable(
                name: "StockAttributes");

            migrationBuilder.DropTable(
                name: "ReserveReasons");

            migrationBuilder.DropTable(
                name: "UnsuitReasons");

            migrationBuilder.DropTable(
                name: "OperationClaims");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "TransactionLogs");

            migrationBuilder.DropTable(
                name: "OrderShipItems");

            migrationBuilder.DropTable(
                name: "Branchs");

            migrationBuilder.DropTable(
                name: "ShipmentTypes");

            migrationBuilder.DropTable(
                name: "AttributeInputTypes");

            migrationBuilder.DropTable(
                name: "WorkTasks");

            migrationBuilder.DropTable(
                name: "OrderItems");

            migrationBuilder.DropTable(
                name: "ProgressStatuses");

            migrationBuilder.DropTable(
                name: "Disturbitors");

            migrationBuilder.DropTable(
                name: "Stocks");

            migrationBuilder.DropTable(
                name: "TaskLists");

            migrationBuilder.DropTable(
                name: "TransactionTypes");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Locations");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Receipts");

            migrationBuilder.DropTable(
                name: "Returns");

            migrationBuilder.DropTable(
                name: "StockContainers");

            migrationBuilder.DropTable(
                name: "Units");

            migrationBuilder.DropTable(
                name: "OrderTypes");

            migrationBuilder.DropTable(
                name: "Status");

            migrationBuilder.DropTable(
                name: "StorageSystems");

            migrationBuilder.DropTable(
                name: "PurchaseOrders");

            migrationBuilder.DropTable(
                name: "ReceiptTypes");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "ReturnTypes");

            migrationBuilder.DropTable(
                name: "ContainerUnits");

            migrationBuilder.DropTable(
                name: "Sites");

            migrationBuilder.DropTable(
                name: "PoTypes");

            migrationBuilder.DropTable(
                name: "Suppliers");

            migrationBuilder.DropTable(
                name: "Buildings");

            migrationBuilder.DropTable(
                name: "Companies");
        }
    }
}
