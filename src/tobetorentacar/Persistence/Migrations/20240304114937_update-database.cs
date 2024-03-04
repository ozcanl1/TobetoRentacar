using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class updatedatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Users_UserId",
                table: "Customers");

            migrationBuilder.DropForeignKey(
                name: "FK_IndividualCustomers_Customers_CustomerId1",
                table: "IndividualCustomers");

            migrationBuilder.DropIndex(
                name: "IX_IndividualCustomers_CustomerId1",
                table: "IndividualCustomers");

            migrationBuilder.DropIndex(
                name: "IX_CorporateCustomers_CustomerId",
                table: "CorporateCustomers");

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("1f84de25-d678-4620-99ff-0294cb10d685"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d364d339-ffba-4a05-beb9-0d2b2220049d"));

            migrationBuilder.DropColumn(
                name: "CustomerId1",
                table: "IndividualCustomers");

            migrationBuilder.AlterColumn<Guid>(
                name: "CustomerId",
                table: "IndividualCustomers",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<Guid>(
                name: "UserId",
                table: "Customers",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddColumn<Guid>(
                name: "CustomerId",
                table: "Customers",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "ModelId1",
                table: "Cars",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "PasswordHash", "PasswordSalt", "UpdatedDate" },
                values: new object[] { new Guid("d1a6b4ee-a5b1-41b1-9299-839f03f11095"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@kodlama.io", new byte[] { 180, 106, 35, 186, 249, 63, 228, 167, 253, 85, 244, 60, 27, 220, 128, 168, 229, 231, 144, 78, 29, 225, 188, 52, 27, 9, 217, 119, 176, 205, 216, 72, 8, 43, 178, 50, 179, 159, 122, 180, 59, 21, 215, 43, 36, 240, 67, 221, 49, 245, 168, 49, 29, 179, 79, 108, 31, 230, 102, 87, 62, 252, 202, 82 }, new byte[] { 208, 189, 185, 33, 117, 149, 114, 183, 137, 196, 141, 56, 136, 14, 24, 186, 30, 246, 89, 222, 148, 142, 99, 100, 242, 202, 205, 125, 65, 233, 144, 198, 201, 102, 46, 175, 84, 234, 130, 71, 77, 22, 160, 172, 167, 180, 178, 223, 98, 153, 134, 222, 174, 184, 0, 239, 97, 193, 89, 150, 29, 150, 190, 177, 199, 209, 174, 211, 16, 249, 131, 243, 95, 186, 218, 73, 206, 236, 143, 109, 42, 151, 19, 230, 63, 113, 38, 149, 144, 148, 133, 82, 248, 228, 110, 10, 234, 22, 250, 76, 73, 64, 122, 236, 155, 165, 252, 104, 72, 116, 238, 29, 140, 209, 36, 227, 158, 168, 174, 167, 208, 33, 149, 124, 198, 75, 131, 222 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("4b044aca-2cb3-42ef-8f29-d029144bc56b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("d1a6b4ee-a5b1-41b1-9299-839f03f11095") });

            migrationBuilder.CreateIndex(
                name: "IX_IndividualCustomers_CustomerId",
                table: "IndividualCustomers",
                column: "CustomerId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CorporateCustomers_CustomerId",
                table: "CorporateCustomers",
                column: "CustomerId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Cars_ModelId1",
                table: "Cars",
                column: "ModelId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_Models_ModelId1",
                table: "Cars",
                column: "ModelId1",
                principalTable: "Models",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Users_UserId",
                table: "Customers",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_IndividualCustomers_Customers_CustomerId",
                table: "IndividualCustomers",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cars_Models_ModelId1",
                table: "Cars");

            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Users_UserId",
                table: "Customers");

            migrationBuilder.DropForeignKey(
                name: "FK_IndividualCustomers_Customers_CustomerId",
                table: "IndividualCustomers");

            migrationBuilder.DropIndex(
                name: "IX_IndividualCustomers_CustomerId",
                table: "IndividualCustomers");

            migrationBuilder.DropIndex(
                name: "IX_CorporateCustomers_CustomerId",
                table: "CorporateCustomers");

            migrationBuilder.DropIndex(
                name: "IX_Cars_ModelId1",
                table: "Cars");

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("4b044aca-2cb3-42ef-8f29-d029144bc56b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d1a6b4ee-a5b1-41b1-9299-839f03f11095"));

            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "ModelId1",
                table: "Cars");

            migrationBuilder.AlterColumn<int>(
                name: "CustomerId",
                table: "IndividualCustomers",
                type: "int",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddColumn<Guid>(
                name: "CustomerId1",
                table: "IndividualCustomers",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "UserId",
                table: "Customers",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "PasswordHash", "PasswordSalt", "UpdatedDate" },
                values: new object[] { new Guid("d364d339-ffba-4a05-beb9-0d2b2220049d"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@kodlama.io", new byte[] { 209, 163, 78, 209, 126, 27, 84, 228, 119, 81, 41, 110, 76, 6, 195, 177, 39, 116, 215, 186, 167, 130, 135, 49, 48, 148, 48, 8, 66, 129, 222, 232, 206, 118, 117, 135, 45, 148, 73, 121, 243, 97, 252, 19, 148, 40, 46, 166, 207, 100, 5, 105, 86, 133, 170, 93, 201, 107, 61, 191, 175, 243, 160, 78 }, new byte[] { 166, 108, 67, 53, 10, 69, 83, 237, 150, 190, 200, 91, 90, 255, 155, 176, 144, 161, 92, 121, 122, 111, 238, 224, 253, 75, 221, 141, 252, 103, 167, 197, 131, 45, 151, 62, 131, 93, 186, 82, 157, 145, 104, 40, 76, 225, 68, 225, 23, 8, 11, 188, 246, 209, 34, 229, 26, 145, 198, 218, 213, 167, 100, 28, 32, 78, 73, 12, 41, 95, 244, 77, 158, 151, 242, 117, 221, 229, 157, 16, 60, 155, 17, 103, 166, 73, 118, 52, 144, 26, 18, 96, 168, 82, 188, 175, 50, 22, 167, 72, 119, 226, 132, 80, 109, 159, 231, 240, 116, 209, 170, 123, 227, 213, 199, 153, 7, 143, 178, 81, 224, 40, 155, 193, 250, 229, 201, 56 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("1f84de25-d678-4620-99ff-0294cb10d685"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("d364d339-ffba-4a05-beb9-0d2b2220049d") });

            migrationBuilder.CreateIndex(
                name: "IX_IndividualCustomers_CustomerId1",
                table: "IndividualCustomers",
                column: "CustomerId1");

            migrationBuilder.CreateIndex(
                name: "IX_CorporateCustomers_CustomerId",
                table: "CorporateCustomers",
                column: "CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Users_UserId",
                table: "Customers",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_IndividualCustomers_Customers_CustomerId1",
                table: "IndividualCustomers",
                column: "CustomerId1",
                principalTable: "Customers",
                principalColumn: "Id");
        }
    }
}
