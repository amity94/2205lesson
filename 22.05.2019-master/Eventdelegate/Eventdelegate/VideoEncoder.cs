using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventdelegate
{
    class VideoEncoder
    {
        // 1  - instance of the delegate (event)
        // subscribe to this!
        // event EventHandler [what-happend?]
        // delegate void EventHandler(object sender, VideoEventArgs e);
        public event EventHandler<VideoEventArgs> VideoEncoded;
        public event EventHandler<VideoEventArgs> VideoEncoding;

        // 2 - On[what-happend?]
        public void OnVideoEncoded(Video video)
        {
            //VideoEventArgs { Video = video } 
            // shortcut for:
            //VideoEventArgs v = new VideoEventArgs();
            //v.Video = video;

            if (VideoEncoded != null)
            {
                VideoEncoded.Invoke(this, new VideoEventArgs { Video = video });
            }
        }

        public void OnVideoEncoding(Video video)
        {
            if (VideoEncoding != null)
            {
                VideoEncoding.Invoke(this, new VideoEventArgs { Video = video });
            }
        }
        public void Encode(Video video)
        {
            Console.WriteLine("Starting to Encode video ...");
            OnVideoEncoding(video);

            // starting to encode
            Console.WriteLine("Encoding video ...");

            OnVideoEncoded(video);
        }
    }
}
