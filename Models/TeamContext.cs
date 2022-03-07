using Microsoft.EntityFrameworkCore;

namespace OlympicGames.Models
{
    public class TeamContext : DbContext
    {
        public TeamContext(DbContextOptions<TeamContext> options) : base(options) { }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Game> Games { get; set; }
        public DbSet<Sport> Sports { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Game>().HasData(
                new Game { GameId = "wint", Name = "Winter Olympics" },
                new Game { GameId = "sum", Name = "Summer Olympics" },
                new Game { GameId = "para", Name = "Paralympics" },
                new Game { GameId = "y", Name = "Youth Olympic Games" }
                );
            modelBuilder.Entity<Sport>().HasData(
                new Sport { SportId = "cur", Name = "Curling/Indoor" },
                new Sport { SportId = "bob", Name = "Bobsleigh/Outdoor" },
                new Sport { SportId = "div", Name = "Diving/Indoor" },
                new Sport { SportId = "road", Name = "Road Cycling/Outdoor" },
                new Sport { SportId = "arch", Name = "Archery/Indoor" },
                new Sport { SportId = "can", Name = "Canoe Sprint/Outdoor" },
                new Sport { SportId = "break", Name = "Breakdancing/Indoor" },
                new Sport { SportId = "skate", Name = "Skateboarding/Outdoor" }
                );
            modelBuilder.Entity<Team>().HasData(
                new Team { TeamId = "canada", GameId = "wint", LogoImage = "canada.png", Name = "Canada", SportId = "cur" },
                new Team { TeamId = "sweden", GameId = "wint", LogoImage = "sweden.png", Name = "Sweden", SportId = "cur" },
                new Team { TeamId = "gb", GameId = "wint", LogoImage = "gb.png", Name = "Great Britain", SportId = "cur" },
                new Team { TeamId = "jamaica", GameId = "wint", LogoImage = "jamaica.png", Name = "Jamaica", SportId = "bob" },
                new Team { TeamId = "italy", GameId = "wint", LogoImage = "italy.png", Name = "Italy", SportId = "bob" },
                new Team { TeamId = "japan", GameId = "wint", LogoImage = "japan.png", Name = "Japan", SportId = "bob" },
                new Team { TeamId = "germany", GameId = "sum", LogoImage = "germany.png", Name = "Germany", SportId = "div" },
                new Team { TeamId = "china", GameId = "sum", LogoImage = "china.png", Name = "China", SportId = "div" },
                new Team { TeamId = "mexico", GameId = "sum", LogoImage = "mexico.png", Name = "Mexico", SportId = "div" },
                new Team { TeamId = "brazil", GameId = "sum", LogoImage = "brazil.png", Name = "Brazil", SportId = "road" },
                new Team { TeamId = "netherlands", GameId = "sum", LogoImage = "netherlands.png", Name = "Netherlands", SportId = "road" },
                new Team { TeamId = "usa", GameId = "sum", LogoImage = "usa.png", Name = "USA", SportId = "road" },
                new Team { TeamId = "thailand", GameId="para", LogoImage="thailand.png",Name = "Thailand",SportId="arch" },
                new Team { TeamId = "uruguay", GameId="para", LogoImage="uruguay.png",Name = "Uruguay",SportId="arch" },
                new Team { TeamId = "ukraine", GameId="para", LogoImage="ukraine.png",Name = "Ukraine" , SportId = "arch" },
                new Team { TeamId = "austria", GameId="para", LogoImage="austria.png",Name = "Austria", SportId="can" },
                new Team { TeamId = "pakistan", GameId = "para", LogoImage="pakistan.png", Name = "Pakistan", SportId = "can" },
                new Team { TeamId = "zimbabwe", GameId = "para", LogoImage="zimbabwe.png", Name = "Zimbabwe", SportId = "can" },
                new Team { TeamId = "france", GameId="y", LogoImage = "france.png", Name = "France", SportId="break"},
                new Team { TeamId = "cyprus", GameId = "y", LogoImage = "cyprus.png", Name = "Cyprus", SportId = "break" },
                new Team { TeamId = "russia", GameId = "y", LogoImage = "russia.png", Name = "Russia", SportId = "break" },
                new Team { TeamId = "finland", GameId = "y", LogoImage = "finland.png", Name = "Finland", SportId = "skate" },
                new Team { TeamId = "slovakia", GameId = "y", LogoImage = "slovakia.png", Name = "Slovakia", SportId = "skate" },
                new Team { TeamId = "portugal", GameId = "y", LogoImage = "portugal.png", Name = "Portugal", SportId = "skate" }
                );
        }
    }
}
