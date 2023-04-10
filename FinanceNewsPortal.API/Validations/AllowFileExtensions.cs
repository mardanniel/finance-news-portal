using System.ComponentModel.DataAnnotations;

namespace FinanceNewsPortal.API.Validations
{
    public class AllowFileExtensions : ValidationAttribute
    {
        private readonly string[] _extensions;
        
        public AllowFileExtensions(string[] extensions)
        {
            this._extensions = extensions;
        }

        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            var file = value as IFormFile;
            if (file != null)
            {
                var extension = Path.GetExtension(file.FileName);
                if (!this._extensions.Contains(extension.ToLower()))
                {
                    return new ValidationResult(this.GetErrorMessage());
                }
            }

            return ValidationResult.Success;
        }

        public string GetErrorMessage()
        {
            string extensionsStr = String.Join(",", this._extensions);
            return $"File extension not allowed, only {extensionsStr} are allowed.";
        }
    }
}