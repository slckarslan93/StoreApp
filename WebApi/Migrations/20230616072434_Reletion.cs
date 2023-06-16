using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApi.Migrations
{
    public partial class Reletion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3f55d5ec-8ac0-4a72-b2e4-9624b41f50d4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "acfe3f9b-060b-4b5c-8427-4179614b4dfb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c4c0787c-f105-44bf-b3d8-1419181798e2");

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Books",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "7eec9b88-5e2d-4738-a0a3-247c937c6063", "5408cb30-f210-45fe-aec1-8c9b7029c9e4", "User", "USER" },
                    { "7fc868d8-9136-49db-ab3a-7eb8e18d960c", "1a1d678e-9c1d-432c-9e7a-6a9090df320e", "Admin", "ADMIN" },
                    { "f188ce5e-0c00-4a5c-b8f1-9d7ec350ed43", "82f527fd-8969-418c-af20-084f3a569a03", "Editor", "EDITOR" }
                });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CategoryId", "Title" },
                values: new object[] { 1, "Karagöz ve Hacivat" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                column: "CategoryId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                column: "CategoryId",
                value: 1);

            migrationBuilder.CreateIndex(
                name: "IX_Books_CategoryId",
                table: "Books",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Categories_CategoryId",
                table: "Books",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Categories_CategoryId",
                table: "Books");

            migrationBuilder.DropIndex(
                name: "IX_Books_CategoryId",
                table: "Books");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7eec9b88-5e2d-4738-a0a3-247c937c6063");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7fc868d8-9136-49db-ab3a-7eb8e18d960c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f188ce5e-0c00-4a5c-b8f1-9d7ec350ed43");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Books");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3f55d5ec-8ac0-4a72-b2e4-9624b41f50d4", "49d92c8d-1b9d-42e0-96f3-4d971f57a4ef", "Admin", "ADMIN" },
                    { "acfe3f9b-060b-4b5c-8427-4179614b4dfb", "f59301e4-e169-4a5c-ae84-53525ee7b0ee", "User", "USER" },
                    { "c4c0787c-f105-44bf-b3d8-1419181798e2", "c6987440-0f3e-4a05-83b7-f839ceeaf315", "Editor", "EDITOR" }
                });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                column: "Title",
                value: "Karagöz Ve Hacivat");
        }
    }
}
