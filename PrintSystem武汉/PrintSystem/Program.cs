using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Microsoft.Win32;
using PrintSystem;

namespace PrintSystem
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (GetRegistData().Length > 0)
            {
            if (args.Length != 0)
            {
                String parameter = Regex.Match(args[0], @"(?<=://).+?(?=:|/|\Z)").Value;
                char splitChar = '@';
                string[] paras = parameter.Split(splitChar);
                if (paras[0].Length > 0 && paras[1].Length > 0)
                {
                    //MessageBox.Show(parameter);
                    //MessageBox.Show("查询码" + paras[0] + "标识码" + paras[1] + "单位编码" + paras[2]); 
                    Main f = new Main(paras[0], paras[1], paras[2]);
                    CRD.WinUI.Shared.MainForm = f;
                    Application.Run(f);
                }

            }
            else
            {
                MessageBox.Show("请输入" + "查询码," + "标识码," + "单位编码", "提示");
                frmLogin fl = new frmLogin();
                Application.Run(fl);
            }
            }
            else
            {
                MessageBox.Show("请先注册软件", "提示");
                RegMake rg = new RegMake();
                Application.Run(rg);

            }

        }
        #region 读取注册表验证程序是否安装
        private static string GetRegistData()
        {
            string registData;
            try
            {
                RegistryKey hkml = Registry.ClassesRoot;
                RegistryKey software = hkml.OpenSubKey("FixAssetSys", true);
                registData = software.ToString();

            }
            catch (Exception ex)
            {

                registData = "";
            }
            return registData;
        } 
        #endregion
    }
}
