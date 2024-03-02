using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedIndividualCustomerCrud : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("abeff008-f76f-4ebe-904e-a4f1e365ba32"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c73eea91-4a55-41c7-a1c4-dcb681c77823"));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "PasswordHash", "PasswordSalt", "UpdatedDate" },
                values: new object[] { new Guid("3fd0e238-306c-4f99-8ae4-d97479ab947f"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@kodlama.io", new byte[] { 30, 209, 7, 187, 97, 8, 183, 75, 221, 206, 73, 180, 19, 9, 146, 110, 223, 153, 8, 192, 163, 52, 233, 33, 130, 49, 134, 232, 54, 120, 73, 33, 17, 143, 68, 170, 62, 75, 115, 197, 168, 214, 227, 151, 99, 133, 251, 210, 186, 89, 188, 240, 198, 16, 72, 53, 252, 59, 12, 232, 232, 22, 165, 52 }, new byte[] { 54, 190, 73, 91, 37, 117, 195, 217, 6, 82, 228, 167, 131, 103, 172, 208, 178, 60, 31, 123, 205, 206, 72, 205, 227, 149, 25, 75, 56, 74, 71, 55, 186, 254, 245, 36, 155, 187, 120, 139, 96, 45, 194, 102, 91, 69, 201, 215, 152, 66, 191, 61, 214, 148, 112, 128, 63, 5, 107, 54, 210, 107, 156, 217, 149, 29, 234, 248, 103, 226, 163, 173, 226, 126, 155, 166, 192, 241, 128, 41, 125, 5, 229, 242, 104, 234, 232, 172, 153, 253, 221, 162, 176, 80, 192, 207, 140, 255, 170, 176, 15, 51, 29, 119, 161, 227, 201, 101, 139, 159, 172, 58, 48, 124, 68, 190, 50, 214, 10, 48, 81, 9, 253, 250, 18, 216, 130, 118 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("56a7f038-1855-4b4a-8da3-6025b3cda743"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("3fd0e238-306c-4f99-8ae4-d97479ab947f") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { new Guid("c73eea91-4a55-41c7-a1c4-dcb681c77823"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@kodlama.io", new byte[] { 161, 161, 109, 171, 127, 249, 197, 139, 28, 149, 196, 144, 249, 28, 245, 47, 44, 86, 19, 12, 25, 225, 134, 213, 97, 237, 95, 149, 241, 51, 141, 84, 2, 12, 73, 127, 186, 229, 242, 189, 157, 216, 64, 38, 56, 247, 15, 69, 138, 20, 244, 2, 152, 114, 126, 230, 171, 197, 48, 26, 217, 105, 171, 144 }, new byte[] { 72, 73, 25, 66, 235, 105, 123, 48, 235, 233, 198, 6, 11, 25, 57, 83, 152, 3, 63, 17, 99, 1, 165, 119, 3, 87, 118, 50, 158, 223, 129, 173, 186, 127, 213, 180, 16, 151, 93, 125, 69, 174, 223, 116, 135, 111, 82, 103, 139, 160, 36, 78, 127, 34, 152, 168, 203, 121, 207, 239, 219, 109, 200, 18, 121, 163, 52, 49, 17, 25, 109, 182, 93, 43, 193, 10, 46, 14, 178, 158, 85, 38, 192, 102, 153, 192, 176, 16, 167, 166, 129, 235, 187, 244, 216, 73, 214, 5, 84, 253, 101, 230, 206, 184, 10, 79, 92, 55, 231, 80, 186, 80, 85, 208, 83, 20, 143, 221, 236, 69, 114, 110, 110, 246, 185, 37, 30, 172 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("abeff008-f76f-4ebe-904e-a4f1e365ba32"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("c73eea91-4a55-41c7-a1c4-dcb681c77823") });
        }
    }
}
