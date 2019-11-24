namespace FacadeApp
{
    class SimpleConverter
    {
        public void Convert(string filename, string format)
        {
            VideoFile videoFile = new VideoFile(filename);
            Codec codec;
            switch (format)
            {
                case "mp4":
                    codec = new MPEG4Codec();
                    break;
                case "ogg":
                    codec = new OGGCodec();
                    break;
                default:
                    return;
            }
            VideoCoverter videoCoverter = new VideoCoverter();
            videoCoverter.Convert(videoFile, codec);            
        }
    }
}
