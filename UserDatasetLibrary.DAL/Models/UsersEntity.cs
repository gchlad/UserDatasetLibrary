using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserDatasetLibrary.DAL.Entities
{
    public class UsersEntity: IdentityUser //changeed from internal to public because dbcontext error 
    {
        public string Name { get; set; }
    }
}
