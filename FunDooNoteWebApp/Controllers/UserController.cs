using BusinessLayer.Interface;
using CommonLayer.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FunDooNoteWebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserBusiness userBusiness;
        public UserController(IUserBusiness userBusiness)
        {
            this.userBusiness = userBusiness;
        }
        [HttpPost]
        [Route("UserRegistration")]
        public IActionResult UserReg(UserRegModel model)
        {
            var result = userBusiness.UserReg(model);
            if (result != null)
            {
                return this.Ok(new { success = true, Message = "User Registration Successful", Data = result });
            }
            else
            {
                return this.BadRequest(new { success = false, Message = "User Registration UnSuccessful", Data = result });

            }
        }

    }
}
