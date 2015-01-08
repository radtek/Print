using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing.Printing;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace PrintSystem
{
    public partial class frmSetting : Form
    {
        public frmSetting(PrintConfig confg)
        {
            InitializeComponent();
            pconfig = confg;
        }

        private PrintConfig pconfig;

        private void frmSetting_Load(object sender, EventArgs e)
        { 
            for (int i = 0; i < PrinterSettings.InstalledPrinters.Count; i++)
            {
                cbPrintName.Items.Add(PrinterSettings.InstalledPrinters[i]);
            }
            if (cbPrintName.Items.Count > 0)
            {
                cbPrintName.SelectedItem = pconfig.PrintName;
            }
            numX.Value = pconfig.XOFFSET;
            numY.Value = pconfig.YOFFSET;
            numZoom.Value = (decimal)pconfig.ZOOM;
            numCopies.Value = pconfig.Copies;
            numSpacing.Value = (decimal)pconfig.GAP; 
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            pconfig.XOFFSET = (int)numX.Value;
            pconfig.YOFFSET = (int)numY.Value;
            pconfig.PrintName = cbPrintName.SelectedItem.ToString();
            pconfig.ZOOM = (float)numZoom.Value;
            pconfig.Copies = (int)numCopies.Value;
            pconfig.GAP = (float)numSpacing.Value; 
            string pconfigstr = pconfig.PrintName + "," + pconfig.XOFFSET + "," + pconfig.YOFFSET + "," + pconfig.ZOOM +
                                "," + pconfig.Copies +
                                "," + pconfig.GAP ;
//            Configuration config= ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
//            if (config.AppSettings.Settings["peizhi"]!=null)
//            {
//                config.AppSettings.Settings["peizhi"].Value = pconfigstr;
//            }
//            else
//            {
//                config.AppSettings.Settings.Add("peizhi", pconfigstr);
//            }
//            config.Save(ConfigurationSaveMode.Modified);
//            ConfigurationManager.RefreshSection("appSettings");
//            this.Close();
            string FileName = AppDomain.CurrentDomain.BaseDirectory + "Settings.xml";
            try
            {
                XmlElement root = null;
                XmlDocument xmldoc = new XmlDocument();
                xmldoc.Load(FileName);
                root = xmldoc.DocumentElement;
                if (root.ChildNodes.Count > 0)
                {
                    root.ChildNodes[0].InnerText = pconfigstr;
                }
                xmldoc.Save(FileName);
                MessageBox.Show("设置成功！", "系统提示");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("设置失败！", "系统提示");
            }
        }


    }
}
