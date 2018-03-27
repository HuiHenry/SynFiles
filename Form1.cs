using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Permissions;
using System.IO;
using System.Runtime.InteropServices;

namespace SynFiles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            txtMain.Text= Setting.ReadIniData("SynSection", "mainPath", "");
            txtSyn.Text = Setting.ReadIniData("SynSection", "synPath", "");

        }
        private bool runEnd = true;
        private void btnMain_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "请选择文件路径";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string foldPath = dialog.SelectedPath;
                txtMain.Text = foldPath;

                Setting.WriteIniData("SynSection", "mainPath", foldPath);
                //MessageBox.Show("已选择文件夹:" + foldPath, "选择文件夹提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSyn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "请选择文件路径";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string foldPath = dialog.SelectedPath;

                txtSyn.Text = foldPath;
                Setting.WriteIniData("SynSection", "synPath", foldPath);
                //MessageBox.Show("已选择文件夹:" + foldPath, "选择文件夹提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnStartSyn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMain.Text) || string.IsNullOrEmpty(txtSyn.Text))
            {
                MessageBox.Show("主文件夹和同步文件夹不能为空", "选择文件夹提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!string.IsNullOrEmpty(txtMain.Text))
            {
                if (!Directory.Exists(txtMain.Text))
                {
                    MessageBox.Show("主文件夹不存在", "选择文件夹提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            if (!string.IsNullOrEmpty(txtSyn.Text))
            {
                if (!Directory.Exists(txtSyn.Text))
                {
                    MessageBox.Show("同步文件夹不存在", "选择文件夹提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            txtMain.ReadOnly = txtSyn.ReadOnly = true;
            btnStopSyn.Enabled = true;
            btnStartSyn.Enabled = false;
            timer1.Start();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.runEnd)
            {
                run();
            }
        }

        private void btnStopSyn_Click(object sender, EventArgs e)
        {
            txtMain.ReadOnly = txtSyn.ReadOnly = false;
            btnStopSyn.Enabled = false;
            btnStartSyn.Enabled = true;
            timer1.Stop();
        }


        private void run()
        {
            this.runEnd = false;
            

            Sync(txtMain.Text, txtSyn.Text);
            if (logView.Items.Count > 100)
            {
                logView.Items.Clear();
            }

            this.runEnd = true;
        }

        private void Sync(string mainPath,string synPath)
        {
            var dirList = Directory.GetDirectories(mainPath);
            var dirList2 = Directory.GetDirectories(synPath);
            var files = Directory.GetFiles(mainPath);
            var files2 = Directory.GetFiles(synPath);
            logView.Items.Add(mainPath+"下的文件夹个数：" + dirList.Length + ",文件个数：" + files.Length);
            logView.Items.Add(synPath+"下的文件夹个数：" + dirList2.Length + ",文件个数：" + files2.Length);
            ////同步文件
            foreach (var item in files)
            {
                string pFilePath = synPath + "\\" + Path.GetFileName(item);
                if (File.Exists(pFilePath))
                    continue;
                File.Copy(item, pFilePath, true);
            }
            //foreach (var item in files2)
            //{
            //    string pFilePath = mainPath + "\\" + item;//Path.GetFileName(item);
            //    if (File.Exists(pFilePath))
            //        continue;
            //    File.Copy(item, pFilePath, true);
            //}

            //同步文件夹
            foreach (var item in dirList)
            {
                string dirPath = synPath + "\\" + Path.GetFileName(item);
                if (!Directory.Exists(dirPath))
                {
                    Directory.CreateDirectory(dirPath);
                }
                Sync(item, dirPath);
            }
        }


        
    }
}
