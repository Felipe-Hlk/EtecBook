using EtecBookApi.Data;
using EtecBookAPI.DataTransferObjects;
using Microsoft.AspNetCore.Mvc;

namespace EtecBookApi.Controllers;

    [ApiController]
    [Route("api/[controller]")]
    public class AccountController : ControllerBase
    {
        private readonly AppDbContext _context;

        public AccountController(AppDbContext context)
        {
            _context = context;
        }
        
        [HttpPost("authenticate")]
        public async Task<IActionResult> Authenticate([FromBody] LoginDto login ) {

            if (login == null)
                return BadRequest();

            if (!ModelState.IsValid)
                return BadRequest();

            return null;

        }
    }
