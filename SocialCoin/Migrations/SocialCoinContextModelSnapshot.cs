using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using SocialCoin.Models;

namespace SocialCoin.Migrations
{
    [DbContext(typeof(SocialCoinContext))]
    partial class SocialCoinContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SocialCoin.Models.Coin", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("AvailableSupply");

                    b.Property<decimal>("Change1Hr");

                    b.Property<decimal>("Change24hr");

                    b.Property<decimal>("Change7d");

                    b.Property<decimal>("DailyVolume");

                    b.Property<string>("Description");

                    b.Property<decimal>("MarketCapUSD");

                    b.Property<string>("Name");

                    b.Property<decimal>("PriceBTC");

                    b.Property<decimal>("PriceUSD");

                    b.Property<int>("Rank");

                    b.Property<string>("Symbol");

                    b.HasKey("ID");

                    b.ToTable("Coin");
                });

            modelBuilder.Entity("SocialCoin.Models.User", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Bio");

                    b.Property<DateTime>("DateOfBirth");

                    b.Property<string>("Email");

                    b.Property<string>("Password");

                    b.Property<string>("ProfilePicUrl");

                    b.Property<string>("Username");

                    b.HasKey("ID");

                    b.ToTable("User");
                });
        }
    }
}
