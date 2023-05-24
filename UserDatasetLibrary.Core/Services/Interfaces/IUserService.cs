using UserDatasetLibrary.Core.Dtos.User;

namespace UserDatasetLibrary.Core.Services.Interfaces
{
    public interface IUserService
    {
        Task CreateUser(UserDto user);
        UserDto? GetUserById(string id);

        UserDto?[] GetAllUsers();
        //Task UpdateUser(UserDto user);

        UserDto? DeleteUserById(string id);
    }
}