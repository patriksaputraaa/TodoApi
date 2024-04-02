using System;
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
    [Route("[controller]")]
    [ApiController]
    public class MapelController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public MapelController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpDelete("{kode}")]
        public async Task<IActionResult> DeleteMapel(string nip)
        {
            return Ok(new { Status = true });
        }

        [HttpPut("{kode}")]
        public async Task<IActionResult> PutTodoItem(long id, TodoItem todoItem)
        {
            return Ok(new { Status = true });
        }
    }
}
