using EntityLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Mappings
{
    public class CoiffeurShiftMap : IEntityTypeConfiguration<EntityLayer.Entities.CoiffeurShift>
    {
        public void Configure(EntityTypeBuilder<EntityLayer.Entities.CoiffeurShift> builder)
        {
            builder.HasData(new CoiffeurShift
            {
                Id = 75319,
                CoiffeurId = 753159,
                StartTime = TimeSpan.FromHours(10),
                EndTime = TimeSpan.FromHours(18)
            },
            new CoiffeurShift
            {
                Id = 91357,
                CoiffeurId = 951357,
                StartTime = TimeSpan.FromHours(10),
                EndTime = TimeSpan.FromHours(22)
            });
        }
    }
}
