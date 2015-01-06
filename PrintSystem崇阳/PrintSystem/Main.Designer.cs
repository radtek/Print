namespace PrintSystem
{
    partial class Main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvInfo = new System.Windows.Forms.DataGridView();
            this.Selected = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.PrintState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KPBH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ZCMC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ZCLB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QDRQ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DepName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SYZT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrintTimes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new CRD.WinUI.Misc.panel();
            this.btnclose = new CRD.WinUI.Misc.Button();
            this.CreateXml = new CRD.WinUI.Misc.Button();
            this.btnprint = new CRD.WinUI.Misc.Button();
            this.btnselect_all = new CRD.WinUI.Misc.Button();
            this.btnsetting = new CRD.WinUI.Misc.Button();
            this.btnconcelselect = new CRD.WinUI.Misc.Button();
            this.panel2 = new CRD.WinUI.Misc.panel();
            this.panel3 = new CRD.WinUI.Misc.panel();
            this.monthCalendar2 = new System.Windows.Forms.MonthCalendar();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label7 = new CRD.WinUI.Misc.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new CRD.WinUI.Misc.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBack = new CRD.WinUI.Misc.Button();
            this.btnselect = new CRD.WinUI.Misc.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.bdsInfo = new System.Windows.Forms.BindingSource(this.components);
            this.panel4 = new CRD.WinUI.Misc.panel();
            this.bdnInfo = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.txtCurrentPage = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.lblPageCount = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.lbl1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.SaveAs = new System.Windows.Forms.SaveFileDialog();
            this.button1 = new CRD.WinUI.Misc.Button();
            this.pnlBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfo)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsInfo)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdnInfo)).BeginInit();
            this.bdnInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBackground
            // 
            this.pnlBackground.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlBackground.BackgroundImage")));
            this.pnlBackground.Controls.Add(this.panel4);
            this.pnlBackground.Controls.Add(this.panel3);
            this.pnlBackground.Controls.Add(this.panel2);
            this.pnlBackground.Controls.Add(this.panel1);
            this.pnlBackground.Size = new System.Drawing.Size(1359, 606);
            // 
            // dgvInfo
            // 
            this.dgvInfo.AllowUserToAddRows = false;
            this.dgvInfo.AllowUserToDeleteRows = false;
            this.dgvInfo.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Selected,
            this.PrintState,
            this.KPBH,
            this.ZCMC,
            this.ZCLB,
            this.SL,
            this.QDRQ,
            this.DepName,
            this.SYZT,
            this.PrintTimes});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInfo.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvInfo.Location = new System.Drawing.Point(0, 0);
            this.dgvInfo.Name = "dgvInfo";
            this.dgvInfo.ReadOnly = true;
            this.dgvInfo.RowTemplate.Height = 23;
            this.dgvInfo.Size = new System.Drawing.Size(1059, 534);
            this.dgvInfo.TabIndex = 30;
            this.dgvInfo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInfo_CellContentClick);
            // 
            // Selected
            // 
            this.Selected.DataPropertyName = "Selected";
            this.Selected.FalseValue = "0";
            this.Selected.HeaderText = "选择";
            this.Selected.IndeterminateValue = "0";
            this.Selected.Name = "Selected";
            this.Selected.ReadOnly = true;
            this.Selected.TrueValue = "1";
            this.Selected.Width = 103;
            // 
            // PrintState
            // 
            this.PrintState.DataPropertyName = "PrintState";
            this.PrintState.HeaderText = "打印状态";
            this.PrintState.Name = "PrintState";
            this.PrintState.ReadOnly = true;
            this.PrintState.Width = 105;
            // 
            // KPBH
            // 
            this.KPBH.DataPropertyName = "KPBH";
            this.KPBH.HeaderText = "编号";
            this.KPBH.Name = "KPBH";
            this.KPBH.ReadOnly = true;
            this.KPBH.Width = 105;
            // 
            // ZCMC
            // 
            this.ZCMC.DataPropertyName = "ZCMC";
            this.ZCMC.HeaderText = "资产名称";
            this.ZCMC.Name = "ZCMC";
            this.ZCMC.ReadOnly = true;
            this.ZCMC.Width = 104;
            // 
            // ZCLB
            // 
            this.ZCLB.DataPropertyName = "ZCLB";
            this.ZCLB.HeaderText = "资产类别";
            this.ZCLB.Name = "ZCLB";
            this.ZCLB.ReadOnly = true;
            this.ZCLB.Width = 105;
            // 
            // SL
            // 
            this.SL.DataPropertyName = "SL";
            this.SL.HeaderText = "数量";
            this.SL.Name = "SL";
            this.SL.ReadOnly = true;
            this.SL.Width = 104;
            // 
            // QDRQ
            // 
            this.QDRQ.DataPropertyName = "QDRQ";
            this.QDRQ.HeaderText = "取得时间";
            this.QDRQ.Name = "QDRQ";
            this.QDRQ.ReadOnly = true;
            this.QDRQ.Width = 105;
            // 
            // DepName
            // 
            this.DepName.DataPropertyName = "DepName";
            this.DepName.HeaderText = "使用部门";
            this.DepName.Name = "DepName";
            this.DepName.ReadOnly = true;
            this.DepName.Width = 106;
            // 
            // SYZT
            // 
            this.SYZT.DataPropertyName = "SYZT";
            this.SYZT.HeaderText = "使用状态";
            this.SYZT.Name = "SYZT";
            this.SYZT.ReadOnly = true;
            this.SYZT.Width = 105;
            // 
            // PrintTimes
            // 
            this.PrintTimes.DataPropertyName = "PrintTimes";
            this.PrintTimes.HeaderText = "打印次数";
            this.PrintTimes.Name = "PrintTimes";
            this.PrintTimes.ReadOnly = true;
            this.PrintTimes.Width = 84;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(217)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.btnclose);
            this.panel1.Controls.Add(this.CreateXml);
            this.panel1.Controls.Add(this.btnprint);
            this.panel1.Controls.Add(this.btnselect_all);
            this.panel1.Controls.Add(this.btnsetting);
            this.panel1.Controls.Add(this.btnconcelselect);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ImageTransparentColor = System.Drawing.Color.Empty;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1359, 44);
            this.panel1.TabIndex = 29;
            // 
            // btnclose
            // 
            this.btnclose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnclose.BackgroundImage")));
            this.btnclose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnclose.Caption = "退出程序";
            this.btnclose.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnclose.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.btnclose.Location = new System.Drawing.Point(604, 7);
            this.btnclose.MouseDownImage = ((System.Drawing.Image)(resources.GetObject("btnclose.MouseDownImage")));
            this.btnclose.MouseMoveImage = ((System.Drawing.Image)(resources.GetObject("btnclose.MouseMoveImage")));
            this.btnclose.Name = "btnclose";
            this.btnclose.NormalImage = ((System.Drawing.Image)(resources.GetObject("btnclose.NormalImage")));
            this.btnclose.Size = new System.Drawing.Size(78, 30);
            this.btnclose.TabIndex = 24;
            this.btnclose.ToolTip = null;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // CreateXml
            // 
            this.CreateXml.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CreateXml.BackgroundImage")));
            this.CreateXml.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CreateXml.Caption = "导出数据";
            this.CreateXml.DialogResult = System.Windows.Forms.DialogResult.None;
            this.CreateXml.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.CreateXml.Location = new System.Drawing.Point(500, 7);
            this.CreateXml.MouseDownImage = ((System.Drawing.Image)(resources.GetObject("CreateXml.MouseDownImage")));
            this.CreateXml.MouseMoveImage = ((System.Drawing.Image)(resources.GetObject("CreateXml.MouseMoveImage")));
            this.CreateXml.Name = "CreateXml";
            this.CreateXml.NormalImage = ((System.Drawing.Image)(resources.GetObject("CreateXml.NormalImage")));
            this.CreateXml.Size = new System.Drawing.Size(78, 30);
            this.CreateXml.TabIndex = 23;
            this.CreateXml.ToolTip = null;
            this.CreateXml.Click += new System.EventHandler(this.CreateXml_Click);
            // 
            // btnprint
            // 
            this.btnprint.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnprint.BackgroundImage")));
            this.btnprint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnprint.Caption = "打印";
            this.btnprint.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnprint.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.btnprint.Location = new System.Drawing.Point(200, 7);
            this.btnprint.MouseDownImage = ((System.Drawing.Image)(resources.GetObject("btnprint.MouseDownImage")));
            this.btnprint.MouseMoveImage = ((System.Drawing.Image)(resources.GetObject("btnprint.MouseMoveImage")));
            this.btnprint.Name = "btnprint";
            this.btnprint.NormalImage = ((System.Drawing.Image)(resources.GetObject("btnprint.NormalImage")));
            this.btnprint.Size = new System.Drawing.Size(78, 30);
            this.btnprint.TabIndex = 21;
            this.btnprint.ToolTip = null;
            this.btnprint.Click += new System.EventHandler(this.btnprint_Click);
            // 
            // btnselect_all
            // 
            this.btnselect_all.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnselect_all.BackgroundImage")));
            this.btnselect_all.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnselect_all.Caption = "全选";
            this.btnselect_all.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnselect_all.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.btnselect_all.Location = new System.Drawing.Point(6, 7);
            this.btnselect_all.MouseDownImage = ((System.Drawing.Image)(resources.GetObject("btnselect_all.MouseDownImage")));
            this.btnselect_all.MouseMoveImage = ((System.Drawing.Image)(resources.GetObject("btnselect_all.MouseMoveImage")));
            this.btnselect_all.Name = "btnselect_all";
            this.btnselect_all.NormalImage = ((System.Drawing.Image)(resources.GetObject("btnselect_all.NormalImage")));
            this.btnselect_all.Size = new System.Drawing.Size(78, 30);
            this.btnselect_all.TabIndex = 0;
            this.btnselect_all.ToolTip = null;
            this.btnselect_all.Click += new System.EventHandler(this.btnselect_all_Click);
            // 
            // btnsetting
            // 
            this.btnsetting.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnsetting.BackgroundImage")));
            this.btnsetting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnsetting.Caption = "设置";
            this.btnsetting.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnsetting.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.btnsetting.Location = new System.Drawing.Point(398, 7);
            this.btnsetting.MouseDownImage = ((System.Drawing.Image)(resources.GetObject("btnsetting.MouseDownImage")));
            this.btnsetting.MouseMoveImage = ((System.Drawing.Image)(resources.GetObject("btnsetting.MouseMoveImage")));
            this.btnsetting.Name = "btnsetting";
            this.btnsetting.NormalImage = ((System.Drawing.Image)(resources.GetObject("btnsetting.NormalImage")));
            this.btnsetting.Size = new System.Drawing.Size(78, 30);
            this.btnsetting.TabIndex = 22;
            this.btnsetting.ToolTip = null;
            this.btnsetting.Click += new System.EventHandler(this.btnsetting_Click);
            // 
            // btnconcelselect
            // 
            this.btnconcelselect.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnconcelselect.BackgroundImage")));
            this.btnconcelselect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnconcelselect.Caption = "取消全选";
            this.btnconcelselect.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnconcelselect.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.btnconcelselect.Location = new System.Drawing.Point(103, 7);
            this.btnconcelselect.MouseDownImage = ((System.Drawing.Image)(resources.GetObject("btnconcelselect.MouseDownImage")));
            this.btnconcelselect.MouseMoveImage = ((System.Drawing.Image)(resources.GetObject("btnconcelselect.MouseMoveImage")));
            this.btnconcelselect.Name = "btnconcelselect";
            this.btnconcelselect.NormalImage = ((System.Drawing.Image)(resources.GetObject("btnconcelselect.NormalImage")));
            this.btnconcelselect.Size = new System.Drawing.Size(78, 30);
            this.btnconcelselect.TabIndex = 20;
            this.btnconcelselect.ToolTip = null;
            this.btnconcelselect.Click += new System.EventHandler(this.btnconcelselect_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.dgvInfo);
            this.panel2.ImageTransparentColor = System.Drawing.Color.Empty;
            this.panel2.Location = new System.Drawing.Point(0, 72);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1059, 534);
            this.panel2.TabIndex = 26;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.monthCalendar2);
            this.panel3.Controls.Add(this.monthCalendar1);
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Controls.Add(this.comboBox4);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.btnBack);
            this.panel3.Controls.Add(this.btnselect);
            this.panel3.Controls.Add(this.comboBox2);
            this.panel3.Controls.Add(this.comboBox1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.textBox3);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.ImageTransparentColor = System.Drawing.Color.Empty;
            this.panel3.Location = new System.Drawing.Point(1059, 44);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(300, 562);
            this.panel3.TabIndex = 26;
            // 
            // monthCalendar2
            // 
            this.monthCalendar2.Location = new System.Drawing.Point(78, 109);
            this.monthCalendar2.Name = "monthCalendar2";
            this.monthCalendar2.TabIndex = 34;
            this.monthCalendar2.Visible = false;
            this.monthCalendar2.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar2_DateSelected);
            this.monthCalendar2.MouseLeave += new System.EventHandler(this.monthCalendar2_MouseLeave);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(78, 58);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 32;
            this.monthCalendar1.Visible = false;
            this.monthCalendar1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateSelected);
            this.monthCalendar1.MouseLeave += new System.EventHandler(this.monthCalendar1_MouseLeave);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(21, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(262, 109);
            this.groupBox1.TabIndex = 45;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "按时间查询";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(57, 68);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(199, 21);
            this.textBox2.TabIndex = 35;
            this.textBox2.Click += new System.EventHandler(this.textBox2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(12, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 12);
            this.label7.TabIndex = 44;
            this.label7.Text = "到";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(57, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(199, 21);
            this.textBox1.TabIndex = 33;
            this.textBox1.Click += new System.EventHandler(this.textBox1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(6, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 12);
            this.label5.TabIndex = 44;
            this.label5.Text = " 从";
            // 
            // comboBox4
            // 
            this.comboBox4.BackColor = System.Drawing.SystemColors.Control;
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "未打印",
            "已打印"});
            this.comboBox4.Location = new System.Drawing.Point(122, 302);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(155, 20);
            this.comboBox4.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 307);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 12);
            this.label1.TabIndex = 42;
            this.label1.Text = "按打印状态查询:";
            // 
            // btnBack
            // 
            this.btnBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBack.BackgroundImage")));
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.Caption = "返回";
            this.btnBack.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnBack.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.btnBack.Location = new System.Drawing.Point(202, 349);
            this.btnBack.MouseDownImage = ((System.Drawing.Image)(resources.GetObject("btnBack.MouseDownImage")));
            this.btnBack.MouseMoveImage = ((System.Drawing.Image)(resources.GetObject("btnBack.MouseMoveImage")));
            this.btnBack.Name = "btnBack";
            this.btnBack.NormalImage = ((System.Drawing.Image)(resources.GetObject("btnBack.NormalImage")));
            this.btnBack.Size = new System.Drawing.Size(75, 32);
            this.btnBack.TabIndex = 40;
            this.btnBack.ToolTip = null;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnselect
            // 
            this.btnselect.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnselect.BackgroundImage")));
            this.btnselect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnselect.Caption = "查询";
            this.btnselect.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnselect.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.btnselect.Location = new System.Drawing.Point(21, 349);
            this.btnselect.MouseDownImage = ((System.Drawing.Image)(resources.GetObject("btnselect.MouseDownImage")));
            this.btnselect.MouseMoveImage = ((System.Drawing.Image)(resources.GetObject("btnselect.MouseMoveImage")));
            this.btnselect.Name = "btnselect";
            this.btnselect.NormalImage = ((System.Drawing.Image)(resources.GetObject("btnselect.NormalImage")));
            this.btnselect.Size = new System.Drawing.Size(75, 32);
            this.btnselect.TabIndex = 41;
            this.btnselect.ToolTip = null;
            this.btnselect.Click += new System.EventHandler(this.btnselect_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.BackColor = System.Drawing.SystemColors.Control;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(122, 199);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(155, 20);
            this.comboBox2.TabIndex = 39;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.Control;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            ""});
            this.comboBox1.Location = new System.Drawing.Point(122, 148);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(155, 20);
            this.comboBox1.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 12);
            this.label2.TabIndex = 29;
            this.label2.Text = "按部门查询:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 12);
            this.label3.TabIndex = 30;
            this.label3.Text = "按名称查询:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(121, 250);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(156, 21);
            this.textBox3.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 12);
            this.label4.TabIndex = 31;
            this.label4.Text = "按类别查询:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.bdnInfo);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.ImageTransparentColor = System.Drawing.Color.Empty;
            this.panel4.Location = new System.Drawing.Point(0, 44);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1059, 26);
            this.panel4.TabIndex = 31;
            // 
            // bdnInfo
            // 
            this.bdnInfo.AddNewItem = null;
            this.bdnInfo.BackColor = System.Drawing.SystemColors.Control;
            this.bdnInfo.CountItem = null;
            this.bdnInfo.DeleteItem = null;
            this.bdnInfo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripSeparator1,
            this.txtCurrentPage,
            this.toolStripLabel2,
            this.lblPageCount,
            this.toolStripSeparator2,
            this.lbl1,
            this.toolStripSeparator3});
            this.bdnInfo.Location = new System.Drawing.Point(0, 0);
            this.bdnInfo.MoveFirstItem = null;
            this.bdnInfo.MoveLastItem = null;
            this.bdnInfo.MoveNextItem = null;
            this.bdnInfo.MovePreviousItem = null;
            this.bdnInfo.Name = "bdnInfo";
            this.bdnInfo.PositionItem = null;
            this.bdnInfo.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.bdnInfo.Size = new System.Drawing.Size(1059, 25);
            this.bdnInfo.TabIndex = 32;
            this.bdnInfo.Text = "bindingNavigator1";
            this.bdnInfo.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.bdnInfo_ItemClicked);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(44, 22);
            this.toolStripLabel1.Text = "上一页";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // txtCurrentPage
            // 
            this.txtCurrentPage.Name = "txtCurrentPage";
            this.txtCurrentPage.Size = new System.Drawing.Size(100, 25);
            this.txtCurrentPage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCurrentPage_KeyDown);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(13, 22);
            this.toolStripLabel2.Text = "/";
            // 
            // lblPageCount
            // 
            this.lblPageCount.Name = "lblPageCount";
            this.lblPageCount.Size = new System.Drawing.Size(15, 22);
            this.lblPageCount.Text = "0";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // lbl1
            // 
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(44, 22);
            this.lbl1.Text = "下一页";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // SaveAs
            // 
            this.SaveAs.Filter = "XML 文件(*.xml)|*.XML";
            this.SaveAs.InitialDirectory = "D:\\";
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Caption = "打印全部";
            this.button1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.button1.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.button1.Location = new System.Drawing.Point(300, 7);
            this.button1.MouseDownImage = ((System.Drawing.Image)(resources.GetObject("button1.MouseDownImage")));
            this.button1.MouseMoveImage = ((System.Drawing.Image)(resources.GetObject("button1.MouseMoveImage")));
            this.button1.Name = "button1";
            this.button1.NormalImage = ((System.Drawing.Image)(resources.GetObject("button1.NormalImage")));
            this.button1.Size = new System.Drawing.Size(78, 30);
            this.button1.TabIndex = 26;
            this.button1.ToolTip = null;
            this.button1.Click += new System.EventHandler(this.btnprintAll_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 710);
            this.Controls.Add(this.pnlBackground);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "地税条码打印系统1.0";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.Load += new System.EventHandler(this.Main_Load);
            this.Controls.SetChildIndex(this.pnlBackground, 0);
            this.pnlBackground.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsInfo)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdnInfo)).EndInit();
            this.bdnInfo.ResumeLayout(false);
            this.bdnInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dgvInfo;
        private CRD.WinUI.Misc.panel panel1;
        private CRD.WinUI.Misc.Button btnclose;
        private CRD.WinUI.Misc.Button CreateXml;
        private CRD.WinUI.Misc.Button btnprint;
        private CRD.WinUI.Misc.Button btnselect_all;
        private CRD.WinUI.Misc.Button btnconcelselect;
        private CRD.WinUI.Misc.panel panel2;
        private CRD.WinUI.Misc.panel panel3;
        private System.Windows.Forms.BindingSource bdsInfo;
        private CRD.WinUI.Misc.panel panel4;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MonthCalendar monthCalendar2;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private CRD.WinUI.Misc.Button btnBack;
        private CRD.WinUI.Misc.Button btnselect;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingNavigator bdnInfo;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox txtCurrentPage;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripLabel lblPageCount;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel lbl1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.TextBox textBox3;
        private CRD.WinUI.Misc.Button btnsetting;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Selected;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrintState;
        private System.Windows.Forms.DataGridViewTextBoxColumn KPBH;
        private System.Windows.Forms.DataGridViewTextBoxColumn ZCMC;
        private System.Windows.Forms.DataGridViewTextBoxColumn ZCLB;
        private System.Windows.Forms.DataGridViewTextBoxColumn SL;
        private System.Windows.Forms.DataGridViewTextBoxColumn QDRQ;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SYZT;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrintTimes;
        public System.Windows.Forms.SaveFileDialog SaveAs;
        private System.Windows.Forms.GroupBox groupBox1;
        private CRD.WinUI.Misc.Label label7;
        private CRD.WinUI.Misc.Label label5;
        private CRD.WinUI.Misc.Button button1;

    }
}

