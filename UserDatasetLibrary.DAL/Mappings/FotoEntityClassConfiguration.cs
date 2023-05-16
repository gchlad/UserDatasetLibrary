using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserDatasetLibrary.DAL.Entities;

namespace UserDatasetLibrary.DAL.Mappings
{
    public sealed class FotoEntityClassConfiguration : IEntityTypeConfiguration<FotoEntity>
    {
        public void Configure(EntityTypeBuilder<FotoEntity> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(256);     
        }
    }
}
