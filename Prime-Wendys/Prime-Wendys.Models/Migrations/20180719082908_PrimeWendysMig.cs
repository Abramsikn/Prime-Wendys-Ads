using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PrimeWendys.Models.Migrations
{
    public partial class PrimeWendysMig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "USER",
                columns: table => new
                {
                    User_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Email = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    First_Name = table.Column<string>(nullable: true),
                    Last_Name = table.Column<string>(nullable: true),
                    ContactNumber = table.Column<string>(nullable: true),
                    DoB = table.Column<string>(nullable: true),
                    Home_Address = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    Zip_Code = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_USER", x => x.User_Id);
                });

            migrationBuilder.CreateTable(
                name: "WOOD",
                columns: table => new
                {
                    Wood_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Wood_Type = table.Column<string>(nullable: true),
                    Wood_Desc = table.Column<string>(nullable: true),
                    Wood_Price = table.Column<double>(nullable: false),
                    Wood_Picture = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WOOD", x => x.Wood_Id);
                });

            migrationBuilder.CreateTable(
                name: "ROLE",
                columns: table => new
                {
                    Role_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    User_Id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ROLE", x => x.Role_Id);
                    table.ForeignKey(
                        name: "FK_ROLE_USER_User_Id",
                        column: x => x.User_Id,
                        principalTable: "USER",
                        principalColumn: "User_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WENDY",
                columns: table => new
                {
                    Wendy_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Size = table.Column<string>(nullable: true),
                    NumOfRooms = table.Column<int>(nullable: false),
                    Wendy_Type = table.Column<double>(nullable: false),
                    Price = table.Column<double>(nullable: false),
                    Picture = table.Column<byte[]>(nullable: true),
                    Wood_Id = table.Column<int>(nullable: false),
                    User_Id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WENDY", x => x.Wendy_Id);
                    table.ForeignKey(
                        name: "FK_WENDY_USER_User_Id",
                        column: x => x.User_Id,
                        principalTable: "USER",
                        principalColumn: "User_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WENDY_WOOD_Wood_Id",
                        column: x => x.Wood_Id,
                        principalTable: "WOOD",
                        principalColumn: "Wood_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PERMISSION",
                columns: table => new
                {
                    Per_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Role_Id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PERMISSION", x => x.Per_Id);
                    table.ForeignKey(
                        name: "FK_PERMISSION_ROLE_Role_Id",
                        column: x => x.Role_Id,
                        principalTable: "ROLE",
                        principalColumn: "Role_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DOOR",
                columns: table => new
                {
                    Door_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Door_Type = table.Column<string>(nullable: true),
                    Door_Price = table.Column<double>(nullable: false),
                    Door_Picture = table.Column<byte[]>(nullable: true),
                    Wendy_Id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DOOR", x => x.Door_Id);
                    table.ForeignKey(
                        name: "FK_DOOR_WENDY_Wendy_Id",
                        column: x => x.Wendy_Id,
                        principalTable: "WENDY",
                        principalColumn: "Wendy_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "WINDOW",
                columns: table => new
                {
                    Win_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Win_Type = table.Column<string>(nullable: true),
                    Win_Price = table.Column<double>(nullable: false),
                    Win_Picture = table.Column<byte[]>(nullable: true),
                    Wendy_Id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WINDOW", x => x.Win_Id);
                    table.ForeignKey(
                        name: "FK_WINDOW_WENDY_Wendy_Id",
                        column: x => x.Wendy_Id,
                        principalTable: "WENDY",
                        principalColumn: "Wendy_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DOOR_Wendy_Id",
                table: "DOOR",
                column: "Wendy_Id");

            migrationBuilder.CreateIndex(
                name: "IX_PERMISSION_Role_Id",
                table: "PERMISSION",
                column: "Role_Id");

            migrationBuilder.CreateIndex(
                name: "IX_ROLE_User_Id",
                table: "ROLE",
                column: "User_Id");

            migrationBuilder.CreateIndex(
                name: "IX_WENDY_User_Id",
                table: "WENDY",
                column: "User_Id");

            migrationBuilder.CreateIndex(
                name: "IX_WENDY_Wood_Id",
                table: "WENDY",
                column: "Wood_Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_WINDOW_Wendy_Id",
                table: "WINDOW",
                column: "Wendy_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DOOR");

            migrationBuilder.DropTable(
                name: "PERMISSION");

            migrationBuilder.DropTable(
                name: "WINDOW");

            migrationBuilder.DropTable(
                name: "ROLE");

            migrationBuilder.DropTable(
                name: "WENDY");

            migrationBuilder.DropTable(
                name: "USER");

            migrationBuilder.DropTable(
                name: "WOOD");
        }
    }
}
