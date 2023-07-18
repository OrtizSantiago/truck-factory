using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NissanApi.Migrations
{
    /// <inheritdoc />
    public partial class model_001 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Accessory",
                columns: table => new
                {
                    AccessoryID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Code = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Enabled = table.Column<bool>(type: "bit", nullable: false),
                    Required = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<long>(type: "bigint", nullable: false),
                    UpdatedAt = table.Column<long>(type: "bigint", nullable: false),
                    Deleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedUserID = table.Column<int>(type: "int", nullable: true),
                    UpdatedUserID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accessory", x => x.AccessoryID);
                });

            migrationBuilder.CreateTable(
                name: "Property",
                columns: table => new
                {
                    PropertyID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<long>(type: "bigint", nullable: false),
                    UpdatedAt = table.Column<long>(type: "bigint", nullable: false),
                    Deleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedUserID = table.Column<int>(type: "int", nullable: true),
                    UpdatedUserID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Property", x => x.PropertyID);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    UserID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Avatar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Code = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Administrative = table.Column<bool>(type: "bit", nullable: false),
                    Administrator = table.Column<bool>(type: "bit", nullable: false),
                    Operator = table.Column<bool>(type: "bit", nullable: false),
                    LastConnection = table.Column<long>(type: "bigint", nullable: true),
                    CreatedAt = table.Column<long>(type: "bigint", nullable: false),
                    UpdatedAt = table.Column<long>(type: "bigint", nullable: false),
                    Deleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedUserID = table.Column<int>(type: "int", nullable: true),
                    UpdatedUserID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.UserID);
                });

            migrationBuilder.CreateTable(
                name: "PropertyValue",
                columns: table => new
                {
                    PropertyValueID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PropertyCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PropertyId = table.Column<long>(type: "bigint", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ValueString = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ValueDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ValueInt = table.Column<int>(type: "int", nullable: true),
                    ValueFloat = table.Column<float>(type: "real", nullable: true),
                    TextES = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TextEN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TextPT = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<long>(type: "bigint", nullable: false),
                    UpdatedAt = table.Column<long>(type: "bigint", nullable: false),
                    Deleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedUserID = table.Column<int>(type: "int", nullable: true),
                    UpdatedUserID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropertyValue", x => x.PropertyValueID);
                    table.ForeignKey(
                        name: "FK_PropertyValue_Property_PropertyId",
                        column: x => x.PropertyId,
                        principalTable: "Property",
                        principalColumn: "PropertyID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Pickup",
                columns: table => new
                {
                    PickupID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Code = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    MarketId = table.Column<long>(type: "bigint", nullable: false),
                    Enabled = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<long>(type: "bigint", nullable: false),
                    UpdatedAt = table.Column<long>(type: "bigint", nullable: false),
                    Deleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedUserID = table.Column<int>(type: "int", nullable: true),
                    UpdatedUserID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pickup", x => x.PickupID);
                    table.ForeignKey(
                        name: "FK_Pickup_PropertyValue_MarketId",
                        column: x => x.MarketId,
                        principalTable: "PropertyValue",
                        principalColumn: "PropertyValueID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Accessory_Code",
                table: "Accessory",
                column: "Code",
                unique: true,
                filter: "[Code] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Pickup_Code",
                table: "Pickup",
                column: "Code",
                unique: true,
                filter: "[Code] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Pickup_MarketId",
                table: "Pickup",
                column: "MarketId");

            migrationBuilder.CreateIndex(
                name: "IX_Property_Code",
                table: "Property",
                column: "Code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PropertyValue_Code",
                table: "PropertyValue",
                column: "Code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PropertyValue_PropertyId",
                table: "PropertyValue",
                column: "PropertyId");

            migrationBuilder.CreateIndex(
                name: "IX_User_Code",
                table: "User",
                column: "Code",
                unique: true,
                filter: "[Code] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_User_Email",
                table: "User",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_User_Username",
                table: "User",
                column: "Username",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Accessory");

            migrationBuilder.DropTable(
                name: "Pickup");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "PropertyValue");

            migrationBuilder.DropTable(
                name: "Property");
        }
    }
}
