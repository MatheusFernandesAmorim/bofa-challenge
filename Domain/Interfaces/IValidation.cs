using FluentValidation.Results;

namespace BOFAChallenge.UI.Domain.Interfaces
{
    public interface IValidation<T>
    {
        void ValidateMessage(ValidationResult result);
        void ValidateObject(T validant);
    }
}