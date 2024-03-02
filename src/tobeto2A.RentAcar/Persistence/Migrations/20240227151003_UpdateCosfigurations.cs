using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class UpdateCosfigurations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("384aa712-c085-4c83-9691-6189151617cf"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9438de4d-b712-4e1e-b5b0-a7ab84389dee"));

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
                name: "CompanyName",
                table: "CorporateCustomer",
                type: "nvarchar(50)",
                maxLength: 50,
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

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "PasswordHash", "PasswordSalt", "UpdatedDate" },
                values: new object[] { new Guid("4ea8f0bf-dcb3-4faa-a450-849fc13b1e65"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@kodlama.io", new byte[] { 107, 90, 213, 185, 150, 71, 69, 209, 57, 38, 117, 60, 41, 233, 254, 226, 174, 164, 71, 187, 49, 11, 220, 83, 103, 61, 180, 195, 156, 158, 213, 155, 149, 20, 216, 10, 156, 58, 138, 215, 9, 50, 70, 211, 157, 101, 218, 254, 164, 169, 193, 178, 54, 109, 140, 218, 106, 202, 202, 65, 232, 44, 88, 124 }, new byte[] { 169, 105, 194, 235, 19, 181, 48, 141, 64, 248, 211, 166, 151, 149, 81, 134, 74, 46, 50, 201, 161, 250, 168, 195, 234, 250, 106, 121, 191, 132, 179, 112, 194, 119, 115, 103, 148, 200, 196, 233, 130, 74, 133, 186, 159, 106, 68, 251, 10, 29, 212, 247, 48, 197, 109, 188, 54, 130, 87, 122, 85, 87, 76, 90, 70, 249, 23, 23, 78, 113, 219, 171, 125, 2, 99, 189, 130, 138, 133, 130, 193, 147, 253, 6, 159, 169, 19, 171, 105, 113, 128, 22, 41, 120, 251, 19, 248, 194, 207, 1, 148, 87, 103, 201, 147, 9, 18, 106, 164, 106, 234, 201, 79, 117, 54, 25, 2, 160, 16, 99, 225, 24, 193, 243, 207, 58, 153, 81 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("08f84936-5d60-44f1-8607-e1447ccea663"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("4ea8f0bf-dcb3-4faa-a450-849fc13b1e65") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("08f84936-5d60-44f1-8607-e1447ccea663"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4ea8f0bf-dcb3-4faa-a450-849fc13b1e65"));

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
                name: "CompanyName",
                table: "CorporateCustomer",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

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

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "PasswordHash", "PasswordSalt", "UpdatedDate" },
                values: new object[] { new Guid("9438de4d-b712-4e1e-b5b0-a7ab84389dee"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@kodlama.io", new byte[] { 102, 226, 9, 165, 116, 35, 141, 157, 48, 163, 37, 236, 141, 46, 234, 240, 105, 14, 143, 47, 123, 43, 44, 140, 76, 158, 230, 244, 57, 24, 10, 33, 89, 202, 0, 239, 251, 237, 254, 228, 150, 41, 140, 131, 188, 67, 17, 227, 29, 34, 98, 19, 74, 142, 188, 144, 25, 161, 48, 18, 255, 221, 98, 128 }, new byte[] { 222, 188, 254, 59, 35, 45, 172, 175, 22, 66, 171, 155, 165, 242, 228, 168, 45, 123, 136, 114, 82, 171, 173, 186, 244, 58, 37, 160, 157, 151, 250, 239, 148, 194, 202, 75, 41, 72, 23, 244, 90, 206, 214, 240, 207, 73, 97, 196, 49, 49, 129, 69, 2, 115, 181, 11, 72, 193, 7, 8, 26, 248, 130, 6, 140, 207, 81, 144, 248, 211, 231, 173, 125, 12, 145, 121, 179, 162, 97, 214, 81, 113, 89, 162, 147, 115, 242, 180, 135, 137, 250, 55, 169, 22, 140, 253, 129, 129, 100, 140, 37, 12, 60, 101, 135, 65, 213, 114, 85, 216, 160, 180, 32, 235, 52, 239, 83, 123, 139, 93, 135, 55, 100, 156, 126, 28, 131, 119 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("384aa712-c085-4c83-9691-6189151617cf"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("9438de4d-b712-4e1e-b5b0-a7ab84389dee") });
        }
    }
}
