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
    public class CoiffeurMap : IEntityTypeConfiguration<Coiffeur>
    {
        public void Configure(EntityTypeBuilder<Coiffeur> builder)
        {
            builder.HasData(new Coiffeur
            {
                Id = 753159,
                Gender = "Kadın"
            },
            new Coiffeur
            {
                Id = 951357,
                Gender = "Erkek"

            });
        }
    }
}
