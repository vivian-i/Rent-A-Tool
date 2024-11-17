using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RentAToolWebApp.Migrations
{
    /// <inheritdoc />
    public partial class changeGuid2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clients_Addresses_AddressId",
                table: "Clients");

            migrationBuilder.DropForeignKey(
                name: "FK_Invoices_Rentals_RentalId",
                table: "Invoices");

            migrationBuilder.DropForeignKey(
                name: "FK_Rentals_Clients_ClientId",
                table: "Rentals");

            migrationBuilder.DropForeignKey(
                name: "FK_Rentals_Equipments_EquipmentId",
                table: "Rentals");

            migrationBuilder.DropIndex(
                name: "IX_Rentals_EquipmentId",
                table: "Rentals");

            migrationBuilder.DropIndex(
                name: "IX_Maintenances_EquipmentId",
                table: "Maintenances");

            migrationBuilder.DropIndex(
                name: "IX_Clients_AddressId",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "EquipmentId",
                table: "Rentals");

            migrationBuilder.DropColumn(
                name: "AddressId",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AppUsers");

            migrationBuilder.DropColumn(
                name: "IdentityId",
                table: "AppUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AppUsers");

            migrationBuilder.RenameColumn(
                name: "Role",
                table: "AppUsers",
                newName: "RefreshToken");

            migrationBuilder.RenameColumn(
                name: "PhoneNumber",
                table: "AppUsers",
                newName: "PasswordHash");

            migrationBuilder.RenameColumn(
                name: "Password",
                table: "AppUsers",
                newName: "Name");

            migrationBuilder.AddColumn<int>(
                name: "BatchInvoiceId",
                table: "Invoices",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EquipmentId",
                table: "Invoices",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "Condition",
                table: "Equipments",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "RentalId",
                table: "Equipments",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ClientId",
                table: "AppUsers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "AppUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "RefreshTokenExpiryTime",
                table: "AppUsers",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ClientId",
                table: "Addresses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "BatchInvoices",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BatchInvoices", x => x.id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Maintenances_EquipmentId",
                table: "Maintenances",
                column: "EquipmentId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Invoices_BatchInvoiceId",
                table: "Invoices",
                column: "BatchInvoiceId");

            migrationBuilder.CreateIndex(
                name: "IX_Invoices_EquipmentId",
                table: "Invoices",
                column: "EquipmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Equipments_RentalId",
                table: "Equipments",
                column: "RentalId");

            migrationBuilder.CreateIndex(
                name: "IX_AppUsers_ClientId",
                table: "AppUsers",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_ClientId",
                table: "Addresses",
                column: "ClientId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Addresses_Clients_ClientId",
                table: "Addresses",
                column: "ClientId",
                principalTable: "Clients",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AppUsers_Clients_ClientId",
                table: "AppUsers",
                column: "ClientId",
                principalTable: "Clients",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Equipments_Rentals_RentalId",
                table: "Equipments",
                column: "RentalId",
                principalTable: "Rentals",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Invoices_BatchInvoices_BatchInvoiceId",
                table: "Invoices",
                column: "BatchInvoiceId",
                principalTable: "BatchInvoices",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Invoices_Equipments_EquipmentId",
                table: "Invoices",
                column: "EquipmentId",
                principalTable: "Equipments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Invoices_Rentals_RentalId",
                table: "Invoices",
                column: "RentalId",
                principalTable: "Rentals",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Rentals_Clients_ClientId",
                table: "Rentals",
                column: "ClientId",
                principalTable: "Clients",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Addresses_Clients_ClientId",
                table: "Addresses");

            migrationBuilder.DropForeignKey(
                name: "FK_AppUsers_Clients_ClientId",
                table: "AppUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_Equipments_Rentals_RentalId",
                table: "Equipments");

            migrationBuilder.DropForeignKey(
                name: "FK_Invoices_BatchInvoices_BatchInvoiceId",
                table: "Invoices");

            migrationBuilder.DropForeignKey(
                name: "FK_Invoices_Equipments_EquipmentId",
                table: "Invoices");

            migrationBuilder.DropForeignKey(
                name: "FK_Invoices_Rentals_RentalId",
                table: "Invoices");

            migrationBuilder.DropForeignKey(
                name: "FK_Rentals_Clients_ClientId",
                table: "Rentals");

            migrationBuilder.DropTable(
                name: "BatchInvoices");

            migrationBuilder.DropIndex(
                name: "IX_Maintenances_EquipmentId",
                table: "Maintenances");

            migrationBuilder.DropIndex(
                name: "IX_Invoices_BatchInvoiceId",
                table: "Invoices");

            migrationBuilder.DropIndex(
                name: "IX_Invoices_EquipmentId",
                table: "Invoices");

            migrationBuilder.DropIndex(
                name: "IX_Equipments_RentalId",
                table: "Equipments");

            migrationBuilder.DropIndex(
                name: "IX_AppUsers_ClientId",
                table: "AppUsers");

            migrationBuilder.DropIndex(
                name: "IX_Addresses_ClientId",
                table: "Addresses");

            migrationBuilder.DropColumn(
                name: "BatchInvoiceId",
                table: "Invoices");

            migrationBuilder.DropColumn(
                name: "EquipmentId",
                table: "Invoices");

            migrationBuilder.DropColumn(
                name: "RentalId",
                table: "Equipments");

            migrationBuilder.DropColumn(
                name: "ClientId",
                table: "AppUsers");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "AppUsers");

            migrationBuilder.DropColumn(
                name: "RefreshTokenExpiryTime",
                table: "AppUsers");

            migrationBuilder.DropColumn(
                name: "ClientId",
                table: "Addresses");

            migrationBuilder.RenameColumn(
                name: "RefreshToken",
                table: "AppUsers",
                newName: "Role");

            migrationBuilder.RenameColumn(
                name: "PasswordHash",
                table: "AppUsers",
                newName: "PhoneNumber");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "AppUsers",
                newName: "Password");

            migrationBuilder.AddColumn<int>(
                name: "EquipmentId",
                table: "Rentals",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Condition",
                table: "Equipments",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "AddressId",
                table: "Clients",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AppUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "IdentityId",
                table: "AppUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AppUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Rentals_EquipmentId",
                table: "Rentals",
                column: "EquipmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Maintenances_EquipmentId",
                table: "Maintenances",
                column: "EquipmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Clients_AddressId",
                table: "Clients",
                column: "AddressId");

            migrationBuilder.AddForeignKey(
                name: "FK_Clients_Addresses_AddressId",
                table: "Clients",
                column: "AddressId",
                principalTable: "Addresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Invoices_Rentals_RentalId",
                table: "Invoices",
                column: "RentalId",
                principalTable: "Rentals",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Rentals_Clients_ClientId",
                table: "Rentals",
                column: "ClientId",
                principalTable: "Clients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Rentals_Equipments_EquipmentId",
                table: "Rentals",
                column: "EquipmentId",
                principalTable: "Equipments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
