using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserDatasetLibrary.DAL.Entities;

namespace UserDatasetLibrary.DAL.Mappings
{
    internal class RolesEntityConfiguration
    {
        public void Configure(EntityTypeBuilder<RolesEntity> builder)
        {
            builder.HasKey(x => x.IdRole);

            builder.Property(x => x.RoleName)
                .IsRequired()
                .HasMaxLength(80);
            
            builder.Property(x => x.Right_ChangeUsers)
                .IsRequired();

            builder.Property(x => x.Right_ChangeRoles)
                .IsRequired();
        }
    }
}
