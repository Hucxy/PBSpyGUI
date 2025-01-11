using PBSpyGUI.PBSpy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PBSpyGUI.Test
{
    internal static class TestClass
    {
        public static void Test()
        {
            var ret = PBSpyApi.Api<PBSpyApiRequestWithData<WorkspaceOpenRequestData>, PBSpyApiResponseWithData<WorkspaceGetResponseData>>(new PBSpyApiRequestWithData<WorkspaceOpenRequestData>() { Fun = "WorkspaceGet", Data = new WorkspaceOpenRequestData() {  WorkspacePath = "D:\\身份证\\idcard.pbw" } });
        }
    }
}
