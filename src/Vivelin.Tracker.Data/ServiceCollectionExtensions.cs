using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;

using Vivelin.Tracker.Data;

namespace Microsoft.Extensions.DependencyInjection;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddTrackerDataServices(this IServiceCollection services,
        string sqliteConnectionString)
    {
        return services.AddSqlite<TrackerContext>(sqliteConnectionString);
    }
}
