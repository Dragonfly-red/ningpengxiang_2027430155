using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
namespace WindowsFormsApp1
{
    public partial class Dialog : Form
    {
        private object dlg;
        private object filepath;
        private string goalPath;
        private DialogResult dr;
        private object Media;

        public Dialog()
        {
            InitializeComponent();
        }
      

        private void button1_logon_Click(object sender, EventArgs e)
        {
          
            _dlg.logon();
        }

        private void button2_hide_Click(object sender, EventArgs e)
        {
            _dlg._hide();
        }

        private void button3_showDialog_Click(object sender, EventArgs e)
        {
            _dlg.ShowDialog();
        }

        private string Button4_Click(object sender, EventArgs e, object flower)
        {
            using (OpenFileDialog dlg = new OpenFileDialog()) 
            {
                _dlg.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    String fileName = dlg.FileName;
                    this.pictureBox1.Media = Media.FromFile(fileName);//将图片填充到pictureBox中
                    filepath = dlg.FileName;//获取全部文件路径
                    goalPath = @"E:\图像识别精英班\train\train-image";//系统文件目录


                }
            }
        }

        private static void pictureBox1_Clicks(string srcFolder, string destFilder)
        {
            string Media=_dlg.Media;
            DirectoryInfo directoryInfo = new DirectoryInfo(srcFolder);
            FileInfo[] files = directoryInfo.GetFiles();
            foreach (FileInfo file in files)
            {
                if (file.Extension == "jpg")
                {
                    file.CopyTo(Path.Combine(destFilder, file.Name));
                }
            }

        }
    }

    internal class _dlg
    {
        public static string Media { get; internal set; }

        internal static void Logon()
        {
            throw new NotImplementedException();
        }

        internal static void _hide()
        {
            throw new NotImplementedException();
        }

        internal static void ShowDialog()
        {
            throw new NotImplementedException();
        }

        internal static void logon()
        {
            throw new NotImplementedException();
        }
    }
}
