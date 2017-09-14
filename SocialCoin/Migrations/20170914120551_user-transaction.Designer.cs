using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using SocialCoin.Models;

namespace SocialCoin.Migrations
{
    [DbContext(typeof(SocialCoinContext))]
    [Migration("20170914120551_user-transaction")]
    partial class usertransaction
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SocialCoin.Models.Coin", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("AvailableSupply");

                    b.Property<decimal>("Change1hr");

                    b.Property<decimal>("Change24hr");

                    b.Property<decimal>("Change7d");

                    b.Property<string>("CmcId");

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

            modelBuilder.Entity("SocialCoin.Models.CoinDTO", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("Change1hr");

                    b.Property<string>("Name");

                    b.Property<string>("Symbol");

                    b.HasKey("ID");

                    b.ToTable("CoinDTO");
                });

            modelBuilder.Entity("SocialCoin.Models.Comment", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Body");

                    b.Property<string>("CoinId");

                    b.Property<DateTime>("DatePosted");

                    b.Property<int?>("UserID");

                    b.HasKey("ID");

                    b.HasIndex("UserID");

                    b.ToTable("Comment");
                });

            modelBuilder.Entity("SocialCoin.Models.Global", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Active_Assets");

                    b.Property<int>("Active_Currencies");

                    b.Property<int>("Active_Markets");

                    b.Property<double>("Bitcoin_Percentage_Of_Market_Cap");

                    b.Property<decimal>("Total_24hr_Volume_Usd");

                    b.Property<decimal>("Total_Market_Cap_Usd");

                    b.HasKey("ID");

                    b.ToTable("Global");
                });

            modelBuilder.Entity("SocialCoin.Models.Transaction", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("Amount");

                    b.Property<string>("CoinID");

                    b.Property<DateTime>("Date");

                    b.Property<decimal>("Price");

                    b.Property<int?>("UserID");

                    b.HasKey("ID");

                    b.HasIndex("UserID");

                    b.ToTable("Transaction");
                });

            modelBuilder.Entity("SocialCoin.Models.User", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Bio");

                    b.Property<DateTime>("DateCreated");

                    b.Property<DateTime>("DateOfBirth");

                    b.Property<string>("Email");

                    b.Property<string>("Password");

                    b.Property<string>("ProfilePicUrl");

                    b.Property<string>("RealName");

                    b.Property<string>("Username");

                    b.HasKey("ID");

                    b.ToTable("User");
                });

            modelBuilder.Entity("SocialCoin.Models.Comment", b =>
                {
                    b.HasOne("SocialCoin.Models.User", "User")
                        .WithMany("Comments")
                        .HasForeignKey("UserID");
                });

            modelBuilder.Entity("SocialCoin.Models.Transaction", b =>
                {
                    b.HasOne("SocialCoin.Models.User", "User")
                        .WithMany("Transactions")
                        .HasForeignKey("UserID");
                });
        }
    }
}
