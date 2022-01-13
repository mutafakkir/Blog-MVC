
using Microsoft.EntityFrameworkCore;

namespace blog.ViewModels;

[Keyless]
public class BlogsViewModel
{
    public List<BlogViewModel> Blogs { get; set; }
}