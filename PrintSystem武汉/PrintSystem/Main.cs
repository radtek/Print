using System.Configuration;
using System.Text;
using Common;
using CRD.WinUI;
using CRD.WinUI.Forms;
using ThoughtWorks.QRCode.Codec;
using MessageBox = System.Windows.Forms.MessageBox;

#region 引用

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Printing;
using System.Data;
using System.Drawing; 
using System.Windows.Forms; 
using System.Xml;

#endregion

#region 注释引用

//using System.Text;
//using System.Configuration;
//using Gma.QrCodeNet.Encoding;
//using Gma.QrCodeNet.Encoding.Windows.Render;
//using ThoughtWorks.QRCode.Codec;
//using PrintSystem;
//using ThoughtWorks.QRCode.Codec.Data;
//using System.Drawing.Imaging;
//using System.IO;
//using System.Runtime.InteropServices;
//using System.Reflection;
//using System.Xml;
//using CRD.WinUI.Forms;
//using PrintSystem.TTdetails;
//using System.Drawing.Drawing2D;
//using com.google.zxing.qrcode.encoder;
//using Encoder = com.google.zxing.qrcode.encoder.Encoder;
//using com.google.zxing.qrcode; 

#endregion

namespace PrintSystem
{
    public partial class Main : MainForm
    {
        #region 初始化

        public static readonly string c = "123132321331312312";
        private readonly string DWBM;
        private readonly string Flag;
        private readonly string Querystr;
        protected int Curpage = 1;
        protected List<string> Liststr = new List<string>();
        protected List<string> ListstrAll = new List<string>();
        private string MC = "";
        private DataTable _dtGetTmp = new DataTable(); 
        private DataTable dtInfo = new DataTable();
        private string dtnum = "";
        private DataTable dttmp = new DataTable();
        private int nCurrent; //当前记录行 
        private int nMax; //总记录数
        private int offset_Y = 139 - 3;
        private string p1;
        private string p2;
        private int pageCount; //页数＝总记录数/每页显示行数
        private int pageCurrent; //当前页号
        private int pageSize; //每页显示行数
        private PrintConfig printerConfig = new PrintConfig();

        #endregion

        #region 构造方法Main（str，flag，dwbm）

        /// <summary>
        ///     构造方法
        /// </summary>
        /// <param name="strings"></param>
        public Main(string querystr, string flag, string dwbm)
        {
            DWBM = dwbm;
            Querystr = querystr;　
            Flag = flag;
            //刷新当前的皮肤  
            DoBindTable(querystr, flag, dwbm);
            SetStyle(ControlStyles.DoubleBuffer | ControlStyles.AllPaintingInWmPaint, true);
            InitializeComponent();
        }

        public Main(string flag, string dwbm)
        {
            DWBM = dwbm;
            Querystr = "";
            Flag = flag;
            // TODO: Complete member initialization
            DWBM = dwbm;
            //刷新当前的皮肤  
            DoAllBindTable(dwbm);
            SetStyle(ControlStyles.DoubleBuffer | ControlStyles.AllPaintingInWmPaint, true);
            InitializeComponent();
        }

        #endregion

        #region 数据绑定配置

        private void DoBindTable(string str1, string flag, string dwbm)
        {
            if (flag == "0")
            {
                if (str1.Contains("*"))
                {
                    string[] strlist = str1.Split('*');
                    string result = strlist[0].Replace(",", " ','");
                    string re = "'" + result + "'";
                    if (strlist[1] != "")
                    {
                        GetDatatable_1(re, strlist[1], dwbm);
                    }
                    else
                    {
                        MessageBox.Show("未能指定类型", "系统提示");
                    }
                }
                else
                {
                    string result = str1.Replace(",", " ','");
                    string re = "'" + result + "'";
                    GetDatatable_3(re, dwbm);
                }
            }
            else
            {
                GetDatatable_2(str1, dwbm);
            }
        }

        #endregion

        #region 根据表类别、资产编码、卡片编码 dt1

