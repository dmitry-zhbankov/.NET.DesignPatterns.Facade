using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FacadeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleConverter converter = new SimpleConverter();
            converter.Convert("file.avi", "mp4");
            converter.Convert("file.avi", "ogg");
        }
    }
}
