using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventdelegate
{
    class Program
    {
        public static void AfterVideoEncoded(Video video)
        {
            Console.WriteLine($"my delegate -- {video} was encoded! yeah!");
        }

        // 3 void [what-happend]-EventHandler (object sender, EventArgs e)
        public static void VideoEncodedEventHandler(object sender, VideoEventArgs e)
        {
            Console.WriteLine(sender);
            Console.WriteLine($"MAIN -------- Video was encoded!!!! {e.Video}");
        }
        public static void EmailSentEventHandler(object sender, VideoEventArgs e)
        {
            Console.WriteLine(sender);
            Console.WriteLine($"Email was sent {e.Video}");
        }
        public static void VideoEncodingEventHandler(object sender, VideoEventArgs e)
        {
            Console.WriteLine(sender);
            Console.WriteLine($"MAIN--------- Video is Encoding..... encoding");
        }
        static void Main(string[] args)
        {

            VideoEncoder encode = new VideoEncoder();
            Video video = new Video("My cool video");

            // 4 registrating the method to the Publisher
            encode.VideoEncoded += VideoEncodedEventHandler;
            encode.VideoEncoded += EmailSentEventHandler;
            encode.VideoEncoding += VideoEncodingEventHandler;

            encode.Encode(video);

        }
    }
}