        private void GetDatatable_1(string cxtj, string table, string dwbm)
        {
            dtnum = table;
            if (table == "01")
            {
                MC = "土地";
            }
            if (table == "02")
            {
                MC = "房屋";
            }
            if (table == "03")
            {
                MC = "构筑物";
            }
            if (table == "04")
            {
                MC = "通用设备";
            }
            if (table == "05")
            {
                MC = "车辆";
            }
            if (table == "06")
            {
                MC = "专用设备";
            }
            if (table == "07")
            {
                MC = "文物";
            }
            if (table == "08")
            {
                MC = "家具";
            }
            if (table == "09")
            {
                MC = "图书";
            }
            if (table == "10")
            {
                MC = "特种动植物";
            }
            if (table == "11")
            {
                MC = "无形资产";
            }
            if (table=="0")
            {
                DataTable dt=JHDataTable.JHAllDataTableByDWBM(cxtj,dwbm);
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("没有查询到数据", "系统提示");
                    Application.Exit();
                }
                dtInfo = dt;
                return;
            }
            //DataTable dt = CombinationDT.GetAllDT();
            //DataView dv = new DataView();
            //dv.RowFilter = string.Format("KPBM in '{0}'", str1);
            try
            { 
                DataTable dt = JHDataTable.JHDataTableBystrdwbm(cxtj, MC, dwbm);
                //GetNewDT(dt);
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("没有查询到数据", "系统提示");
                    Application.Exit();
                }
                dtInfo = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "系统提示");
            }
        }

        #endregion

        #region 根据单位编码以及部门查询dt2

        private void GetDatatable_2(string str1, string dwbm)
        {
            try
            {
                string[] stmp = str1.Split(',');
                DataTable dt = JHDataTable.JHDataTableBydwbmdep(dwbm, str1);
                //GetNewDT(dt);
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("没有查询到数据", "系统提示");
                    return;
                }
                dtInfo = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "系统提示");
                ;
            }
        }

        #endregion

        #region 根据卡片编码、单位编码查询dt3

        private void GetDatatable_3(string re, string dwbm)
        {
            //DataTable dt = CombinationDT.GetAllDT();
            //DataView dv = new DataView();
            //dv.RowFilter = string.Format("KPBM in '{0}'", str1);
            try
            {
                DataTable dt = JHDataTable.JHAllDataTableByDWBM(re, dwbm);
                //GetNewDT(dt);
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("没有查询到数据", "系统提示");
                    Application.Exit();
                }
                dtInfo = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "系统提示");
            }
        }

        #endregion

        #region 根据单位编码查询dt4

        private void DoAllBindTable(string dwbm)
        {
            try
            {
                DataTable dt = JHDataTable.JHViewdataBydwbm(dwbm);
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("没有查询到数据", "系统提示");
                    Application.Exit();
                }
                dtInfo = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "123");
            }
        }

        #endregion

        #region 皮肤设置

        public override void ChangeSkinColor(SkinColor skinColor)
        {
            //设置皮肤
            base.ChangeSkinColor(skinColor);
            //Tree面板
            //Tree  
            panel1.BackColor = MainFormBorderColor;
            panel2.BackColor = MainFormBorderColor;
            panel3.BackColor = MainFormBorderColor;
            panel4.BackColor = MainFormBorderColor;
            pnlBackground.BackColor = MainFormBorderColor;
            bdnInfo.BackColor = MainFormBorderColor;
            dgvInfo.BackColor = MainFormBorderColor;
            dgvInfo.BackgroundColor = MainFormBorderColor;
            dgvInfo.GridColor = MainFormBorderColor;
            //dgvInfo.DefaultCellStyle.BackColor = this.MainFormBorderColor; 
            //Selected.DefaultCellStyle.BackColor = this.MainFormBorderColor;  
        }

        #endregion

        #region Main_Load

        private void Main_Load(object sender, EventArgs e)
        {
            dgvInfo.GridColor = MainFormBorderColor;
            //dgvInfo.DefaultCellStyle.BackColor = this.MainFormBorderColor; 
            //Selected.DefaultCellStyle.BackColor = this.MainFormBorderColor; 
            panel1.BackColor = MainFormBorderColor;
            panel2.BackColor = MainFormBorderColor;
            panel3.BackColor = MainFormBorderColor;
            panel4.BackColor = MainFormBorderColor;
            pnlBackground.BackColor = MainFormBorderColor;
            bdnInfo.BackColor = MainFormBorderColor;
            dgvInfo.BackColor = MainFormBorderColor;
            dgvInfo.ColumnHeadersDefaultCellStyle.BackColor = MainFormBorderColor;
            dgvInfo.BackgroundColor = MainFormBorderColor;
            dgvInfo.AutoGenerateColumns = false;
            dgvInfo.AllowUserToAddRows = false;
            WindowState = FormWindowState.Maximized;
            Initialise();
            //frmLogin fm=new frmLogin();
            //fm.Hide();
            GetAutoSize(); //自适应
            SettingBind();
        }

        #endregion

        #region datagridview自适应

        private void GetAutoSize()
        {
            for (int i = 0; i < dgvInfo.ColumnCount; i++)
            {
                dgvInfo.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
//            dgvInfo.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
//            dgvInfo.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
//            dgvInfo.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
//            dgvInfo.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        #endregion

        #region 绑定数据初始化

        private void Initialise()
        {
            try
            {
                dttmp = dtInfo;
                InitDataSet(dttmp);
                SelectctTypeBind();
                SelectctDeptBind();
            }
            catch (Exception ex)
            {
            }
        }

        #endregion

        #region 查询文本框逻辑设置

        private void textBox1_Click(object sender, EventArgs e)
        {
            if (monthCalendar2.Visible)
            {
                monthCalendar2.Visible = false;
            }
            monthCalendar1.Visible = true;
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            if (monthCalendar1.Visible)
            {
                monthCalendar1.Visible = false;
            }
            monthCalendar2.Visible = true;
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            var d1 = new DateTime();
            var d2 = new DateTime();

            textBox1.Text = e.Start.ToString("yyyy-MM-dd");
            d1 = Convert.ToDateTime(textBox1.Text);
            try
            {
                d2 = Convert.ToDateTime(textBox2.Text);
            }
            catch (Exception)
            {
                textBox2.Text = e.Start.ToString("yyyy-MM-dd");
                monthCalendar1.Visible = false;
                return;
            }
            if (d2.Year > d1.Year)
            {
                MessageBox.Show("时间区间不能超过一年", "系统提示");
            }
            else if (d1 > d2)
            {
                MessageBox.Show("开始时间不能大于结束时间", "系统提示");
            }
            else
            {
                textBox1.Text = e.Start.ToString("yyyy-MM-dd");
                monthCalendar1.Visible = false;
            }
        }

        private void monthCalendar2_DateSelected(object sender, DateRangeEventArgs e)
        {
            var d1 = new DateTime();
            var d2 = new DateTime();
            textBox2.Text = e.Start.ToString("yyyy-MM-dd");
            d2 = Convert.ToDateTime(textBox2.Text);
            try
            {
                d1 = Convert.ToDateTime(textBox1.Text);
            }
            catch (Exception)
            {
                textBox1.Text = e.Start.ToString("yyyy-MM-dd");
                monthCalendar2.Visible = false;
                return;
            }

            if (d2.Year > d1.Year)
            {
                MessageBox.Show("时间区间不能超过一年", "系统提示");
            }
            else if (d1 > d2)
            {
                MessageBox.Show("开始时间不能大于结束时间", "系统提示");
            }
            else
            {
                textBox2.Text = e.Start.ToString("yyyy-MM-dd");
                monthCalendar2.Visible = false;
            }
        }

        #endregion

        #region 绑定类别下拉框

        private void SelectctTypeBind()
        {
            string list = "土地,房屋,构筑物,通用设备,车辆,专用设备,文物,家具,图书,特种动植物,无形资产";
            string[] slist = list.Split(',');
            var dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("Type");
            string id = "";
            for (int i = 0; i < slist.Length; i++)
            {
                DataRow dr = dt.NewRow();
                if (i + 1 < 10)
                {
                    id = "0" + (i + 1);
                }
                dr["ID"] = id;
                dr["Type"] = slist[i];
                dt.Rows.Add(dr);
            }
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "Type";
            comboBox1.ValueMember = "ID";
            comboBox1.Text = "";
        }

        #endregion

        #region 绑定部门下拉框

        private void SelectctDeptBind()
        {　
            DataTable dt = JHDataTable.GetDepDt(DWBM);
            comboBox2.DataSource = dt;
            comboBox2.DisplayMember = "DepName";
            comboBox2.ValueMember = "DepName";
            //comboBox2.ValueMember = "SYGLBM";
            comboBox2.Text = "";
        }

        #endregion

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        public class QrImage
        {
            protected Color qrCodeBackgroundColor = Color.White;
            protected Color qrCodeForegroundColor = Color.Black;
            protected float qrCodeScale =2f;

            public Bitmap CreateImage(bool[][] matrix)
            {
                var brush = new SolidBrush(qrCodeBackgroundColor);
                var image = new Bitmap(Convert.ToInt32(matrix.Length*qrCodeScale) + 1, Convert.ToInt32(matrix.Length*qrCodeScale) + 1);
                image.SetResolution(150,150); 
                Graphics g = Graphics.FromImage(image);
               
                g.FillRectangle(brush, new Rectangle(0, 0, image.Width, image.Height));
                brush.Color = qrCodeForegroundColor;
                for (int i = 0; i < matrix.Length; i++)
                {
                    for (int j = 0; j < matrix.Length; j++)
                    {
                        if (matrix[j][i])
                        {
                            g.FillRectangle(brush, j*qrCodeScale, i*qrCodeScale, qrCodeScale, qrCodeScale);
                        }
                    }
                }

                return image;
            }
        }

        #region 二维码绘制    

        private void GetCodeImgbyStr(string str, PrintPageEventArgs e)
        {
            if (str == String.Empty)
            {
                MessageBox.Show("数据为空，无法打印！");
                return;
            }
//            str = "#71110520100300012#台式电脑主机#微型数字电子计算机#1#2010-03-01##在用#征收局#商璐#征收局#征收局#计算中心#########23#6880##";
            string[] strslist_cy = str.Split('$');
            string[] strslist = strslist_cy[0].Split('&');
            var qrCodeEncoder = new QRCodeEncoder();
            try
            {
                qrCodeEncoder.QRCodeEncodeMode = QRCodeEncoder.ENCODE_MODE.BYTE;
                qrCodeEncoder.QRCodeScale = 2;
                qrCodeEncoder.QRCodeVersion = 8;
                qrCodeEncoder.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.L;
                bool[][] encodedData = qrCodeEncoder.Encode(strslist_cy[0], Encoding.Default);
                var qrImage = new QrImage();
                Bitmap image = qrImage.CreateImage(encodedData);
            
                var padding = new Point(112 + 12 + PrinterConfig.XOFFSET, PrinterConfig.YOFFSET + 18);
                var p1 = new Point(PrinterConfig.XOFFSET, (int) PrinterConfig.GAP*1 + PrinterConfig.YOFFSET);
                var p2 = new Point(PrinterConfig.XOFFSET, (int) PrinterConfig.GAP*2 + PrinterConfig.YOFFSET);
                var p3 = new Point(PrinterConfig.XOFFSET, (int) PrinterConfig.GAP*3 + PrinterConfig.YOFFSET);
                // Point p4=new Point(0,0);
                Brush b1 = Brushes.Black;
                var f1 = new Font("宋体", 9, FontStyle.Bold);

                using (Graphics graphics = e.Graphics)
                {
                    //graphics.DrawString("00000", f1, b1, p4);
                    graphics.DrawString(strslist[0], f1, b1, p1);
                    graphics.DrawString(getlength(strslist[1]), f1, b1, p2);
                    graphics.DrawString(strslist_cy[1], f1, b1, p3);
                    graphics.DrawImage(image, padding);
                    
                }
            }
            catch (Exception exe)
            {
                MessageBox.Show("文字过多，无法打印.");
            }
        }

        private string getlength(string p0)
        {
            string str = "";
            if (p0.Length > 7)
            {
                str = p0.Substring(0, 7);
            }
            else
            {
                str = p0;
            }
            return str;
        }

        #endregion

        #region PrintDoc文档

        public void PrintDocument(object sender, PrintPageEventArgs e)
        {
            try
            {
                GetCodeImgbyStr(Liststr[Curpage - 1], e);
                if (Curpage < Liststr.Count)
                {
                    e.HasMorePages = true;
                    Curpage++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("文档错误", "系统提示");
            }
        }

        #endregion

        #region 打印按钮

        private void btnprint_Click(object sender, EventArgs e)
        {
            try
            {
                //PrintPreviewDialog ppd = new PrintPreviewDialog();
                var pd = new PrintDocument();
                //pd.PrinterSettings.PrinterName = "TEC B-452-R";
                var ps = new PaperSize("Custom Size 1", 280, offset_Y);
                pd.DefaultPageSettings.PrinterResolution.Kind = PrinterResolutionKind.Low; 
                //pd.DefaultPageSettings.PrinterResolution.X = 150;
                //pd.DefaultPageSettings.PrinterResolution.Y = 150;
                //ps.RawKind = 150;
                //pd.DefaultPageSettings.PaperSize.RawKind = 256;
                pd.DefaultPageSettings.PaperSize = ps;
                Liststr = GetRowsList();
                ListstrAll = GetRowsListAll();
                pd.PrintPage += PrintDocument;
                pd.PrinterSettings.PrinterName = printerConfig.PrintName;
                //ppd.Document = pd;
                try
                {
                    if (Liststr.Count > 0)
                    {
                        pd.Print();
                        //lbtimes.Text = pTimes.ToString();
                        //SetValue("Times", pTimes.ToString());
                        Curpage = 1;
                        if (GetBMList().Count > 0)
                        {
                            for (int i = 0; i < GetBMList().Count; i++)
                            {
                                int tt = Print_StateLogic.GetIDByBH(GetBMList()[i]);
                                if (tt > 0)
                                {
                                    Print_State pts = Print_StateManager.GetPrint_StateByPtintID(tt);
                                    pts.PrintBH = GetBMList()[i];
                                    pts.PrintState = "已打印";
                                    pts.PrintTimes += 1;
                                    Print_StateManager.ModifyPrint_State(pts);
                                }
                                else
                                {
                                    var pts = new Print_State();
                                    pts.PrintBH = GetBMList()[i];
                                    pts.PrintState = "已打印";
                                    pts.PrintTimes += 1;
                                    Print_StateManager.AddPrint_State(pts);
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("请选中至少一条数据", "系统提示");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("打印错误.", "系统提示");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("未获取打印数据集合", "系统提示");
            }
        }

        #endregion

        #region 获取编码集合

        private List<string> GetBMList()
        {
            var liststrtemp = new List<string>();
            //取得选中的行 
            DataTable dt = _dtGetTmp;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i]["Selected"].ToString() == "1")
                {
                    //相应的操作 
                    string str = "";
                    str += dt.Rows[i]["KPBH"] + "#";
                    str = str.TrimEnd('#');
                    liststrtemp.Add(str);
                }
            }
            return liststrtemp;
        }

        #endregion

        #region 获取打印数据集合

        private List<string> GetRowsList()
        {
            var liststrtemp = new List<string>();
            var dt = (DataTable) bdsInfo.DataSource;
            //MessageBox.Show(dt.Rows.Count.ToString(),dt.Columns[0].ToString());
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string str = "";
                if (dt.Rows[i]["Selected"].ToString() == "1")
                {
                    //MessageBox.Show("1");
                    str += dt.Rows[i]["KPBH"] + "&";
                    str += dt.Rows[i]["ZCMC"] + "&";
                    str += dt.Rows[i]["ZCLB"] + "&";
                    str += dt.Rows[i]["SL"] + "&";
                    str += dt.Rows[i]["RZRQ"] + "&";
                    str += dt.Rows[i]["SYZT"] + "&";
                    str += dt.Rows[i]["DepName"]  + "&";
                    str += dt.Rows[i]["SYR"]  + "&";  
                    if (dt.Rows[i]["CFDD"].ToString() != "")
                    {
                        str += GetCFDDNAME(dt.Rows[i]["CFDD"].ToString()) + "&";
                    }
                    else
                    {
                        str += "&";
                    }
                    str += dt.Rows[i]["YJSYNX"] + "&";
                    str += dt.Rows[i]["JZ"] + "&";
                    str += dt.Rows[i]["PP"] + "&";str += dt.Rows[i]["GGXH"] + "&";str += dt.Rows[i]["HTBH"] + "&";str += dt.Rows[i]["KJPZH"] + "&";str += dt.Rows[i]["QDFS"] + "&";str += dt.Rows[i]["QDRQ"] + "$";
                    // str +=  "&"+JHDataTable.GetDWMC(dt.Rows[i]["DWBM"].ToString());
                    if (PrinterConfig.SelectText.Split('*')[1]=="使用人")
                    {
                        if (dt.Rows[i]["SYR"].ToString()=="")
                        {
                            str += "";
                        }
                        else
                        str += PrinterConfig.SelectText.Split('*')[0] + " " + dt.Rows[i]["SYR"];
                    }
                    else  if (PrinterConfig.SelectText.Split('*')[1] == "使用部门")
                    {
                        if (dt.Rows[i]["DepName"].ToString() == "")
                        {
                            str += "";
                        }
                        else
                        str += PrinterConfig.SelectText.Split('*')[0] +" "+ dt.Rows[i]["DepName"];
                    }
                    else if (PrinterConfig.SelectText.Split('*')[1] == "存放地点")
                    {
                        if (dt.Rows[i]["CFDD"].ToString() == "")
                        {
                            str += "";
                        }
                        else
                        str += PrinterConfig.SelectText.Split('*')[0] + " " + dt.Rows[i]["CFDD"];
                    }
                    //if (dt.Rows[i]["MC"].ToString() == "通用设备")
                    //{
                    //    if (dt.Rows[i]["ZCFLDM"].ToString() == "2010601" || dt.Rows[i]["ZCFLDM"].ToString() == "2010104" ||
                    //        dt.Rows[i]["ZCFLDM"].ToString() == "2010105")
                    //    {
                    //        str += dt.Rows[i]["SYR"] + "";
                    //    }
                    //    else
                    //    {
                    //        str += dt.Rows[i]["CFDD"] + "";
                    //    }
                    //}
                    //else
                    //{
                    //    if (dt.Rows[i]["CFDD"].ToString() != "")
                    //    {
                    //        str += GetCFDDNAME(dt.Rows[i]["CFDD"].ToString()) + "";
                    //    }
                    //    else
                    //    {
                    //        str += "";
                    //    }
                    //}
                    liststrtemp.Add(str);
                }
            }
            return liststrtemp;
        }

        private string GetCFDDNAME(string cfddcode)
        {
            string codename = "";
            codename = JHDataTable.GETCFDDNAMEBYCODE(DWBM,cfddcode);
            return codename;
        }

        #endregion

        #region 全选

        private void btnselect_all_Click(object sender, EventArgs e)
        {
            DataTable dt = _dtGetTmp;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dt.Rows[i]["Selected"] = 1;
            }
        }

        #endregion

        #region 取消全选

        private void btnconcelselect_Click(object sender, EventArgs e)
        {
            DataTable dt = _dtGetTmp;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dt.Rows[i]["Selected"] = 0;
            }
        }

        #endregion

        #region 退出按钮

        private void btnclose_Click(object sender, EventArgs e)
        {
            Close();
            Application.Exit(); //退出程序
        }

        #endregion

        #region 打印设置

        private void btnsetting_Click(object sender, EventArgs e)
        {
            //SettingBind();
            //frmSetting fr = new frmSetting(pconfig);
            //fr.Show(); 

            try
            {
                var fs = new frmSetting(PrinterConfig);
                fs.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("未安装打印机", "系统提示");
            }
        }

        private void SettingBind()
        {
           string pconfigstr = "";
            string FileName = AppDomain.CurrentDomain.BaseDirectory + "Settings.xml";
            try
            {
                XmlElement root = null;
                XmlDocument xmldoc = new XmlDocument();
                xmldoc.Load(FileName);
                root = xmldoc.DocumentElement;
                if (root.ChildNodes.Count > 0)
                {
                    pconfigstr = root.ChildNodes[0].InnerText;
                }
            }
            catch (Exception ex)
            {
                var xmldoc = new XmlDocument();
                //创建XML声明段落
                XmlDeclaration xmldecl = xmldoc.CreateXmlDeclaration("1.0", "UTF-8", null); 
                xmldoc.AppendChild(xmldecl);
                XmlElement xmlelem = xmldoc.CreateElement("settings");
                xmldoc.AppendChild(xmlelem);
                XmlNode root = xmldoc.SelectSingleNode(@"settings");
                XmlElement childElement = null;
                childElement = xmldoc.CreateElement("setting");
                childElement.InnerText = "";
                if (root != null) root.AppendChild(childElement);
                xmldoc.Save(FileName);
            }
            if (pconfigstr == "")
            {
                MessageBox.Show("请先配置打印机设置!", "系统提示");
            }
            else
            {
                string[] peizhi = pconfigstr.Split(',');

                PrinterConfig.PrintName = peizhi[0];
                PrinterConfig.XOFFSET = common.IntSafeConvert(peizhi[1]);
                PrinterConfig.YOFFSET = common.IntSafeConvert(peizhi[2]);
                PrinterConfig.ZOOM = (float) Convert.ToDouble(peizhi[3]);
                PrinterConfig.Copies = common.IntSafeConvert(peizhi[4]);
                PrinterConfig.GAP = (float) Convert.ToDouble(peizhi[5]);
                PrinterConfig.SelectText = peizhi[6];
            }
        }

        #endregion

        #region 取得或设置打印设置

        /// <summary>
        ///     取得或设置打印设置
        /// </summary>
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public PrintConfig PrinterConfig
        {
            get { return printerConfig; }
            set { printerConfig = value; }
        }

        #endregion

        #region 导出xml文件

        /// <summary>
        ///     导出xml文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CreateXml_Click(object sender, EventArgs e)
        {
            string FileName = "";
            var xmldoc = new XmlDocument();
            //创建XML声明段落
            XmlDeclaration xmldecl = xmldoc.CreateXmlDeclaration("1.0", "UTF-8", null);
            xmldoc.AppendChild(xmldecl);

            //创建root根节点
            XmlElement xmlelem = xmldoc.CreateElement("root");
            xmlelem.SetAttribute("name", "资产卡片");
            xmldoc.AppendChild(xmlelem);

            //查找定位root根节点
            XmlNode root1 = xmldoc.SelectSingleNode(@"root");
            DataTable dt = JHDataTable.GetDepDt(DWBM);
            var dt1 = new DataTable();
            // CRD.WinUI.Forms.MessageBoxForm ss = new CRD.WinUI.Forms.MessageBoxForm("是否打印全部？", "系统提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning); 
            if (MessageBox.Show("是否打印全部？", "系统提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) ==
                DialogResult.OK)
            {
                dt1 = dttmp;
            }
            else
            {
                dt1 = _dtGetTmp;
            }
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                XmlElement xmlelem1 = xmldoc.CreateElement("node");
                xmlelem1.SetAttribute("name", dt.Rows[i]["DepName"].ToString());
                xmlelem1.SetAttribute("AssStatus", "0");
                root1.AppendChild(xmlelem1);
                //创建province子节点地区数据

                for (int a = 0; a < dt1.Rows.Count; a++)
                {
                    if (dt.Rows[i]["DepID"].ToString() == dt1.Rows[a]["SYGLBM"].ToString())
                    {
                        XmlElement xmlelem2 = xmldoc.CreateElement("list");
                        xmlelem2.SetAttribute("DWBM", dt1.Rows[a]["DWBM"].ToString());
                        xmlelem2.SetAttribute("ZCMC", dt1.Rows[a]["ZCMC"].ToString());
                        xmlelem2.SetAttribute("KPBH", dt1.Rows[a]["KPBH"].ToString());
                        xmlelem2.SetAttribute("ZCLB", dt1.Rows[a]["ZCLB"].ToString());
                        xmlelem2.SetAttribute("YSXMBH", dt1.Rows[a]["YSXMBH"].ToString());
                        xmlelem2.SetAttribute("JFLY", dt1.Rows[a]["JFLY"].ToString());
                        xmlelem2.SetAttribute("RZXS", dt1.Rows[a]["RZXS"].ToString());
                        xmlelem2.SetAttribute("JZLX", dt1.Rows[a]["JZLX"].ToString());
                        xmlelem2.SetAttribute("JZ", dt1.Rows[a]["JZ"].ToString());
                        xmlelem2.SetAttribute("RZKM", dt1.Rows[a]["RZKM"].ToString());
                        xmlelem2.SetAttribute("KJPZH", dt1.Rows[a]["KJPZH"].ToString());
                        xmlelem2.SetAttribute("RZRQ", dt1.Rows[a]["RZRQ"].ToString());
                        xmlelem2.SetAttribute("SYZT", dt1.Rows[a]["SYZT"].ToString());
                        xmlelem2.SetAttribute("BZ", dt1.Rows[a]["BZ"].ToString());
                        xmlelem2.SetAttribute("DepName", dt1.Rows[a]["SYGLBM"].ToString());
                        xmlelem2.SetAttribute("SFSB", dt1.Rows[a]["SFSB"].ToString());
                        xmlelem2.SetAttribute("SFSH", dt1.Rows[a]["SFSH"].ToString());
                        xmlelem2.SetAttribute("KPZT", dt1.Rows[a]["KPZT"].ToString());
                        xmlelem2.SetAttribute("ISSELECT", dt1.Rows[a]["ISSELECT"].ToString());
                        xmlelem2.SetAttribute("AssStatus", "0");
                        xmlelem2.SetAttribute("DepName", dt.Rows[i]["DepName"].ToString());
                        xmlelem1.AppendChild(xmlelem2);
                    }
                }
            }
            if (SaveAs.ShowDialog() == DialogResult.OK)
            {
                FileName = SaveAs.FileName;
                xmldoc.Save(FileName);
                MessageBox.Show("导出成功！", "系统提示");
            }
            else
            {
                MessageBox.Show("导出失败！", "系统提示");
            }
        }

        #endregion

        #region 查询

        /// <summary>
        ///     查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnselect_Click(object sender, EventArgs e)
        {
            string str1 = string.Empty;
            string str2 = string.Empty;
            string str3 = string.Empty;
            string str4 = string.Empty;
            string str5 = string.Empty;
            var listtmp = new List<string>();
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                //if (textBox1.Text == textBox2.Text)
                //{
                //    str1 =
                //    string.Format(
                //        "TRSYRQ  ='{0} '", textBox1.Text);
                //    listtmp.Add(str1);
                //}
                //else
                //{
                //    //str1 = string.Format("(Convert(varchar,TRSYRQ,120) BETWEEN '{0}' AND '{1}')", textBox1.Text, textBox2.Text);
                //    str1 =
                //        string.Format(
                //            "TRSYRQ  >= '{0} '  and  TRSYRQ  < '{1}'", textBox1.Text, textBox2.Text);
                //    listtmp.Add(str1);
                //}
                str1 =
                    string.Format(
                        "RZRQ  >= '{0} '  and  RZRQ  < '{1}'", textBox1.Text, textBox2.Text);
                listtmp.Add(str1);
            }
            else
            {
                str1 = "";
            }
            if (comboBox1.SelectedText != "")
            {
                str2 = "MC = '" + comboBox1.Text + "'";
                listtmp.Add(str2);
            }
            else
            {
                str2 = "";
            }
            if (comboBox2.SelectedText != "")
            {
                str3 = "DepName = '" + comboBox2.Text + "'";
                listtmp.Add(str3);
            }
            else
            {
                str3 = "";
            }
            if (textBox3.Text != "")
            {
                str4 = "ZCMC like '%" + textBox3.Text + "%'";
                listtmp.Add(str4);
            }
            else
            {
                str4 = "";
            }
            if (comboBox4.SelectedText != "")
            {
                str5 = "PrintState = '" + comboBox4.Text + "'";
                listtmp.Add(str5);
            }
            else
            {
                str5 = "";
            }
            try
            {
                string sql = "";
                if (listtmp.Count == 0)
                {
                    MessageBox.Show("请选择至少一条规则进行查询.", "系统提示");
                    return;
                }
                for (int i = 0; i < listtmp.Count; i++)
                {
                    sql += listtmp[i] + " and ";
                }
                sql = sql.Substring(0, sql.Length - 4);
                var dt = new DataTable();
                dt = dtInfo;
                var dv = new DataView(dt);
                dv.RowFilter = sql;
                dttmp = new DataTable();
                dttmp = dv.ToTable(true);
                //dtInfo = dttmp;
                if (dttmp.Rows.Count > 0)
                {
                    InitDataSet(dttmp);
                }
                else
                {
                    MessageBox.Show("没有查询到数据", "系统提示");
                    //comboBox1.Text = "";
                    //comboBox2.Text = "";
                    //textBox3.Text = "";
                    //comboBox4.Text = "";
                    //textBox1.Text = "";
                    //textBox2.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "系统提示");
                //comboBox1.Text = "";
                //comboBox2.Text = "";
                //textBox3.Text = "";
                //comboBox4.Text = "";
                //textBox1.Text = "";
                //textBox2.Text = "";
            }
        }

        #endregion

        #region 日历隐藏

        private void monthCalendar2_MouseLeave(object sender, EventArgs e)
        {
            monthCalendar2.Visible = false;
        }

        private void monthCalendar1_MouseLeave(object sender, EventArgs e)
        {
            monthCalendar1.Visible = false;
        }

        #endregion

        #region 定义几个所需的公有成员以及初始化

        private void InitDataSet(DataTable dtMade)
        {
            pageSize = 28; //设置页面行数
            nMax = dtMade.Rows.Count;
            toolStripLabel3.Text = "每页"+pageSize+"行共"+nMax+"行";
            pageCount = (nMax/pageSize); //计算出总页数
            if ((nMax%pageSize) > 0) pageCount++;
            pageCurrent = 1; //当前页数从1开始
            nCurrent = 0; //当前记录数从0开始
            dttmp = dtMade;
            LoadData(dtMade);
        }

        #endregion

        #region 加载数据

        private void LoadData(DataTable dtMade)
        {
            DataTable dt = GetTmpDT(dtMade);
            DoBind(dt);
        }

        #endregion

        #region 获取当前页面dt

        private DataTable GetTmpDT(DataTable dtMade)
        {
            int nStartPos = 0; //当前页面开始记录行
            int nEndPos = 0; //当前页面结束记录行
            var dt = new DataTable();
            try
            {
                try
                {
                    dt = dtMade.Clone(); //克隆DataTable结构框架 
                }
                catch (Exception ex)
                {
                }

                if (pageCurrent == pageCount)
                {
                    nEndPos = nMax;
                }
                else
                {
                    nEndPos = pageSize*pageCurrent;
                }

                nStartPos = nCurrent;
                lblPageCount.Text = pageCount.ToString();
                txtCurrentPage.Text = Convert.ToString(pageCurrent);


                //从元数据源复制记录行
                for (int i = nStartPos; i < nEndPos; i++)
                {
                    dt.ImportRow(dtMade.Rows[i]);
                    nCurrent++;
                }
                _dtGetTmp = dt;
            }
            catch (Exception exw)
            {
                MessageBox.Show(exw.ToString());
            }
            return dt;
        }

        #endregion

        #region 根据DT数据绑定

        private void DoBind(DataTable dtTemp)
        {
            bdsInfo.DataSource = dtTemp;
            bdnInfo.BindingSource = bdsInfo;
            dgvInfo.DataSource = bdsInfo;
        }

        #endregion

        #region 菜单响应事件

        private void bdnInfo_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Text == "关闭")
            {
                Close();
            }
            if (e.ClickedItem.Text == "上一页")
            {
                pageCurrent--;
                if (pageCurrent <= 0)
                {
                    MessageBox.Show("已经是第一页，请点击“下一页”查看！");
                    pageCurrent++;
                    return;
                }
                nCurrent = pageSize*(pageCurrent - 1);
                LoadData(dttmp);
            }
            if (e.ClickedItem.Text == "下一页")
            {
                pageCurrent++;
                if (pageCurrent > pageCount)
                {
                    MessageBox.Show("已经是最后一页，请点击“上一页”查看！");
                    pageCurrent--;
                    return;
                }
                nCurrent = pageSize*(pageCurrent - 1);
                LoadData(dttmp);
            }
        }

        #endregion

        #region 返回首次登录

        private void btnBack_Click(object sender, EventArgs e)
        {
            InitialiseBack();
        }

        #endregion

        #region 点击更改datagridview的checkbox

        private void dgvInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                if (dgvInfo.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == null ||
                    dgvInfo.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == "0" ||
                    dgvInfo.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == "")
                {
                    dgvInfo.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = 1;
                }
                else
                {
                    dgvInfo.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = 0;
                }
            }
        }

        #endregion

        #region 文本框进入页面

        private void txtCurrentPage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int pagett = common.IntSafeConvert(txtCurrentPage.Text.Trim());
                if (pagett > 0 && pagett < pageCount)
                {
                    pageCurrent = pagett;
                    nCurrent = pageSize*(pageCurrent - 1);
                    LoadData(dttmp);
                }
                else
                {
                    //CRD.WinUI.Forms.MessageBoxForm ss = new CRD.WinUI.Forms.MessageBoxForm("页码错误！", "提示");
                    //ss.Show();
                    //if (ss.DialogResult ==DialogResult.OK)
                    //{
                    //    ss.Close();
                    //}
                    MessageBox.Show("页码错误！", "系统提示");
                }
            }
        }

        #endregion

        #region 绑定数据返回

        private void InitialiseBack()
        {
            try
            {
                if (Querystr == "")
                {
                    DoAllBindTable(DWBM);
                }
                else
                {
                    DoBindTable(Querystr, Flag, DWBM);
                }
                dttmp = dtInfo;
                InitDataSet(dttmp);
                SelectctTypeBind();
                SelectctDeptBind();
            }
            catch (Exception ex)
            {
            }
        }

        #endregion

        private void btnprintAll_Click(object sender, EventArgs e)
        {
            try
            {
                //PrintPreviewDialog ppd = new PrintPreviewDialog();
                var pd = new PrintDocument();
                //pd.PrinterSettings.PrinterName = "TEC B-452-R";
                var ps = new PaperSize("Custom Size 1", 280, offset_Y);
                pd.DefaultPageSettings.PrinterResolution.Kind = PrinterResolutionKind.Low;
                //pd.DefaultPageSettings.PrinterResolution.X = 150;
                //pd.DefaultPageSettings.PrinterResolution.Y = 150;
                //ps.RawKind = 150;
                //pd.DefaultPageSettings.PaperSize.RawKind = 256;
                pd.DefaultPageSettings.PaperSize = ps;
                ListstrAll = GetRowsListAll();
                pd.PrintPage += PrintDocumentAll;
                pd.PrinterSettings.PrinterName = printerConfig.PrintName;
                //ppd.Document = pd;
                try
                {
                    if (ListstrAll.Count > 0)
                    {
                        pd.Print();
                        //lbtimes.Text = pTimes.ToString();
                        //SetValue("Times", pTimes.ToString());
                        Curpage = 1;
                        if (GetBMList().Count > 0)
                        {
                            for (int i = 0; i < GetBMList().Count; i++)
                            {
                                int tt = Print_StateLogic.GetIDByBH(GetBMList()[i]);
                                if (tt > 0)
                                {
                                    Print_State pts = Print_StateManager.GetPrint_StateByPtintID(tt);
                                    pts.PrintBH = GetBMList()[i];
                                    pts.PrintState = "已打印";
                                    pts.PrintTimes += 1;
                                    Print_StateManager.ModifyPrint_State(pts);
                                }
                                else
                                {
                                    var pts = new Print_State();
                                    pts.PrintBH = GetBMList()[i];
                                    pts.PrintState = "已打印";
                                    pts.PrintTimes += 1;
                                    Print_StateManager.AddPrint_State(pts);
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("请选中至少一条数据", "系统提示");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("打印错误.", "系统提示");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("未获取打印数据集合", "系统提示");
            }
        } 

        private List<string> GetRowsListAll()
        { 
            var liststrtemp = new List<string>();
            var dt = dttmp;
            if (dt.Rows.Count==0)
            {
                MessageBox.Show("数据为空，无法打印", "系统提示");
            }
            //MessageBox.Show(dt.Rows.Count.ToString(),dt.Columns[0].ToString());
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string str = "";
//                if (dt.Rows[i]["Selected"].ToString() == "1")
//                {
                    //MessageBox.Show("1");
                    str += dt.Rows[i]["KPBH"] + "&";
                    str += dt.Rows[i]["ZCMC"] + "&";
                    str += dt.Rows[i]["ZCLB"] + "&";
                    str += dt.Rows[i]["SL"] + "&";
                    str += dt.Rows[i]["RZRQ"] + "&";
                    str += dt.Rows[i]["SYZT"] + "&";
                    str += dt.Rows[i]["DepName"]  + "&";
                    str += dt.Rows[i]["SYR"]  + "&";
                    if (dt.Rows[i]["CFDD"].ToString() != "")
                    {
                        str += GetCFDDNAME(dt.Rows[i]["CFDD"].ToString()) + "&";
                    }
                    else
                    {
                        str += "&";
                    }
                    str += dt.Rows[i]["YJSYNX"] + "&";
                    str += dt.Rows[i]["JZ"] + "&";  
                    str += dt.Rows[i]["PP"] + "&"; str += dt.Rows[i]["GGXH"] + "&"; str += dt.Rows[i]["HTBH"] + "&"; str += dt.Rows[i]["KJPZH"] + "&"; str += dt.Rows[i]["QDFS"] + "&"; str += dt.Rows[i]["QDRQ"] + "$";
                    // str +=  "&"+JHDataTable.GetDWMC(dt.Rows[i]["DWBM"].ToString());
                    if (PrinterConfig.SelectText.Split('*')[1]=="使用人")
                    {
                        if (dt.Rows[i]["SYR"].ToString()=="")
                        {
                            str += "";
                        }
                        else
                            str += PrinterConfig.SelectText.Split('*')[0] + " " + dt.Rows[i]["SYR"];
                    }
                    else if (PrinterConfig.SelectText.Split('*')[1] == "使用部门")
                    {
                        if (dt.Rows[i]["DepName"].ToString() == "")
                        {
                            str += "";
                        }
                        else
                            str += PrinterConfig.SelectText.Split('*')[0] +" "+ dt.Rows[i]["DepName"];
                    }
                    else if (PrinterConfig.SelectText.Split('*')[1] == "存放地点")
                    {
                        if (dt.Rows[i]["CFDD"].ToString() == "")
                        {
                            str += "";
                        }
                        else
                            str += PrinterConfig.SelectText.Split('*')[0] + " " + dt.Rows[i]["CFDD"];
                    }
                    //if (dt.Rows[i]["MC"].ToString() == "通用设备")
                    //{
                    //    if (dt.Rows[i]["ZCFLDM"].ToString() == "2010601" || dt.Rows[i]["ZCFLDM"].ToString() == "2010104" ||
                    //        dt.Rows[i]["ZCFLDM"].ToString() == "2010105")
                    //    {
                    //        str += dt.Rows[i]["SYR"] + "";
                    //    }
                    //    else
                    //    {
                    //        str += dt.Rows[i]["CFDD"] + "";
                    //    }
                    //}
                    //else
                    //{
                    //    if (dt.Rows[i]["CFDD"].ToString() != "")
                    //    {
                    //        str += GetCFDDNAME(dt.Rows[i]["CFDD"].ToString()) + "";
                    //    }
                    //    else
                    //    {
                    //        str += "";
                    //    }
                    //}
                    liststrtemp.Add(str);
//                }
            }
            return liststrtemp;
        }
        public void PrintDocumentAll(object sender, PrintPageEventArgs e)
        {
            try
            {
                GetCodeImgbyStr(ListstrAll[Curpage - 1], e);
                if (Curpage < ListstrAll.Count)
                {
                    e.HasMorePages = true;
                    Curpage++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("文档错误", "系统提示");
            }
        }
    }
}