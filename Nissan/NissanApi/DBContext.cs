using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using NissanApi.Models;

namespace NissanApi
{
    public class DBContext:DbContext
    {
        public DBContext(DbContextOptions<DBContext> options)
            : base(options)
        {
            User = Set<User>();
            Accessory = Set<Accessory>();
            Property = Set<Property>();
            PropertyValue = Set<PropertyValue>();

        }

        public DbSet<User> User { get; set; }
        public DbSet<Accessory> Accessory { get; set; }
        public DbSet<Property> Property { get; set; }
        public DbSet<PropertyValue> PropertyValue { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Accessory>().Property(k => k.Id).HasColumnName("AccessoryID");
            modelBuilder.Entity<User>().Property(k => k.Id).HasColumnName("UserID");
            modelBuilder.Entity<Property>().Property(k => k.Id).HasColumnName("PropertyID");
            modelBuilder.Entity<PropertyValue>().Property(k => k.Id).HasColumnName("PropertyValueID");
            base.OnModelCreating(modelBuilder);
        }
    }

    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<DBContext>
    {
        public DBContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile(Directory.GetCurrentDirectory() + "/appsettings.json", optional: true)
                //.AddJsonFile(Directory.GetCurrentDirectory() + $"/appsettings.{Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT")}.json", optional: true)
                .Build();
            var builder = new DbContextOptionsBuilder<DBContext>();
            var connectionString = configuration.GetConnectionString("backend");
            builder.UseSqlServer(connectionString);
            return new DBContext(builder.Options);
        }
    }
}
