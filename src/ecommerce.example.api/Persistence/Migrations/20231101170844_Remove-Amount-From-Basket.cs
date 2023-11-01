using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class RemoveAmountFromBasket : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Amount",
                table: "Baskets");

            migrationBuilder.InsertData(
                table: "OperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { 14, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Orders.Admin", null },
                    { 15, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Orders.Read", null },
                    { 16, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Orders.Write", null },
                    { 17, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Orders.Add", null },
                    { 18, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Orders.Update", null },
                    { 19, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Orders.Delete", null },
                    { 20, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Baskets.Admin", null },
                    { 21, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Baskets.Read", null },
                    { 22, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Baskets.Write", null },
                    { 23, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Baskets.Add", null },
                    { 24, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Baskets.Update", null },
                    { 25, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Baskets.Delete", null },
                    { 26, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OrderItems.Admin", null },
                    { 27, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OrderItems.Read", null },
                    { 28, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OrderItems.Write", null },
                    { 29, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OrderItems.Add", null },
                    { 30, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OrderItems.Update", null },
                    { 31, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OrderItems.Delete", null }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 226, 214, 89, 135, 192, 44, 99, 152, 250, 154, 164, 183, 197, 28, 160, 254, 230, 187, 113, 60, 136, 132, 91, 173, 76, 185, 204, 177, 239, 201, 248, 123, 214, 128, 234, 98, 99, 207, 200, 250, 255, 88, 193, 138, 209, 176, 118, 161, 128, 189, 245, 69, 71, 241, 203, 94, 200, 196, 132, 110, 51, 104, 251, 160 }, new byte[] { 220, 186, 198, 62, 58, 109, 232, 198, 31, 37, 156, 83, 64, 83, 47, 249, 61, 222, 146, 32, 241, 114, 247, 219, 5, 142, 139, 72, 131, 101, 208, 139, 249, 137, 9, 4, 29, 250, 164, 93, 62, 140, 141, 102, 131, 208, 219, 115, 71, 146, 18, 35, 72, 230, 249, 0, 89, 4, 220, 103, 15, 147, 248, 248, 239, 192, 57, 20, 118, 162, 130, 61, 235, 2, 155, 58, 50, 93, 66, 164, 76, 45, 205, 213, 201, 193, 114, 156, 10, 96, 96, 15, 80, 26, 190, 153, 88, 124, 65, 115, 150, 77, 200, 50, 72, 10, 25, 93, 150, 27, 14, 130, 255, 66, 24, 141, 111, 21, 194, 98, 218, 232, 79, 251, 135, 132, 235, 181 } });

            migrationBuilder.CreateIndex(
                name: "IX_Baskets_ProductId",
                table: "Baskets",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_Baskets_Products_ProductId",
                table: "Baskets",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Baskets_Products_ProductId",
                table: "Baskets");

            migrationBuilder.DropIndex(
                name: "IX_Baskets_ProductId",
                table: "Baskets");

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.AddColumn<float>(
                name: "Amount",
                table: "Baskets",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 5, 238, 199, 61, 175, 80, 117, 101, 180, 47, 153, 2, 200, 182, 193, 104, 0, 253, 251, 105, 8, 27, 96, 251, 240, 222, 213, 74, 200, 90, 96, 192, 142, 217, 177, 213, 25, 251, 27, 199, 220, 139, 129, 238, 130, 229, 165, 230, 21, 93, 88, 215, 58, 131, 82, 224, 108, 69, 101, 112, 153, 60, 221, 115 }, new byte[] { 197, 158, 232, 22, 50, 129, 183, 200, 58, 238, 162, 34, 181, 185, 231, 198, 222, 101, 138, 91, 52, 161, 183, 25, 20, 211, 128, 62, 105, 159, 151, 110, 119, 81, 222, 118, 71, 117, 130, 108, 246, 48, 79, 109, 143, 223, 96, 128, 148, 230, 163, 133, 254, 73, 138, 233, 181, 223, 98, 95, 140, 140, 183, 250, 23, 99, 164, 9, 202, 195, 244, 198, 27, 126, 231, 173, 184, 162, 152, 160, 40, 174, 198, 157, 189, 18, 230, 12, 45, 59, 13, 38, 60, 196, 54, 181, 141, 166, 161, 243, 190, 224, 230, 41, 40, 238, 41, 101, 39, 163, 74, 84, 46, 108, 34, 96, 61, 34, 237, 252, 9, 102, 115, 200, 210, 44, 152, 17 } });
        }
    }
}
