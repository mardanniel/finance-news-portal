using System.ComponentModel.DataAnnotations;

namespace FinanceNewsPortal.Web.Validations
{
    public class RequiredArticleContext : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if (value is string stringValue)
            {
                if (string.IsNullOrWhiteSpace(stringValue))
                {
                    return new ValidationResult(this.GetErrorMessage());
                }
            }
            return ValidationResult.Success;
        }
        public string GetErrorMessage()
        {
            return $"Context must not be empty.";
        }
    }
}
