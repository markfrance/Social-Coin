using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SocialCoin.Migrations
{
    public partial class Coinmarketcap : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "AvailableSupply",
                table: "Coin",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Change1Hr",
                table: "Coin",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Change24hr",
                table: "Coin",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Change7d",
                table: "Coin",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "DailyVolume",
                table: "Coin",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "MarketCapUSD",
                table: "Coin",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "PriceBTC",
                table: "Coin",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "PriceUSD",
                table: "Coin",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "Rank",
                table: "Coin",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Symbol",
                table: "Coin",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AvailableSupply",
                table: "Coin");

            migrationBuilder.DropColumn(
                name: "Change1Hr",
                table: "Coin");

            migrationBuilder.DropColumn(
                name: "Change24hr",
                table: "Coin");

            migrationBuilder.DropColumn(
                name: "Change7d",
                table: "Coin");

            migrationBuilder.DropColumn(
                name: "DailyVolume",
                table: "Coin");

            migrationBuilder.DropColumn(
                name: "MarketCapUSD",
                table: "Coin");

            migrationBuilder.DropColumn(
                name: "PriceBTC",
                table: "Coin");

            migrationBuilder.DropColumn(
                name: "PriceUSD",
                table: "Coin");

            migrationBuilder.DropColumn(
                name: "Rank",
                table: "Coin");

            migrationBuilder.DropColumn(
                name: "Symbol",
                table: "Coin");
        }
    }
}
