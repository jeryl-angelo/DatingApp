using DatingApp.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatingApp.Server.Configurations.Entities
{
    public class MatchSeedConfiguration : IEntityTypeConfiguration<Match>
    {
        public void Configure(EntityTypeBuilder<Match> builder)
        {
            builder.HasData(
               new Match
               {
                  Id =1,
                  MatchId =1,
                  MatcheeId = 10,
                  MatcherId = 20,
                  DateMatched = DateTime.Now



               },

               new Match
               {
                   Id =2,
                   MatchId=2,
                   MatcheeId = 20,
                   MatcherId = 10,
                   DateMatched = DateTime.Now

               }



               );

        }
    }
}
