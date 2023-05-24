using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserDatasetLibrary.DAL;
using UserDatasetLibrary.Core.Services.Interfaces;
using UserDatasetLibrary.Core.Dtos.User;
using UserDatasetLibrary.DAL.Entities;
using UserDatasetLibrary.Core.Extensions;

namespace UserDatasetLibrary.Core.Services
{
    internal class UserService :IUserService
    {
        private readonly UserDbContext _context;

        public UserService(UserDbContext context)
        {
            this._context = context;
        }

        public async Task CreateUser(UserDto user)
        {
            UsersEntity entity = user.ToEntity();
            await _context.Users.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public UserDto? GetUserById(Guid id)
        {
            UsersEntity? entity = _context.Users.Where(f => f.Id == id).FirstOrDefault(); 
            // TODO: throw entity not found exception and set up exception handling middleware
            return entity?.ToDto();
        }
        public UserDto[] GetAllUsers()
        {
            UsersEntity[] entities = _context.Users.ToArray();
            return entities.Select(u => u.ToDto()).ToArray();
        }

        public UserDto? DeleteUserById(Guid id) //TODO: Make it Async 
        {
            UsersEntity? entity = _context.Users.Where(f => f.Id == id).FirstOrDefault();
            // TODO: throw entity not found exception and set up exception handling middleware
            entity.IsDeleted = true;
            _context.Users.Update(entity);
            _context.SaveChangesAsync();
            //await _context.Users.Update(entity);
            //await _context.SaveChangesAsync();

            return entity?.ToDto();
        }
        /*
        public UserDto? GetUserById(int id)
        {
            throw new NotImplementedException();
        }*/
    }
}
