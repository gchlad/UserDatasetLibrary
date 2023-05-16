using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserDatasetLibrary.Core.Dtos.Foto;
using UserDatasetLibrary.DAL.Entities;

namespace UserDatasetLibrary.Core.Extensions
{
    public static class FotoMappingExtensions
    {
        public static FotoEntity ToEntity(this FotoDto dto)
        {
            return new FotoEntity
            {
                Name = dto.Name,
            };
        }

        public static FotoDto ToDto(this FotoEntity entity)
        {
            return new FotoDto
            (
                Id: entity.Id,
                Name: entity.Name
            );
        }
    }
}
