using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }
        ProcessStartInfo startInfo = new ProcessStartInfo("C:\\Program Files (x86)\\Microsoft\\Edge\\Application\\msedge.exe");

        private void btnfish_Click(object sender, EventArgs e)
        {
            Form11 form11 = new Form11();
            form11.Size = this.Size;
            form11.StartPosition = FormStartPosition.Manual;
            form11.Location = this.Location;
            form11.ShowDialog();
        }

        private void btnpoint_Click(object sender, EventArgs e)
        {
            startInfo.Arguments = "https://map.naver.com/p/entry/place/19130425?placePath=%2Fhome%3Fentry%3Dplt%26from%3Dmap%26fromPanelNum%3D1%26additionalHeight%3D76%26timestamp%3D202608031736%26locale%3Dko%26svcName%3Dmap_pcv5&searchType=place&lng=127.160339&lat=36.817401&c=15.29,0,0,0,dh";
            Process.Start(startInfo);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            startInfo.Arguments = "https://map.naver.com/p/entry/place/15160493?placePath=%252Fhome%253Fentry%253Dplt&searchType=place&lng=127.160339&lat=36.817401&c=15.00,0,0,0,dh";
            Process.Start(startInfo);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            startInfo.Arguments = "https://map.naver.com/p/entry/place/37805261?c=8.24,0,0,0,dh&placePath=%2Fhome%3Ffrom%3Dmap%26fromPanelNum%3D1%26additionalHeight%3D76%26timestamp%3D202608041727%26locale%3Dko%26svcName%3Dmap_pcv5";
            Process.Start(startInfo);
        }

        private void button122_Click(object sender, EventArgs e)
        {
            startInfo.Arguments = "https://www.badatime.com/";
            Process.Start(startInfo);
        }

        private void button12342_Click(object sender, EventArgs e)
        {
            startInfo.Arguments = "http://www.banakpo.co.kr/frame/webMain.do";
            Process.Start(startInfo);
        }
    }
}

