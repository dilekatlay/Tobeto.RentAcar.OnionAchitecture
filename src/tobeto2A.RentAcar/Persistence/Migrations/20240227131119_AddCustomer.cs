using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddCustomer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("8970c9f1-8a4b-4e4d-a2af-ca739ff48ccf"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("139029e6-dcfb-4ec3-9e2b-ff22f332c5c9"));

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "PasswordHash", "PasswordSalt", "UpdatedDate" },
                values: new object[] { new Guid("d6c5973b-d993-40da-aa3b-fe88702faed4"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@kodlama.io", new byte[] { 160, 16, 215, 191, 234, 115, 147, 168, 231, 110, 69, 162, 43, 7, 48, 114, 181, 233, 98, 208, 169, 105, 25, 130, 112, 20, 76, 144, 59, 69, 25, 246, 98, 200, 247, 249, 52, 226, 189, 50, 64, 238, 254, 84, 242, 150, 33, 198, 5, 117, 193, 139, 136, 31, 214, 94, 254, 125, 191, 166, 85, 88, 157, 95 }, new byte[] { 223, 27, 208, 82, 228, 11, 31, 137, 21, 214, 157, 6, 17, 244, 36, 181, 164, 179, 222, 94, 127, 13, 60, 32, 93, 221, 247, 190, 204, 62, 247, 153, 106, 56, 117, 237, 35, 247, 20, 188, 130, 142, 71, 189, 155, 40, 189, 253, 135, 33, 84, 154, 251, 180, 207, 235, 40, 255, 225, 47, 146, 11, 16, 238, 250, 184, 232, 29, 186, 149, 162, 237, 193, 175, 210, 9, 20, 234, 100, 185, 41, 142, 0, 127, 177, 122, 184, 74, 129, 146, 251, 240, 71, 105, 2, 164, 118, 193, 3, 192, 193, 44, 156, 70, 127, 24, 188, 194, 144, 82, 108, 56, 73, 236, 210, 115, 41, 43, 127, 57, 122, 146, 125, 129, 8, 207, 18, 209 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("d6ba1a8a-9569-4f82-9f54-08ad76e7e40e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("d6c5973b-d993-40da-aa3b-fe88702faed4") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("d6ba1a8a-9569-4f82-9f54-08ad76e7e40e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d6c5973b-d993-40da-aa3b-fe88702faed4"));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "PasswordHash", "PasswordSalt", "UpdatedDate" },
                values: new object[] { new Guid("139029e6-dcfb-4ec3-9e2b-ff22f332c5c9"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@kodlama.io", new byte[] { 185, 111, 111, 56, 255, 58, 101, 125, 250, 184, 52, 157, 3, 219, 144, 38, 165, 162, 203, 182, 172, 201, 40, 122, 222, 152, 95, 38, 148, 24, 5, 167, 112, 44, 79, 244, 202, 71, 211, 225, 137, 209, 89, 122, 211, 122, 45, 175, 166, 33, 135, 171, 220, 205, 52, 179, 75, 243, 119, 199, 82, 16, 71, 12 }, new byte[] { 217, 207, 68, 236, 200, 221, 130, 99, 103, 172, 242, 118, 32, 194, 118, 211, 124, 124, 204, 175, 242, 25, 249, 15, 51, 94, 82, 27, 25, 98, 116, 235, 234, 196, 179, 190, 21, 140, 168, 125, 148, 46, 207, 238, 245, 15, 57, 65, 31, 179, 76, 194, 157, 194, 28, 195, 86, 6, 222, 86, 90, 67, 168, 187, 0, 25, 111, 91, 16, 188, 161, 193, 65, 223, 215, 38, 150, 83, 20, 51, 90, 50, 90, 118, 141, 173, 4, 216, 21, 42, 241, 78, 201, 81, 184, 244, 175, 170, 4, 228, 151, 76, 241, 211, 139, 45, 127, 132, 66, 172, 49, 55, 111, 141, 215, 54, 143, 2, 108, 33, 89, 47, 246, 193, 170, 121, 38, 39 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("8970c9f1-8a4b-4e4d-a2af-ca739ff48ccf"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("139029e6-dcfb-4ec3-9e2b-ff22f332c5c9") });
        }
    }
}
