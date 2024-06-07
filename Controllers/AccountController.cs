using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Toverland_API.Data;
using Toverland_API.Models;

namespace Toverland_API.Controllers
{
    [Route("api/account")]
    [ApiController]
    public class AccountController: ControllerBase
    {

        private readonly ApplicationDBContext _context;

        public AccountController(ApplicationDBContext context)
        {
            _context = context;
        }   

        [HttpGet]
        public IActionResult GetAll() {
            List<Account> accounts = _context.Account.ToList();

            Console.WriteLine(accounts);
            return Ok(accounts);
        }

        [HttpGet("{id}")]
        public IActionResult Get([FromRoute] int id) {
            Account? account = _context.Account.Find(id);

            if (account == null) {
                return NotFound();
            }

            return Ok(account);
        }
    }
}