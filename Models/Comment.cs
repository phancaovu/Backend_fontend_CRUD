namespace Backend.Models
{
    public class Comment
    {
        public int CommentID { get; set; }
        public string Content { get; set; } = string.Empty;
        public DateTime CreatedDate { get; set; }
    }
}
