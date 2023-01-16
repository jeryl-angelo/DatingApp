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
                  MatchId = 1,
                  MatcheeID = 1,
                  MatcherID = 2,
                  DateMatched = DateTime.Now



               },

               new Match
               {
                   MatchId = 2, 
                   MatcheeID = 2,
                   MatcherID = 1,
                   DateMatched = DateTime.Now

               }



               );

        }
    }
}
