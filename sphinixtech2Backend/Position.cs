// Position.cs
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace PositionStore.Models
{
    public class Position
    {
        public int Id { get; set; }
        public float XPos { get; set; }
        public float YPos { get; set; }
    }

    public class PositionDbContext : DbContext
    {
        public PositionDbContext(DbContextOptions<PositionDbContext> options) : base(options) { }
        public DbSet<Position> Positions { get; set; } = null!;
    }
}
