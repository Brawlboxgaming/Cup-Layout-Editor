using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CupLayoutEditor
{
    public struct Cup
    {
        public Track Track1;
        public Track Track2;
        public Track Track3;
        public Track Track4;

        public Cup(Track t1, Track t2, Track t3, Track t4)
        {
            Track1 = t1;
            Track2 = t2;
            Track3 = t3;
            Track4 = t4;
        }
    }
}
