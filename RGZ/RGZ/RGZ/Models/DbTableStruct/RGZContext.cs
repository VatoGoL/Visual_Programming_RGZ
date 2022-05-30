using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace RGZ.Models.DbTableStruct
{
    public partial class RGZContext : DbContext
    {
        public RGZContext()
        {
        }

        public RGZContext(DbContextOptions<RGZContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Match> Matches { get; set; } = null!;
        public virtual DbSet<MatchStage> MatchStages { get; set; } = null!;
        public virtual DbSet<MatchStatistic> MatchStatistics { get; set; } = null!;
        public virtual DbSet<Player> Players { get; set; } = null!;
        public virtual DbSet<PlayerStatisticsForTheMatch> PlayerStatisticsForTheMatches { get; set; } = null!;
        public virtual DbSet<Stadium> Stadia { get; set; } = null!;
        public virtual DbSet<Team> Teams { get; set; } = null!;
        public virtual DbSet<Tournament> Tournaments { get; set; } = null!;
        public virtual DbSet<TournamentStage> TournamentStages { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlite("Data Source=C:\\Users\\Vato\\Desktop\\Визуальное программирование\\Visual_Programming_RGZ\\RGZ\\RGZ\\RGZ\\DataBase\\RGZ");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Match>(entity =>
            {
                entity.ToTable("Match");

                entity.HasIndex(e => e.Id, "IX_Match_id")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.DateTime)
                    .HasColumnType("DATETIME")
                    .HasColumnName("Date/Time");

                entity.Property(e => e.Score).HasColumnType("VARCHAR (5)");

                entity.Property(e => e.StadiumId).HasColumnName("Stadium (id)");

                entity.Property(e => e.StatisticsId).HasColumnName("Statistics (id)");

                entity.Property(e => e.TeamOneId).HasColumnName("Team_One (id)");

                entity.Property(e => e.TeamTwoId).HasColumnName("Team_Two (id)");

                entity.Property(e => e.TournayId).HasColumnName("Tournay (id)");
            });

            modelBuilder.Entity<MatchStage>(entity =>
            {
                entity.HasKey(e => e.MatchId);

                entity.ToTable("Match/Stage");

                entity.Property(e => e.MatchId)
                    .ValueGeneratedNever()
                    .HasColumnName("Match (id)");

                entity.Property(e => e.StageId).HasColumnName("Stage (id)");
            });

            modelBuilder.Entity<MatchStatistic>(entity =>
            {
                entity.ToTable("Match statistics");

                entity.HasIndex(e => e.Id, "IX_Match statistics_id")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Goal).HasColumnType("VARCHAR (5)");

                entity.Property(e => e.MatchId).HasColumnName("Match (id)");

                entity.Property(e => e.OwnGoal).HasColumnType("VARCHAR (5)");

                entity.Property(e => e.Penalty).HasColumnType("VARCHAR (5)");

                entity.Property(e => e.RedCards).HasColumnType("VARCHAR (5)");

                entity.Property(e => e.YellowCards).HasColumnType("VARCHAR (5)");
            });

            modelBuilder.Entity<Player>(entity =>
            {
                entity.ToTable("Player");

                entity.HasIndex(e => e.Id, "IX_Player_id")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.FirstName).HasColumnType("VARCHAR (20)");

                entity.Property(e => e.LastName).HasColumnType("VARCHAR (30)");

                entity.Property(e => e.RoleOnTheField).HasColumnType("VARCHAR (20)");

                entity.Property(e => e.TeamId).HasColumnName("Team (id)");
            });

            modelBuilder.Entity<PlayerStatisticsForTheMatch>(entity =>
            {
                entity.ToTable("Player statistics for the match");

                entity.HasIndex(e => e.Id, "IX_Player statistics for the match_id")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.MatchId).HasColumnName("Match (id)");

                entity.Property(e => e.PlayerId).HasColumnName("Player (id)");
            });

            modelBuilder.Entity<Stadium>(entity =>
            {
                entity.ToTable("Stadium");

                entity.HasIndex(e => e.Id, "IX_Stadium_id")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.CityLocation)
                    .HasColumnType("VARCHAR (60)")
                    .HasColumnName("City (Location)");

                entity.Property(e => e.Name).HasColumnType("VARCHAR (30)");
            });

            modelBuilder.Entity<Team>(entity =>
            {
                entity.ToTable("Team");

                entity.HasIndex(e => e.Id, "IX_Team_id")
                    .IsUnique();

                entity.HasIndex(e => e.Name, "IX_Team_Name")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Name).HasColumnType("VARCHAR (30)");
            });

            modelBuilder.Entity<Tournament>(entity =>
            {
                entity.ToTable("Tournament");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Name).HasColumnType("VARCHAR (20)");
            });

            modelBuilder.Entity<TournamentStage>(entity =>
            {
                entity.ToTable("Tournament stage");

                entity.HasIndex(e => e.Id, "IX_Tournament stage_id")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.StageName).HasColumnType("VARCHAR (20)");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
