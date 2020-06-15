namespace Social.Models
{
  public class Post
  {
    public int PostId { get; set; }
    public string Message { get; set; }
    public virtual ApplicationUser User { get; set; }
  }
}