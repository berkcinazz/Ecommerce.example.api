using System.Text.RegularExpressions;

namespace Core.Security.Helpers
{
    public static class FileHelper
    {
        public static string AddFromBase64(string base64, string fileExtension, string folder = "")
        {
            base64 = Regex.Replace(base64, @"^data:image\/[a-zA-Z]+;base64,", string.Empty);
            byte[] imageBytes = Convert.FromBase64String(base64);
            string newPath = NewPathForBase64();
            var folderPath = Environment.CurrentDirectory + @"\wwwroot\documents\" + folder;
            if (!Directory.Exists(folderPath)) Directory.CreateDirectory(folderPath);
            File.WriteAllBytes(folderPath + @"\" + newPath + fileExtension, imageBytes);
            var pathDirectory = @"/documents/" + folder + @"/" + newPath;
            return pathDirectory;
        }
        public static string NewPathForBase64()
        {
            return Guid.NewGuid().ToString("N");
        }
        public static string GetFileExtension(string base64String)
        {
            base64String = Regex.Replace(base64String, @"^data:image\/[a-zA-Z]+;base64,", string.Empty);
            var data = base64String.Substring(0, 5);

            switch (data.ToUpper())
            {
                case "IVBOR":
                    return ".png";
                case "/9J/4":
                    return ".jpg";
                case "AAAAF":
                    return ".mp4";
                case "JVBER":
                    return ".pdf";
                case "AAABA":
                    return ".ico";
                case "UMFYI":
                    return ".rar";
                case "E1XYD":
                    return ".rtf";
                case "U1PKC":
                    return ".txt";
                case "MQOWM":
                case "77U/M":
                    return ".srt";
                default:
                    return string.Empty;
            }
        }
    }
}
