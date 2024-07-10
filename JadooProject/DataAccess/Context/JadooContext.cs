﻿using JadooProject.DataAccess.Entites;
using Microsoft.EntityFrameworkCore;

namespace JadooProject.DataAccess.Context
{
    public class JadooContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server = DESKTOP-TOGRPIE\\SQLEXPRESS; integrated security = true; initial catalog = JadooDb; trustServerCertificate = true");
        }

        public DbSet<Service> Services { get; set; }
        public DbSet<Destination> Destinations { get; set; }
    }
}
