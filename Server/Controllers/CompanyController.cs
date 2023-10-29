using BlApp.Server.Data;
using BlApp.Server.Data.Migrations;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BlApp.Server;

namespace BlApp.Server.Controllers
{
    [Route("api/companies")]
    [ApiController]
    [Authorize]
    public class CompanyController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public CompanyController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult<List<Models.Company>>> GetCompanies()
        {
            var companies = _context.Companies.ToList();
            return companies;
        }

    }
}
