using DatingApp.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatingApp.Server.Configurations.Entities
{
    public class StaffSeedConfiguration : IEntityTypeConfiguration<Staff>
    {
        public void Configure(EntityTypeBuilder<Staff> builder)
        {
            builder.HasData(
                new Staff
                {
                    Id = 1,
                    StaffName = "Yi Feng",
                    Age = 19,
                    Email = "2104394h@student.tp.edu.sg",
                    ContactNum = 96417218,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },

                new Staff
                {
                    Id = 2,
                    StaffName = "Jeryl",
                    Age = 19,
                    Email = "2104395e@student.tp.edu.sg",
                    ContactNum = 93381467,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                }
                );
        }
    }
}
