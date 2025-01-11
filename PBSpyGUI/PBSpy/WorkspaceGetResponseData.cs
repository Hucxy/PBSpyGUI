using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PBSpyGUI.PBSpy
{
    internal class WorkspaceGetResponseData
    {
        public string Path { get; set; }
        public Dictionary<int, string> Targets { get; set; }
        public string DefaultTarget { get; set; }
        public string DefaultRemoteTarget { get; set; }
    }
}
