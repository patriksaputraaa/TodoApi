using Microsoft.EntityFrameworkCore;
using TodoApi.Models;

namespace TodoApi.Data;

public class ApplicationDbContext: DbContext{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options):base(options){
        
    }
    
    public DbSet<TodoItem> TodoItems{get; set;}
    public DbSet<User> Users{get; set;}
    public DbSet<Post> Posts{get; set;}
    public DbSet<Student> Students{get; set;}
    public DbSet<Course> Courses{get; set;}
}