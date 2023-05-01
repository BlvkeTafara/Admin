using AdmissionSettings.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdmissionSettings.DataAccess.Context
{
    public class AdmissionSettingsDbContext : DbContext 
    {
        public AdmissionSettingsDbContext(DbContextOptions<AdmissionSettingsDbContext> options): base(options) { }

        public DbSet<AdmissionSession> AdmissionSessions { get; set; }
        public DbSet<AdmissionSessionRequest> AdmissionSessionRequestz { get; set; }

       /* protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
                 modelBuilder.Entity<AdmissionSession>().HasData(
                   new AdmissionSession { Id = 1 , Name = "Tafara", Year = 2022 },
                   new AdmissionSession { Id = 2, Name = "Awethu", Year = 2023 }
                );
            modelBuilder.Entity<AdmissionSessionRequest>().HasData(
                 new AdmissionSessionRequest { Id = 1 , Name = "Fees" , Year = 2022}
                );
        } */
    }
    }

