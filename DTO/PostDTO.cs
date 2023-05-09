namespace Backend.DTO
{
    public class PostDTO
    {
        public int PostID { get; set; } 
        public string Title { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
    }
}
