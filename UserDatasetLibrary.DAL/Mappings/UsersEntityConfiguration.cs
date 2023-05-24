using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserDatasetLibrary.DAL.Entities;

namespace UserDatasetLibrary.DAL.Mappings
{
    internal class UsersEntityConfiguration
    {
        public void Configure(EntityTypeBuilder<UsersEntity> builder)
        {
            builder.Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(256);
            /*builder.Property(x => x.isDeleted)
                .ValueGeneratedOnAdd(bool.true)
                .IsRequired()
                .HasMaxLength(256);*/
        } 
    }
}
