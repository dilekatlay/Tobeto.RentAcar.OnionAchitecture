using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedCorporateCustomerCrud : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("15e5cc1a-7b0c-43e6-9e7b-06bd6e0ff96f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("50ea7e9b-3b88-490c-9eae-b1d2ad6a0fec"));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "PasswordHash", "PasswordSalt", "UpdatedDate" },
                values: new object[] { new Guid("7f57af5a-9026-4347-934b-363f386a0a69"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@kodlama.io", new byte[] { 195, 183, 163, 113, 243, 29, 83, 184, 159, 199, 103, 71, 230, 132, 139, 51, 234, 8, 177, 15, 12, 198, 62, 57, 140, 180, 43, 27, 221, 0, 13, 62, 140, 24, 227, 162, 201, 164, 132, 108, 242, 114, 169, 236, 139, 165, 79, 29, 239, 128, 217, 192, 116, 6, 153, 48, 78, 35, 110, 58, 180, 112, 196, 48 }, new byte[] { 171, 98, 167, 84, 182, 185, 192, 145, 16, 168, 200, 213, 90, 54, 205, 39, 155, 106, 120, 215, 20, 10, 167, 67, 24, 155, 123, 178, 204, 89, 207, 214, 220, 230, 176, 3, 191, 148, 48, 108, 162, 88, 182, 79, 59, 201, 81, 140, 206, 251, 34, 125, 215, 82, 167, 129, 82, 170, 255, 81, 61, 128, 204, 205, 116, 91, 117, 42, 166, 180, 88, 86, 135, 145, 11, 83, 95, 220, 120, 217, 170, 52, 57, 200, 15, 121, 221, 15, 91, 186, 231, 185, 189, 212, 154, 232, 109, 236, 156, 107, 221, 49, 103, 55, 36, 108, 141, 84, 148, 154, 217, 197, 182, 87, 239, 155, 128, 247, 91, 238, 242, 122, 57, 16, 120, 205, 108, 77 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("4d2b05ce-d7fa-452d-b933-b628f3029e38"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("7f57af5a-9026-4347-934b-363f386a0a69") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { new Guid("50ea7e9b-3b88-490c-9eae-b1d2ad6a0fec"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@kodlama.io", new byte[] { 191, 33, 147, 147, 132, 182, 45, 143, 245, 230, 255, 186, 108, 51, 114, 160, 193, 58, 76, 10, 196, 118, 9, 191, 107, 106, 149, 213, 246, 116, 83, 180, 201, 44, 147, 150, 168, 253, 131, 162, 173, 35, 183, 228, 31, 72, 98, 73, 150, 255, 59, 216, 137, 117, 242, 128, 109, 207, 83, 230, 45, 13, 133, 162 }, new byte[] { 188, 229, 90, 169, 88, 111, 78, 229, 52, 227, 25, 81, 124, 227, 159, 171, 47, 193, 73, 115, 24, 205, 116, 95, 161, 169, 169, 20, 24, 178, 216, 97, 10, 170, 231, 162, 22, 224, 4, 194, 136, 239, 49, 196, 165, 97, 252, 237, 244, 96, 167, 255, 165, 227, 142, 233, 67, 236, 189, 33, 131, 35, 237, 74, 79, 56, 1, 48, 51, 174, 221, 247, 191, 181, 247, 56, 3, 200, 154, 192, 177, 75, 209, 247, 91, 225, 3, 90, 243, 241, 161, 148, 148, 16, 137, 192, 223, 193, 213, 194, 134, 230, 149, 0, 176, 120, 111, 27, 239, 99, 239, 154, 139, 201, 91, 182, 141, 241, 193, 82, 195, 8, 238, 10, 167, 157, 139, 225 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("15e5cc1a-7b0c-43e6-9e7b-06bd6e0ff96f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("50ea7e9b-3b88-490c-9eae-b1d2ad6a0fec") });
        }
    }
}
