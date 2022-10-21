using GenshinAccount.Utils;
using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Threading;
using System.Windows.Forms;

namespace GenshinAccount
{
    public partial class Plugin : Form
    {
        public Plugin()
        {
            InitializeComponent();
        }

        public string WorkPath = Environment.CurrentDirectory;
        public string PluginPath = Environment.CurrentDirectory + "\\Plugins";

        private void WishExport_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(PluginPath + "\\genshin-wish-export"))
            {
                if (MessageBox.Show("是否下载？下载时若出现卡顿 请不要关闭！\n 此过程预计需要5-10分钟", "提示",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No) ;
                else
                {
                    if (!Directory.Exists(WorkPath + "/Plugins"))
                        Directory.CreateDirectory(WorkPath + "/Plugins");
                    HttpWebRequest request = (HttpWebRequest)WebRequest.Create(
                        "https://github.com/biuuu/genshin-wish-export/releases/download/v0.8.10/Genshin-Wish-Export.zip");
                    HttpWebResponse response = request.GetResponse() as HttpWebResponse;
                    Stream responseStream = response.GetResponseStream();
                    Stream stream = new FileStream(WorkPath + "/Plugins/Genshin-Wish-Export.zip", FileMode.Create);
                    byte[] bArr = new byte[1024];
                    int size = responseStream.Read(bArr, 0, bArr.Length);
                    while (size > 0)
                    {
                        stream.Write(bArr, 0, size);
                        size = responseStream.Read(bArr, 0, bArr.Length);
                    }
                    stream.Close();
                    responseStream.Close();

                    MessageBox.Show("下载成功！！！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ZipHelper.ZipHelper.UnZip(WorkPath + "/Plugins/Genshin-Wish-Export.zip", WorkPath + "/Plugins");
                    MessageBox.Show("解压成功！！！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Process.Start(PluginPath + "\\genshin-wish-export\\Genshin Wish Export.exe");
                }
            }
            else if(Directory.Exists(PluginPath + "\\genshin-wish-export"))
                Process.Start(PluginPath + "\\genshin-wish-export\\Genshin Wish Export.exe");
        }

        private void AutoShoot_Click(object sender, EventArgs e)
        {
            // 我不知道这是什么QAQ
        }

        private void Sinicization_Click(object sender, EventArgs e)
        {
            Process.Start("https://docs.qq.com/doc/DVHdQWVBYSWVqUnN5");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Process.Start("https://docs.qq.com/doc/DVGVjbGNET1FJWVVN");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(PluginPath + "\\WindSong-Lyre-Genshin-Impact"))
            {
                if (MessageBox.Show("是否下载？下载时若出现卡顿 请不要关闭！\n 此过程预计需要5-10分钟", "提示",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No) ;
                else
                {
                    if (!Directory.Exists(WorkPath + "/Plugins"))
                        Directory.CreateDirectory(WorkPath + "/Plugins");
                    HttpWebRequest request = (HttpWebRequest)WebRequest.Create(
                        "https://github.com/Mppedoers/WindSong-Lyre-Genshin-Impact/releases/download/main/WindSong-Lyre-Genshin-Impact.zip");
                    HttpWebResponse response = request.GetResponse() as HttpWebResponse;
                    Stream responseStream = response.GetResponseStream();
                    Stream stream = new FileStream(WorkPath + "/Plugins/WindSong-Lyre-Genshin-Impact.zip", FileMode.Create);
                    byte[] bArr = new byte[1024];
                    int size = responseStream.Read(bArr, 0, bArr.Length);
                    while (size > 0)
                    {
                        stream.Write(bArr, 0, size);
                        size = responseStream.Read(bArr, 0, bArr.Length);
                    }
                    stream.Close();
                    responseStream.Close();

                    MessageBox.Show("下载成功！！！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ZipHelper.ZipHelper.UnZip(WorkPath + "/Plugins/WindSong-Lyre-Genshin-Impact.zip", WorkPath + "/Plugins");
                    MessageBox.Show("解压成功！！！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Process.Start(PluginPath + "\\WindSong-Lyre-Genshin-Impact\\疯物之诗琴（窗口版）.exe");
                }
            }
            else if (Directory.Exists(PluginPath + "\\WindSong-Lyre-Genshin-Impact"))
                Process.Start(PluginPath + "\\WindSong-Lyre-Genshin-Impact\\疯物之诗琴（窗口版）.exe");
        }
    }
}
