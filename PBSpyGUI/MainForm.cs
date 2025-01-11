using PBSpyGUI.PBSpy;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PBSpyGUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string ext = openFileDialog1.SafeFileName.Substring(openFileDialog1.SafeFileName.LastIndexOf(".") + 1).ToLower();
                switch (ext)
                {
                    case "pbw":
                        var pbw = PBSpyApi.Api<PBSpyApiRequestWithData<WorkspaceOpenRequestData>, PBSpyApiResponseWithData<WorkspaceGetResponseData>>(new PBSpyApiRequestWithData<WorkspaceOpenRequestData>() { Fun = "WorkspaceGet", Data = new WorkspaceOpenRequestData() { WorkspacePath = openFileDialog1.FileName } });
                        break;
                    case "pbt":
                        var pbt = PBSpyApi.Api<PBSpyApiRequestWithData<TargetGetRequestData>, PBSpyApiResponseWithData<TargetGetResponseData>>(new PBSpyApiRequestWithData<TargetGetRequestData>() { Fun = "TargetGet", Data = new TargetGetRequestData() {  TargetPath = openFileDialog1.FileName } });
                        break;
                }
            }
        }

        private void tabControl1_DoubleClick(object sender, EventArgs e)
        {
            tabControl1.TabPages.RemoveAt(tabControl1.SelectedIndex);
        }
    }
}
