using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PBSpyGUI.PBSpy
{
    internal class PBSpyApiResponseWithData<T> : PBSpyApiResponse
    {
        [JsonProperty(PropertyName = "data")]
        public T Data { get; set; }
    }
}
