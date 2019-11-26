using System;
using System.Diagnostics;
using System.IO;

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
            string arguments = $"-i {videoFile.FullPath} {videoFile.FileName}_output.{format} -hide_banner -loglevel quiet";
            Console.WriteLine("Starting convertion process");
            Process process = new Process();
            process.StartInfo.FileName = @"ffmpeg\ffmpeg.exe";
            if (File.Exists(process.StartInfo.FileName))
            {
                process.StartInfo.Arguments = arguments;
                process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                process.Start();
                process.WaitForExit();
                return process.ExitCode;
            }
            else
            {
                throw new FileNotFoundException("File ffmpeg\\ffmpeg.exe is missing");
            }
        }
    }
}
