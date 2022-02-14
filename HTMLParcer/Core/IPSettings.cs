using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTMLParcer.Core
{
    interface IPSettings
    {
        string url { get; set; }

        string prefix { get; set; }

        int startPoint { get; set; }

        int endPoint { get; set; }

    }
}
