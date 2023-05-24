using UserDatasetLibrary.Core.Dtos.User;

namespace UserDatasetLibrary.Core.Services.Interfaces
{
    public interface IUserService
    {
        Task CreateUser(UserDto user);
        UserDto? GetUserById(Guid id);
        UserDto?[] GetAllUsers();
        //Task UpdateUser(UserDto user);
        UserDto? DeleteUserById(Guid id);
        //UserDto? DeleteUserById(object id);
    }
}