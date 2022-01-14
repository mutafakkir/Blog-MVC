using blog.Entity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace blog.Data;

public class BlogAppDbContext : IdentityDbContext<User>
{
    public BlogAppDbContext(DbContextOptions<BlogAppDbContext> options)
        : base(options) { }
}