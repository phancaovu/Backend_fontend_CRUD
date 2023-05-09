using Backend.DTO;
using Backend.Models;

namespace Backend.Repository
{
    public class PostRepository : IPostRepository
    {
        public Task<int> AddPostAsync(Post Post)
        {
            throw new NotImplementedException();
        }

        public Task DeletePostAsync(int PostID)
        {
            throw new NotImplementedException();
        }

        public Task<List<PostDTO>> GetAllPostAsync()
        {
            throw new NotImplementedException();
        }

        public Task<PostDTO> GetPostAsync(int PostID)
        {
            throw new NotImplementedException();
        }

        public Task UpdatePostAsync(int PostID, Post Postmodel)
        {
            throw new NotImplementedException();
        }
    }
}
