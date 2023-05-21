using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserDatasetLibrary.DAL.Entities
{
    public class RolesEntity
    {
        public int IdRole { get; set; }
        public string RoleName { get; set; }
        public bool Right_ChangeUsers { get; set; }
        public bool Right_ChangeRoles { get; set; }
    }
}
