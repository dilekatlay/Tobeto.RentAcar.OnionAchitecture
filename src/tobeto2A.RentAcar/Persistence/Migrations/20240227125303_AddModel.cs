using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("3c613c12-a975-4bcc-b09a-cc11d7c4c546"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6e2acfa1-3be3-47df-a26e-698cb440d831"));

            migrationBuilder.CreateTable(
                name: "Models",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BrandId = table.Column<int>(type: "int", nullable: false),
                    FuelId = table.Column<int>(type: "int", nullable: false),
                    TransmissionId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Year = table.Column<short>(type: "smallint", nullable: false),
                    DailyPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Models", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "PasswordHash", "PasswordSalt", "UpdatedDate" },
                values: new object[] { new Guid("139029e6-dcfb-4ec3-9e2b-ff22f332c5c9"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@kodlama.io", new byte[] { 185, 111, 111, 56, 255, 58, 101, 125, 250, 184, 52, 157, 3, 219, 144, 38, 165, 162, 203, 182, 172, 201, 40, 122, 222, 152, 95, 38, 148, 24, 5, 167, 112, 44, 79, 244, 202, 71, 211, 225, 137, 209, 89, 122, 211, 122, 45, 175, 166, 33, 135, 171, 220, 205, 52, 179, 75, 243, 119, 199, 82, 16, 71, 12 }, new byte[] { 217, 207, 68, 236, 200, 221, 130, 99, 103, 172, 242, 118, 32, 194, 118, 211, 124, 124, 204, 175, 242, 25, 249, 15, 51, 94, 82, 27, 25, 98, 116, 235, 234, 196, 179, 190, 21, 140, 168, 125, 148, 46, 207, 238, 245, 15, 57, 65, 31, 179, 76, 194, 157, 194, 28, 195, 86, 6, 222, 86, 90, 67, 168, 187, 0, 25, 111, 91, 16, 188, 161, 193, 65, 223, 215, 38, 150, 83, 20, 51, 90, 50, 90, 118, 141, 173, 4, 216, 21, 42, 241, 78, 201, 81, 184, 244, 175, 170, 4, 228, 151, 76, 241, 211, 139, 45, 127, 132, 66, 172, 49, 55, 111, 141, 215, 54, 143, 2, 108, 33, 89, 47, 246, 193, 170, 121, 38, 39 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("8970c9f1-8a4b-4e4d-a2af-ca739ff48ccf"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("139029e6-dcfb-4ec3-9e2b-ff22f332c5c9") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Models");

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("8970c9f1-8a4b-4e4d-a2af-ca739ff48ccf"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("139029e6-dcfb-4ec3-9e2b-ff22f332c5c9"));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "PasswordHash", "PasswordSalt", "UpdatedDate" },
                values: new object[] { new Guid("6e2acfa1-3be3-47df-a26e-698cb440d831"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@kodlama.io", new byte[] { 142, 181, 223, 33, 65, 199, 247, 76, 240, 0, 166, 83, 203, 103, 76, 75, 34, 227, 80, 179, 238, 222, 2, 129, 57, 230, 186, 147, 15, 38, 165, 39, 211, 94, 0, 90, 97, 26, 122, 216, 218, 85, 225, 227, 22, 87, 51, 18, 26, 64, 71, 206, 52, 91, 231, 209, 15, 221, 6, 194, 64, 207, 156, 44 }, new byte[] { 137, 190, 79, 25, 215, 53, 195, 150, 157, 29, 15, 125, 19, 160, 185, 146, 79, 193, 13, 24, 107, 49, 77, 2, 234, 165, 16, 64, 244, 244, 178, 35, 51, 218, 0, 230, 137, 58, 29, 100, 73, 65, 255, 0, 206, 50, 252, 179, 252, 192, 190, 146, 242, 211, 114, 144, 18, 142, 174, 41, 191, 66, 72, 136, 186, 184, 200, 25, 237, 120, 45, 173, 91, 163, 124, 254, 89, 153, 0, 25, 151, 25, 158, 82, 142, 8, 214, 197, 37, 204, 156, 127, 29, 198, 70, 224, 246, 191, 246, 202, 6, 251, 86, 210, 202, 167, 181, 120, 16, 73, 59, 129, 115, 1, 159, 77, 44, 158, 196, 170, 156, 194, 245, 175, 85, 135, 41, 149 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("3c613c12-a975-4bcc-b09a-cc11d7c4c546"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("6e2acfa1-3be3-47df-a26e-698cb440d831") });
        }
    }
}
