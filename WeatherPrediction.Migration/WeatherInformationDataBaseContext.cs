using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using WeatherPrediction.Model.Entity;

namespace WeatherPrediction.Migrations
{
    public class WeatherInformationDataBaseContext: DbContext
    {
        public WeatherInformationDataBaseContext(DbContextOptions<WeatherInformationDataBaseContext> options) : base(options)
        {
        }

        public DbSet<WeatherInfo> WeatherInfos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<WeatherInfo>().ToTable("WeatherInfos");
        }
    }

}

