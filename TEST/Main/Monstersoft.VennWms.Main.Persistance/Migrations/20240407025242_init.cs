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
                name: "Addresses",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false),
                    Province = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    City = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Country = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    AddressText = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    ZipCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Latitude = table.Column<decimal>(type: "DECIMAL(11,7)", nullable: true),
                    Longitude = table.Column<decimal>(type: "DECIMAL(11,7)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.Id);
                });

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
                name: "LocationCodeComponents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    TableName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    FieldName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    FieldCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LocationCodeComponents", x => x.Id);
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
                name: "PickingTypes",
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
                    table.PrimaryKey("PK_PickingTypes", x => x.Id);
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
                name: "TransactionLogs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LogDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OrderId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    OrderItemId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ReturnId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ReturnItemId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ReceiptId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ReceiptItemId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    WorkTaskId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DepositorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DepositorCompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransactionLogs", x => x.Id);
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
                    AddressId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DepositorCompanies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DepositorCompanies_Addresses_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Addresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LogStocks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LogStocks_TransactionLogs_TransactionLogId",
                        column: x => x.TransactionLogId,
                        principalTable: "TransactionLogs",
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
                name: "Barcodes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Copy = table.Column<int>(type: "int", nullable: false),
                    Query = table.Column<string>(type: "NVARCHAR(MAX)", nullable: false),
                    Text = table.Column<string>(type: "NVARCHAR(MAX)", nullable: false),
                    DepositorCompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Barcodes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Barcodes_DepositorCompanies_DepositorCompanyId",
                        column: x => x.DepositorCompanyId,
                        principalTable: "DepositorCompanies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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
                    AddressId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DepositorCompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Companies_Addresses_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Addresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Companies_DepositorCompanies_DepositorCompanyId",
                        column: x => x.DepositorCompanyId,
                        principalTable: "DepositorCompanies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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
                    DepositorCompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContainerUnits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ContainerUnits_DepositorCompanies_DepositorCompanyId",
                        column: x => x.DepositorCompanyId,
                        principalTable: "DepositorCompanies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Depositors",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    DepositorCompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Depositors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Depositors_DepositorCompanies_DepositorCompanyId",
                        column: x => x.DepositorCompanyId,
                        principalTable: "DepositorCompanies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "LockReasons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    DepositorCompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LockReasons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LockReasons_DepositorCompanies_DepositorCompanyId",
                        column: x => x.DepositorCompanyId,
                        principalTable: "DepositorCompanies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    DepositorCompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrderAttributes_DepositorCompanies_DepositorCompanyId",
                        column: x => x.DepositorCompanyId,
                        principalTable: "DepositorCompanies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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
                    DepositorCompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Counter = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderTypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderTypes_DepositorCompanies_DepositorCompanyId",
                        column: x => x.DepositorCompanyId,
                        principalTable: "DepositorCompanies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PoAttributes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    AttributeInputTypeId = table.Column<int>(type: "int", nullable: false),
                    DepositorCompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PoAttributes_DepositorCompanies_DepositorCompanyId",
                        column: x => x.DepositorCompanyId,
                        principalTable: "DepositorCompanies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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
                    DepositorCompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PoTypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PoTypes_DepositorCompanies_DepositorCompanyId",
                        column: x => x.DepositorCompanyId,
                        principalTable: "DepositorCompanies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Printers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    PrinterAddress = table.Column<string>(type: "nvarchar(600)", maxLength: 600, nullable: false),
                    DepositorCompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Printers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Printers_DepositorCompanies_DepositorCompanyId",
                        column: x => x.DepositorCompanyId,
                        principalTable: "DepositorCompanies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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
                    DepositorCompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProductAttributes_DepositorCompanies_DepositorCompanyId",
                        column: x => x.DepositorCompanyId,
                        principalTable: "DepositorCompanies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false),
                    AlternativeCode = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    DepositorCompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_DepositorCompanies_DepositorCompanyId",
                        column: x => x.DepositorCompanyId,
                        principalTable: "DepositorCompanies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ReceiptAttributes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    AttributeInputTypeId = table.Column<int>(type: "int", nullable: false),
                    DepositorCompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ReceiptAttributes_DepositorCompanies_DepositorCompanyId",
                        column: x => x.DepositorCompanyId,
                        principalTable: "DepositorCompanies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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
                    DepositorCompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReceiptTypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ReceiptTypes_DepositorCompanies_DepositorCompanyId",
                        column: x => x.DepositorCompanyId,
                        principalTable: "DepositorCompanies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ReserveReasons",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    DepositorCompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsBlocked = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReserveReasons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ReserveReasons_DepositorCompanies_DepositorCompanyId",
                        column: x => x.DepositorCompanyId,
                        principalTable: "DepositorCompanies",
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
                    DepositorCompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ReturnAttributes_DepositorCompanies_DepositorCompanyId",
                        column: x => x.DepositorCompanyId,
                        principalTable: "DepositorCompanies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ReturnTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    DepositorCompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                    table.ForeignKey(
                        name: "FK_ReturnTypes_DepositorCompanies_DepositorCompanyId",
                        column: x => x.DepositorCompanyId,
                        principalTable: "DepositorCompanies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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
                    DepositorCompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ShipmentAttributes_DepositorCompanies_DepositorCompanyId",
                        column: x => x.DepositorCompanyId,
                        principalTable: "DepositorCompanies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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
                    DepositorCompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShipmentTypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShipmentTypes_DepositorCompanies_DepositorCompanyId",
                        column: x => x.DepositorCompanyId,
                        principalTable: "DepositorCompanies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Sites",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false),
                    DepositorCompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sites", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sites_DepositorCompanies_DepositorCompanyId",
                        column: x => x.DepositorCompanyId,
                        principalTable: "DepositorCompanies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "StockAttributes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    AttributeInputTypeId = table.Column<int>(type: "int", nullable: false),
                    DepositorCompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StockAttributes_DepositorCompanies_DepositorCompanyId",
                        column: x => x.DepositorCompanyId,
                        principalTable: "DepositorCompanies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TransactionTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    IsLogging = table.Column<bool>(type: "bit", nullable: false),
                    DepositorCompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransactionTypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TransactionTypes_DepositorCompanies_DepositorCompanyId",
                        column: x => x.DepositorCompanyId,
                        principalTable: "DepositorCompanies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Units",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    DepositorCompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Units", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Units_DepositorCompanies_DepositorCompanyId",
                        column: x => x.DepositorCompanyId,
                        principalTable: "DepositorCompanies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UnsuitReasons",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    DepositorCompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsBlocked = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnsuitReasons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UnsuitReasons_DepositorCompanies_DepositorCompanyId",
                        column: x => x.DepositorCompanyId,
                        principalTable: "DepositorCompanies",
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
                    FromContainerTypeId = table.Column<int>(type: "int", nullable: false),
                    ToContainerTypeId = table.Column<int>(type: "int", nullable: false),
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
                });

            migrationBuilder.CreateTable(
                name: "LogStockUnsuitReasons",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LogStockId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FromReasonId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ToReasonId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    CompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DepositorCompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AddressId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Customers_Addresses_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Addresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Customers_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Customers_DepositorCompanies_DepositorCompanyId",
                        column: x => x.DepositorCompanyId,
                        principalTable: "DepositorCompanies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Distributors",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    CompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DepositorCompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AddressId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Distributors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Distributors_Addresses_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Addresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Distributors_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Distributors_DepositorCompanies_DepositorCompanyId",
                        column: x => x.DepositorCompanyId,
                        principalTable: "DepositorCompanies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Suppliers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    CompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AddressId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DepositorCompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suppliers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Suppliers_Addresses_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Addresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Suppliers_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Suppliers_DepositorCompanies_DepositorCompanyId",
                        column: x => x.DepositorCompanyId,
                        principalTable: "DepositorCompanies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "StockContainers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Sscc = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    ContainerUnitId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StockContainers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StockContainers_ContainerUnits_ContainerUnitId",
                        column: x => x.ContainerUnitId,
                        principalTable: "ContainerUnits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DepositorFeatures",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DepositorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GenerateSsccLed = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    OrderModifyLed = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    ForbidNewReceiptLineLed = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    AllowDuplicateBarcodeLed = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    ForceTaskStockLed = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    ForbidTransferReservedLed = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    ChangeStockWithTaskLed = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    ManualReceiptCompletionLed = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    ManualReturnCompletionLed = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DepositorFeatures", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DepositorFeatures_Depositors_DepositorId",
                        column: x => x.DepositorId,
                        principalTable: "Depositors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TaskLists",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    DepositorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DepositorCompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaskLists", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TaskLists_DepositorCompanies_DepositorCompanyId",
                        column: x => x.DepositorCompanyId,
                        principalTable: "DepositorCompanies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TaskLists_Depositors_DepositorId",
                        column: x => x.DepositorId,
                        principalTable: "Depositors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserDepositors",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DepositorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserDepositors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserDepositors_Depositors_DepositorId",
                        column: x => x.DepositorId,
                        principalTable: "Depositors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserDepositors_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BarcodePrinters",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BarcodeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PrinterId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BarcodePrinters", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BarcodePrinters_Barcodes_BarcodeId",
                        column: x => x.BarcodeId,
                        principalTable: "Barcodes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BarcodePrinters_Printers_PrinterId",
                        column: x => x.PrinterId,
                        principalTable: "Printers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProductAttributeValues_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductDepositors",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DepositorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductDepositors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductDepositors_Depositors_DepositorId",
                        column: x => x.DepositorId,
                        principalTable: "Depositors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProductDepositors_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    AddressText = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    ZipCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    SiteId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DepositorCompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Latitude = table.Column<decimal>(type: "DECIMAL(11,7)", nullable: true),
                    Longitude = table.Column<decimal>(type: "DECIMAL(11,7)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Buildings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Buildings_DepositorCompanies_DepositorCompanyId",
                        column: x => x.DepositorCompanyId,
                        principalTable: "DepositorCompanies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Buildings_Sites_SiteId",
                        column: x => x.SiteId,
                        principalTable: "Sites",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SiteDepositors",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SiteId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DepositorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SiteDepositors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SiteDepositors_Depositors_DepositorId",
                        column: x => x.DepositorId,
                        principalTable: "Depositors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SiteDepositors_Sites_SiteId",
                        column: x => x.SiteId,
                        principalTable: "Sites",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductStockAttributes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StockAttributeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsNecessary = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductStockAttributes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductStockAttributes_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductStockAttributes_StockAttributes_StockAttributeId",
                        column: x => x.StockAttributeId,
                        principalTable: "StockAttributes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TaskCodeFormats",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false),
                    TaskFormat = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    TaskCounter = table.Column<int>(type: "int", nullable: false),
                    TaskListFormat = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TaskListCounter = table.Column<int>(type: "int", maxLength: 20, nullable: false),
                    TransactionTypeId = table.Column<int>(type: "int", nullable: false),
                    DepositorCompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaskCodeFormats", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TaskCodeFormats_DepositorCompanies_DepositorCompanyId",
                        column: x => x.DepositorCompanyId,
                        principalTable: "DepositorCompanies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TaskCodeFormats_TransactionTypes_TransactionTypeId",
                        column: x => x.TransactionTypeId,
                        principalTable: "TransactionTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ItemUnits",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UnitId = table.Column<int>(type: "int", nullable: false),
                    IsCustomerUnit = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemUnits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemUnits_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ItemUnits_Units_UnitId",
                        column: x => x.UnitId,
                        principalTable: "Units",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Receivers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false),
                    CustomerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DepositorCompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AddressId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Receivers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Receivers_Addresses_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Addresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Receivers_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Receivers_DepositorCompanies_DepositorCompanyId",
                        column: x => x.DepositorCompanyId,
                        principalTable: "DepositorCompanies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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
                    DepositorCompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Returns_DepositorCompanies_DepositorCompanyId",
                        column: x => x.DepositorCompanyId,
                        principalTable: "DepositorCompanies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Returns_Depositors_DepositorId",
                        column: x => x.DepositorId,
                        principalTable: "Depositors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Returns_ReturnTypes_ReturnTypeId",
                        column: x => x.ReturnTypeId,
                        principalTable: "ReturnTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Returns_Status_StatusId",
                        column: x => x.StatusId,
                        principalTable: "Status",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Branches",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false),
                    DistributorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DepositorCompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AddressId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Branches", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Branches_Addresses_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Addresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Branches_DepositorCompanies_DepositorCompanyId",
                        column: x => x.DepositorCompanyId,
                        principalTable: "DepositorCompanies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Branches_Distributors_DistributorId",
                        column: x => x.DistributorId,
                        principalTable: "Distributors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PurchaseOrders",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    SupplierId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DepositorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DepositorCompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                        name: "FK_PurchaseOrders_DepositorCompanies_DepositorCompanyId",
                        column: x => x.DepositorCompanyId,
                        principalTable: "DepositorCompanies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PurchaseOrders_Depositors_DepositorId",
                        column: x => x.DepositorId,
                        principalTable: "Depositors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PurchaseOrders_PoTypes_PoTypeId",
                        column: x => x.PoTypeId,
                        principalTable: "PoTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PurchaseOrders_Status_StatusId",
                        column: x => x.StatusId,
                        principalTable: "Status",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PurchaseOrders_Suppliers_SupplierId",
                        column: x => x.SupplierId,
                        principalTable: "Suppliers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BuildingDimensions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BuildingId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LenghtUnitId = table.Column<int>(type: "int", nullable: false),
                    BuildingLevel = table.Column<int>(type: "int", nullable: true),
                    Width = table.Column<decimal>(type: "DECIMAL(18,6)", nullable: true),
                    Height = table.Column<decimal>(type: "DECIMAL(18,6)", nullable: true),
                    Length = table.Column<decimal>(type: "DECIMAL(18,6)", nullable: true),
                    VolumeUnitId = table.Column<int>(type: "int", nullable: false),
                    Volume = table.Column<decimal>(type: "DECIMAL(18,6)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BuildingDimensions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BuildingDimensions_Buildings_BuildingId",
                        column: x => x.BuildingId,
                        principalTable: "Buildings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BuildingDimensions_Units_LenghtUnitId",
                        column: x => x.LenghtUnitId,
                        principalTable: "Units",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BuildingDimensions_Units_VolumeUnitId",
                        column: x => x.VolumeUnitId,
                        principalTable: "Units",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "StorageSystems",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    BuildingId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DepositorCompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StorageSystems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StorageSystems_Buildings_BuildingId",
                        column: x => x.BuildingId,
                        principalTable: "Buildings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StorageSystems_DepositorCompanies_DepositorCompanyId",
                        column: x => x.DepositorCompanyId,
                        principalTable: "DepositorCompanies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Zones",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false),
                    BuildingId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DepositorCompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Zones_Buildings_BuildingId",
                        column: x => x.BuildingId,
                        principalTable: "Buildings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Zones_DepositorCompanies_DepositorCompanyId",
                        column: x => x.DepositorCompanyId,
                        principalTable: "DepositorCompanies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ItemPackTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ItemUnitId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Length = table.Column<decimal>(type: "decimal(18,6)", nullable: true),
                    Width = table.Column<decimal>(type: "decimal(18,6)", nullable: true),
                    Height = table.Column<decimal>(type: "decimal(18,6)", nullable: true),
                    LenghtUnitId = table.Column<int>(type: "int", nullable: false),
                    Volume = table.Column<decimal>(type: "decimal(18,6)", nullable: true),
                    VolumeUnitId = table.Column<int>(type: "int", nullable: false),
                    DeadWeight = table.Column<decimal>(type: "decimal(18,6)", nullable: true),
                    NetWeight = table.Column<decimal>(type: "decimal(18,6)", nullable: true),
                    WeightUnitId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemPackTypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemPackTypes_ItemUnits_ItemUnitId",
                        column: x => x.ItemUnitId,
                        principalTable: "ItemUnits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ItemPackTypes_Units_LenghtUnitId",
                        column: x => x.LenghtUnitId,
                        principalTable: "Units",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ItemPackTypes_Units_VolumeUnitId",
                        column: x => x.VolumeUnitId,
                        principalTable: "Units",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ItemPackTypes_Units_WeightUnitId",
                        column: x => x.WeightUnitId,
                        principalTable: "Units",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ItemUnitConversions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ReferenceItemUnitId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ConvertedItemUnitId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ConversionQuantity = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemUnitConversions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemUnitConversions_ItemUnits_ConvertedItemUnitId",
                        column: x => x.ConvertedItemUnitId,
                        principalTable: "ItemUnits",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ItemUnitConversions_ItemUnits_ReferenceItemUnitId",
                        column: x => x.ReferenceItemUnitId,
                        principalTable: "ItemUnits",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ProductBarcodes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ItemUnitId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BarcodeString = table.Column<string>(type: "nvarchar(140)", maxLength: 140, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductBarcodes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductBarcodes_ItemUnits_ItemUnitId",
                        column: x => x.ItemUnitId,
                        principalTable: "ItemUnits",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ProductBarcodes_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
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
                    DepositorCompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Orders_DepositorCompanies_DepositorCompanyId",
                        column: x => x.DepositorCompanyId,
                        principalTable: "DepositorCompanies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Orders_Depositors_DepositorId",
                        column: x => x.DepositorId,
                        principalTable: "Depositors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Orders_OrderTypes_OrderTypeId",
                        column: x => x.OrderTypeId,
                        principalTable: "OrderTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Orders_Receivers_ReceiverId",
                        column: x => x.ReceiverId,
                        principalTable: "Receivers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Orders_Status_StatusId",
                        column: x => x.StatusId,
                        principalTable: "Status",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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
                        onDelete: ReferentialAction.Restrict);
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
                    ItemUnitId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                        name: "FK_ReturnItems_ItemUnits_ItemUnitId",
                        column: x => x.ItemUnitId,
                        principalTable: "ItemUnits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ReturnItems_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ReturnItems_Returns_ReturnId",
                        column: x => x.ReturnId,
                        principalTable: "Returns",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ReturnItems_Status_StatusId",
                        column: x => x.StatusId,
                        principalTable: "Status",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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
                    DepositorCompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DistributorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BranchId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ShipmentTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    InputDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExpectedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ActualDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shipments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Shipments_Branches_BranchId",
                        column: x => x.BranchId,
                        principalTable: "Branches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Shipments_DepositorCompanies_DepositorCompanyId",
                        column: x => x.DepositorCompanyId,
                        principalTable: "DepositorCompanies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Shipments_Depositors_DepositorId",
                        column: x => x.DepositorId,
                        principalTable: "Depositors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Shipments_Distributors_DistributorId",
                        column: x => x.DistributorId,
                        principalTable: "Distributors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Shipments_ShipmentTypes_ShipmentTypeId",
                        column: x => x.ShipmentTypeId,
                        principalTable: "ShipmentTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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
                        onDelete: ReferentialAction.Restrict);
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
                    DepositorCompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    InputDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExpectedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ReceiveDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PurchaseOrderId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
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
                        name: "FK_Receipts_DepositorCompanies_DepositorCompanyId",
                        column: x => x.DepositorCompanyId,
                        principalTable: "DepositorCompanies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Receipts_Depositors_DepositorId",
                        column: x => x.DepositorId,
                        principalTable: "Depositors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Receipts_Status_StatusId",
                        column: x => x.StatusId,
                        principalTable: "Status",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false),
                    StorageSystemId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DepositorCompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Locations_DepositorCompanies_DepositorCompanyId",
                        column: x => x.DepositorCompanyId,
                        principalTable: "DepositorCompanies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Locations_StorageSystems_StorageSystemId",
                        column: x => x.StorageSystemId,
                        principalTable: "StorageSystems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BarcodeSuppliers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductBarcodeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SupplierId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DepositorCompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BarcodeSuppliers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BarcodeSuppliers_DepositorCompanies_DepositorCompanyId",
                        column: x => x.DepositorCompanyId,
                        principalTable: "DepositorCompanies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BarcodeSuppliers_ProductBarcodes_ProductBarcodeId",
                        column: x => x.ProductBarcodeId,
                        principalTable: "ProductBarcodes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BarcodeSuppliers_Suppliers_SupplierId",
                        column: x => x.SupplierId,
                        principalTable: "Suppliers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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
                        onDelete: ReferentialAction.Restrict);
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
                    ItemUnitId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                        onDelete: ReferentialAction.Restrict);
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
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OrderShipments",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    OrderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ShipmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DepositorCompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                        name: "FK_OrderShipments_DepositorCompanies_DepositorCompanyId",
                        column: x => x.DepositorCompanyId,
                        principalTable: "DepositorCompanies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrderShipments_Shipments_ShipmentId",
                        column: x => x.ShipmentId,
                        principalTable: "Shipments",
                        principalColumn: "Id");
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
                        onDelete: ReferentialAction.Restrict);
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
                        onDelete: ReferentialAction.Restrict);
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
                    ItemUnitId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                        name: "FK_ReceiptItems_ItemUnits_ItemUnitId",
                        column: x => x.ItemUnitId,
                        principalTable: "ItemUnits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ReceiptItems_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ReceiptItems_Receipts_ReceiptId",
                        column: x => x.ReceiptId,
                        principalTable: "Receipts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ReceiptItems_Status_StatusId",
                        column: x => x.StatusId,
                        principalTable: "Status",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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
                name: "LocationCodeFormats",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LocationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Sector = table.Column<int>(type: "int", nullable: false),
                    SectorCode = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Column = table.Column<int>(type: "int", nullable: false),
                    ColumnCode = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Level = table.Column<int>(type: "int", nullable: false),
                    LevelCode = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Side = table.Column<int>(type: "int", nullable: false),
                    SideCode = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    SubLevel = table.Column<int>(type: "int", nullable: false),
                    SubLevelCode = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    SubColumn = table.Column<int>(type: "int", nullable: false),
                    SubColumnCode = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    SubPositionCode = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LocationCodeFormats", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LocationCodeFormats_Locations_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Locations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LocationCoordinates",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LocationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BuildingId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LocationX = table.Column<decimal>(type: "DECIMAL(18,6)", nullable: false),
                    LocationY = table.Column<decimal>(type: "DECIMAL(18,6)", nullable: false),
                    LocationZ = table.Column<decimal>(type: "DECIMAL(18,6)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LocationCoordinates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LocationCoordinates_Buildings_BuildingId",
                        column: x => x.BuildingId,
                        principalTable: "Buildings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LocationCoordinates_Locations_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Locations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LocationDepositors",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LocationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DepositorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsForbid = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LocationDepositors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LocationDepositors_Depositors_DepositorId",
                        column: x => x.DepositorId,
                        principalTable: "Depositors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LocationDepositors_Locations_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Locations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LocationDimensions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LocationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Width = table.Column<decimal>(type: "DECIMAL(18,6)", nullable: true),
                    Height = table.Column<decimal>(type: "DECIMAL(18,6)", nullable: true),
                    Length = table.Column<decimal>(type: "DECIMAL(18,6)", nullable: true),
                    LengthUnitId = table.Column<int>(type: "int", nullable: true),
                    Volume = table.Column<decimal>(type: "DECIMAL(18,6)", nullable: true),
                    VolumeUnitId = table.Column<int>(type: "int", nullable: true),
                    MaxWeight = table.Column<decimal>(type: "DECIMAL(18,6)", nullable: true),
                    WeightUnitId = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LocationDimensions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LocationDimensions_Locations_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Locations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LocationDimensions_Units_LengthUnitId",
                        column: x => x.LengthUnitId,
                        principalTable: "Units",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LocationDimensions_Units_VolumeUnitId",
                        column: x => x.VolumeUnitId,
                        principalTable: "Units",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LocationDimensions_Units_WeightUnitId",
                        column: x => x.WeightUnitId,
                        principalTable: "Units",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "LocationFeatures",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LocationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StockControlLed = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    ReceivingLed = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    SendingLed = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    DamagedLed = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    ReturnsLed = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    PackingLed = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    SortingLed = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    PickingLed = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    RepackingLed = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    ReplenishSourceLed = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    ReplenishTargetLed = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    NoStockMergeLed = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    SingleProductLed = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    SinglePackTypeLed = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LocationFeatures", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LocationFeatures_Locations_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Locations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LocationLockReasons",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LocationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LockReasonId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LocationLockReasons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LocationLockReasons_Locations_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Locations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LocationLockReasons_LockReasons_LockReasonId",
                        column: x => x.LockReasonId,
                        principalTable: "LockReasons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "LocationPickingTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LocationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PickingTypeId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LocationPickingTypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LocationPickingTypes_Locations_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Locations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LocationPickingTypes_PickingTypes_PickingTypeId",
                        column: x => x.PickingTypeId,
                        principalTable: "PickingTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "LocationPriorities",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LocationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    InboundPriority = table.Column<int>(type: "int", nullable: false),
                    OutboundPriority = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LocationPriorities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LocationPriorities_Locations_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Locations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LocationProductAttributes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LocationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductAttributeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    IsForbid = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LocationProductAttributes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LocationProductAttributes_Locations_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Locations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LocationProductAttributes_ProductAttributes_ProductAttributeId",
                        column: x => x.ProductAttributeId,
                        principalTable: "ProductAttributes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "LocationProductConstraints",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LocationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UnitId = table.Column<int>(type: "int", nullable: false),
                    Capacity = table.Column<decimal>(type: "DECIMAL(18,6)", nullable: false),
                    ReplenishmentTreshold = table.Column<decimal>(type: "DECIMAL(6,3)", nullable: false),
                    ExceedCapacityMargin = table.Column<decimal>(type: "DECIMAL(6,3)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LocationProductConstraints", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LocationProductConstraints_Locations_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Locations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LocationProductConstraints_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LocationProductConstraints_Units_UnitId",
                        column: x => x.UnitId,
                        principalTable: "Units",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "LocationProducts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LocationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsForbid = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LocationProducts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LocationProducts_Locations_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Locations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LocationProducts_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "LocationStockAttributes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LocationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StockAttributeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    IsForbid = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LocationStockAttributes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LocationStockAttributes_Locations_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Locations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LocationStockAttributes_StockAttributes_StockAttributeId",
                        column: x => x.StockAttributeId,
                        principalTable: "StockAttributes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "LocationUnitConstraints",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LocationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UnitId = table.Column<int>(type: "int", nullable: false),
                    Capacity = table.Column<decimal>(type: "DECIMAL(18,6)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LocationUnitConstraints", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LocationUnitConstraints_Locations_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Locations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LocationUnitConstraints_Units_UnitId",
                        column: x => x.UnitId,
                        principalTable: "Units",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "LocationZones",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LocationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ZoneId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LocationZones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LocationZones_Locations_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Locations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LocationZones_Zones_ZoneId",
                        column: x => x.ZoneId,
                        principalTable: "Zones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Stocks",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StockContainerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DepositorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DepositorCompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Quantity = table.Column<decimal>(type: "DECIMAL(18,6)", nullable: false),
                    FreeQuantity = table.Column<decimal>(type: "DECIMAL(18,6)", nullable: false),
                    LocationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UnitId = table.Column<int>(type: "int", nullable: false),
                    ReceiptId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ReturnId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stocks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Stocks_DepositorCompanies_DepositorCompanyId",
                        column: x => x.DepositorCompanyId,
                        principalTable: "DepositorCompanies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Stocks_Depositors_DepositorId",
                        column: x => x.DepositorId,
                        principalTable: "Depositors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Stocks_Locations_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Locations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Stocks_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Stocks_Units_UnitId",
                        column: x => x.UnitId,
                        principalTable: "Units",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OrderShipItems",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OrderItemId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OrderShipmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProgressStatusId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<decimal>(type: "DECIMAL(18,6)", nullable: false),
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
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_OrderShipItems_OrderShipments_OrderShipmentId",
                        column: x => x.OrderShipmentId,
                        principalTable: "OrderShipments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderShipItems_ProgressStatuses_ProgressStatusId",
                        column: x => x.ProgressStatusId,
                        principalTable: "ProgressStatuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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
                        name: "FK_ReceiptItmStockAttrValues_StockAttributes_StockAttributeId",
                        column: x => x.StockAttributeId,
                        principalTable: "StockAttributes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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
                        onDelete: ReferentialAction.Restrict);
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
                name: "StockPackTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StockId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ItemUnitId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Quantity = table.Column<decimal>(type: "DECIMAL(18,6)", nullable: false),
                    QuantityFree = table.Column<decimal>(type: "DECIMAL(18,6)", nullable: false),
                    PackTypeRatio = table.Column<decimal>(type: "DECIMAL(18,6)", nullable: false),
                    CUQuantity = table.Column<decimal>(type: "DECIMAL(18,6)", nullable: false),
                    CUQuantityFree = table.Column<decimal>(type: "DECIMAL(18,6)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StockPackTypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StockPackTypes_ItemUnits_ItemUnitId",
                        column: x => x.ItemUnitId,
                        principalTable: "ItemUnits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StockPackTypes_Stocks_StockId",
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
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StockReserveReasons_Stocks_StockId",
                        column: x => x.StockId,
                        principalTable: "Stocks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StockUnsuitReasons",
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
                    table.PrimaryKey("PK_StockUnsuitReasons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StockUnsuitReasons_Stocks_StockId",
                        column: x => x.StockId,
                        principalTable: "Stocks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StockUnsuitReasons_UnsuitReasons_UnsuitReasonId",
                        column: x => x.UnsuitReasonId,
                        principalTable: "UnsuitReasons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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
                    ToLocationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StatusId = table.Column<int>(type: "int", nullable: false),
                    TransactionTypeId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<decimal>(type: "DECIMAL(18,6)", nullable: false),
                    DepositorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DepositorCompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkTasks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WorkTasks_DepositorCompanies_DepositorCompanyId",
                        column: x => x.DepositorCompanyId,
                        principalTable: "DepositorCompanies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WorkTasks_Depositors_DepositorId",
                        column: x => x.DepositorId,
                        principalTable: "Depositors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WorkTasks_Locations_FromLocationId",
                        column: x => x.FromLocationId,
                        principalTable: "Locations",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_WorkTasks_Locations_ToLocationId",
                        column: x => x.ToLocationId,
                        principalTable: "Locations",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_WorkTasks_Status_StatusId",
                        column: x => x.StatusId,
                        principalTable: "Status",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_WorkTasks_Stocks_StockId",
                        column: x => x.StockId,
                        principalTable: "Stocks",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_WorkTasks_TaskLists_TaskListId",
                        column: x => x.TaskListId,
                        principalTable: "TaskLists",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_WorkTasks_TransactionTypes_TransactionTypeId",
                        column: x => x.TransactionTypeId,
                        principalTable: "TransactionTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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
                    table.ForeignKey(
                        name: "FK_OrderShipItemTasks_WorkTasks_WorkTaskId",
                        column: x => x.WorkTaskId,
                        principalTable: "WorkTasks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TaskStocks_WorkTasks_WorkTaskId",
                        column: x => x.WorkTaskId,
                        principalTable: "WorkTasks",
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
                    StockPackTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                    table.ForeignKey(
                        name: "FK_OrderShipItemStocks_StockPackTypes_StockPackTypeId",
                        column: x => x.StockPackTypeId,
                        principalTable: "StockPackTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrderShipItemStocks_Stocks_StockId",
                        column: x => x.StockId,
                        principalTable: "Stocks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "AddressText", "City", "Country", "CreatedDate", "DeletedDate", "Description", "Latitude", "Longitude", "Province", "UpdatedDate", "ZipCode" },
                values: new object[] { new Guid("1224c606-3856-4a03-bb00-ed897ce47098"), "Istanbul", "Istanbul", "Turkey", new DateTime(2024, 4, 7, 5, 52, 41, 811, DateTimeKind.Local).AddTicks(3475), null, "Kadikoy Main", null, null, "Kadikoy", null, "34710" });

            migrationBuilder.InsertData(
                table: "AttributeInputTypes",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "Description", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 4, 7, 5, 52, 41, 811, DateTimeKind.Local).AddTicks(3674), null, "Text", null },
                    { 2, new DateTime(2024, 4, 7, 5, 52, 41, 811, DateTimeKind.Local).AddTicks(3677), null, "Bool", null },
                    { 3, new DateTime(2024, 4, 7, 5, 52, 41, 811, DateTimeKind.Local).AddTicks(3678), null, "Numeric", null },
                    { 4, new DateTime(2024, 4, 7, 5, 52, 41, 811, DateTimeKind.Local).AddTicks(3679), null, "Date", null },
                    { 5, new DateTime(2024, 4, 7, 5, 52, 41, 811, DateTimeKind.Local).AddTicks(3680), null, "DateTime", null }
                });

            migrationBuilder.InsertData(
                table: "LocationCodeComponents",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "Description", "FieldCode", "FieldName", "TableName", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 4, 7, 5, 52, 41, 811, DateTimeKind.Local).AddTicks(4453), null, "StorageSystem", "{SS}", "Code", "StorageSystems", null },
                    { 2, new DateTime(2024, 4, 7, 5, 52, 41, 811, DateTimeKind.Local).AddTicks(4455), null, "Building", "{BLD}", "Code", "Buildings", null },
                    { 3, new DateTime(2024, 4, 7, 5, 52, 41, 811, DateTimeKind.Local).AddTicks(4457), null, "Sector", "{SEC}", "Code", "Sectors", null },
                    { 4, new DateTime(2024, 4, 7, 5, 52, 41, 811, DateTimeKind.Local).AddTicks(4459), null, "Column", "{COL}", "ColumnCode", "LocationCodeFormat", null },
                    { 5, new DateTime(2024, 4, 7, 5, 52, 41, 811, DateTimeKind.Local).AddTicks(4460), null, "Level", "{LEV}", "LevelCode", "LocationCodeFormat", null },
                    { 6, new DateTime(2024, 4, 7, 5, 52, 41, 811, DateTimeKind.Local).AddTicks(4461), null, "SubColumn", "{SUBCOL}", "SubColumnCode", "LocationCodeFormat", null },
                    { 7, new DateTime(2024, 4, 7, 5, 52, 41, 811, DateTimeKind.Local).AddTicks(4463), null, "SubLevel", "{SUBLEV}", "SubLevelCode", "LocationCodeFormat", null },
                    { 8, new DateTime(2024, 4, 7, 5, 52, 41, 811, DateTimeKind.Local).AddTicks(4464), null, "SubPosition", "{SUBPOS}", "SubPositionCode", "LocationCodeFormat", null }
                });

            migrationBuilder.InsertData(
                table: "OperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 4, 7, 5, 52, 41, 811, DateTimeKind.Local).AddTicks(4560), null, "Admin", null },
                    { 2, new DateTime(2024, 4, 7, 5, 52, 41, 811, DateTimeKind.Local).AddTicks(4562), null, "User", null },
                    { 3, new DateTime(2024, 4, 7, 5, 52, 41, 811, DateTimeKind.Local).AddTicks(4563), null, "Read", null },
                    { 4, new DateTime(2024, 4, 7, 5, 52, 41, 811, DateTimeKind.Local).AddTicks(4564), null, "Write", null },
                    { 5, new DateTime(2024, 4, 7, 5, 52, 41, 811, DateTimeKind.Local).AddTicks(4565), null, "Add", null },
                    { 6, new DateTime(2024, 4, 7, 5, 52, 41, 811, DateTimeKind.Local).AddTicks(4566), null, "Update", null },
                    { 7, new DateTime(2024, 4, 7, 5, 52, 41, 811, DateTimeKind.Local).AddTicks(4577), null, "Delete", null }
                });

            migrationBuilder.InsertData(
                table: "ProgressStatuses",
                columns: new[] { "Id", "Code", "CreatedDate", "DeletedDate", "Description", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "01", new DateTime(2024, 4, 7, 5, 52, 41, 811, DateTimeKind.Local).AddTicks(4686), null, "Pending", null },
                    { 2, "02", new DateTime(2024, 4, 7, 5, 52, 41, 811, DateTimeKind.Local).AddTicks(4687), null, "ToPick", null },
                    { 3, "03", new DateTime(2024, 4, 7, 5, 52, 41, 811, DateTimeKind.Local).AddTicks(4689), null, "InPick", null },
                    { 4, "04", new DateTime(2024, 4, 7, 5, 52, 41, 811, DateTimeKind.Local).AddTicks(4690), null, "Picked", null },
                    { 5, "05", new DateTime(2024, 4, 7, 5, 52, 41, 811, DateTimeKind.Local).AddTicks(4691), null, "InSorting", null },
                    { 6, "06", new DateTime(2024, 4, 7, 5, 52, 41, 811, DateTimeKind.Local).AddTicks(4692), null, "Sorted", null },
                    { 7, "07", new DateTime(2024, 4, 7, 5, 52, 41, 811, DateTimeKind.Local).AddTicks(4693), null, "InPacking", null },
                    { 8, "08", new DateTime(2024, 4, 7, 5, 52, 41, 811, DateTimeKind.Local).AddTicks(4694), null, "Packed", null },
                    { 9, "09", new DateTime(2024, 4, 7, 5, 52, 41, 811, DateTimeKind.Local).AddTicks(4695), null, "InLoading", null },
                    { 10, "10", new DateTime(2024, 4, 7, 5, 52, 41, 811, DateTimeKind.Local).AddTicks(4696), null, "Completed", null },
                    { 11, "11", new DateTime(2024, 4, 7, 5, 52, 41, 811, DateTimeKind.Local).AddTicks(4697), null, "Cancelled", null }
                });

            migrationBuilder.InsertData(
                table: "Status",
                columns: new[] { "Id", "Code", "CreatedDate", "DeletedDate", "Description", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "01", new DateTime(2024, 4, 7, 5, 52, 41, 811, DateTimeKind.Local).AddTicks(4899), null, "Pending", null },
                    { 2, "02", new DateTime(2024, 4, 7, 5, 52, 41, 811, DateTimeKind.Local).AddTicks(4942), null, "Executing", null },
                    { 3, "03", new DateTime(2024, 4, 7, 5, 52, 41, 811, DateTimeKind.Local).AddTicks(4943), null, "Completed", null },
                    { 4, "04", new DateTime(2024, 4, 7, 5, 52, 41, 811, DateTimeKind.Local).AddTicks(4944), null, "Cancelled", null }
                });

            migrationBuilder.InsertData(
                table: "DepositorCompanies",
                columns: new[] { "Id", "AddressId", "Code", "CreatedDate", "DeletedDate", "Description", "FaxNumber", "Name", "PhoneNumber", "TaxNumber", "TaxOffice", "UpdatedDate" },
                values: new object[] { new Guid("dd4d5460-8146-4e62-ac19-a74d89955dd7"), new Guid("1224c606-3856-4a03-bb00-ed897ce47098"), "MAIN", new DateTime(2024, 4, 7, 5, 52, 41, 811, DateTimeKind.Local).AddTicks(4182), null, "Main Company", "123456789101", "Main Company LTD.", "905432044767", "123456789", "Istanbul Anadolu Kurumlar VD", null });

            migrationBuilder.InsertData(
                table: "ContainerUnits",
                columns: new[] { "Id", "Code", "Counter", "CountryCode", "CreatedDate", "DeletedDate", "DepositorCompanyId", "Description", "FirstDigit", "ProducerCode", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "PAL", "101", "40", new DateTime(2024, 4, 7, 5, 52, 41, 811, DateTimeKind.Local).AddTicks(4008), null, new Guid("dd4d5460-8146-4e62-ac19-a74d89955dd7"), "Pallet", "P", "1234567", null },
                    { 2, "EUR", "201", "40", new DateTime(2024, 4, 7, 5, 52, 41, 811, DateTimeKind.Local).AddTicks(4011), null, new Guid("dd4d5460-8146-4e62-ac19-a74d89955dd7"), "Euro Pallet", "E", "1234567", null },
                    { 3, "PCK", "301", "40", new DateTime(2024, 4, 7, 5, 52, 41, 811, DateTimeKind.Local).AddTicks(4014), null, new Guid("dd4d5460-8146-4e62-ac19-a74d89955dd7"), "Packing Pallet", "C", "1234567", null },
                    { 4, "AMR", "401", "40", new DateTime(2024, 4, 7, 5, 52, 41, 811, DateTimeKind.Local).AddTicks(4016), null, new Guid("dd4d5460-8146-4e62-ac19-a74d89955dd7"), "American Pallet", "A", "1234567", null }
                });

            migrationBuilder.InsertData(
                table: "Depositors",
                columns: new[] { "Id", "Code", "CreatedDate", "DeletedDate", "DepositorCompanyId", "UpdatedDate" },
                values: new object[] { new Guid("202d64f3-4474-4b55-b30d-61c430799efa"), "MAIN", new DateTime(2024, 4, 7, 5, 52, 41, 811, DateTimeKind.Local).AddTicks(4361), null, new Guid("dd4d5460-8146-4e62-ac19-a74d89955dd7"), null });

            migrationBuilder.InsertData(
                table: "Sites",
                columns: new[] { "Id", "Code", "CreatedDate", "DeletedDate", "DepositorCompanyId", "Description", "UpdatedDate" },
                values: new object[] { new Guid("f769e1ec-71cd-450b-80aa-1b863e518a26"), "MAIN", new DateTime(2024, 4, 7, 5, 52, 41, 811, DateTimeKind.Local).AddTicks(4811), null, new Guid("dd4d5460-8146-4e62-ac19-a74d89955dd7"), "MAIN SITE", null });

            migrationBuilder.InsertData(
                table: "Units",
                columns: new[] { "Id", "Code", "CreatedDate", "DeletedDate", "DepositorCompanyId", "Description", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "EA", new DateTime(2024, 4, 7, 5, 52, 41, 811, DateTimeKind.Local).AddTicks(5135), null, new Guid("dd4d5460-8146-4e62-ac19-a74d89955dd7"), "Adet", null },
                    { 2, "m", new DateTime(2024, 4, 7, 5, 52, 41, 811, DateTimeKind.Local).AddTicks(5139), null, new Guid("dd4d5460-8146-4e62-ac19-a74d89955dd7"), "Meter", null },
                    { 3, "desi", new DateTime(2024, 4, 7, 5, 52, 41, 811, DateTimeKind.Local).AddTicks(5141), null, new Guid("dd4d5460-8146-4e62-ac19-a74d89955dd7"), "Desi", null }
                });

            migrationBuilder.InsertData(
                table: "Buildings",
                columns: new[] { "Id", "AddressText", "City", "Code", "Country", "CreatedDate", "DeletedDate", "DepositorCompanyId", "Description", "Latitude", "Longitude", "Province", "SiteId", "UpdatedDate", "ZipCode" },
                values: new object[] { new Guid("6b94bdfe-4158-4e98-816e-a3422816b2a3"), "Deri Org. San. Bolgesi No:26", "Istanbul", "MAIN", "Turkey", new DateTime(2024, 4, 7, 5, 52, 41, 811, DateTimeKind.Local).AddTicks(3907), null, new Guid("dd4d5460-8146-4e62-ac19-a74d89955dd7"), "Main Factory", 40.8503m, 29.3032m, "Tuzla", new Guid("f769e1ec-71cd-450b-80aa-1b863e518a26"), null, "34953" });

            migrationBuilder.InsertData(
                table: "DepositorFeatures",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "DepositorId", "GenerateSsccLed", "UpdatedDate" },
                values: new object[] { new Guid("2c3f6012-1d25-4818-b450-a90460e8d0e4"), new DateTime(2024, 4, 7, 5, 52, 41, 811, DateTimeKind.Local).AddTicks(4273), null, new Guid("202d64f3-4474-4b55-b30d-61c430799efa"), true, null });

            migrationBuilder.InsertData(
                table: "BuildingDimensions",
                columns: new[] { "Id", "BuildingId", "BuildingLevel", "CreatedDate", "DeletedDate", "Height", "LenghtUnitId", "Length", "UpdatedDate", "Volume", "VolumeUnitId", "Width" },
                values: new object[] { new Guid("daf214c4-92e9-4e93-989b-4fa1c2ecf793"), new Guid("6b94bdfe-4158-4e98-816e-a3422816b2a3"), null, new DateTime(2024, 4, 7, 5, 52, 41, 811, DateTimeKind.Local).AddTicks(3791), null, 10m, 2, 30m, null, 6000m, 3, 20m });

            migrationBuilder.InsertData(
                table: "StorageSystems",
                columns: new[] { "Id", "BuildingId", "Code", "CreatedDate", "DeletedDate", "DepositorCompanyId", "Description", "UpdatedDate" },
                values: new object[] { new Guid("861615e9-ec51-44f2-91dc-7a30fa477896"), new Guid("6b94bdfe-4158-4e98-816e-a3422816b2a3"), "RAMP", new DateTime(2024, 4, 7, 5, 52, 41, 811, DateTimeKind.Local).AddTicks(5043), null, new Guid("dd4d5460-8146-4e62-ac19-a74d89955dd7"), "Ramp Area", null });

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_Id",
                table: "Addresses",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Adresses_Areas",
                table: "Addresses",
                columns: new[] { "Description", "Province", "City", "Country", "AddressText", "ZipCode", "Latitude", "Longitude", "CreatedDate" });

            migrationBuilder.CreateIndex(
                name: "IX_AttributeInputTypes_Areas",
                table: "AttributeInputTypes",
                columns: new[] { "Description", "CreatedDate" });

            migrationBuilder.CreateIndex(
                name: "IX_AttributeInputTypes_Id",
                table: "AttributeInputTypes",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UK_AttributeInputTypes_Description",
                table: "AttributeInputTypes",
                column: "Description",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_BarcodeAreas_Areas",
                table: "BarcodeAreas",
                columns: new[] { "BarcodeId", "QueryField", "TextField", "CreatedDate" });

            migrationBuilder.CreateIndex(
                name: "IX_BarcodeAreas_Id",
                table: "BarcodeAreas",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_BarcodePrinters_Areas",
                table: "BarcodePrinters",
                columns: new[] { "BarcodeId", "PrinterId", "CreatedDate" });

            migrationBuilder.CreateIndex(
                name: "IX_BarcodePrinters_Id",
                table: "BarcodePrinters",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_BarcodePrinters_PrinterId",
                table: "BarcodePrinters",
                column: "PrinterId");

            migrationBuilder.CreateIndex(
                name: "IX_Barcodes_Areas",
                table: "Barcodes",
                columns: new[] { "Code", "DepositorCompanyId", "CreatedDate" });

            migrationBuilder.CreateIndex(
                name: "IX_Barcodes_DepositorCompanyId",
                table: "Barcodes",
                column: "DepositorCompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Barcodes_Id",
                table: "Barcodes",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_BarcodeSuppliers_Areas",
                table: "BarcodeSuppliers",
                columns: new[] { "ProductBarcodeId", "SupplierId", "DepositorCompanyId", "CreatedDate" });

            migrationBuilder.CreateIndex(
                name: "IX_BarcodeSuppliers_DepositorCompanyId",
                table: "BarcodeSuppliers",
                column: "DepositorCompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_BarcodeSuppliers_Id",
                table: "BarcodeSuppliers",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_BarcodeSuppliers_SupplierId",
                table: "BarcodeSuppliers",
                column: "SupplierId");

            migrationBuilder.CreateIndex(
                name: "IX_Branches_AddressId",
                table: "Branches",
                column: "AddressId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Branches_DepositorCompanyId",
                table: "Branches",
                column: "DepositorCompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Branches_DistributorId",
                table: "Branches",
                column: "DistributorId");

            migrationBuilder.CreateIndex(
                name: "IX_Branches_Id",
                table: "Branches",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Branchs_Areas",
                table: "Branches",
                columns: new[] { "Code", "Name", "AddressId", "DistributorId", "DepositorCompanyId", "CreatedDate" });

            migrationBuilder.CreateIndex(
                name: "IX_BuildingDimensions_Areas",
                table: "BuildingDimensions",
                columns: new[] { "BuildingId", "LenghtUnitId", "BuildingLevel", "VolumeUnitId", "CreatedDate" });

            migrationBuilder.CreateIndex(
                name: "IX_BuildingDimensions_BuildingId",
                table: "BuildingDimensions",
                column: "BuildingId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_BuildingDimensions_Id",
                table: "BuildingDimensions",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_BuildingDimensions_LenghtUnitId",
                table: "BuildingDimensions",
                column: "LenghtUnitId");

            migrationBuilder.CreateIndex(
                name: "IX_BuildingDimensions_VolumeUnitId",
                table: "BuildingDimensions",
                column: "VolumeUnitId");

            migrationBuilder.CreateIndex(
                name: "IX_Buildings_Areas",
                table: "Buildings",
                columns: new[] { "Code", "SiteId", "Description", "Province", "City", "Country", "AddressText", "ZipCode", "DepositorCompanyId", "Longitude", "Latitude", "CreatedDate" });

            migrationBuilder.CreateIndex(
                name: "IX_Buildings_DepositorCompanyId",
                table: "Buildings",
                column: "DepositorCompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Buildings_Id",
                table: "Buildings",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Buildings_SiteId",
                table: "Buildings",
                column: "SiteId");

            migrationBuilder.CreateIndex(
                name: "IX_Companies_AddressId",
                table: "Companies",
                column: "AddressId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Companies_Areas",
                table: "Companies",
                columns: new[] { "Code", "Name", "Description", "TaxNumber", "PhoneNumber", "FaxNumber", "AddressId", "DepositorCompanyId", "CreatedDate" });

            migrationBuilder.CreateIndex(
                name: "IX_Companies_DepositorCompanyId",
                table: "Companies",
                column: "DepositorCompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Companies_Id",
                table: "Companies",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ContainerUnits_Areas",
                table: "ContainerUnits",
                columns: new[] { "Code", "Description", "FirstDigit", "CountryCode", "ProducerCode", "Counter", "DepositorCompanyId", "CreatedDate" });

            migrationBuilder.CreateIndex(
                name: "IX_ContainerUnits_DepositorCompanyId",
                table: "ContainerUnits",
                column: "DepositorCompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_ContainerUnits_Id",
                table: "ContainerUnits",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Customers_AddressId",
                table: "Customers",
                column: "AddressId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Customers_Areas",
                table: "Customers",
                columns: new[] { "Code", "Name", "CompanyId", "AddressId", "DepositorCompanyId", "CreatedDate" });

            migrationBuilder.CreateIndex(
                name: "IX_Customers_CompanyId",
                table: "Customers",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_DepositorCompanyId",
                table: "Customers",
                column: "DepositorCompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_Id",
                table: "Customers",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DepositorCompanies_AddressId",
                table: "DepositorCompanies",
                column: "AddressId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DepositorCompanies_Areas",
                table: "DepositorCompanies",
                columns: new[] { "Code", "Name", "Description", "TaxOffice", "TaxNumber", "PhoneNumber", "FaxNumber", "AddressId", "CreatedDate" });

            migrationBuilder.CreateIndex(
                name: "IX_DepositorCompanies_Id",
                table: "DepositorCompanies",
                column: "Id",
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
                name: "IX_DepositorFeatures_Areas",
                table: "DepositorFeatures",
                columns: new[] { "DepositorId", "CreatedDate" });

            migrationBuilder.CreateIndex(
                name: "IX_DepositorFeatures_DepositorId",
                table: "DepositorFeatures",
                column: "DepositorId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DepositorFeatures_Id",
                table: "DepositorFeatures",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Depositors_Areas",
                table: "Depositors",
                columns: new[] { "Code", "DepositorCompanyId", "CreatedDate" });

            migrationBuilder.CreateIndex(
                name: "IX_Depositors_DepositorCompanyId",
                table: "Depositors",
                column: "DepositorCompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Depositors_Id",
                table: "Depositors",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Distributors_AddressId",
                table: "Distributors",
                column: "AddressId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Distributors_CompanyId",
                table: "Distributors",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Distributors_DepositorCompanyId",
                table: "Distributors",
                column: "DepositorCompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Distributors_Id",
                table: "Distributors",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Disturbitors_Areas",
                table: "Distributors",
                columns: new[] { "Code", "Name", "CompanyId", "AddressId", "DepositorCompanyId", "CreatedDate" });

            migrationBuilder.CreateIndex(
                name: "IX_EmailAuthenticators_UserId",
                table: "EmailAuthenticators",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemPackTypes_Areas",
                table: "ItemPackTypes",
                columns: new[] { "ItemUnitId", "Length", "Width", "Height", "LenghtUnitId", "Volume", "VolumeUnitId", "DeadWeight", "NetWeight", "WeightUnitId", "CreatedDate" });

            migrationBuilder.CreateIndex(
                name: "IX_ItemPackTypes_Id",
                table: "ItemPackTypes",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ItemPackTypes_LenghtUnitId",
                table: "ItemPackTypes",
                column: "LenghtUnitId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemPackTypes_VolumeUnitId",
                table: "ItemPackTypes",
                column: "VolumeUnitId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemPackTypes_WeightUnitId",
                table: "ItemPackTypes",
                column: "WeightUnitId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemUnitConversions_Areas",
                table: "ItemUnitConversions",
                columns: new[] { "ReferenceItemUnitId", "ConvertedItemUnitId", "ConversionQuantity", "CreatedDate" });

            migrationBuilder.CreateIndex(
                name: "IX_ItemUnitConversions_ConvertedItemUnitId",
                table: "ItemUnitConversions",
                column: "ConvertedItemUnitId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemUnitConversions_Id",
                table: "ItemUnitConversions",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ItemUnits_Areas",
                table: "ItemUnits",
                columns: new[] { "ProductId", "UnitId", "IsCustomerUnit", "CreatedDate" });

            migrationBuilder.CreateIndex(
                name: "IX_ItemUnits_Id",
                table: "ItemUnits",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ItemUnits_UnitId",
                table: "ItemUnits",
                column: "UnitId");

            migrationBuilder.CreateIndex(
                name: "IX_LocationCodeComponents_Areas",
                table: "LocationCodeComponents",
                columns: new[] { "Description", "TableName", "FieldName", "FieldCode", "CreatedDate" });

            migrationBuilder.CreateIndex(
                name: "IX_LocationCodeComponents_Description",
                table: "LocationCodeComponents",
                column: "Description",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_LocationCodeComponents_Id",
                table: "LocationCodeComponents",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_LocationCodeFormat_Areas",
                table: "LocationCodeFormats",
                columns: new[] { "LocationId", "Sector", "Column", "Level", "Side", "SubLevel", "SubColumn", "CreatedDate" });

            migrationBuilder.CreateIndex(
                name: "IX_LocationCodeFormats_Id",
                table: "LocationCodeFormats",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_LocationCodeFormats_LocationId",
                table: "LocationCodeFormats",
                column: "LocationId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_LocationCoordinates_Areas",
                table: "LocationCoordinates",
                columns: new[] { "LocationId", "BuildingId", "CreatedDate" });

            migrationBuilder.CreateIndex(
                name: "IX_LocationCoordinates_BuildingId",
                table: "LocationCoordinates",
                column: "BuildingId");

            migrationBuilder.CreateIndex(
                name: "IX_LocationCoordinates_Id",
                table: "LocationCoordinates",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_LocationCoordinates_LocationId",
                table: "LocationCoordinates",
                column: "LocationId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_LocationDepositors_Areas",
                table: "LocationDepositors",
                columns: new[] { "LocationId", "DepositorId", "CreatedDate" });

            migrationBuilder.CreateIndex(
                name: "IX_LocationDepositors_DepositorId",
                table: "LocationDepositors",
                column: "DepositorId");

            migrationBuilder.CreateIndex(
                name: "IX_LocationDepositors_Id",
                table: "LocationDepositors",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_LocationDimensions_Areas",
                table: "LocationDimensions",
                columns: new[] { "LocationId", "LengthUnitId", "VolumeUnitId", "WeightUnitId", "CreatedDate" });

            migrationBuilder.CreateIndex(
                name: "IX_LocationDimensions_Id",
                table: "LocationDimensions",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_LocationDimensions_LengthUnitId",
                table: "LocationDimensions",
                column: "LengthUnitId");

            migrationBuilder.CreateIndex(
                name: "IX_LocationDimensions_LocationId",
                table: "LocationDimensions",
                column: "LocationId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_LocationDimensions_VolumeUnitId",
                table: "LocationDimensions",
                column: "VolumeUnitId");

            migrationBuilder.CreateIndex(
                name: "IX_LocationDimensions_WeightUnitId",
                table: "LocationDimensions",
                column: "WeightUnitId");

            migrationBuilder.CreateIndex(
                name: "IX_LocationFeatures_Areas",
                table: "LocationFeatures",
                columns: new[] { "LocationId", "CreatedDate" });

            migrationBuilder.CreateIndex(
                name: "IX_LocationFeatures_Id",
                table: "LocationFeatures",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_LocationFeatures_LocationId",
                table: "LocationFeatures",
                column: "LocationId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_LocationLockReasons_Areas",
                table: "LocationLockReasons",
                columns: new[] { "LocationId", "LockReasonId", "CreatedDate" });

            migrationBuilder.CreateIndex(
                name: "IX_LocationLockReasons_Id",
                table: "LocationLockReasons",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_LocationLockReasons_LocationId",
                table: "LocationLockReasons",
                column: "LocationId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_LocationLockReasons_LockReasonId",
                table: "LocationLockReasons",
                column: "LockReasonId");

            migrationBuilder.CreateIndex(
                name: "IX_LocationPickingTypes_Areas",
                table: "LocationPickingTypes",
                columns: new[] { "LocationId", "PickingTypeId", "CreatedDate" });

            migrationBuilder.CreateIndex(
                name: "IX_LocationPickingTypes_Id",
                table: "LocationPickingTypes",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_LocationPickingTypes_LocationId",
                table: "LocationPickingTypes",
                column: "LocationId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_LocationPickingTypes_PickingTypeId",
                table: "LocationPickingTypes",
                column: "PickingTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_LocationPriorities_Areas",
                table: "LocationPriorities",
                columns: new[] { "LocationId", "CreatedDate" });

            migrationBuilder.CreateIndex(
                name: "IX_LocationPriorities_Id",
                table: "LocationPriorities",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_LocationPriorities_LocationId",
                table: "LocationPriorities",
                column: "LocationId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_LocationProductAttributes_Areas",
                table: "LocationProductAttributes",
                columns: new[] { "LocationId", "ProductAttributeId", "CreatedDate" });

            migrationBuilder.CreateIndex(
                name: "IX_LocationProductAttributes_Id",
                table: "LocationProductAttributes",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_LocationProductAttributes_ProductAttributeId",
                table: "LocationProductAttributes",
                column: "ProductAttributeId");

            migrationBuilder.CreateIndex(
                name: "IX_LocationProductConstraints_Areas",
                table: "LocationProductConstraints",
                columns: new[] { "LocationId", "ProductId", "UnitId", "CreatedDate" });

            migrationBuilder.CreateIndex(
                name: "IX_LocationProductConstraints_Id",
                table: "LocationProductConstraints",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_LocationProductConstraints_ProductId",
                table: "LocationProductConstraints",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_LocationProductConstraints_UnitId",
                table: "LocationProductConstraints",
                column: "UnitId");

            migrationBuilder.CreateIndex(
                name: "IX_LocationProducts_Areas",
                table: "LocationProducts",
                columns: new[] { "LocationId", "ProductId", "CreatedDate" });

            migrationBuilder.CreateIndex(
                name: "IX_LocationProducts_Id",
                table: "LocationProducts",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_LocationProducts_ProductId",
                table: "LocationProducts",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Locations_Areas",
                table: "Locations",
                columns: new[] { "Code", "Description", "StorageSystemId", "DepositorCompanyId", "CreatedDate" });

            migrationBuilder.CreateIndex(
                name: "IX_Locations_DepositorCompanyId",
                table: "Locations",
                column: "DepositorCompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Locations_Id",
                table: "Locations",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Locations_StorageSystemId",
                table: "Locations",
                column: "StorageSystemId");

            migrationBuilder.CreateIndex(
                name: "IX_LocationStockAttributes_Areas",
                table: "LocationStockAttributes",
                columns: new[] { "LocationId", "StockAttributeId", "CreatedDate" });

            migrationBuilder.CreateIndex(
                name: "IX_LocationStockAttributes_Id",
                table: "LocationStockAttributes",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_LocationStockAttributes_StockAttributeId",
                table: "LocationStockAttributes",
                column: "StockAttributeId");

            migrationBuilder.CreateIndex(
                name: "IX_LocationUnitConstraints_Areas",
                table: "LocationUnitConstraints",
                columns: new[] { "LocationId", "UnitId", "CreatedDate" });

            migrationBuilder.CreateIndex(
                name: "IX_LocationUnitConstraints_Id",
                table: "LocationUnitConstraints",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_LocationUnitConstraints_UnitId",
                table: "LocationUnitConstraints",
                column: "UnitId");

            migrationBuilder.CreateIndex(
                name: "IX_LocationZones_Areas",
                table: "LocationZones",
                columns: new[] { "LocationId", "ZoneId", "CreatedDate" });

            migrationBuilder.CreateIndex(
                name: "IX_LocationZones_Id",
                table: "LocationZones",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_LocationZones_ZoneId",
                table: "LocationZones",
                column: "ZoneId");

            migrationBuilder.CreateIndex(
                name: "IX_LockReasons_Areas",
                table: "LockReasons",
                columns: new[] { "Code", "Description", "DepositorCompanyId", "CreatedDate" });

            migrationBuilder.CreateIndex(
                name: "IX_LockReasons_DepositorCompanyId",
                table: "LockReasons",
                column: "DepositorCompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_LockReasons_Id",
                table: "LockReasons",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_LogStockAttributeValues_Areas",
                table: "LogStockAttributeValues",
                columns: new[] { "LogStockId", "StockAttributeId", "FromValue", "ToValue", "CreatedDate" });

            migrationBuilder.CreateIndex(
                name: "IX_LogStockAttributeValues_Id",
                table: "LogStockAttributeValues",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_LogStockContainers_Areas",
                table: "LogStockContainers",
                columns: new[] { "LogStockId", "FromContainerId", "ToContainerId", "FromContainerSSCC", "ToContainerSSCC", "FromContainerTypeId", "ToContainerTypeId", "CreatedDate" });

            migrationBuilder.CreateIndex(
                name: "IX_LogStockContainers_Id",
                table: "LogStockContainers",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_LogStockReserveReasons_Areas",
                table: "LogStockReserveReasons",
                columns: new[] { "LogStockId", "FromReasaonId", "ToReasaonId", "CreatedDate" });

            migrationBuilder.CreateIndex(
                name: "IX_LogStockReserveReasons_Id",
                table: "LogStockReserveReasons",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_LogStocks_Areas",
                table: "LogStocks",
                columns: new[] { "TransactionLogId", "StockId", "ProductId", "FromLocaitonId", "ToLocationId", "TransactionTypeId", "Quantity", "CreatedDate" });

            migrationBuilder.CreateIndex(
                name: "IX_LogStocks_Id",
                table: "LogStocks",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_LogStockUnsuitReasons_Areas",
                table: "LogStockUnsuitReasons",
                columns: new[] { "LogStockId", "FromReasonId", "ToReasonId", "CreatedDate" });

            migrationBuilder.CreateIndex(
                name: "IX_LogStockUnsuitReasons_Id",
                table: "LogStockUnsuitReasons",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UK_OperationClaims_Name",
                table: "OperationClaims",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_OrderAttributes_Areas",
                table: "OrderAttributes",
                columns: new[] { "Code", "Description", "AttributeInputTypeId", "DepositorCompanyId", "CreatedDate" });

            migrationBuilder.CreateIndex(
                name: "IX_OrderAttributes_AttributeInputTypeId",
                table: "OrderAttributes",
                column: "AttributeInputTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderAttributes_DepositorCompanyId",
                table: "OrderAttributes",
                column: "DepositorCompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderAttributes_Id",
                table: "OrderAttributes",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_OrderAttributeValues_Areas",
                table: "OrderAttributeValues",
                columns: new[] { "OrderId", "OrderAttributeId", "Value", "CreatedDate" });

            migrationBuilder.CreateIndex(
                name: "IX_OrderAttributeValues_Id",
                table: "OrderAttributeValues",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_OrderAttributeValues_OrderAttributeId",
                table: "OrderAttributeValues",
                column: "OrderAttributeId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItemMemos_Areas",
                table: "OrderItemMemos",
                columns: new[] { "OrderItemId", "Description", "Text", "CreatedDate" });

            migrationBuilder.CreateIndex(
                name: "IX_OrderItemMemos_Id",
                table: "OrderItemMemos",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_Areas",
                table: "OrderItems",
                columns: new[] { "OrderId", "ProductId", "ItemUnitId", "Quantity", "CreatedDate" });

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_Id",
                table: "OrderItems",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_ProductId",
                table: "OrderItems",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItemStockAttrValues_Areas",
                table: "OrderItemStockAttrValues",
                columns: new[] { "OrderItemId", "StockAttributeId", "Value", "CreatedDate" });

            migrationBuilder.CreateIndex(
                name: "IX_OrderItemStockAttrValues_Id",
                table: "OrderItemStockAttrValues",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_OrderItemStockAttrValues_StockAttributeId",
                table: "OrderItemStockAttrValues",
                column: "StockAttributeId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderMemos_Areas",
                table: "OrderMemos",
                columns: new[] { "OrderId", "Description", "Text", "EditDate", "InputDate", "CreatedDate" });

            migrationBuilder.CreateIndex(
                name: "IX_OrderMemos_Id",
                table: "OrderMemos",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Orders_Areas",
                table: "Orders",
                columns: new[] { "Code", "DepositorId", "DepositorCompanyId", "CustomerId", "ReceiverId", "OrderTypeId", "StatusId", "InputDate", "ExpectedDate", "ActualDate", "CreatedDate" });

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CustomerId",
                table: "Orders",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_DepositorCompanyId",
                table: "Orders",
                column: "DepositorCompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_DepositorId",
                table: "Orders",
                column: "DepositorId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_Id",
                table: "Orders",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Orders_OrderTypeId",
                table: "Orders",
                column: "OrderTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_ReceiverId",
                table: "Orders",
                column: "ReceiverId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_StatusId",
                table: "Orders",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderShipItems_Areas",
                table: "OrderShipItems",
                columns: new[] { "OrderItemId", "OrderShipmentId", "ProgressStatusId", "Quantity", "CreatedDate" });

            migrationBuilder.CreateIndex(
                name: "IX_OrderShipItems_Id",
                table: "OrderShipItems",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_OrderShipItems_OrderShipmentId",
                table: "OrderShipItems",
                column: "OrderShipmentId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderShipItems_ProgressStatusId",
                table: "OrderShipItems",
                column: "ProgressStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderShipItemStocks_Areas",
                table: "OrderShipItemStocks",
                columns: new[] { "OrderShipItemId", "OrderShipItemTaskId", "StockId", "StockPackTypeId", "Quantity", "CreatedDate" });

            migrationBuilder.CreateIndex(
                name: "IX_OrderShipItemStocks_Id",
                table: "OrderShipItemStocks",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_OrderShipItemStocks_OrderShipItemTaskId",
                table: "OrderShipItemStocks",
                column: "OrderShipItemTaskId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderShipItemStocks_StockId",
                table: "OrderShipItemStocks",
                column: "StockId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderShipItemStocks_StockPackTypeId",
                table: "OrderShipItemStocks",
                column: "StockPackTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderShipItemTasks_Areas",
                table: "OrderShipItemTasks",
                columns: new[] { "OrderShipItemId", "WorkTaskId", "Quantity", "CreatedDate" });

            migrationBuilder.CreateIndex(
                name: "IX_OrderShipItemTasks_Id",
                table: "OrderShipItemTasks",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_OrderShipItemTasks_WorkTaskId",
                table: "OrderShipItemTasks",
                column: "WorkTaskId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderShipments_Areas",
                table: "OrderShipments",
                columns: new[] { "Code", "OrderId", "ShipmentId", "ProgressStatusId", "LastMoveDate", "CreatedDate" });

            migrationBuilder.CreateIndex(
                name: "IX_OrderShipments_DepositorCompanyId",
                table: "OrderShipments",
                column: "DepositorCompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderShipments_Id",
                table: "OrderShipments",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_OrderShipments_OrderId",
                table: "OrderShipments",
                column: "OrderId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_OrderShipments_ProgressStatusId",
                table: "OrderShipments",
                column: "ProgressStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderShipments_ShipmentId",
                table: "OrderShipments",
                column: "ShipmentId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderTypes_Areas",
                table: "OrderTypes",
                columns: new[] { "Code", "Description", "Format", "Counter", "DepositorCompanyId", "CreatedDate" });

            migrationBuilder.CreateIndex(
                name: "IX_OrderTypes_DepositorCompanyId",
                table: "OrderTypes",
                column: "DepositorCompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderTypes_Id",
                table: "OrderTypes",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_OtpAuthenticators_UserId",
                table: "OtpAuthenticators",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_PickingTypes_Areas",
                table: "PickingTypes",
                columns: new[] { "Code", "Description", "CreatedDate" });

            migrationBuilder.CreateIndex(
                name: "IX_PickingTypes_Id",
                table: "PickingTypes",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PoAttributes_Areas",
                table: "PoAttributes",
                columns: new[] { "Code", "Description", "AttributeInputTypeId", "DepositorCompanyId", "CreatedDate" });

            migrationBuilder.CreateIndex(
                name: "IX_PoAttributes_AttributeInputTypeId",
                table: "PoAttributes",
                column: "AttributeInputTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_PoAttributes_DepositorCompanyId",
                table: "PoAttributes",
                column: "DepositorCompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_PoAttributes_Id",
                table: "PoAttributes",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PoAttributeValues_Areas",
                table: "PoAttributeValues",
                columns: new[] { "PurchaseOrderId", "PoAttributeId", "Value", "CreatedDate" });

            migrationBuilder.CreateIndex(
                name: "IX_PoAttributeValues_Id",
                table: "PoAttributeValues",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PoAttributeValues_PoAttributeId",
                table: "PoAttributeValues",
                column: "PoAttributeId");

            migrationBuilder.CreateIndex(
                name: "IX_PoMemos_Areas",
                table: "PoMemos",
                columns: new[] { "PurchaseOrderId", "Description", "InputDate", "Text", "EditDate", "CreatedDate" });

            migrationBuilder.CreateIndex(
                name: "IX_PoMemos_Id",
                table: "PoMemos",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PoTypes_Areas",
                table: "PoTypes",
                columns: new[] { "Code", "Description", "Format", "Counter", "DepositorCompanyId", "CreatedDate" });

            migrationBuilder.CreateIndex(
                name: "IX_PoTypes_DepositorCompanyId",
                table: "PoTypes",
                column: "DepositorCompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_PoTypes_Id",
                table: "PoTypes",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Printers_Areas",
                table: "Printers",
                columns: new[] { "Code", "PrinterAddress", "DepositorCompanyId", "CreatedDate" });

            migrationBuilder.CreateIndex(
                name: "IX_Printers_DepositorCompanyId",
                table: "Printers",
                column: "DepositorCompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Printers_Id",
                table: "Printers",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProductAttributes_Areas",
                table: "ProductAttributes",
                columns: new[] { "Code", "Description", "AttributeInputTypeId", "DepositorCompanyId", "CreatedDate" });

            migrationBuilder.CreateIndex(
                name: "IX_ProductAttributes_AttributeInputTypeId",
                table: "ProductAttributes",
                column: "AttributeInputTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductAttributes_DepositorCompanyId",
                table: "ProductAttributes",
                column: "DepositorCompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductAttributes_Id",
                table: "ProductAttributes",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProductAttributeValues_Areas",
                table: "ProductAttributeValues",
                columns: new[] { "ProductId", "ProductAttributeId", "Value", "CreatedDate" });

            migrationBuilder.CreateIndex(
                name: "IX_ProductAttributeValues_Id",
                table: "ProductAttributeValues",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProductAttributeValues_ProductAttributeId",
                table: "ProductAttributeValues",
                column: "ProductAttributeId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductBarcodes_Areas",
                table: "ProductBarcodes",
                columns: new[] { "ProductId", "BarcodeString", "ItemUnitId", "CreatedDate" });

            migrationBuilder.CreateIndex(
                name: "IX_ProductBarcodes_Id",
                table: "ProductBarcodes",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProductBarcodes_ItemUnitId",
                table: "ProductBarcodes",
                column: "ItemUnitId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductDepositors_Areas",
                table: "ProductDepositors",
                columns: new[] { "ProductId", "DepositorId", "CreatedDate" });

            migrationBuilder.CreateIndex(
                name: "IX_ProductDepositors_DepositorId",
                table: "ProductDepositors",
                column: "DepositorId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductDepositors_Id",
                table: "ProductDepositors",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Products_Areas",
                table: "Products",
                columns: new[] { "Code", "Description", "AlternativeCode", "DepositorCompanyId", "CreatedDate" });

            migrationBuilder.CreateIndex(
                name: "IX_Products_DepositorCompanyId",
                table: "Products",
                column: "DepositorCompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_Id",
                table: "Products",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProductStockAttributes_Areas",
                table: "ProductStockAttributes",
                columns: new[] { "ProductId", "StockAttributeId", "CreatedDate" });

            migrationBuilder.CreateIndex(
                name: "IX_ProductStockAttributes_Id",
                table: "ProductStockAttributes",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProductStockAttributes_StockAttributeId",
                table: "ProductStockAttributes",
                column: "StockAttributeId");

            migrationBuilder.CreateIndex(
                name: "IX_ProgressStatuses_Areas",
                table: "ProgressStatuses",
                columns: new[] { "Code", "Description", "CreatedDate" });

            migrationBuilder.CreateIndex(
                name: "IX_ProgressStatuses_Id",
                table: "ProgressStatuses",
                column: "Id",
                unique: true);

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
                name: "IX_PurchaseOrders_Areas",
                table: "PurchaseOrders",
                columns: new[] { "Code", "DepositorId", "DepositorCompanyId", "SupplierId", "PoTypeId", "StatusId", "CreatedDate" });

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseOrders_DepositorCompanyId",
                table: "PurchaseOrders",
                column: "DepositorCompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseOrders_DepositorId",
                table: "PurchaseOrders",
                column: "DepositorId");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseOrders_Id",
                table: "PurchaseOrders",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseOrders_PoTypeId",
                table: "PurchaseOrders",
                column: "PoTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseOrders_StatusId",
                table: "PurchaseOrders",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseOrders_SupplierId",
                table: "PurchaseOrders",
                column: "SupplierId");

            migrationBuilder.CreateIndex(
                name: "IX_ReceiptAttributes_Areas",
                table: "ReceiptAttributes",
                columns: new[] { "Code", "Description", "AttributeInputTypeId", "DepositorCompanyId", "CreatedDate" });

            migrationBuilder.CreateIndex(
                name: "IX_ReceiptAttributes_AttributeInputTypeId",
                table: "ReceiptAttributes",
                column: "AttributeInputTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ReceiptAttributes_DepositorCompanyId",
                table: "ReceiptAttributes",
                column: "DepositorCompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_ReceiptAttributes_Id",
                table: "ReceiptAttributes",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ReceiptAttributeValues_Areas",
                table: "ReceiptAttributeValues",
                columns: new[] { "ReceiptId", "ReceiptAttributeId", "Value", "CreatedDate" });

            migrationBuilder.CreateIndex(
                name: "IX_ReceiptAttributeValues_Id",
                table: "ReceiptAttributeValues",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ReceiptAttributeValues_ReceiptAttributeId",
                table: "ReceiptAttributeValues",
                column: "ReceiptAttributeId");

            migrationBuilder.CreateIndex(
                name: "IX_ReceiptItemMemos_Areas",
                table: "ReceiptItemMemos",
                columns: new[] { "ReceiptItemId", "Description", "Text", "InputDate", "EditDate", "CreatedDate" });

            migrationBuilder.CreateIndex(
                name: "IX_ReceiptItemMemos_Id",
                table: "ReceiptItemMemos",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ReceiptItems_Areas",
                table: "ReceiptItems",
                columns: new[] { "ReceiptId", "ProductId", "ItemUnitId", "StatusId", "ExpectedQuantity", "ActualQuantity", "CreatedDate" });

            migrationBuilder.CreateIndex(
                name: "IX_ReceiptItems_Id",
                table: "ReceiptItems",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ReceiptItems_ItemUnitId",
                table: "ReceiptItems",
                column: "ItemUnitId");

            migrationBuilder.CreateIndex(
                name: "IX_ReceiptItems_ProductId",
                table: "ReceiptItems",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ReceiptItems_StatusId",
                table: "ReceiptItems",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_ReceiptItmStockAttrValues_Areas",
                table: "ReceiptItmStockAttrValues",
                columns: new[] { "ReceiptItemId", "StockAttributeId", "Value", "CreatedDate" });

            migrationBuilder.CreateIndex(
                name: "IX_ReceiptItmStockAttrValues_Id",
                table: "ReceiptItmStockAttrValues",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ReceiptItmStockAttrValues_StockAttributeId",
                table: "ReceiptItmStockAttrValues",
                column: "StockAttributeId");

            migrationBuilder.CreateIndex(
                name: "IX_ReceiptMemos_Areas",
                table: "ReceiptMemos",
                columns: new[] { "ReceiptId", "Description", "InputDate", "Text", "EditDate", "CreatedDate" });

            migrationBuilder.CreateIndex(
                name: "IX_ReceiptMemos_Id",
                table: "ReceiptMemos",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Receipts_Areas",
                table: "Receipts",
                columns: new[] { "Code", "DepositorId", "DepositorCompanyId", "PurchaseOrderId", "ReceiptTypeId", "StatusId", "InputDate", "ExpectedDate", "ReceiveDate", "CreatedDate" });

            migrationBuilder.CreateIndex(
                name: "IX_Receipts_DepositorCompanyId",
                table: "Receipts",
                column: "DepositorCompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Receipts_DepositorId",
                table: "Receipts",
                column: "DepositorId");

            migrationBuilder.CreateIndex(
                name: "IX_Receipts_Id",
                table: "Receipts",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Receipts_PurchaseOrderId",
                table: "Receipts",
                column: "PurchaseOrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Receipts_ReceiptTypeId",
                table: "Receipts",
                column: "ReceiptTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Receipts_StatusId",
                table: "Receipts",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_ReceiptTypes_Areas",
                table: "ReceiptTypes",
                columns: new[] { "Code", "Description", "Format", "Counter", "DepositorCompanyId", "CreatedDate" });

            migrationBuilder.CreateIndex(
                name: "IX_ReceiptTypes_DepositorCompanyId",
                table: "ReceiptTypes",
                column: "DepositorCompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_ReceiptTypes_Id",
                table: "ReceiptTypes",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Receivers_AddressId",
                table: "Receivers",
                column: "AddressId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Receivers_Areas",
                table: "Receivers",
                columns: new[] { "Code", "Name", "AddressId", "CustomerId", "DepositorCompanyId", "CreatedDate" });

            migrationBuilder.CreateIndex(
                name: "IX_Receivers_CustomerId",
                table: "Receivers",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Receivers_DepositorCompanyId",
                table: "Receivers",
                column: "DepositorCompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Receivers_Id",
                table: "Receivers",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_RefreshTokens_UserId",
                table: "RefreshTokens",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ReserveReasons_Areas",
                table: "ReserveReasons",
                columns: new[] { "Code", "Description", "DepositorCompanyId", "CreatedDate" });

            migrationBuilder.CreateIndex(
                name: "IX_ReserveReasons_DepositorCompanyId",
                table: "ReserveReasons",
                column: "DepositorCompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_ReserveReasons_Id",
                table: "ReserveReasons",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ReturnAttributes_Areas",
                table: "ReturnAttributes",
                columns: new[] { "Code", "Description", "AttributeInputTypeId", "DepositorCompanyId", "CreatedDate" });

            migrationBuilder.CreateIndex(
                name: "IX_ReturnAttributes_AttributeInputTypeId",
                table: "ReturnAttributes",
                column: "AttributeInputTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ReturnAttributes_DepositorCompanyId",
                table: "ReturnAttributes",
                column: "DepositorCompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_ReturnAttributes_Id",
                table: "ReturnAttributes",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ReturnAttributeValues_Areas",
                table: "ReturnAttributeValues",
                columns: new[] { "ReturnId", "ReturnAttributeId", "Value", "CreatedDate" });

            migrationBuilder.CreateIndex(
                name: "IX_ReturnAttributeValues_Id",
                table: "ReturnAttributeValues",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ReturnAttributeValues_ReturnAttributeId",
                table: "ReturnAttributeValues",
                column: "ReturnAttributeId");

            migrationBuilder.CreateIndex(
                name: "IX_ReturnItemMemos_Areas",
                table: "ReturnItemMemos",
                columns: new[] { "ReturnItemId", "Description", "Text", "InputDate", "EditDate", "CreatedDate" });

            migrationBuilder.CreateIndex(
                name: "IX_ReturnItemMemos_Id",
                table: "ReturnItemMemos",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ReturnItems_Areas",
                table: "ReturnItems",
                columns: new[] { "ReturnId", "ProductId", "ItemUnitId", "StatusId", "ExpectedQuantity", "ActualQuantity", "CreatedDate" });

            migrationBuilder.CreateIndex(
                name: "IX_ReturnItems_Id",
                table: "ReturnItems",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ReturnItems_ItemUnitId",
                table: "ReturnItems",
                column: "ItemUnitId");

            migrationBuilder.CreateIndex(
                name: "IX_ReturnItems_ProductId",
                table: "ReturnItems",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ReturnItems_StatusId",
                table: "ReturnItems",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_ReturnItmStockAttrValues_Areas",
                table: "ReturnItmStockAttrValues",
                columns: new[] { "ReturnItemId", "StockAttributeId", "Value", "CreatedDate" });

            migrationBuilder.CreateIndex(
                name: "IX_ReturnItmStockAttrValues_Id",
                table: "ReturnItmStockAttrValues",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ReturnItmStockAttrValues_StockAttributeId",
                table: "ReturnItmStockAttrValues",
                column: "StockAttributeId");

            migrationBuilder.CreateIndex(
                name: "IX_ReturnMemos_Areas",
                table: "ReturnMemos",
                columns: new[] { "ReturnId", "Description", "Text", "InputDate", "EditDate", "CreatedDate" });

            migrationBuilder.CreateIndex(
                name: "IX_ReturnMemos_Id",
                table: "ReturnMemos",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Returns_Areas",
                table: "Returns",
                columns: new[] { "Code", "CustomerId", "StatusId", "DepositorCompanyId", "DepositorId", "ReturnTypeId", "InputDate", "ExpectedDate", "ReceiveDate", "CreatedDate" });

            migrationBuilder.CreateIndex(
                name: "IX_Returns_CustomerId",
                table: "Returns",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Returns_DepositorCompanyId",
                table: "Returns",
                column: "DepositorCompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Returns_DepositorId",
                table: "Returns",
                column: "DepositorId");

            migrationBuilder.CreateIndex(
                name: "IX_Returns_Id",
                table: "Returns",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Returns_ReturnTypeId",
                table: "Returns",
                column: "ReturnTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Returns_StatusId",
                table: "Returns",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_ReturnTypes_Areas",
                table: "ReturnTypes",
                columns: new[] { "Code", "Description", "Format", "Counter", "DepositorCompanyId", "CreatedDate" });

            migrationBuilder.CreateIndex(
                name: "IX_ReturnTypes_DepositorCompanyId",
                table: "ReturnTypes",
                column: "DepositorCompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_ReturnTypes_Id",
                table: "ReturnTypes",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ShipmentAttributes_Areas",
                table: "ShipmentAttributes",
                columns: new[] { "Code", "Description", "AttributeInputTypeId", "DepositorCompanyId", "CreatedDate" });

            migrationBuilder.CreateIndex(
                name: "IX_ShipmentAttributes_AttributeInputTypeId",
                table: "ShipmentAttributes",
                column: "AttributeInputTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ShipmentAttributes_DepositorCompanyId",
                table: "ShipmentAttributes",
                column: "DepositorCompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_ShipmentAttributes_Id",
                table: "ShipmentAttributes",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ShipmentAttributeValues_Areas",
                table: "ShipmentAttributeValues",
                columns: new[] { "ShipmentId", "ShipmentAttributeId", "Value", "CreatedDate" });

            migrationBuilder.CreateIndex(
                name: "IX_ShipmentAttributeValues_Id",
                table: "ShipmentAttributeValues",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ShipmentAttributeValues_ShipmentAttributeId",
                table: "ShipmentAttributeValues",
                column: "ShipmentAttributeId");

            migrationBuilder.CreateIndex(
                name: "IX_ShipmentMemos_Areas",
                table: "ShipmentMemos",
                columns: new[] { "ShipmentId", "Description", "Text", "InputDate", "EditDate", "CreatedDate" });

            migrationBuilder.CreateIndex(
                name: "IX_ShipmentMemos_Id",
                table: "ShipmentMemos",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Shipments_Areas",
                table: "Shipments",
                columns: new[] { "Code", "DepositorId", "DepositorCompanyId", "DistributorId", "BranchId", "ShipmentTypeId", "InputDate", "ExpectedDate", "ActualDate", "CreatedDate" });

            migrationBuilder.CreateIndex(
                name: "IX_Shipments_BranchId",
                table: "Shipments",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_Shipments_DepositorCompanyId",
                table: "Shipments",
                column: "DepositorCompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Shipments_DepositorId",
                table: "Shipments",
                column: "DepositorId");

            migrationBuilder.CreateIndex(
                name: "IX_Shipments_DistributorId",
                table: "Shipments",
                column: "DistributorId");

            migrationBuilder.CreateIndex(
                name: "IX_Shipments_Id",
                table: "Shipments",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Shipments_ShipmentTypeId",
                table: "Shipments",
                column: "ShipmentTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ShipmentTypes_Areas",
                table: "ShipmentTypes",
                columns: new[] { "Code", "Description", "Format", "Counter", "DepositorCompanyId", "CreatedDate" });

            migrationBuilder.CreateIndex(
                name: "IX_ShipmentTypes_DepositorCompanyId",
                table: "ShipmentTypes",
                column: "DepositorCompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_ShipmentTypes_Id",
                table: "ShipmentTypes",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SiteDepositors_Areas",
                table: "SiteDepositors",
                columns: new[] { "SiteId", "DepositorId", "CreatedDate" });

            migrationBuilder.CreateIndex(
                name: "IX_SiteDepositors_DepositorId",
                table: "SiteDepositors",
                column: "DepositorId");

            migrationBuilder.CreateIndex(
                name: "IX_SiteDepositors_Id",
                table: "SiteDepositors",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Sites_Areas",
                table: "Sites",
                columns: new[] { "Code", "Description", "DepositorCompanyId", "CreatedDate" });

            migrationBuilder.CreateIndex(
                name: "IX_Sites_DepositorCompanyId",
                table: "Sites",
                column: "DepositorCompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Sites_Id",
                table: "Sites",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Status_Areas",
                table: "Status",
                columns: new[] { "Code", "Description", "CreatedDate" });

            migrationBuilder.CreateIndex(
                name: "IX_Status_Id",
                table: "Status",
                column: "Id",
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
                name: "IX_StockAttributes_Areas",
                table: "StockAttributes",
                columns: new[] { "Code", "Description", "AttributeInputTypeId", "DepositorCompanyId", "CreatedDate" });

            migrationBuilder.CreateIndex(
                name: "IX_StockAttributes_AttributeInputTypeId",
                table: "StockAttributes",
                column: "AttributeInputTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_StockAttributes_DepositorCompanyId",
                table: "StockAttributes",
                column: "DepositorCompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_StockAttributes_Id",
                table: "StockAttributes",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_StockAttributeValues_Areas",
                table: "StockAttributeValues",
                columns: new[] { "StockId", "StockAttributeId", "Value", "CreatedDate" });

            migrationBuilder.CreateIndex(
                name: "IX_StockAttributeValues_Id",
                table: "StockAttributeValues",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_StockAttributeValues_StockAttributeId",
                table: "StockAttributeValues",
                column: "StockAttributeId");

            migrationBuilder.CreateIndex(
                name: "IX_StockContainers_Areas",
                table: "StockContainers",
                columns: new[] { "Sscc", "ContainerUnitId", "CreatedDate" });

            migrationBuilder.CreateIndex(
                name: "IX_StockContainers_ContainerUnitId",
                table: "StockContainers",
                column: "ContainerUnitId");

            migrationBuilder.CreateIndex(
                name: "IX_StockContainers_Id",
                table: "StockContainers",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_StockMemos_Areas",
                table: "StockMemos",
                columns: new[] { "StockId", "Description", "Text", "InputDate", "EditDate", "CreatedDate" });

            migrationBuilder.CreateIndex(
                name: "IX_StockMemos_Id",
                table: "StockMemos",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_StockPackTypes_Areas",
                table: "StockPackTypes",
                columns: new[] { "StockId", "ItemUnitId", "Quantity", "QuantityFree", "CUQuantity", "CUQuantityFree", "PackTypeRatio", "CreatedDate" });

            migrationBuilder.CreateIndex(
                name: "IX_StockPackTypes_Id",
                table: "StockPackTypes",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_StockPackTypes_ItemUnitId",
                table: "StockPackTypes",
                column: "ItemUnitId");

            migrationBuilder.CreateIndex(
                name: "IX_StockReserveReasons_Areas",
                table: "StockReserveReasons",
                columns: new[] { "StockId", "ReserveReasonId", "CreatedDate" });

            migrationBuilder.CreateIndex(
                name: "IX_StockReserveReasons_Id",
                table: "StockReserveReasons",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_StockReserveReasons_ReserveReasonId",
                table: "StockReserveReasons",
                column: "ReserveReasonId");

            migrationBuilder.CreateIndex(
                name: "IX_Stocks_Areas",
                table: "Stocks",
                columns: new[] { "StockContainerId", "ProductId", "DepositorId", "DepositorCompanyId", "LocationId", "UnitId", "ReceiptId", "ReturnId", "Quantity", "FreeQuantity", "CreatedDate" });

            migrationBuilder.CreateIndex(
                name: "IX_Stocks_DepositorCompanyId",
                table: "Stocks",
                column: "DepositorCompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Stocks_DepositorId",
                table: "Stocks",
                column: "DepositorId");

            migrationBuilder.CreateIndex(
                name: "IX_Stocks_Id",
                table: "Stocks",
                column: "Id",
                unique: true);

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
                name: "IX_Stocks_UnitId",
                table: "Stocks",
                column: "UnitId");

            migrationBuilder.CreateIndex(
                name: "IX_StockUnsuitReason_Areas",
                table: "StockUnsuitReasons",
                columns: new[] { "StockId", "UnsuitReasonId", "CreatedDate" });

            migrationBuilder.CreateIndex(
                name: "IX_StockUnsuitReasons_Id",
                table: "StockUnsuitReasons",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_StockUnsuitReasons_UnsuitReasonId",
                table: "StockUnsuitReasons",
                column: "UnsuitReasonId");

            migrationBuilder.CreateIndex(
                name: "IX_StorageSystems_Areas",
                table: "StorageSystems",
                columns: new[] { "Code", "Description", "DepositorCompanyId", "BuildingId", "CreatedDate" });

            migrationBuilder.CreateIndex(
                name: "IX_StorageSystems_BuildingId",
                table: "StorageSystems",
                column: "BuildingId");

            migrationBuilder.CreateIndex(
                name: "IX_StorageSystems_DepositorCompanyId",
                table: "StorageSystems",
                column: "DepositorCompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_StorageSystems_Id",
                table: "StorageSystems",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Suppliers_AddressId",
                table: "Suppliers",
                column: "AddressId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Suppliers_Areas",
                table: "Suppliers",
                columns: new[] { "Code", "Name", "AddressId", "CompanyId", "DepositorCompanyId", "CreatedDate" });

            migrationBuilder.CreateIndex(
                name: "IX_Suppliers_CompanyId",
                table: "Suppliers",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Suppliers_DepositorCompanyId",
                table: "Suppliers",
                column: "DepositorCompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Suppliers_Id",
                table: "Suppliers",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TaskCodeFormats_Areas",
                table: "TaskCodeFormats",
                columns: new[] { "Code", "TaskFormat", "TaskCounter", "TaskListCounter", "TaskListFormat", "TransactionTypeId", "DepositorCompanyId", "CreatedDate" });

            migrationBuilder.CreateIndex(
                name: "IX_TaskCodeFormats_DepositorCompanyId",
                table: "TaskCodeFormats",
                column: "DepositorCompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_TaskCodeFormats_Id",
                table: "TaskCodeFormats",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TaskCodeFormats_TransactionTypeId",
                table: "TaskCodeFormats",
                column: "TransactionTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_TaskLists_Areas",
                table: "TaskLists",
                columns: new[] { "Code", "DepositorId", "DepositorCompanyId", "CreatedDate" });

            migrationBuilder.CreateIndex(
                name: "IX_TaskLists_DepositorCompanyId",
                table: "TaskLists",
                column: "DepositorCompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_TaskLists_DepositorId",
                table: "TaskLists",
                column: "DepositorId");

            migrationBuilder.CreateIndex(
                name: "IX_TaskLists_Id",
                table: "TaskLists",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TaskStocks_Areas",
                table: "TaskStocks",
                columns: new[] { "WorkTaskId", "StockId", "Quantity", "CreatedDate" });

            migrationBuilder.CreateIndex(
                name: "IX_TaskStocks_Id",
                table: "TaskStocks",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TaskStocks_StockId",
                table: "TaskStocks",
                column: "StockId");

            migrationBuilder.CreateIndex(
                name: "IX_TransactionLogs_Areas",
                table: "TransactionLogs",
                columns: new[] { "DepositorId", "DepositorCompanyId", "UserId", "OrderId", "OrderItemId", "ReturnId", "ReturnItemId", "ReceiptId", "ReceiptItemId", "WorkTaskId", "CreatedDate" });

            migrationBuilder.CreateIndex(
                name: "IX_TransactionLogs_Id",
                table: "TransactionLogs",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TransactionTypes_Areas",
                table: "TransactionTypes",
                columns: new[] { "Code", "Description", "DepositorCompanyId", "CreatedDate" });

            migrationBuilder.CreateIndex(
                name: "IX_TransactionTypes_DepositorCompanyId",
                table: "TransactionTypes",
                column: "DepositorCompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_TransactionTypes_Id",
                table: "TransactionTypes",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Units_Areas",
                table: "Units",
                columns: new[] { "Code", "Description", "DepositorCompanyId", "CreatedDate" });

            migrationBuilder.CreateIndex(
                name: "IX_Units_DepositorCompanyId",
                table: "Units",
                column: "DepositorCompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Units_Id",
                table: "Units",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UnsuitReasons_Areas",
                table: "UnsuitReasons",
                columns: new[] { "Code", "Description", "DepositorCompanyId", "CreatedDate" });

            migrationBuilder.CreateIndex(
                name: "IX_UnsuitReasons_DepositorCompanyId",
                table: "UnsuitReasons",
                column: "DepositorCompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_UnsuitReasons_Id",
                table: "UnsuitReasons",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserDepositors_Areas",
                table: "UserDepositors",
                columns: new[] { "DepositorId", "UserId", "CreatedDate" });

            migrationBuilder.CreateIndex(
                name: "IX_UserDepositors_Id",
                table: "UserDepositors",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserDepositors_UserId",
                table: "UserDepositors",
                column: "UserId");

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
                name: "IX_WorkTasks_Areas",
                table: "WorkTasks",
                columns: new[] { "Code", "DepositorId", "DepositorCompanyId", "TaskListId", "StockId", "FromLocationId", "ToLocationId", "StatusId", "TransactionTypeId", "Quantity", "CreatedDate" });

            migrationBuilder.CreateIndex(
                name: "IX_WorkTasks_DepositorCompanyId",
                table: "WorkTasks",
                column: "DepositorCompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkTasks_DepositorId",
                table: "WorkTasks",
                column: "DepositorId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkTasks_FromLocationId",
                table: "WorkTasks",
                column: "FromLocationId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkTasks_Id",
                table: "WorkTasks",
                column: "Id",
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
                name: "IX_WorkTasks_ToLocationId",
                table: "WorkTasks",
                column: "ToLocationId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkTasks_TransactionTypeId",
                table: "WorkTasks",
                column: "TransactionTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Zones_Areas",
                table: "Zones",
                columns: new[] { "Code", "Description", "DepositorCompanyId", "BuildingId", "CreatedDate" });

            migrationBuilder.CreateIndex(
                name: "IX_Zones_BuildingId",
                table: "Zones",
                column: "BuildingId");

            migrationBuilder.CreateIndex(
                name: "IX_Zones_DepositorCompanyId",
                table: "Zones",
                column: "DepositorCompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Zones_Id",
                table: "Zones",
                column: "Id",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BarcodeAreas");

            migrationBuilder.DropTable(
                name: "BarcodePrinters");

            migrationBuilder.DropTable(
                name: "BarcodeSuppliers");

            migrationBuilder.DropTable(
                name: "BuildingDimensions");

            migrationBuilder.DropTable(
                name: "DepositorFeatures");

            migrationBuilder.DropTable(
                name: "EmailAuthenticators");

            migrationBuilder.DropTable(
                name: "ItemPackTypes");

            migrationBuilder.DropTable(
                name: "ItemUnitConversions");

            migrationBuilder.DropTable(
                name: "LocationCodeComponents");

            migrationBuilder.DropTable(
                name: "LocationCodeFormats");

            migrationBuilder.DropTable(
                name: "LocationCoordinates");

            migrationBuilder.DropTable(
                name: "LocationDepositors");

            migrationBuilder.DropTable(
                name: "LocationDimensions");

            migrationBuilder.DropTable(
                name: "LocationFeatures");

            migrationBuilder.DropTable(
                name: "LocationLockReasons");

            migrationBuilder.DropTable(
                name: "LocationPickingTypes");

            migrationBuilder.DropTable(
                name: "LocationPriorities");

            migrationBuilder.DropTable(
                name: "LocationProductAttributes");

            migrationBuilder.DropTable(
                name: "LocationProductConstraints");

            migrationBuilder.DropTable(
                name: "LocationProducts");

            migrationBuilder.DropTable(
                name: "LocationStockAttributes");

            migrationBuilder.DropTable(
                name: "LocationUnitConstraints");

            migrationBuilder.DropTable(
                name: "LocationZones");

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
                name: "OtpAuthenticators");

            migrationBuilder.DropTable(
                name: "PoAttributeValues");

            migrationBuilder.DropTable(
                name: "PoMemos");

            migrationBuilder.DropTable(
                name: "ProductAttributeValues");

            migrationBuilder.DropTable(
                name: "ProductDepositors");

            migrationBuilder.DropTable(
                name: "ProductStockAttributes");

            migrationBuilder.DropTable(
                name: "ReceiptAttributeValues");

            migrationBuilder.DropTable(
                name: "ReceiptItemMemos");

            migrationBuilder.DropTable(
                name: "ReceiptItmStockAttrValues");

            migrationBuilder.DropTable(
                name: "ReceiptMemos");

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
                name: "SiteDepositors");

            migrationBuilder.DropTable(
                name: "StockAttributeValues");

            migrationBuilder.DropTable(
                name: "StockMemos");

            migrationBuilder.DropTable(
                name: "StockReserveReasons");

            migrationBuilder.DropTable(
                name: "StockUnsuitReasons");

            migrationBuilder.DropTable(
                name: "TaskCodeFormats");

            migrationBuilder.DropTable(
                name: "TaskStocks");

            migrationBuilder.DropTable(
                name: "UserDepositors");

            migrationBuilder.DropTable(
                name: "UserOperationClaims");

            migrationBuilder.DropTable(
                name: "Barcodes");

            migrationBuilder.DropTable(
                name: "Printers");

            migrationBuilder.DropTable(
                name: "ProductBarcodes");

            migrationBuilder.DropTable(
                name: "LockReasons");

            migrationBuilder.DropTable(
                name: "PickingTypes");

            migrationBuilder.DropTable(
                name: "Zones");

            migrationBuilder.DropTable(
                name: "LogStocks");

            migrationBuilder.DropTable(
                name: "OrderAttributes");

            migrationBuilder.DropTable(
                name: "OrderShipItemTasks");

            migrationBuilder.DropTable(
                name: "StockPackTypes");

            migrationBuilder.DropTable(
                name: "PoAttributes");

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
                name: "WorkTasks");

            migrationBuilder.DropTable(
                name: "ItemUnits");

            migrationBuilder.DropTable(
                name: "AttributeInputTypes");

            migrationBuilder.DropTable(
                name: "OrderItems");

            migrationBuilder.DropTable(
                name: "OrderShipments");

            migrationBuilder.DropTable(
                name: "Stocks");

            migrationBuilder.DropTable(
                name: "TaskLists");

            migrationBuilder.DropTable(
                name: "TransactionTypes");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "ProgressStatuses");

            migrationBuilder.DropTable(
                name: "Shipments");

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
                name: "Receivers");

            migrationBuilder.DropTable(
                name: "Branches");

            migrationBuilder.DropTable(
                name: "ShipmentTypes");

            migrationBuilder.DropTable(
                name: "StorageSystems");

            migrationBuilder.DropTable(
                name: "PurchaseOrders");

            migrationBuilder.DropTable(
                name: "ReceiptTypes");

            migrationBuilder.DropTable(
                name: "ReturnTypes");

            migrationBuilder.DropTable(
                name: "ContainerUnits");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Distributors");

            migrationBuilder.DropTable(
                name: "Buildings");

            migrationBuilder.DropTable(
                name: "Depositors");

            migrationBuilder.DropTable(
                name: "PoTypes");

            migrationBuilder.DropTable(
                name: "Status");

            migrationBuilder.DropTable(
                name: "Suppliers");

            migrationBuilder.DropTable(
                name: "Sites");

            migrationBuilder.DropTable(
                name: "Companies");

            migrationBuilder.DropTable(
                name: "DepositorCompanies");

            migrationBuilder.DropTable(
                name: "Addresses");
        }
    }
}
