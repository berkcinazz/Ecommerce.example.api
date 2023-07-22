using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddBrandAndProduct : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Brands",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Website = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AvatarFilePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Approved = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brands", x => x.Id);
                });

            //migrationBuilder.CreateTable(
            //    name: "OperationClaims",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
            //        UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //        DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_OperationClaims", x => x.Id);
            //    });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UnitPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    UnitsInStock = table.Column<int>(type: "int", nullable: false),
                    QuantityPerUnit = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CommonCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OnSale = table.Column<bool>(type: "bit", nullable: false),
                    ShippingCost = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BrandId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            //migrationBuilder.CreateTable(
            //    name: "Users",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        PasswordSalt = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
            //        PasswordHash = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
            //        Status = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
            //        AuthenticatorType = table.Column<int>(type: "int", nullable: false),
            //        CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
            //        UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //        DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Users", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "EmailAuthenticators",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        UserId = table.Column<int>(type: "int", nullable: false),
            //        ActivationKey = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        IsVerified = table.Column<bool>(type: "bit", nullable: false),
            //        CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
            //        UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //        DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_EmailAuthenticators", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_EmailAuthenticators_Users_UserId",
            //            column: x => x.UserId,
            //            principalTable: "Users",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "OtpAuthenticators",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        UserId = table.Column<int>(type: "int", nullable: false),
            //        SecretKey = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
            //        IsVerified = table.Column<bool>(type: "bit", nullable: false),
            //        CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
            //        UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //        DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_OtpAuthenticators", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_OtpAuthenticators_Users_UserId",
            //            column: x => x.UserId,
            //            principalTable: "Users",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "RefreshTokens",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        UserId = table.Column<int>(type: "int", nullable: false),
            //        Token = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        Expires = table.Column<DateTime>(type: "datetime2", nullable: false),
            //        CreatedByIp = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        Revoked = table.Column<DateTime>(type: "datetime2", nullable: true),
            //        RevokedByIp = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        ReplacedByToken = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        ReasonRevoked = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
            //        UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //        DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_RefreshTokens", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_RefreshTokens_Users_UserId",
            //            column: x => x.UserId,
            //            principalTable: "Users",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "UserOperationClaims",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        UserId = table.Column<int>(type: "int", nullable: false),
            //        OperationClaimId = table.Column<int>(type: "int", nullable: false),
            //        CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
            //        UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //        DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_UserOperationClaims", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_UserOperationClaims_OperationClaims_OperationClaimId",
            //            column: x => x.OperationClaimId,
            //            principalTable: "OperationClaims",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //        table.ForeignKey(
            //            name: "FK_UserOperationClaims_Users_UserId",
            //            column: x => x.UserId,
            //            principalTable: "Users",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            //migrationBuilder.InsertData(
            //    table: "OperationClaims",
            //    columns: new[] { "Id", "CreatedDate", "DeletedDate", "Name", "UpdatedDate" },
            //    values: new object[,]
            //    {
            //        { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Admin", null },
            //        { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Products.Admin", null },
            //        { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Products.Read", null },
            //        { 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Products.Write", null },
            //        { 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Products.Add", null },
            //        { 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Products.Update", null },
            //        { 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Products.Delete", null },
            //        { 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Brands.Admin", null },
            //        { 9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Brands.Read", null },
            //        { 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Brands.Write", null },
            //        { 11, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Brands.Add", null },
            //        { 12, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Brands.Update", null },
            //        { 13, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Brands.Delete", null }
            //    });

            //migrationBuilder.InsertData(
            //    table: "Users",
            //    columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "FirstName", "LastName", "PasswordHash", "PasswordSalt", "Status", "UpdatedDate" },
            //    values: new object[] { 1, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "admin@admin.com", "Admin", "NArchitecture", new byte[] { 236, 235, 52, 15, 133, 109, 214, 234, 146, 242, 34, 13, 118, 120, 2, 250, 64, 217, 69, 95, 245, 79, 95, 118, 15, 120, 235, 133, 191, 232, 5, 66, 235, 117, 215, 81, 32, 206, 167, 198, 77, 95, 200, 121, 93, 245, 240, 21, 48, 77, 23, 165, 168, 1, 232, 143, 222, 109, 100, 195, 15, 1, 30, 206 }, new byte[] { 107, 127, 45, 172, 126, 139, 182, 111, 140, 139, 131, 207, 216, 174, 68, 157, 146, 253, 233, 46, 212, 67, 118, 4, 248, 28, 187, 86, 228, 122, 84, 165, 178, 205, 8, 152, 106, 204, 82, 2, 80, 181, 70, 222, 145, 112, 232, 58, 36, 168, 236, 198, 128, 17, 188, 45, 87, 202, 205, 70, 139, 241, 39, 68, 3, 152, 165, 25, 109, 202, 46, 175, 247, 207, 248, 145, 9, 148, 185, 237, 93, 90, 196, 238, 149, 217, 139, 88, 37, 203, 130, 227, 11, 225, 255, 114, 254, 22, 227, 21, 67, 11, 152, 38, 187, 46, 127, 205, 11, 169, 197, 135, 0, 99, 251, 241, 247, 53, 71, 143, 145, 6, 159, 174, 7, 180, 170, 68 }, true, null });

            //migrationBuilder.InsertData(
            //    table: "UserOperationClaims",
            //    columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
            //    values: new object[] { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, 1 });

            //migrationBuilder.CreateIndex(
            //    name: "IX_EmailAuthenticators_UserId",
            //    table: "EmailAuthenticators",
            //    column: "UserId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_OtpAuthenticators_UserId",
            //    table: "OtpAuthenticators",
            //    column: "UserId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_RefreshTokens_UserId",
            //    table: "RefreshTokens",
            //    column: "UserId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_UserOperationClaims_OperationClaimId",
            //    table: "UserOperationClaims",
            //    column: "OperationClaimId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_UserOperationClaims_UserId",
            //    table: "UserOperationClaims",
            //    column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Brands");

            //migrationBuilder.DropTable(
            //    name: "EmailAuthenticators");

            //migrationBuilder.DropTable(
            //    name: "OtpAuthenticators");

            migrationBuilder.DropTable(
                name: "Products");

            //migrationBuilder.DropTable(
            //    name: "RefreshTokens");

            //migrationBuilder.DropTable(
            //    name: "UserOperationClaims");

            //migrationBuilder.DropTable(
            //    name: "OperationClaims");

            //migrationBuilder.DropTable(
            //    name: "Users");
        }
    }
}
