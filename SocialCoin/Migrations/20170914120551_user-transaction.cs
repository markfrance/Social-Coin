using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace SocialCoin.Migrations
{
    public partial class usertransaction : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Change1Hr",
                table: "Coin",
                newName: "Change1hr");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "User",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "RealName",
                table: "User",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CmcId",
                table: "Coin",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "CoinDTO",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Change1hr = table.Column<decimal>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Symbol = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CoinDTO", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Comment",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Body = table.Column<string>(nullable: true),
                    CoinId = table.Column<string>(nullable: true),
                    DatePosted = table.Column<DateTime>(nullable: false),
                    UserID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comment", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Comment_User_UserID",
                        column: x => x.UserID,
                        principalTable: "User",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Global",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Active_Assets = table.Column<int>(nullable: false),
                    Active_Currencies = table.Column<int>(nullable: false),
                    Active_Markets = table.Column<int>(nullable: false),
                    Bitcoin_Percentage_Of_Market_Cap = table.Column<double>(nullable: false),
                    Total_24hr_Volume_Usd = table.Column<decimal>(nullable: false),
                    Total_Market_Cap_Usd = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Global", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Transaction",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Amount = table.Column<decimal>(nullable: false),
                    CoinID = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    Price = table.Column<decimal>(nullable: false),
                    UserID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transaction", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Transaction_User_UserID",
                        column: x => x.UserID,
                        principalTable: "User",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Comment_UserID",
                table: "Comment",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Transaction_UserID",
                table: "Transaction",
                column: "UserID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CoinDTO");

            migrationBuilder.DropTable(
                name: "Comment");

            migrationBuilder.DropTable(
                name: "Global");

            migrationBuilder.DropTable(
                name: "Transaction");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "User");

            migrationBuilder.DropColumn(
                name: "RealName",
                table: "User");

            migrationBuilder.DropColumn(
                name: "CmcId",
                table: "Coin");

            migrationBuilder.RenameColumn(
                name: "Change1hr",
                table: "Coin",
                newName: "Change1Hr");
        }
    }
}
