using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddCorporateCustomer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("aa85c4b6-2c6d-44f7-85cc-f7097420e89a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("876c49e2-3464-450b-a411-964874d3495f"));

            migrationBuilder.CreateTable(
                name: "CorporateCustomer",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TaxNo = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CorporateCustomer", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "PasswordHash", "PasswordSalt", "UpdatedDate" },
                values: new object[] { new Guid("f9737e91-e54c-4928-9583-11876ead772f"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@kodlama.io", new byte[] { 10, 7, 61, 13, 143, 44, 183, 26, 63, 228, 132, 80, 234, 105, 3, 160, 3, 244, 231, 58, 85, 207, 209, 211, 10, 241, 242, 138, 179, 131, 62, 96, 77, 34, 236, 56, 234, 39, 103, 134, 2, 82, 111, 149, 192, 81, 240, 27, 238, 15, 232, 81, 143, 102, 221, 148, 11, 61, 209, 164, 239, 191, 199, 154 }, new byte[] { 69, 177, 221, 255, 221, 146, 189, 224, 122, 20, 76, 100, 174, 161, 110, 127, 193, 217, 175, 158, 136, 161, 222, 248, 61, 96, 114, 31, 6, 21, 245, 179, 189, 44, 246, 181, 95, 15, 108, 250, 22, 108, 129, 157, 167, 245, 74, 33, 126, 64, 181, 8, 113, 233, 77, 122, 144, 131, 29, 13, 1, 155, 35, 144, 28, 21, 123, 84, 254, 69, 205, 105, 3, 11, 13, 157, 115, 198, 242, 253, 126, 200, 225, 197, 43, 157, 17, 198, 118, 136, 241, 149, 140, 3, 129, 214, 111, 36, 163, 201, 198, 42, 248, 122, 187, 82, 120, 76, 35, 223, 141, 228, 205, 2, 88, 62, 60, 117, 70, 152, 15, 174, 83, 206, 79, 141, 54, 155 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("cb34b330-354d-4185-9f31-d4a3a8349429"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("f9737e91-e54c-4928-9583-11876ead772f") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CorporateCustomer");

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("cb34b330-354d-4185-9f31-d4a3a8349429"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f9737e91-e54c-4928-9583-11876ead772f"));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "PasswordHash", "PasswordSalt", "UpdatedDate" },
                values: new object[] { new Guid("876c49e2-3464-450b-a411-964874d3495f"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@kodlama.io", new byte[] { 160, 79, 250, 233, 9, 226, 73, 233, 74, 125, 183, 126, 50, 235, 50, 154, 65, 109, 177, 69, 31, 33, 21, 115, 128, 80, 50, 28, 111, 144, 80, 211, 162, 16, 53, 140, 80, 186, 188, 42, 181, 229, 158, 213, 131, 210, 198, 153, 159, 131, 58, 134, 73, 23, 21, 129, 177, 209, 190, 132, 94, 25, 53, 109 }, new byte[] { 147, 70, 89, 46, 19, 102, 230, 154, 213, 34, 181, 204, 255, 81, 18, 223, 167, 197, 60, 162, 45, 11, 250, 182, 95, 225, 72, 251, 95, 126, 66, 209, 61, 151, 221, 176, 108, 93, 61, 98, 108, 67, 45, 123, 255, 80, 192, 203, 229, 82, 150, 250, 35, 22, 102, 37, 182, 59, 156, 111, 27, 19, 49, 180, 112, 20, 77, 33, 138, 158, 217, 223, 157, 216, 119, 208, 8, 186, 140, 248, 197, 101, 44, 160, 110, 18, 207, 182, 128, 82, 115, 177, 185, 167, 85, 199, 240, 135, 139, 51, 145, 79, 20, 206, 60, 160, 252, 85, 60, 91, 27, 198, 66, 233, 223, 131, 153, 118, 233, 246, 134, 226, 115, 102, 143, 121, 84, 53 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("aa85c4b6-2c6d-44f7-85cc-f7097420e89a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("876c49e2-3464-450b-a411-964874d3495f") });
        }
    }
}
