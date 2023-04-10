using System.ComponentModel.DataAnnotations;

namespace FinanceNewsPortal.API.Validations
{
    public class MaxFileSize : ValidationAttribute
    {
        private readonly int _maxFileSizeBytes;

        public MaxFileSize(int maxFileSize)
        {
            this._maxFileSizeBytes = maxFileSize;
        }

        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            var file = value as IFormFile;

            if (file != null)
            {
                if (file.Length > _maxFileSizeBytes)
                {
                    return new ValidationResult(this.GetErrorMessage());
                }
            }

            return ValidationResult.Success;
        }

        public string GetErrorMessage()
        {
            int maxFileSizeMB = Convert.ToInt16(this._maxFileSizeBytes * 0.000001);
            return $"Maximum allowed file size is {maxFileSizeMB} mb.";
        }
    }
}