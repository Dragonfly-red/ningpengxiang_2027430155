using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        private object dlg;
        private object filepath;
        private string goalPath;
        private new readonly object ShowDialog;
        private readonly object FileName;
        private object absoluttepath;
        public Form2()
        {
            InitializeComponent();
        }

        private void Button4_OK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void Button5_cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void Button6_hide_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1_Click(sender, e, new OpenFileDialog());
        }

        private void button1_Click(object sender, EventArgs e, OpenFileDialog openFileDialog)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())  
           
            {
                int absoluttepath;
                DialogResult dr = dlg.ShowDialog();
                if(dr==DialogResult.OK)
                {
                    String fileName = dlg.FileName;
                    this.pictureBox1.Image = Image.FromFile(fileName);//将图片填充到pictureBox中
                    filepath = dlg.FileName;//获取全部文件路径
                    goalPath = @"E:\图像识别精英班\train\train-image";//系统文件目录


                     
                }
            }

        }

        private void moveFiles(object absoluttepath, string v)
        {
            throw new NotImplementedException();
        }

        private void MoveFiles(object absoluttepath, string v)
        {
            throw new NotImplementedException();
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
