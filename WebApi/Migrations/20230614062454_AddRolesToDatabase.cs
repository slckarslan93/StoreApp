using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApi.Migrations
{
    public partial class AddRolesToDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}