using IdentityProject.WebApi.Contexts;
using IdentityProject.WebApi.Models; // Projemizde kullanılacak 'User' modeli bu namespace'de yer alıyor ve burada dahil ediliyor.
using IdentityProject.WebApi.Models.Dtos.Users.Request;
using IdentityProject.WebApi.Services.Abstracts;
using Microsoft.AspNetCore.Http; // HTTP talepleriyle çalışmak için gerekli olan namespace.
using Microsoft.AspNetCore.Mvc; // Web API oluşturmak ve HTTP isteklerini işlemek için gerekli namespace.

namespace IdentityProject.WebApi.Controllers // 'UsersController' sınıfının ait olduğu namespace.
{
    // API Controller'ımızın route (URL yolu) bilgisini ayarlıyoruz. '[controller]' ifadesi, 'UsersController' sınıfının adını temel alır ve "Users" olur.
    [Route("api/[controller]")]

    // Bu sınıfın bir API Controller olduğunu belirtiyoruz. Bu, sınıfın Web API taleplerine (GET, POST, PUT, DELETE) yanıt verebileceği anlamına gelir.
    [ApiController]

    public class UsersController : ControllerBase // 'ControllerBase' sınıfını miras alarak Web API controller'ı oluşturuyoruz.
    {
        private IUserService _userService;
        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _userService.GetAllUsers();
            return Ok(result);
        }


        [HttpPost("add")]
        public IActionResult Add(AddUsersRequestDto user)
        {
            var result=_userService.Add(user);
            return Ok(result);
        }


        [HttpGet("getemail")]
        public IActionResult GetByEmail(string email)
        {

            AddUsersRequestDto dto= new AddUsersRequestDto();
            User user=(User)dto;
            var result= _userService.GetByEmail(email);
            return Ok(result);
        }
    }
}
