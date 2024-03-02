using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class UpdateFuelCrud : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { new Guid("c73eea91-4a55-41c7-a1c4-dcb681c77823"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@kodlama.io", new byte[] { 161, 161, 109, 171, 127, 249, 197, 139, 28, 149, 196, 144, 249, 28, 245, 47, 44, 86, 19, 12, 25, 225, 134, 213, 97, 237, 95, 149, 241, 51, 141, 84, 2, 12, 73, 127, 186, 229, 242, 189, 157, 216, 64, 38, 56, 247, 15, 69, 138, 20, 244, 2, 152, 114, 126, 230, 171, 197, 48, 26, 217, 105, 171, 144 }, new byte[] { 72, 73, 25, 66, 235, 105, 123, 48, 235, 233, 198, 6, 11, 25, 57, 83, 152, 3, 63, 17, 99, 1, 165, 119, 3, 87, 118, 50, 158, 223, 129, 173, 186, 127, 213, 180, 16, 151, 93, 125, 69, 174, 223, 116, 135, 111, 82, 103, 139, 160, 36, 78, 127, 34, 152, 168, 203, 121, 207, 239, 219, 109, 200, 18, 121, 163, 52, 49, 17, 25, 109, 182, 93, 43, 193, 10, 46, 14, 178, 158, 85, 38, 192, 102, 153, 192, 176, 16, 167, 166, 129, 235, 187, 244, 216, 73, 214, 5, 84, 253, 101, 230, 206, 184, 10, 79, 92, 55, 231, 80, 186, 80, 85, 208, 83, 20, 143, 221, 236, 69, 114, 110, 110, 246, 185, 37, 30, 172 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("abeff008-f76f-4ebe-904e-a4f1e365ba32"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("c73eea91-4a55-41c7-a1c4-dcb681c77823") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { new Guid("09f67b9a-d8d7-43f0-806e-947b52cb7dc5"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@kodlama.io", new byte[] { 58, 210, 101, 10, 118, 96, 167, 93, 45, 240, 116, 52, 222, 25, 248, 40, 197, 167, 18, 104, 166, 137, 121, 12, 135, 151, 227, 8, 63, 28, 96, 109, 90, 243, 239, 246, 85, 69, 154, 66, 42, 26, 172, 45, 181, 22, 2, 234, 89, 174, 26, 194, 73, 169, 181, 120, 121, 104, 73, 239, 87, 22, 25, 10 }, new byte[] { 81, 99, 186, 220, 106, 4, 201, 244, 245, 242, 221, 236, 121, 35, 150, 234, 80, 201, 179, 46, 237, 249, 0, 103, 242, 146, 109, 242, 87, 248, 22, 180, 87, 205, 47, 248, 225, 122, 53, 39, 103, 163, 229, 117, 161, 127, 60, 202, 217, 182, 60, 212, 87, 236, 161, 52, 224, 184, 186, 94, 65, 31, 223, 191, 150, 195, 36, 30, 87, 141, 30, 242, 101, 31, 215, 124, 96, 130, 231, 163, 183, 172, 101, 188, 98, 69, 135, 228, 152, 163, 227, 231, 240, 211, 231, 203, 16, 62, 190, 158, 121, 133, 52, 234, 123, 177, 87, 214, 110, 238, 153, 96, 112, 108, 164, 181, 57, 31, 71, 240, 12, 24, 254, 184, 251, 160, 185, 7 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("1a7ec9a5-a03e-4328-9358-70ce7e667273"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("09f67b9a-d8d7-43f0-806e-947b52cb7dc5") });
        }
    }
}
