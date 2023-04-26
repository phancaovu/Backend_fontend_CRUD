using Backend.Models;

namespace Backend.Repository
{
    public interface IUserRepository
    {
        public Task<List<User>> GetAllUserAsync();
        public Task<User> GetUserAsync(string UserID);

        public Task<User> AddUserAsync(User user);
        public Task UpdateUserAsync(string UserID,User user);
        public Task DeleteUserAsync(string UserID);
        Task GetUserAsync(User newUser);
    }
}
