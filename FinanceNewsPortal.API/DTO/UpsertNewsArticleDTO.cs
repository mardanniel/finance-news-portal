using FinanceNewsPortal.API.Validations;
using System.ComponentModel.DataAnnotations;

namespace FinanceNewsPortal.API.DTO
{
    public class UpsertNewsArticleDTO
    {
        public Guid? Id { get; set; }

        public Guid? Author { get; set; }

        public string Title { get; set; }

        public string Context { get; set; }

        public IEnumerable<Guid>? Tags { get; set; }

        public List<Guid>? SelectedTagsOnEdit { get; set; }

        [DataType(DataType.Upload)]
        [MaxFileSize(2 * 1024 * 1024)]
        [AllowFileExtensions(new string[] { ".jpg", ".jpeg", ".png" })]
        public IFormFile? Image { get; set; }

        public string? ImageFilePath { get; set; }
    }
}
