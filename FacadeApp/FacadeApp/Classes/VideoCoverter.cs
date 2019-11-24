namespace FacadeApp
{
    class VideoCoverter
    {        
        public VideoCoverter()
        {
            
        }
        //private void CompressVideo(string filePath)
        //{
        //    if (File.Exists(filePath) && compressionProcesses <= camerasCount * 2)
        //    {
        //        //string fullDirectoryPath = new FileInfo(filePath).Directory.FullName;
        //        string fileName = Path.GetFileNameWithoutExtension(filePath);
        //        string newFileName = fileName + "_cmp";
        //        string directoryPath = Path.GetDirectoryName(filePath);
        //        string arguments = string.Format("-i \"{0}\\{1}.mp4\" -f mp4 -vcodec libx264 -preset fast -profile:v main \"{0}\\{2}.mp4\" -hide_banner", directoryPath, fileName, newFileName);
        //        Task task = new Task(() =>
        //        {
        //            compressionProcesses += 1;
        //            Process process = new Process();
        //            process.StartInfo.FileName = "ffmpeg\\ffmpeg.exe";
        //            process.StartInfo.Arguments = arguments;
        //            process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
        //            process.Start();
        //            process.WaitForExit();
        //            if (File.Exists(Path.Combine(directoryPath, newFileName + ".mp4")))
        //            {
        //                File.Delete(filePath);
        //            }
        //            compressionProcesses -= 1;
        //        });
        //        task.Start();
        //    }
        //}

        public void Convert(VideoFile file, Codec codec)
        {            
            codec.Encode(file);
        }
    }
}
