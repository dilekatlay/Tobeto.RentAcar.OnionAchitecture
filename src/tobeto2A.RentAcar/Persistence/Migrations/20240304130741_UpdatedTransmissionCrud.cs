using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedTransmissionCrud : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("dd25fa97-580c-4244-b1b4-faf67ba153b5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("359289c7-8b90-4955-ba87-a27830c3661f"));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "PasswordHash", "PasswordSalt", "UpdatedDate" },
                values: new object[] { new Guid("3dcb5b61-2c70-4126-8485-d2e74a8bbb6c"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@kodlama.io", new byte[] { 94, 156, 33, 51, 164, 220, 53, 121, 214, 227, 157, 78, 51, 184, 101, 85, 243, 143, 40, 173, 77, 174, 8, 184, 57, 210, 232, 145, 47, 35, 211, 151, 131, 195, 133, 85, 16, 107, 212, 107, 77, 83, 17, 104, 55, 207, 218, 104, 130, 95, 34, 148, 188, 145, 63, 22, 164, 211, 197, 53, 135, 253, 190, 254 }, new byte[] { 231, 149, 196, 174, 52, 171, 117, 175, 204, 71, 239, 233, 202, 153, 224, 178, 53, 106, 224, 230, 0, 61, 244, 173, 252, 43, 160, 202, 236, 184, 43, 115, 161, 207, 137, 49, 139, 220, 106, 24, 248, 209, 43, 123, 110, 78, 138, 44, 132, 32, 64, 213, 192, 105, 76, 175, 174, 81, 254, 250, 211, 176, 28, 67, 209, 18, 208, 25, 120, 78, 47, 175, 128, 250, 14, 3, 66, 172, 85, 148, 238, 58, 199, 213, 92, 244, 135, 180, 189, 22, 62, 25, 218, 125, 15, 102, 139, 28, 148, 179, 4, 141, 38, 98, 159, 34, 232, 130, 148, 213, 171, 19, 160, 12, 57, 162, 59, 243, 77, 195, 134, 199, 211, 142, 144, 212, 245, 26 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("b4c94077-8d9a-4e6b-b315-e62d086d306a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("3dcb5b61-2c70-4126-8485-d2e74a8bbb6c") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("b4c94077-8d9a-4e6b-b315-e62d086d306a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3dcb5b61-2c70-4126-8485-d2e74a8bbb6c"));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "PasswordHash", "PasswordSalt", "UpdatedDate" },
                values: new object[] { new Guid("359289c7-8b90-4955-ba87-a27830c3661f"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@kodlama.io", new byte[] { 178, 5, 134, 246, 164, 57, 165, 230, 47, 110, 62, 110, 43, 107, 73, 133, 131, 148, 144, 128, 172, 105, 159, 157, 54, 62, 141, 195, 98, 153, 233, 122, 250, 2, 4, 254, 212, 20, 45, 16, 247, 93, 113, 141, 236, 179, 43, 219, 244, 211, 21, 141, 61, 37, 178, 173, 234, 8, 224, 51, 24, 136, 227, 97 }, new byte[] { 27, 35, 199, 170, 105, 123, 127, 187, 84, 29, 136, 219, 149, 175, 234, 163, 205, 218, 106, 149, 24, 166, 100, 49, 45, 175, 82, 67, 156, 60, 241, 229, 49, 204, 243, 67, 229, 174, 151, 161, 182, 13, 210, 22, 109, 144, 85, 190, 18, 65, 228, 114, 94, 119, 218, 21, 197, 106, 181, 13, 96, 36, 169, 187, 198, 5, 88, 220, 89, 212, 70, 103, 92, 182, 114, 78, 213, 162, 110, 38, 199, 169, 165, 34, 163, 82, 128, 234, 167, 192, 170, 147, 253, 200, 52, 252, 166, 8, 134, 0, 13, 241, 252, 92, 164, 235, 168, 116, 47, 36, 137, 155, 0, 126, 74, 217, 221, 189, 46, 250, 154, 114, 75, 221, 177, 113, 208, 119 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("dd25fa97-580c-4244-b1b4-faf67ba153b5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("359289c7-8b90-4955-ba87-a27830c3661f") });
        }
    }
}
