using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddCar : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("c523092d-4fea-4aee-a15b-92c67785e93c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c069ac29-6baf-4148-8975-d767f2f18ff0"));

            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ColorId = table.Column<int>(type: "int", nullable: false),
                    ModelId = table.Column<int>(type: "int", nullable: false),
                    CarState = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Kilometer = table.Column<int>(type: "int", nullable: false),
                    Plate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "PasswordHash", "PasswordSalt", "UpdatedDate" },
                values: new object[] { new Guid("6e2acfa1-3be3-47df-a26e-698cb440d831"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@kodlama.io", new byte[] { 142, 181, 223, 33, 65, 199, 247, 76, 240, 0, 166, 83, 203, 103, 76, 75, 34, 227, 80, 179, 238, 222, 2, 129, 57, 230, 186, 147, 15, 38, 165, 39, 211, 94, 0, 90, 97, 26, 122, 216, 218, 85, 225, 227, 22, 87, 51, 18, 26, 64, 71, 206, 52, 91, 231, 209, 15, 221, 6, 194, 64, 207, 156, 44 }, new byte[] { 137, 190, 79, 25, 215, 53, 195, 150, 157, 29, 15, 125, 19, 160, 185, 146, 79, 193, 13, 24, 107, 49, 77, 2, 234, 165, 16, 64, 244, 244, 178, 35, 51, 218, 0, 230, 137, 58, 29, 100, 73, 65, 255, 0, 206, 50, 252, 179, 252, 192, 190, 146, 242, 211, 114, 144, 18, 142, 174, 41, 191, 66, 72, 136, 186, 184, 200, 25, 237, 120, 45, 173, 91, 163, 124, 254, 89, 153, 0, 25, 151, 25, 158, 82, 142, 8, 214, 197, 37, 204, 156, 127, 29, 198, 70, 224, 246, 191, 246, 202, 6, 251, 86, 210, 202, 167, 181, 120, 16, 73, 59, 129, 115, 1, 159, 77, 44, 158, 196, 170, 156, 194, 245, 175, 85, 135, 41, 149 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("3c613c12-a975-4bcc-b09a-cc11d7c4c546"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("6e2acfa1-3be3-47df-a26e-698cb440d831") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cars");

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("3c613c12-a975-4bcc-b09a-cc11d7c4c546"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6e2acfa1-3be3-47df-a26e-698cb440d831"));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "PasswordHash", "PasswordSalt", "UpdatedDate" },
                values: new object[] { new Guid("c069ac29-6baf-4148-8975-d767f2f18ff0"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@kodlama.io", new byte[] { 131, 64, 4, 252, 65, 134, 68, 43, 195, 216, 251, 102, 127, 45, 135, 37, 50, 169, 219, 113, 98, 246, 163, 214, 128, 23, 11, 94, 78, 235, 96, 160, 149, 93, 150, 175, 193, 90, 156, 215, 241, 7, 66, 39, 244, 103, 197, 248, 31, 231, 141, 171, 105, 66, 168, 63, 123, 139, 148, 63, 238, 228, 49, 82 }, new byte[] { 83, 123, 123, 85, 20, 115, 98, 147, 227, 171, 121, 68, 15, 247, 77, 221, 160, 132, 148, 90, 87, 36, 70, 97, 189, 87, 211, 149, 172, 8, 54, 88, 146, 226, 142, 75, 208, 254, 89, 18, 114, 234, 26, 117, 133, 149, 80, 154, 116, 218, 154, 75, 32, 67, 76, 141, 68, 186, 74, 151, 88, 121, 84, 123, 231, 34, 200, 175, 146, 107, 113, 151, 66, 37, 69, 176, 234, 250, 33, 184, 99, 244, 213, 16, 34, 214, 186, 154, 56, 117, 170, 66, 218, 12, 103, 40, 69, 250, 18, 4, 46, 119, 9, 148, 172, 246, 218, 219, 102, 108, 223, 146, 51, 206, 14, 9, 147, 68, 223, 199, 138, 12, 191, 70, 89, 249, 183, 143 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("c523092d-4fea-4aee-a15b-92c67785e93c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("c069ac29-6baf-4148-8975-d767f2f18ff0") });
        }
    }
}
