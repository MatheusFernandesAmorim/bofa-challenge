using BOFAChallenge.UI.Domain.Entities.DTOs;
using BOFAChallenge.UI.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BOFAChallenge.UI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IValidationUser _validation;

        public UserController(IValidationUser validation) 
        {
            _validation = validation;
        }

        /// <summary>
        /// Method which validate if user data informed are valid and secure
        /// </summary>
        /// <param name="userDTO">Parameter that represents user data (name and password)</param>
        /// <returns>A message to inform if it's ok or not</returns>
        [HttpPost]
        [Route("ValidateUser")]
        public IActionResult ValidateUser(UserDTO userDTO)
        {
            try
            {
                _validation.ValidateUser(userDTO);

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}