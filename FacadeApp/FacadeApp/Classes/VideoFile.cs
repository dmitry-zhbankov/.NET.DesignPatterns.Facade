using System;
using System.IO;

namespace FacadeApp
{
    class VideoFile
    {
        public string FileName { get; private set; }
        public string SourceFormat { get; private set; }        
        public VideoFile(string filename)
        {
            if (File.Exists(filename))
            {
                SourceFormat = Path.GetExtension(filename).ToLower();
                switch (SourceFormat)
                {
                    case "avi":
                    case "mp4":
                        FileName = Path.GetFileNameWithoutExtension(filename);
                        break;
                    default:
                        throw new FormatException();                        
                }
                //Regex regex = new Regex($".*\\.[mp4|ogg]",RegexOptions.IgnoreCase);
                //if (regex.IsMatch(filename))
                //{
                //    path = filename;
                //}
                //else
                //{
                //    throw new FormatException();
                //}
            }
            else
            {
                throw new FileNotFoundException();
            }
        }
    }
}
