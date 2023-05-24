using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserDatasetLibrary.Core.Dtos.User
{
    public record UserDto(Guid Id, string Name, string UserName, string Email)
    {
    }

    //public record UserDto[](string Id, string Name, string UserName, string Email)  { }
}
