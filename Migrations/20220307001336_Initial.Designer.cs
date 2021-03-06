// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OlympicGames.Models;

namespace OlympicGames.Migrations
{
    [DbContext(typeof(TeamContext))]
    [Migration("20220307001336_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("OlympicGames.Models.Game", b =>
                {
                    b.Property<string>("GameId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GameId");

                    b.ToTable("Games");

                    b.HasData(
                        new
                        {
                            GameId = "wint",
                            Name = "Winter Olympics"
                        },
                        new
                        {
                            GameId = "sum",
                            Name = "Summer Olympics"
                        },
                        new
                        {
                            GameId = "para",
                            Name = "Paralympics"
                        },
                        new
                        {
                            GameId = "y",
                            Name = "Youth Olympic Games"
                        });
                });

            modelBuilder.Entity("OlympicGames.Models.Sport", b =>
                {
                    b.Property<string>("SportId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SportId");

                    b.ToTable("Sports");

                    b.HasData(
                        new
                        {
                            SportId = "cur",
                            Name = "Curling/Indoor"
                        },
                        new
                        {
                            SportId = "bob",
                            Name = "Bobsleigh/Outdoor"
                        },
                        new
                        {
                            SportId = "div",
                            Name = "Diving/Indoor"
                        },
                        new
                        {
                            SportId = "road",
                            Name = "Road Cycling/Outdoor"
                        },
                        new
                        {
                            SportId = "arch",
                            Name = "Archery/Indoor"
                        },
                        new
                        {
                            SportId = "can",
                            Name = "Canoe Sprint/Outdoor"
                        },
                        new
                        {
                            SportId = "break",
                            Name = "Breakdancing/Indoor"
                        },
                        new
                        {
                            SportId = "skate",
                            Name = "Skateboarding/Outdoor"
                        });
                });

            modelBuilder.Entity("OlympicGames.Models.Team", b =>
                {
                    b.Property<string>("TeamId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("GameId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LogoImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SportId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("TeamId");

                    b.HasIndex("GameId");

                    b.HasIndex("SportId");

                    b.ToTable("Teams");

                    b.HasData(
                        new
                        {
                            TeamId = "canada",
                            Name = "Canada"
                        },
                        new
                        {
                            TeamId = "sweden",
                            Name = "Sweden"
                        },
                        new
                        {
                            TeamId = "gb",
                            Name = "Great Britain"
                        },
                        new
                        {
                            TeamId = "jamaica",
                            Name = "Jamaica"
                        },
                        new
                        {
                            TeamId = "italy",
                            Name = "Italy"
                        },
                        new
                        {
                            TeamId = "japan",
                            Name = "Japan"
                        },
                        new
                        {
                            TeamId = "germany",
                            Name = "Germany"
                        },
                        new
                        {
                            TeamId = "china",
                            Name = "China"
                        },
                        new
                        {
                            TeamId = "mexico",
                            Name = "Mexico"
                        },
                        new
                        {
                            TeamId = "brazil",
                            Name = "Brazil"
                        },
                        new
                        {
                            TeamId = "netherlands",
                            Name = "Netherlands"
                        },
                        new
                        {
                            TeamId = "usa",
                            Name = "USA"
                        },
                        new
                        {
                            TeamId = "thailand",
                            Name = "Thailand"
                        },
                        new
                        {
                            TeamId = "uruguay",
                            Name = "Uruguay"
                        },
                        new
                        {
                            TeamId = "ukraine",
                            Name = "Ukraine"
                        },
                        new
                        {
                            TeamId = "austria",
                            Name = "Austria"
                        },
                        new
                        {
                            TeamId = "pakistan",
                            Name = "Pakistan"
                        },
                        new
                        {
                            TeamId = "zimbabwe",
                            Name = "Zimbabwe"
                        },
                        new
                        {
                            TeamId = "france",
                            Name = "France"
                        },
                        new
                        {
                            TeamId = "cyprus",
                            Name = "Cyprus"
                        },
                        new
                        {
                            TeamId = "russia",
                            Name = "Russia"
                        },
                        new
                        {
                            TeamId = "finland",
                            Name = "Finland"
                        },
                        new
                        {
                            TeamId = "slovakia",
                            Name = "Slovakia"
                        },
                        new
                        {
                            TeamId = "portugal",
                            Name = "Portugal"
                        });
                });

            modelBuilder.Entity("OlympicGames.Models.Team", b =>
                {
                    b.HasOne("OlympicGames.Models.Game", "Game")
                        .WithMany()
                        .HasForeignKey("GameId");

                    b.HasOne("OlympicGames.Models.Sport", "Sport")
                        .WithMany()
                        .HasForeignKey("SportId");

                    b.Navigation("Game");

                    b.Navigation("Sport");
                });
#pragma warning restore 612, 618
        }
    }
}
