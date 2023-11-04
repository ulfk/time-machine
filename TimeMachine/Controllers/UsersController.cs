using Microsoft.AspNetCore.Mvc;
using TimeMachine.Persistence.Entities;

namespace TimeMachine.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly ILogger<UsersController> _logger;

        public UsersController(ILogger<UsersController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("users")]
        public IEnumerable<IEnumerable<User>> GetUsers()
        {
            throw new NotImplementedException();
        }
    }
}