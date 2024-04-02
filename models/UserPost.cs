using Microsoft.EntityFrameworkCore;

namespace TodoApi.Models;

public class UserPost
{
    public int Id { get; set; } 
    public string Name { get; set; } 
    public string Email { get; set; } 
    public List<Post> Posts { get; set; }

    public UserPost(List<User> dataUser, List<Post> dataPost)
    {
        // Example: Assuming you want to aggregate data from users and posts
        if (dataUser.Any())
        {
            var user = dataUser.First(); // Example: Taking the first user
            Id = user.Id; // Example: Assigning Id from user
            Name = user.Name; // Example: Assigning Name from user
            Email = user.Email; // Example: Assigning Email from user
        }

        Posts = dataPost;
    }
}