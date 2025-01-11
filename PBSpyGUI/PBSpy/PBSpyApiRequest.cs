using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PBSpyGUI.PBSpy
{
    internal class PBSpyApiRequest
    {
        [JsonProperty(PropertyName = "fun")]
        public string Fun { get; set; }
    }
}
