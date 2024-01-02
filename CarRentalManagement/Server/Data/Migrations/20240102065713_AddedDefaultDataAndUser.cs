using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedDefaultDataAndUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_bookings_Vehicles_VehicleID",
                table: "bookings");

            migrationBuilder.DropForeignKey(
                name: "FK_bookings_customers_CustomerID",
                table: "bookings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_customers",
                table: "customers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_bookings",
                table: "bookings");

            migrationBuilder.RenameTable(
                name: "customers",
                newName: "Customers");

            migrationBuilder.RenameTable(
                name: "bookings",
                newName: "Bookings");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Vehicles",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Models",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Makes",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Customers",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Colours",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Bookings",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_bookings_VehicleID",
                table: "Bookings",
                newName: "IX_Bookings_VehicleID");

            migrationBuilder.RenameIndex(
                name: "IX_bookings_CustomerID",
                table: "Bookings",
                newName: "IX_Bookings_CustomerID");

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "Models",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "Makes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "Colours",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "Bookings",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Customers",
                table: "Customers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Bookings",
                table: "Bookings",
                column: "Id");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", null, "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "d1d63479-ef32-4558-8ab6-2005212fe90b", "admin@localhost.com", false, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEFzWOojatv2WJDjQkdcK5EYPxzvXCiMf8oQ0a18FRPjgu8caYDDqewfzt70eu948fw==", null, false, "c6f3cfd7-4885-4bfa-9e66-9c31e16d6bc9", false, "admin@localhost.com" });

            migrationBuilder.InsertData(
                table: "Colours",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 1, 2, 14, 57, 13, 232, DateTimeKind.Local).AddTicks(6130), new DateTime(2024, 1, 2, 14, 57, 13, 232, DateTimeKind.Local).AddTicks(6146), "Black", "System" },
                    { 2, "System", new DateTime(2024, 1, 2, 14, 57, 13, 232, DateTimeKind.Local).AddTicks(6150), new DateTime(2024, 1, 2, 14, 57, 13, 232, DateTimeKind.Local).AddTicks(6151), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Makes",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 1, 2, 14, 57, 13, 232, DateTimeKind.Local).AddTicks(7249), new DateTime(2024, 1, 2, 14, 57, 13, 232, DateTimeKind.Local).AddTicks(7250), "BMW", "System" },
                    { 2, "System", new DateTime(2024, 1, 2, 14, 57, 13, 232, DateTimeKind.Local).AddTicks(7253), new DateTime(2024, 1, 2, 14, 57, 13, 232, DateTimeKind.Local).AddTicks(7254), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 1, 2, 14, 57, 13, 232, DateTimeKind.Local).AddTicks(6803), new DateTime(2024, 1, 2, 14, 57, 13, 232, DateTimeKind.Local).AddTicks(6805), "3 Series", "System" },
                    { 2, "System", new DateTime(2024, 1, 2, 14, 57, 13, 232, DateTimeKind.Local).AddTicks(6807), new DateTime(2024, 1, 2, 14, 57, 13, 232, DateTimeKind.Local).AddTicks(6808), "X5", "System" },
                    { 3, "System", new DateTime(2024, 1, 2, 14, 57, 13, 232, DateTimeKind.Local).AddTicks(6810), new DateTime(2024, 1, 2, 14, 57, 13, 232, DateTimeKind.Local).AddTicks(6811), "Prius", "System" },
                    { 4, "System", new DateTime(2024, 1, 2, 14, 57, 13, 232, DateTimeKind.Local).AddTicks(6812), new DateTime(2024, 1, 2, 14, 57, 13, 232, DateTimeKind.Local).AddTicks(6813), "Rav4", "System" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_Customers_CustomerID",
                table: "Bookings",
                column: "CustomerID",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_Vehicles_VehicleID",
                table: "Bookings",
                column: "VehicleID",
                principalTable: "Vehicles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_Customers_CustomerID",
                table: "Bookings");

            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_Vehicles_VehicleID",
                table: "Bookings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Customers",
                table: "Customers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Bookings",
                table: "Bookings");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "Models");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "Makes");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "Colours");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "Bookings");

            migrationBuilder.RenameTable(
                name: "Customers",
                newName: "customers");

            migrationBuilder.RenameTable(
                name: "Bookings",
                newName: "bookings");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Vehicles",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Models",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Makes",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "customers",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Colours",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "bookings",
                newName: "ID");

            migrationBuilder.RenameIndex(
                name: "IX_Bookings_VehicleID",
                table: "bookings",
                newName: "IX_bookings_VehicleID");

            migrationBuilder.RenameIndex(
                name: "IX_Bookings_CustomerID",
                table: "bookings",
                newName: "IX_bookings_CustomerID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_customers",
                table: "customers",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_bookings",
                table: "bookings",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_bookings_Vehicles_VehicleID",
                table: "bookings",
                column: "VehicleID",
                principalTable: "Vehicles",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_bookings_customers_CustomerID",
                table: "bookings",
                column: "CustomerID",
                principalTable: "customers",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
