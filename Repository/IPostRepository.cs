using Backend.DTO;
using Backend.Models;

namespace Backend.Repository
{
    public interface IPostRepository
    {
        public Task<List<PostDTO>> GetAllPostAsync();
        public Task<PostDTO> GetPostAsync(int PostID);

        public Task<int> AddPostAsync(Post post);
        public Task UpdatePostAsync(int PostID, Post postmodel);
        public Task DeletePostAsync(int PostID);
    }
}
