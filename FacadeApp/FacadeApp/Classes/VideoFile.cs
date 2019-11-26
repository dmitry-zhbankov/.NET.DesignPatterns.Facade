using System;
using System.IO;

namespace FacadeApp
{
    class VideoFile
    {
        public string FullPath { get; private set; }
        public string FileName { get; private set; }
        public string Extension { get; private set; }
        public VideoFile(string filename)
        {
            if (File.Exists(filename))
            {
                Extension = Path.GetExtension(filename).ToLower();
                switch (Extension)
                {
                    case ".avi":
                    case ".mp4":
                    case ".mov":
                    case ".flv":
                    case ".wmv":
                        FullPath = Path.GetFullPath(filename);
                        FileName = Path.GetFileNameWithoutExtension(filename);
                        break;
                    default:
                        throw new FormatException($"Convertion to \"{Extension}\" is not supported");
                }
            }
            else
            {
                throw new FileNotFoundException($"Videofile \"{filename}\" is not exist");
            }
        }
    }
}
