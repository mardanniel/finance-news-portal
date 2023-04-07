namespace FinanceNewsPortal.Web.Helper
{
    public class FileUpload
    {
        private readonly string _defaultDirPath = "uploads/";
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly IConfiguration _appConfig;

        public FileUpload(IWebHostEnvironment webHostEnvironment, IConfiguration appConfig)
        {
            this._webHostEnvironment = webHostEnvironment;
            this._appConfig = appConfig;
        }

        public string UploadFile(IFormFile file, string uniqueIdentierForFileName, string folder = "test")
        {

            string dirPath = $"{this._defaultDirPath}{folder}";
            var webrootUploadDir = Path.Combine(this._webHostEnvironment.WebRootPath, dirPath);

            if (!Directory.Exists(webrootUploadDir))
            {
                Directory.CreateDirectory(webrootUploadDir);
            }

            string fileExtension = file.ContentType.Split("/")[1];
            string fileName = Guid.NewGuid().ToString() + uniqueIdentierForFileName + $".{fileExtension}";
            string filePath = Path.Combine(webrootUploadDir, fileName);

            using (var fileStream = new FileStream(filePath, FileMode.Create))
            {
                file.CopyTo(fileStream);
            }

            return fileName;
        }

        public IFormFile? GetFile(string? fileName, string folder = "test")
        {
            if (fileName == null)
            {
                return null;
            }

            string filePathStr = $"{this._defaultDirPath}{folder}/{fileName}";
            var filePath = Path.Combine(this._webHostEnvironment.WebRootPath, filePathStr);
            using (var stream = File.OpenRead(filePath))
            {
                FormFile file = new FormFile(stream, 0, stream.Length, null, fileName);
                return file;
            }
        }

        public void DeleteFile(string? fileName, string folder = "test")
        {
            if (fileName == null)
            {
                return;
            }

            string filePathStr = $"{this._defaultDirPath}{folder}/{fileName}";
            var filePath = Path.Combine(this._webHostEnvironment.WebRootPath, filePathStr);

            FileInfo file = new FileInfo(filePath);

            if (file.Exists)
            {
                file.Delete();
            }
        }
    }
}