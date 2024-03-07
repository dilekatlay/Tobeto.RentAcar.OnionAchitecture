using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddTransmission : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("c79521e4-b46a-4f8c-81a9-3a923718f337"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("09da6fca-aed4-4276-ae1e-de48adeaa37a"));

            migrationBuilder.CreateTable(
                name: "Transmissions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transmissions", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "PasswordHash", "PasswordSalt", "UpdatedDate" },
                values: new object[] { new Guid("9438de4d-b712-4e1e-b5b0-a7ab84389dee"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@kodlama.io", new byte[] { 102, 226, 9, 165, 116, 35, 141, 157, 48, 163, 37, 236, 141, 46, 234, 240, 105, 14, 143, 47, 123, 43, 44, 140, 76, 158, 230, 244, 57, 24, 10, 33, 89, 202, 0, 239, 251, 237, 254, 228, 150, 41, 140, 131, 188, 67, 17, 227, 29, 34, 98, 19, 74, 142, 188, 144, 25, 161, 48, 18, 255, 221, 98, 128 }, new byte[] { 222, 188, 254, 59, 35, 45, 172, 175, 22, 66, 171, 155, 165, 242, 228, 168, 45, 123, 136, 114, 82, 171, 173, 186, 244, 58, 37, 160, 157, 151, 250, 239, 148, 194, 202, 75, 41, 72, 23, 244, 90, 206, 214, 240, 207, 73, 97, 196, 49, 49, 129, 69, 2, 115, 181, 11, 72, 193, 7, 8, 26, 248, 130, 6, 140, 207, 81, 144, 248, 211, 231, 173, 125, 12, 145, 121, 179, 162, 97, 214, 81, 113, 89, 162, 147, 115, 242, 180, 135, 137, 250, 55, 169, 22, 140, 253, 129, 129, 100, 140, 37, 12, 60, 101, 135, 65, 213, 114, 85, 216, 160, 180, 32, 235, 52, 239, 83, 123, 139, 93, 135, 55, 100, 156, 126, 28, 131, 119 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("384aa712-c085-4c83-9691-6189151617cf"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("9438de4d-b712-4e1e-b5b0-a7ab84389dee") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Transmissions");

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("384aa712-c085-4c83-9691-6189151617cf"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9438de4d-b712-4e1e-b5b0-a7ab84389dee"));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "PasswordHash", "PasswordSalt", "UpdatedDate" },
                values: new object[] { new Guid("09da6fca-aed4-4276-ae1e-de48adeaa37a"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@kodlama.io", new byte[] { 83, 253, 113, 27, 205, 19, 26, 36, 141, 107, 106, 131, 60, 89, 108, 97, 206, 23, 69, 225, 89, 212, 214, 25, 236, 61, 66, 27, 141, 164, 133, 192, 153, 44, 109, 92, 51, 75, 234, 195, 136, 242, 251, 54, 175, 150, 77, 232, 105, 176, 44, 43, 140, 183, 107, 62, 194, 206, 172, 137, 186, 170, 178, 13 }, new byte[] { 121, 9, 167, 68, 45, 77, 28, 62, 114, 73, 107, 124, 2, 192, 133, 181, 45, 102, 41, 223, 34, 191, 86, 20, 3, 246, 179, 86, 169, 203, 204, 254, 41, 233, 25, 101, 45, 234, 150, 130, 94, 226, 223, 68, 140, 178, 202, 88, 229, 105, 154, 50, 139, 119, 123, 212, 21, 152, 118, 17, 27, 212, 222, 135, 74, 172, 56, 81, 207, 139, 66, 225, 59, 181, 51, 108, 202, 32, 31, 44, 48, 36, 4, 224, 172, 144, 157, 62, 238, 53, 123, 45, 138, 153, 246, 234, 81, 226, 97, 57, 94, 176, 193, 69, 227, 179, 150, 232, 71, 136, 125, 32, 104, 173, 102, 10, 200, 11, 58, 132, 177, 8, 127, 239, 160, 68, 115, 47 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("c79521e4-b46a-4f8c-81a9-3a923718f337"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("09da6fca-aed4-4276-ae1e-de48adeaa37a") });
        }
    }
}
