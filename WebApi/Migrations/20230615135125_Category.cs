using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApi.Migrations
{
    public partial class Category : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "43672955-c87c-4373-8f71-9a08a3bd6923");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f26dfbc7-b0fb-4e14-adbc-4d29ecf862a9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f62f4b83-0dd4-476b-b3a2-4ab3fbdfa3b1");

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3f55d5ec-8ac0-4a72-b2e4-9624b41f50d4", "49d92c8d-1b9d-42e0-96f3-4d971f57a4ef", "Admin", "ADMIN" },
                    { "acfe3f9b-060b-4b5c-8427-4179614b4dfb", "f59301e4-e169-4a5c-ae84-53525ee7b0ee", "User", "USER" },
                    { "c4c0787c-f105-44bf-b3d8-1419181798e2", "c6987440-0f3e-4a05-83b7-f839ceeaf315", "Editor", "EDITOR" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[,]
                {
                    { 1, "Computer Science" },
                    { 2, "Network" },
                    { 3, "Database Management Systems" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Categories");

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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "43672955-c87c-4373-8f71-9a08a3bd6923", "133e0704-e59e-44e6-8c9b-21239b040a4c", "Editor", "EDITOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f26dfbc7-b0fb-4e14-adbc-4d29ecf862a9", "2d65fce7-c9f3-43ab-af48-cb3830e61257", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f62f4b83-0dd4-476b-b3a2-4ab3fbdfa3b1", "d77fe236-81d9-4053-bbdb-7d11e3d54afe", "User", "USER" });
        }
    }
}
