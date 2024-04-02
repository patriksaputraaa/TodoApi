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
    public class GuruController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public GuruController(ApplicationDbContext context)
        {
            _context = context;
        }

    // GET: api/TodoItems
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Guru>>> GetGuru()
        {
            return Ok(new { Status = true });
        }
        
        [HttpGet("{nip}")]
        public async Task<ActionResult<IEnumerable<Guru>>> GetGuru(string nip)
        {
            return Ok(new { Status = true });
        }

        [HttpPost]
        public async Task<ActionResult<Guru>> PostGuru(Guru guru)
        {
            return Ok(new { Status = true });
        }
    }

 
}
