using DatingApp.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatingApp.Server.Configurations.Entities
{
    public class UserSeedConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasData(
                new User
                {
                    Id = 1,
                    Username = "yifeng123",
                    Email = "yifeng@yahoo.com",
                    Age = "19",
                    Pronouns = "He/His",
                    Gender = "Male",
                    GenderPreference = "Any",
                    AgePreference = ">18",
                    ContactNum = 91234567,
                    Location = "Bedok",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"


                },

                new User
                {
                    Id = 2,
                    Username = "jeryl123",
                    Email = "jeryl@gmail.com",
                    Age = "19",
                    Pronouns = "He/His",
                    Gender = "Male",
                    GenderPreference = "Any",
                    AgePreference = ">18",
                    ContactNum = 93381467,
                    Location = "Pasir Ris",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                }



                ) ;
        }
    }
}
