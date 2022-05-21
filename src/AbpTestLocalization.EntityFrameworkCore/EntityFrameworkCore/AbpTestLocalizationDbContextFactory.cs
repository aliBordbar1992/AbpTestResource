using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace AbpTestLocalization.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class AbpTestLocalizationDbContextFactory : IDesignTimeDbContextFactory<AbpTestLocalizationDbContext>
{
    public AbpTestLocalizationDbContext CreateDbContext(string[] args)
    {
        AbpTestLocalizationEfCoreEntityExtensionMappings.Configure();

        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<AbpTestLocalizationDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Default"));

        return new AbpTestLocalizationDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../AbpTestLocalization.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
