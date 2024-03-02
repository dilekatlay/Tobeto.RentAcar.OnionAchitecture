using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class UpdateModelCrud : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("56a7f038-1855-4b4a-8da3-6025b3cda743"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3fd0e238-306c-4f99-8ae4-d97479ab947f"));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "PasswordHash", "PasswordSalt", "UpdatedDate" },
                values: new object[] { new Guid("359289c7-8b90-4955-ba87-a27830c3661f"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@kodlama.io", new byte[] { 178, 5, 134, 246, 164, 57, 165, 230, 47, 110, 62, 110, 43, 107, 73, 133, 131, 148, 144, 128, 172, 105, 159, 157, 54, 62, 141, 195, 98, 153, 233, 122, 250, 2, 4, 254, 212, 20, 45, 16, 247, 93, 113, 141, 236, 179, 43, 219, 244, 211, 21, 141, 61, 37, 178, 173, 234, 8, 224, 51, 24, 136, 227, 97 }, new byte[] { 27, 35, 199, 170, 105, 123, 127, 187, 84, 29, 136, 219, 149, 175, 234, 163, 205, 218, 106, 149, 24, 166, 100, 49, 45, 175, 82, 67, 156, 60, 241, 229, 49, 204, 243, 67, 229, 174, 151, 161, 182, 13, 210, 22, 109, 144, 85, 190, 18, 65, 228, 114, 94, 119, 218, 21, 197, 106, 181, 13, 96, 36, 169, 187, 198, 5, 88, 220, 89, 212, 70, 103, 92, 182, 114, 78, 213, 162, 110, 38, 199, 169, 165, 34, 163, 82, 128, 234, 167, 192, 170, 147, 253, 200, 52, 252, 166, 8, 134, 0, 13, 241, 252, 92, 164, 235, 168, 116, 47, 36, 137, 155, 0, 126, 74, 217, 221, 189, 46, 250, 154, 114, 75, 221, 177, 113, 208, 119 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("dd25fa97-580c-4244-b1b4-faf67ba153b5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("359289c7-8b90-4955-ba87-a27830c3661f") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { new Guid("3fd0e238-306c-4f99-8ae4-d97479ab947f"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@kodlama.io", new byte[] { 30, 209, 7, 187, 97, 8, 183, 75, 221, 206, 73, 180, 19, 9, 146, 110, 223, 153, 8, 192, 163, 52, 233, 33, 130, 49, 134, 232, 54, 120, 73, 33, 17, 143, 68, 170, 62, 75, 115, 197, 168, 214, 227, 151, 99, 133, 251, 210, 186, 89, 188, 240, 198, 16, 72, 53, 252, 59, 12, 232, 232, 22, 165, 52 }, new byte[] { 54, 190, 73, 91, 37, 117, 195, 217, 6, 82, 228, 167, 131, 103, 172, 208, 178, 60, 31, 123, 205, 206, 72, 205, 227, 149, 25, 75, 56, 74, 71, 55, 186, 254, 245, 36, 155, 187, 120, 139, 96, 45, 194, 102, 91, 69, 201, 215, 152, 66, 191, 61, 214, 148, 112, 128, 63, 5, 107, 54, 210, 107, 156, 217, 149, 29, 234, 248, 103, 226, 163, 173, 226, 126, 155, 166, 192, 241, 128, 41, 125, 5, 229, 242, 104, 234, 232, 172, 153, 253, 221, 162, 176, 80, 192, 207, 140, 255, 170, 176, 15, 51, 29, 119, 161, 227, 201, 101, 139, 159, 172, 58, 48, 124, 68, 190, 50, 214, 10, 48, 81, 9, 253, 250, 18, 216, 130, 118 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("56a7f038-1855-4b4a-8da3-6025b3cda743"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("3fd0e238-306c-4f99-8ae4-d97479ab947f") });
        }
    }
}
