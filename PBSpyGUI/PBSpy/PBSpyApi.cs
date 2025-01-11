using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace PBSpyGUI
{
    internal static class PBSpyApi
    {
        [DllImport("PBSpy.dll")]
        private static extern IntPtr PBSpy_JsonApi(string json);

        [DllImport("PBSpy.dll")]
        private static extern void PBSpy_JsonFree(IntPtr json);

        public static string JsonApi(string json)
        {
            string ret = null;
            IntPtr ptr = PBSpy_JsonApi(json);
            if (ptr != IntPtr.Zero)
            {
                ret = Marshal.PtrToStringAnsi(ptr);
                PBSpy_JsonFree(ptr);
            }
            return ret;
        }

        public static T2 Api<T1, T2>(T1 request)
        {
            return JsonConvert.DeserializeObject<T2>(JsonApi(JsonConvert.SerializeObject(request)));
        }
    }
}
