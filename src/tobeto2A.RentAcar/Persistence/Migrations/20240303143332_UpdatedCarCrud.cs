using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedCarCrud : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_CorporateCustomer",
                table: "CorporateCustomer");

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("08f84936-5d60-44f1-8607-e1447ccea663"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4ea8f0bf-dcb3-4faa-a450-849fc13b1e65"));

            migrationBuilder.RenameTable(
                name: "CorporateCustomer",
                newName: "CorporateCustomers");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Transmissions",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Models",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "NationalIdentity",
                table: "IndividualCustomers",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nchar(11)",
                oldFixedLength: true,
                oldMaxLength: 11);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "IndividualCustomers",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "IndividualCustomers",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Fuels",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "Plate",
                table: "Cars",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(7)",
                oldMaxLength: 7);

            migrationBuilder.AlterColumn<int>(
                name: "Kilometer",
                table: "Cars",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 1000000,
                oldDefaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Brands",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "CompanyName",
                table: "CorporateCustomers",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AddPrimaryKey(
                name: "PK_CorporateCustomers",
                table: "CorporateCustomers",
                column: "Id");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "PasswordHash", "PasswordSalt", "UpdatedDate" },
                values: new object[] { new Guid("50ea7e9b-3b88-490c-9eae-b1d2ad6a0fec"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@kodlama.io", new byte[] { 191, 33, 147, 147, 132, 182, 45, 143, 245, 230, 255, 186, 108, 51, 114, 160, 193, 58, 76, 10, 196, 118, 9, 191, 107, 106, 149, 213, 246, 116, 83, 180, 201, 44, 147, 150, 168, 253, 131, 162, 173, 35, 183, 228, 31, 72, 98, 73, 150, 255, 59, 216, 137, 117, 242, 128, 109, 207, 83, 230, 45, 13, 133, 162 }, new byte[] { 188, 229, 90, 169, 88, 111, 78, 229, 52, 227, 25, 81, 124, 227, 159, 171, 47, 193, 73, 115, 24, 205, 116, 95, 161, 169, 169, 20, 24, 178, 216, 97, 10, 170, 231, 162, 22, 224, 4, 194, 136, 239, 49, 196, 165, 97, 252, 237, 244, 96, 167, 255, 165, 227, 142, 233, 67, 236, 189, 33, 131, 35, 237, 74, 79, 56, 1, 48, 51, 174, 221, 247, 191, 181, 247, 56, 3, 200, 154, 192, 177, 75, 209, 247, 91, 225, 3, 90, 243, 241, 161, 148, 148, 16, 137, 192, 223, 193, 213, 194, 134, 230, 149, 0, 176, 120, 111, 27, 239, 99, 239, 154, 139, 201, 91, 182, 141, 241, 193, 82, 195, 8, 238, 10, 167, 157, 139, 225 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("15e5cc1a-7b0c-43e6-9e7b-06bd6e0ff96f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("50ea7e9b-3b88-490c-9eae-b1d2ad6a0fec") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_CorporateCustomers",
                table: "CorporateCustomers");

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("15e5cc1a-7b0c-43e6-9e7b-06bd6e0ff96f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("50ea7e9b-3b88-490c-9eae-b1d2ad6a0fec"));

            migrationBuilder.RenameTable(
                name: "CorporateCustomers",
                newName: "CorporateCustomer");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Transmissions",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Models",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "NationalIdentity",
                table: "IndividualCustomers",
                type: "nchar(11)",
                fixedLength: true,
                maxLength: 11,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "IndividualCustomers",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "IndividualCustomers",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Fuels",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Plate",
                table: "Cars",
                type: "nvarchar(7)",
                maxLength: 7,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "Kilometer",
                table: "Cars",
                type: "int",
                maxLength: 1000000,
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Brands",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "CompanyName",
                table: "CorporateCustomer",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CorporateCustomer",
                table: "CorporateCustomer",
                column: "Id");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "PasswordHash", "PasswordSalt", "UpdatedDate" },
                values: new object[] { new Guid("4ea8f0bf-dcb3-4faa-a450-849fc13b1e65"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@kodlama.io", new byte[] { 107, 90, 213, 185, 150, 71, 69, 209, 57, 38, 117, 60, 41, 233, 254, 226, 174, 164, 71, 187, 49, 11, 220, 83, 103, 61, 180, 195, 156, 158, 213, 155, 149, 20, 216, 10, 156, 58, 138, 215, 9, 50, 70, 211, 157, 101, 218, 254, 164, 169, 193, 178, 54, 109, 140, 218, 106, 202, 202, 65, 232, 44, 88, 124 }, new byte[] { 169, 105, 194, 235, 19, 181, 48, 141, 64, 248, 211, 166, 151, 149, 81, 134, 74, 46, 50, 201, 161, 250, 168, 195, 234, 250, 106, 121, 191, 132, 179, 112, 194, 119, 115, 103, 148, 200, 196, 233, 130, 74, 133, 186, 159, 106, 68, 251, 10, 29, 212, 247, 48, 197, 109, 188, 54, 130, 87, 122, 85, 87, 76, 90, 70, 249, 23, 23, 78, 113, 219, 171, 125, 2, 99, 189, 130, 138, 133, 130, 193, 147, 253, 6, 159, 169, 19, 171, 105, 113, 128, 22, 41, 120, 251, 19, 248, 194, 207, 1, 148, 87, 103, 201, 147, 9, 18, 106, 164, 106, 234, 201, 79, 117, 54, 25, 2, 160, 16, 99, 225, 24, 193, 243, 207, 58, 153, 81 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("08f84936-5d60-44f1-8607-e1447ccea663"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("4ea8f0bf-dcb3-4faa-a450-849fc13b1e65") });
        }
    }
}
