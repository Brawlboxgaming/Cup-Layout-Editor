using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CupLayoutEditor
{
    public struct Track
    {
        [JsonProperty("Name")]
        public string Name { get; set; }
        [JsonProperty("SlotID")]
        public string SlotID { get; set; }
    }
}
