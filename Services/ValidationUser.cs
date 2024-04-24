using BOFAChallenge.UI.Domain.Entities.DTOs;
using BOFAChallenge.UI.Domain.Interfaces;
using FluentValidation;

namespace BOFAChallenge.UI.Services
{
    public class ValidationUser : Validation<UserDTO>, IValidationUser
    {
        public void ValidateUser(UserDTO userDTO)
        {
            RuleFor(userDTO => userDTO.Username).NotEmpty().NotNull().MinimumLength(4).MaximumLength(20);

            RuleFor(userDTO => userDTO.Password).NotEmpty().NotNull().MinimumLength(8).MaximumLength(12);

            ValidateObject(userDTO);
        }
    }
}