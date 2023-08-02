using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GalloFlix.Migrations
{
    public partial class criandobanco : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RoleClaims_AspNetRoles_RoleId",
                table: "RoleClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_UserRoles_AspNetRoles_RoleId",
                table: "UserRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetRoles",
                table: "AspNetRoles");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7a82e1ec-9739-4924-bfe1-b795530bbe2f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ae9613f-f043-48a0-a131-114a067baa80");

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "21bac4e9-ff9f-4423-99f7-704022267c35", "abecda1d-b194-47cd-83c9-546b8813bed4" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "21bac4e9-ff9f-4423-99f7-704022267c35");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "abecda1d-b194-47cd-83c9-546b8813bed4");

            migrationBuilder.RenameTable(
                name: "AspNetRoles",
                newName: "Roles");

            migrationBuilder.AlterColumn<string>(
                name: "Synopsis",
                table: "Movie",
                type: "varchar(8000)",
                maxLength: 8000,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(5000)",
                oldMaxLength: 5000)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "OriginalTitle",
                table: "Movie",
                type: "varchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 100)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Roles",
                table: "Roles",
                column: "Id");

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "55b5b130-38c8-4264-b452-9cce46a0e8bb", "f8af7d68-5881-47ef-9eb8-51a514084c64", "Moderador", "MODERADOR" },
                    { "5b2ca036-a13a-4440-927c-dce5d2b48417", "8163ec0e-3801-446f-b3f4-d8e21e87428e", "Administrador", "ADMINISTRADOR" },
                    { "bb1853b0-4814-4095-9ced-da955dbc227c", "db2482ca-5e9e-455b-a7b7-a6ad32f6e0fa", "Usuário", " USUÁRIO" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateOfBirth", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePicture", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "0930dd7c-55e2-4fd3-a64c-1e708e633bc3", 0, "68f44922-fd7e-49dc-93e5-e71fb7bdd388", new DateTime(2005, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "AppUser", "admin@gmail.com", true, false, null, "Seu Nome Completo", "ADMIN@GMAIL.COM", "ADMIN", "AQAAAAEAACcQAAAAEKF8Uw0XixgRgxWAVTRh/taR6SDa2QGw08mjLjrGLbyJhYoR4SviJ15vjV/+o08amg==", "14912345678", true, "/img/users/avatar.png", "83af9131-91da-4a66-96fe-5d02c47480ab", false, "Admin" });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "5b2ca036-a13a-4440-927c-dce5d2b48417", "0930dd7c-55e2-4fd3-a64c-1e708e633bc3" });

            migrationBuilder.AddForeignKey(
                name: "FK_RoleClaims_Roles_RoleId",
                table: "RoleClaims",
                column: "RoleId",
                principalTable: "Roles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserRoles_Roles_RoleId",
                table: "UserRoles",
                column: "RoleId",
                principalTable: "Roles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RoleClaims_Roles_RoleId",
                table: "RoleClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_UserRoles_Roles_RoleId",
                table: "UserRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Roles",
                table: "Roles");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "55b5b130-38c8-4264-b452-9cce46a0e8bb");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "bb1853b0-4814-4095-9ced-da955dbc227c");

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "5b2ca036-a13a-4440-927c-dce5d2b48417", "0930dd7c-55e2-4fd3-a64c-1e708e633bc3" });

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "5b2ca036-a13a-4440-927c-dce5d2b48417");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "0930dd7c-55e2-4fd3-a64c-1e708e633bc3");

            migrationBuilder.RenameTable(
                name: "Roles",
                newName: "AspNetRoles");

            migrationBuilder.AlterColumn<string>(
                name: "Synopsis",
                table: "Movie",
                type: "varchar(5000)",
                maxLength: 5000,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(8000)",
                oldMaxLength: 8000)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<int>(
                name: "OriginalTitle",
                table: "Movie",
                type: "int",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldMaxLength: 100)
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetRoles",
                table: "AspNetRoles",
                column: "Id");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "21bac4e9-ff9f-4423-99f7-704022267c35", "2dd4a0e2-d3ab-463b-a7d5-9ef9816ab98d", "Administrator", "ADMINISTRADOR" },
                    { "7a82e1ec-9739-4924-bfe1-b795530bbe2f", "1f86a16e-e04b-4e11-a664-bdce4d186915", "Usuário", "USUÁRIO" },
                    { "8ae9613f-f043-48a0-a131-114a067baa80", "85801f6d-d955-436c-b734-85daf3e2fa45", "Moderador", "MODERADOR" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateOfBirth", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePicture", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "abecda1d-b194-47cd-83c9-546b8813bed4", 0, "39cd47ac-7fb0-482d-aa28-357a340daabe", new DateTime(2006, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "AppUser", "marinaporfirio11@gmail.com", true, false, null, "Marina Porfirio", "MARINAPORFIRIO11@GMAIL.COM", "MARINAMUNHOZ", "AQAAAAEAACcQAAAAEPz1ukjNHtSbft9CdolAmI5369Iy3cj1E3eW0LLBHgJiY3dh9kaETzFPdneGhWzc+Q==", "14998091305", true, "/img/users/avatar.png", "b97fdd5d-a033-4128-8272-f7632d0c8542", false, "MarinaMunhoz" });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "21bac4e9-ff9f-4423-99f7-704022267c35", "abecda1d-b194-47cd-83c9-546b8813bed4" });

            migrationBuilder.AddForeignKey(
                name: "FK_RoleClaims_AspNetRoles_RoleId",
                table: "RoleClaims",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserRoles_AspNetRoles_RoleId",
                table: "UserRoles",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
