using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddOrderOrderItemBasket : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Baskets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<float>(type: "real", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Baskets", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrderItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<float>(type: "real", nullable: false),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItems", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TotalAmount = table.Column<float>(type: "real", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 5, 238, 199, 61, 175, 80, 117, 101, 180, 47, 153, 2, 200, 182, 193, 104, 0, 253, 251, 105, 8, 27, 96, 251, 240, 222, 213, 74, 200, 90, 96, 192, 142, 217, 177, 213, 25, 251, 27, 199, 220, 139, 129, 238, 130, 229, 165, 230, 21, 93, 88, 215, 58, 131, 82, 224, 108, 69, 101, 112, 153, 60, 221, 115 }, new byte[] { 197, 158, 232, 22, 50, 129, 183, 200, 58, 238, 162, 34, 181, 185, 231, 198, 222, 101, 138, 91, 52, 161, 183, 25, 20, 211, 128, 62, 105, 159, 151, 110, 119, 81, 222, 118, 71, 117, 130, 108, 246, 48, 79, 109, 143, 223, 96, 128, 148, 230, 163, 133, 254, 73, 138, 233, 181, 223, 98, 95, 140, 140, 183, 250, 23, 99, 164, 9, 202, 195, 244, 198, 27, 126, 231, 173, 184, 162, 152, 160, 40, 174, 198, 157, 189, 18, 230, 12, 45, 59, 13, 38, 60, 196, 54, 181, 141, 166, 161, 243, 190, 224, 230, 41, 40, 238, 41, 101, 39, 163, 74, 84, 46, 108, 34, 96, 61, 34, 237, 252, 9, 102, 115, 200, 210, 44, 152, 17 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Baskets");

            migrationBuilder.DropTable(
                name: "OrderItems");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 236, 235, 52, 15, 133, 109, 214, 234, 146, 242, 34, 13, 118, 120, 2, 250, 64, 217, 69, 95, 245, 79, 95, 118, 15, 120, 235, 133, 191, 232, 5, 66, 235, 117, 215, 81, 32, 206, 167, 198, 77, 95, 200, 121, 93, 245, 240, 21, 48, 77, 23, 165, 168, 1, 232, 143, 222, 109, 100, 195, 15, 1, 30, 206 }, new byte[] { 107, 127, 45, 172, 126, 139, 182, 111, 140, 139, 131, 207, 216, 174, 68, 157, 146, 253, 233, 46, 212, 67, 118, 4, 248, 28, 187, 86, 228, 122, 84, 165, 178, 205, 8, 152, 106, 204, 82, 2, 80, 181, 70, 222, 145, 112, 232, 58, 36, 168, 236, 198, 128, 17, 188, 45, 87, 202, 205, 70, 139, 241, 39, 68, 3, 152, 165, 25, 109, 202, 46, 175, 247, 207, 248, 145, 9, 148, 185, 237, 93, 90, 196, 238, 149, 217, 139, 88, 37, 203, 130, 227, 11, 225, 255, 114, 254, 22, 227, 21, 67, 11, 152, 38, 187, 46, 127, 205, 11, 169, 197, 135, 0, 99, 251, 241, 247, 53, 71, 143, 145, 6, 159, 174, 7, 180, 170, 68 } });
        }
    }
}
