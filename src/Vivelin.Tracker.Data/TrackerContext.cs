using System;

using Microsoft.EntityFrameworkCore;

using Vivelin.Tracker.Data.Entities;

namespace Vivelin.Tracker.Data;

internal class TrackerContext : DbContext
{
    public TrackerContext(DbContextOptions options)
        : base(options)
    {
    }

    public DbSet<Human> Humans => Set<Human>();
}
