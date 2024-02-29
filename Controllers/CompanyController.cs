using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ResumeMgtBackend.Core.Context;
using ResumeMgtBackend.Core.Dtos.Company;

namespace ResumeMgtBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public CompanyController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        [Route("Create")]
        public async Task<IActionResult> CreateCompany([FromBody] CompanyCreateDto dto)
        {

        }
    }
}
