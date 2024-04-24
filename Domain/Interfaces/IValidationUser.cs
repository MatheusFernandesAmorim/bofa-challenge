using BOFAChallenge.UI.Domain.Entities.DTOs;

namespace BOFAChallenge.UI.Domain.Interfaces
{
    public interface IValidationUser 
    {
        void ValidateUser(UserDTO userDTO);
    }
}