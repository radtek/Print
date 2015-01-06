using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;

namespace PrintSystem
{
    public partial class RegMake : Form
    {
        protected string path = string.Empty;
        protected string checkPath = string.Empty;
        public RegMake()
        {
            InitializeComponent();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            path = GetExeFilePath();
            tbPath.Text = path;
        }


        /// <summary>
        /// 指定筛选器，打开文件并返回地址
        /// </summary>
        /// <returns></returns>
        public static string GetFilePath(string Filter)
        {
            //获取sxt文件路径
            OpenFileDialog opf = new OpenFileDialog();
            opf.AddExtension = true;
            opf.CheckFileExists = true;
            opf.Title = "请选择要打开的文件";
            opf.Filter = Filter;//要打开的文件格式筛选器
            opf.Multiselect = false;
            opf.CheckPathExists = true;
            opf.ShowDialog();
            string path = opf.FileName;
            return path;



        }

        /// <summary>
        /// 打开文件并返回地址
        /// </summary>
        /// <returns></returns>
        public static string GetExeFilePath()
        {
            string filter = "*.EXE文件(*.exe)|*.exe";
            string path = GetFilePath(filter);
            return path;
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            //            HKEY_CLASSES_ROOT
            //vip
            //  (Default) = "URL:vip Protocol"
            //  URL Protocol= ""
            //  DefaultIcon
            //   (Default) = "c:\somepath\APPTest.exe"
            //  shell
            //   open
            //    command
            //     (Default) = "c:\somepath\APPTest.exe" "%1"

            RegistryKey key = Registry.ClassesRoot.CreateSubKey("FixAssetSys");
            key.SetValue("", "URL:FixAssetSys Protocol");
            key.SetValue("URL Protocol", "");
            RegistryKey Subkey = key.CreateSubKey("DefaultICon");
            Subkey.SetValue("", path);
            Subkey = key.CreateSubKey("shell").CreateSubKey("open").CreateSubKey("Command");
            Subkey.SetValue("Path", path);
            Subkey.SetValue("", path + " %1");
            MessageBox.Show("操作成功！请重新运行软件");
            this.Close();

        }

        //private void btnCheckView_Click(object sender, EventArgs e)
        //{
        //    checkPath = GetExeFilePath();
        //    tbCheckPath.Text = checkPath;
        //}

        //private void btnRegCheck_Click(object sender, EventArgs e)
        //{
        //    //            HKEY_CLASSES_ROOT
        //    //vip
        //    //  (Default) = "URL:vip Protocol"
        //    //  URL Protocol= ""
        //    //  DefaultIcon
        //    //   (Default) = "c:\somepath\APPTest.exe"
        //    //  shell
        //    //   open
        //    //    command
        //    //     (Default) = "c:\somepath\APPTest.exe" "%1"

        //    RegistryKey key = Registry.ClassesRoot.CreateSubKey("ICCardCheckEx");
        //    key.SetValue("", "URL:ICCardCheckEx Protocol");
        //    key.SetValue("URL Protocol", "");
        //    RegistryKey Subkey = key.CreateSubKey("DefaultICon");
        //    Subkey.SetValue("", checkPath);
        //    Subkey = key.CreateSubKey("shell").CreateSubKey("open").CreateSubKey("Command");
        //    Subkey.SetValue("", checkPath + " %1");
        //    MessageBox.Show("操作成功！");
        //}

    }
}
