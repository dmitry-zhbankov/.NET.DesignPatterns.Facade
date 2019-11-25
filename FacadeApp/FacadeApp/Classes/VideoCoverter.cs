namespace FacadeApp
{
    class VideoCoverter
    {        
        public VideoCoverter()
        {
            
        }      

        public int Convert(VideoFile file, Codec codec)
        {            
            return codec.Encode(file);
        }
    }
}
