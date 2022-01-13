using blog.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace blog.Data;
public class PostContext : DbContext
{
    public DbSet<BlogViewModel> Blog { get; set; }
    public DbSet<PostViewModel> Post { get; set; }
    public PostContext(DbContextOptions options)
        : base(options) { }
}