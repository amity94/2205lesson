using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventdelegate
{
    class VideoEventArgs : EventArgs
    {
        public Video Video { get; set; }
    }
}
