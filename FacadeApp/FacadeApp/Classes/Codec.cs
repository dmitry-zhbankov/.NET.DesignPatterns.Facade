using System.Diagnostics;

namespace FacadeApp
{
    abstract class Codec
    {
        string format;
        public Codec(string format)
        {
            this.format = format;
        }
        public int Encode(VideoFile videoFile)
        {            
            string arguments = $"-i \"{videoFile.FileName}.{videoFile.SourceFormat}\" -f {format} -vcodec libx264 -preset fast -profile:v main \"{videoFile.FileName}.{format}\" -hide_banner";
            Process process = new Process();
            process.StartInfo.FileName = "ffmpeg\\ffmpeg.exe";
            process.StartInfo.Arguments = arguments;
            process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            process.Start();
            process.WaitForExit();
            return process.ExitCode;
        }
    }
}
