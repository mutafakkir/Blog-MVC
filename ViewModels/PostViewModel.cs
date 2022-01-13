namespace blog.ViewModels;

public class PostViewModel
{
    public Guid Id { get; set; }
    
    public DateTimeOffset CreatedAt { get; set; }
    
    public string Title { get; set; }
    
    public string Content { get; set; }

    public bool Edited { get; set; }   
}