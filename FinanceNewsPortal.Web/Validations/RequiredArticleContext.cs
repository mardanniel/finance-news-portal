using System.ComponentModel.DataAnnotations;

namespace FinanceNewsPortal.Web.Validations
{
    public class RequiredArticleContext : ValidationAttribute
    {
        /*public override bool IsValid(object value)
        {
            if (value is string stringValue)
            {
                if (!string.IsNullOrWhiteSpace(stringValue))
                {
                    return true;
                }
            }
            return false;
        }*/
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if (value is string stringValue)
            {
                if (!string.IsNullOrWhiteSpace(stringValue))
                {
                    return new ValidationResult(this.GetErrorMessage());
                }
            }
            return ValidationResult.Success;
        }
        public string GetErrorMessage()
        {
            return $"Content is required.";
        }
    }
}
