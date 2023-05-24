using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserDatasetLibrary.Core.Dtos.User;
using UserDatasetLibrary.DAL.Entities;

namespace UserDatasetLibrary.Core.Extensions
{
    public static class UserMappingExtensions
    {
        public static UsersEntity ToEntity(this UserDto dto)
        {
            return new UsersEntity
            {
                Name = dto.Name,
            };
        }

        public static UserDto ToDto(this UsersEntity entity)
        {
            return new UserDto
            (
                Id: entity.Id,
                UserName: entity.UserName,
                Name: entity.Name,
                Email: entity.Email
            );
        }
    }
}
