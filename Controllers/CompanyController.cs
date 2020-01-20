using System.Threading.Tasks;
using HilarioMarket.DTO;
using HilarioMarket.Models;
using HilarioMarket.Repositories.Interface;
using Microsoft.AspNetCore.Mvc;

namespace HilarioMarket.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        private readonly ICompanyRepository _repository;
        public CompanyController(ICompanyRepository repository)
        {
            _repository = repository;
        }
        // GET: api/Company
        [HttpGet]
        public Task<CompanyDTO> Get()
        {
            return _repository.GetAll();
        }

        // GET: api/Company/5
        [HttpGet("{id}", Name = "GetCompany")]
        public Task<CompanyDTO.Company> Get(int id)
        {
            return _repository.GetById(id);
        }

        // Post: api/Company
        [HttpPost("CompanySave")]
        public async Task<string> CompanySave([FromBody]Company company)
        {
            return await _repository.Insert(company);
        }
    }
}
