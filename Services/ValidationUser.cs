using BOFAChallenge.UI.Domain.Entities.DTOs;
using BOFAChallenge.UI.Domain.Interfaces;
using FluentValidation;
using System.Text.RegularExpressions;

namespace BOFAChallenge.UI.Services
{
    public class ValidationUser : Validation<UserDTO>, IValidationUser
    {
        private bool ValidateUserPassword(string pw)
        {
            var lowercase = new Regex("[a-z]+");
            var uppercase = new Regex("[A-Z]+");
            var digit = new Regex("(\\d)+");
            var symbol = new Regex("(\\W)+");

            var isValid = lowercase.IsMatch(pw) && uppercase.IsMatch(pw) && digit.IsMatch(pw) && symbol.IsMatch(pw);

            return isValid;
        }

        public void ValidateUser(UserDTO userDTO)
        {
            RuleFor(userDTO => userDTO.Password)
                .NotEmpty()
                .NotNull()
                .Length(8, 12)                
                .Must(ValidateUserPassword);

            RuleFor(userDTO => userDTO.Username)
                .NotEmpty()
                .NotNull()
                .Length(4, 20);                          

            ValidateObject(userDTO);
        }
    }
}