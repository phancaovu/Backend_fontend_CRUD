using Backend.DTO;
using Backend.Models;

namespace Backend.Repository
{
    public interface IUserRepository
    {
        public Task<List<UserDTO>> GetAllUserAsync();
        public Task<UserDTO> GetUserAsync(int UserID);

        public Task<int> AddUserAsync(User user);
        public Task UpdateUserAsync(int UserID,User usermodel);
        public Task DeleteUserAsync(int UserID);
    }
}
