using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddIndividualCustomer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("d6ba1a8a-9569-4f82-9f54-08ad76e7e40e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d6c5973b-d993-40da-aa3b-fe88702faed4"));

            migrationBuilder.CreateTable(
                name: "IndividualCustomers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NationalIdentity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IndividualCustomers", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "PasswordHash", "PasswordSalt", "UpdatedDate" },
                values: new object[] { new Guid("876c49e2-3464-450b-a411-964874d3495f"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@kodlama.io", new byte[] { 160, 79, 250, 233, 9, 226, 73, 233, 74, 125, 183, 126, 50, 235, 50, 154, 65, 109, 177, 69, 31, 33, 21, 115, 128, 80, 50, 28, 111, 144, 80, 211, 162, 16, 53, 140, 80, 186, 188, 42, 181, 229, 158, 213, 131, 210, 198, 153, 159, 131, 58, 134, 73, 23, 21, 129, 177, 209, 190, 132, 94, 25, 53, 109 }, new byte[] { 147, 70, 89, 46, 19, 102, 230, 154, 213, 34, 181, 204, 255, 81, 18, 223, 167, 197, 60, 162, 45, 11, 250, 182, 95, 225, 72, 251, 95, 126, 66, 209, 61, 151, 221, 176, 108, 93, 61, 98, 108, 67, 45, 123, 255, 80, 192, 203, 229, 82, 150, 250, 35, 22, 102, 37, 182, 59, 156, 111, 27, 19, 49, 180, 112, 20, 77, 33, 138, 158, 217, 223, 157, 216, 119, 208, 8, 186, 140, 248, 197, 101, 44, 160, 110, 18, 207, 182, 128, 82, 115, 177, 185, 167, 85, 199, 240, 135, 139, 51, 145, 79, 20, 206, 60, 160, 252, 85, 60, 91, 27, 198, 66, 233, 223, 131, 153, 118, 233, 246, 134, 226, 115, 102, 143, 121, 84, 53 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("aa85c4b6-2c6d-44f7-85cc-f7097420e89a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("876c49e2-3464-450b-a411-964874d3495f") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IndividualCustomers");

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("aa85c4b6-2c6d-44f7-85cc-f7097420e89a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("876c49e2-3464-450b-a411-964874d3495f"));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "PasswordHash", "PasswordSalt", "UpdatedDate" },
                values: new object[] { new Guid("d6c5973b-d993-40da-aa3b-fe88702faed4"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@kodlama.io", new byte[] { 160, 16, 215, 191, 234, 115, 147, 168, 231, 110, 69, 162, 43, 7, 48, 114, 181, 233, 98, 208, 169, 105, 25, 130, 112, 20, 76, 144, 59, 69, 25, 246, 98, 200, 247, 249, 52, 226, 189, 50, 64, 238, 254, 84, 242, 150, 33, 198, 5, 117, 193, 139, 136, 31, 214, 94, 254, 125, 191, 166, 85, 88, 157, 95 }, new byte[] { 223, 27, 208, 82, 228, 11, 31, 137, 21, 214, 157, 6, 17, 244, 36, 181, 164, 179, 222, 94, 127, 13, 60, 32, 93, 221, 247, 190, 204, 62, 247, 153, 106, 56, 117, 237, 35, 247, 20, 188, 130, 142, 71, 189, 155, 40, 189, 253, 135, 33, 84, 154, 251, 180, 207, 235, 40, 255, 225, 47, 146, 11, 16, 238, 250, 184, 232, 29, 186, 149, 162, 237, 193, 175, 210, 9, 20, 234, 100, 185, 41, 142, 0, 127, 177, 122, 184, 74, 129, 146, 251, 240, 71, 105, 2, 164, 118, 193, 3, 192, 193, 44, 156, 70, 127, 24, 188, 194, 144, 82, 108, 56, 73, 236, 210, 115, 41, 43, 127, 57, 122, 146, 125, 129, 8, 207, 18, 209 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("d6ba1a8a-9569-4f82-9f54-08ad76e7e40e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("d6c5973b-d993-40da-aa3b-fe88702faed4") });
        }
    }
}
