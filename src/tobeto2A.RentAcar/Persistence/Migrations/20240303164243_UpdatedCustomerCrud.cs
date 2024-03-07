using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedCustomerCrud : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("4d2b05ce-d7fa-452d-b933-b628f3029e38"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7f57af5a-9026-4347-934b-363f386a0a69"));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "PasswordHash", "PasswordSalt", "UpdatedDate" },
                values: new object[] { new Guid("09f67b9a-d8d7-43f0-806e-947b52cb7dc5"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@kodlama.io", new byte[] { 58, 210, 101, 10, 118, 96, 167, 93, 45, 240, 116, 52, 222, 25, 248, 40, 197, 167, 18, 104, 166, 137, 121, 12, 135, 151, 227, 8, 63, 28, 96, 109, 90, 243, 239, 246, 85, 69, 154, 66, 42, 26, 172, 45, 181, 22, 2, 234, 89, 174, 26, 194, 73, 169, 181, 120, 121, 104, 73, 239, 87, 22, 25, 10 }, new byte[] { 81, 99, 186, 220, 106, 4, 201, 244, 245, 242, 221, 236, 121, 35, 150, 234, 80, 201, 179, 46, 237, 249, 0, 103, 242, 146, 109, 242, 87, 248, 22, 180, 87, 205, 47, 248, 225, 122, 53, 39, 103, 163, 229, 117, 161, 127, 60, 202, 217, 182, 60, 212, 87, 236, 161, 52, 224, 184, 186, 94, 65, 31, 223, 191, 150, 195, 36, 30, 87, 141, 30, 242, 101, 31, 215, 124, 96, 130, 231, 163, 183, 172, 101, 188, 98, 69, 135, 228, 152, 163, 227, 231, 240, 211, 231, 203, 16, 62, 190, 158, 121, 133, 52, 234, 123, 177, 87, 214, 110, 238, 153, 96, 112, 108, 164, 181, 57, 31, 71, 240, 12, 24, 254, 184, 251, 160, 185, 7 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("1a7ec9a5-a03e-4328-9358-70ce7e667273"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("09f67b9a-d8d7-43f0-806e-947b52cb7dc5") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("1a7ec9a5-a03e-4328-9358-70ce7e667273"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("09f67b9a-d8d7-43f0-806e-947b52cb7dc5"));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "PasswordHash", "PasswordSalt", "UpdatedDate" },
                values: new object[] { new Guid("7f57af5a-9026-4347-934b-363f386a0a69"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@kodlama.io", new byte[] { 195, 183, 163, 113, 243, 29, 83, 184, 159, 199, 103, 71, 230, 132, 139, 51, 234, 8, 177, 15, 12, 198, 62, 57, 140, 180, 43, 27, 221, 0, 13, 62, 140, 24, 227, 162, 201, 164, 132, 108, 242, 114, 169, 236, 139, 165, 79, 29, 239, 128, 217, 192, 116, 6, 153, 48, 78, 35, 110, 58, 180, 112, 196, 48 }, new byte[] { 171, 98, 167, 84, 182, 185, 192, 145, 16, 168, 200, 213, 90, 54, 205, 39, 155, 106, 120, 215, 20, 10, 167, 67, 24, 155, 123, 178, 204, 89, 207, 214, 220, 230, 176, 3, 191, 148, 48, 108, 162, 88, 182, 79, 59, 201, 81, 140, 206, 251, 34, 125, 215, 82, 167, 129, 82, 170, 255, 81, 61, 128, 204, 205, 116, 91, 117, 42, 166, 180, 88, 86, 135, 145, 11, 83, 95, 220, 120, 217, 170, 52, 57, 200, 15, 121, 221, 15, 91, 186, 231, 185, 189, 212, 154, 232, 109, 236, 156, 107, 221, 49, 103, 55, 36, 108, 141, 84, 148, 154, 217, 197, 182, 87, 239, 155, 128, 247, 91, 238, 242, 122, 57, 16, 120, 205, 108, 77 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("4d2b05ce-d7fa-452d-b933-b628f3029e38"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("7f57af5a-9026-4347-934b-363f386a0a69") });
        }
    }
}
