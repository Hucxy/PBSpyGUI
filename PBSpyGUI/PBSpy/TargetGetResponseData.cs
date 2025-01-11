using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PBSpyGUI.PBSpy
{
    internal class TargetGetResponseData
    {
        public string Path { get; set; }
        public string appname { get; set; }
        public string applib { get; set; }
        public List<string> liblist { get; set; }
        public string type { get; set; }
        public Dictionary<int, TargetProject> Projects { get; set; }
    }
}
