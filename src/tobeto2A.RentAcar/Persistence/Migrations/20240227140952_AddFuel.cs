using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddFuel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("cb34b330-354d-4185-9f31-d4a3a8349429"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f9737e91-e54c-4928-9583-11876ead772f"));

            migrationBuilder.CreateTable(
                name: "Fuels",
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
                    table.PrimaryKey("PK_Fuels", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "PasswordHash", "PasswordSalt", "UpdatedDate" },
                values: new object[] { new Guid("09da6fca-aed4-4276-ae1e-de48adeaa37a"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@kodlama.io", new byte[] { 83, 253, 113, 27, 205, 19, 26, 36, 141, 107, 106, 131, 60, 89, 108, 97, 206, 23, 69, 225, 89, 212, 214, 25, 236, 61, 66, 27, 141, 164, 133, 192, 153, 44, 109, 92, 51, 75, 234, 195, 136, 242, 251, 54, 175, 150, 77, 232, 105, 176, 44, 43, 140, 183, 107, 62, 194, 206, 172, 137, 186, 170, 178, 13 }, new byte[] { 121, 9, 167, 68, 45, 77, 28, 62, 114, 73, 107, 124, 2, 192, 133, 181, 45, 102, 41, 223, 34, 191, 86, 20, 3, 246, 179, 86, 169, 203, 204, 254, 41, 233, 25, 101, 45, 234, 150, 130, 94, 226, 223, 68, 140, 178, 202, 88, 229, 105, 154, 50, 139, 119, 123, 212, 21, 152, 118, 17, 27, 212, 222, 135, 74, 172, 56, 81, 207, 139, 66, 225, 59, 181, 51, 108, 202, 32, 31, 44, 48, 36, 4, 224, 172, 144, 157, 62, 238, 53, 123, 45, 138, 153, 246, 234, 81, 226, 97, 57, 94, 176, 193, 69, 227, 179, 150, 232, 71, 136, 125, 32, 104, 173, 102, 10, 200, 11, 58, 132, 177, 8, 127, 239, 160, 68, 115, 47 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("c79521e4-b46a-4f8c-81a9-3a923718f337"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("09da6fca-aed4-4276-ae1e-de48adeaa37a") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Fuels");

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("c79521e4-b46a-4f8c-81a9-3a923718f337"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("09da6fca-aed4-4276-ae1e-de48adeaa37a"));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "PasswordHash", "PasswordSalt", "UpdatedDate" },
                values: new object[] { new Guid("f9737e91-e54c-4928-9583-11876ead772f"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@kodlama.io", new byte[] { 10, 7, 61, 13, 143, 44, 183, 26, 63, 228, 132, 80, 234, 105, 3, 160, 3, 244, 231, 58, 85, 207, 209, 211, 10, 241, 242, 138, 179, 131, 62, 96, 77, 34, 236, 56, 234, 39, 103, 134, 2, 82, 111, 149, 192, 81, 240, 27, 238, 15, 232, 81, 143, 102, 221, 148, 11, 61, 209, 164, 239, 191, 199, 154 }, new byte[] { 69, 177, 221, 255, 221, 146, 189, 224, 122, 20, 76, 100, 174, 161, 110, 127, 193, 217, 175, 158, 136, 161, 222, 248, 61, 96, 114, 31, 6, 21, 245, 179, 189, 44, 246, 181, 95, 15, 108, 250, 22, 108, 129, 157, 167, 245, 74, 33, 126, 64, 181, 8, 113, 233, 77, 122, 144, 131, 29, 13, 1, 155, 35, 144, 28, 21, 123, 84, 254, 69, 205, 105, 3, 11, 13, 157, 115, 198, 242, 253, 126, 200, 225, 197, 43, 157, 17, 198, 118, 136, 241, 149, 140, 3, 129, 214, 111, 36, 163, 201, 198, 42, 248, 122, 187, 82, 120, 76, 35, 223, 141, 228, 205, 2, 88, 62, 60, 117, 70, 152, 15, 174, 83, 206, 79, 141, 54, 155 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("cb34b330-354d-4185-9f31-d4a3a8349429"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("f9737e91-e54c-4928-9583-11876ead772f") });
        }
    }
}
