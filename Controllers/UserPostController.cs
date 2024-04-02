using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TodoApi.Data;
using TodoApi.Models;

namespace TodoApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserPostsController : ControllerBase
    {
        private readonly UserPostContext _context;

        public UserPostsController(UserPostContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetUserPosts()
        {
            var usersWithPosts = await _context.Users
                .Include(u => u.Posts)
                .ToListAsync();

            var userPostsDto = usersWithPosts.Select(u => new
            {
                id = u.Id,
                name = u.Name,
                email = u.Email,
                posts = u.Posts.Select(p => new
                {
                    id = p.Id,
                    title = p.Title,
                    content = p.Content
                }).ToList()
            }).ToList();

            var response = new { userposts = userPostsDto };
            return Ok(response);
        }
    }
}