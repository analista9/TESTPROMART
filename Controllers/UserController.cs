using System.Threading.Tasks;
using HilarioMarket.DTO;
using HilarioMarket.Models;
using HilarioMarket.Repositories.Interface;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace HilarioMarket.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("AllowMyOrigin")]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _repository;
        public UserController(IUserRepository repository)
        {
            _repository = repository;
        }
        // GET: api/User
        [HttpGet]
        public Task<UserDTO.Response> Get()
        {
            return _repository.GetAll();
        }

        // GET: api/User/5
        [HttpGet("Login")]
        public Task<UserDTO.Response> Get([FromBody]UserDTO.Request request)
        {
            return _repository.GetById(request);
        }

        // Post: api/User
        [HttpPost("UserSave")]
        public async Task<string> UserSave([FromBody]User user)
        {
            return await _repository.Insert(user);
        }

        // Put: api/User
        [HttpPut("UserSave")]
        public async Task<string> UserUpdate([FromBody]User user)
        {
            return await _repository.Update(user);
        }
    }
}