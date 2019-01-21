namespace WindowsFormsApp1
{
    partial class Form_維修單
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_維修單));
            this.textBox_輸入資料 = new System.Windows.Forms.TextBox();
            this.button_搜尋 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column_保管人 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_電腦名稱 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_機關 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_部門 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_財產編號 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_cpu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_作業系統 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_記憶體 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_硬碟 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_ip位置 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_主機板製造商 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_主機版品牌名稱 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_主機版序號 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_製造商 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_品牌名稱 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_品牌序號 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_品牌型號 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_主機板資產標籤 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_系統UUID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_記憶體說明 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_MAC位址 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_更新日期 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_建立時間 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.關於ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_職編搜尋 = new System.Windows.Forms.TextBox();
            this.textBox_故障情形 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_工程師 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Column_報修序號 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_維護廠商 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_叫修電話 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_故障情形 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_通報人 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_職編 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_通報單位 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_職稱 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_分機號碼 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_資訊室叫修人員 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_輸入故障情形 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_輸入通報人員 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_輸入職編 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_輸入通報單位 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_輸入職稱 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_叫修人員 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_報修序號 = new System.Windows.Forms.TextBox();
            this.comboBox_維護廠商 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button_清空 = new System.Windows.Forms.Button();
            this.button_關閉 = new System.Windows.Forms.Button();
            this.textBox_部門 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.button_預覽 = new System.Windows.Forms.Button();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.label1_版本 = new System.Windows.Forms.Label();
            this.label1_資料庫日期 = new System.Windows.Forms.Label();
            this.timer_時間 = new System.Windows.Forms.Timer(this.components);
            this.label1_時間 = new System.Windows.Forms.Label();
            this.label1_分機 = new System.Windows.Forms.Label();
            this.textBox_分機 = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_輸入資料
            // 
            this.textBox_輸入資料.AllowDrop = true;
            this.textBox_輸入資料.Location = new System.Drawing.Point(77, 149);
            this.textBox_輸入資料.Multiline = true;
            this.textBox_輸入資料.Name = "textBox_輸入資料";
            this.textBox_輸入資料.Size = new System.Drawing.Size(714, 62);
            this.textBox_輸入資料.TabIndex = 0;
            this.textBox_輸入資料.TextChanged += new System.EventHandler(this.textBox_輸入資料_TextChanged);
            // 
            // button_搜尋
            // 
            this.button_搜尋.Location = new System.Drawing.Point(797, 129);
            this.button_搜尋.Name = "button_搜尋";
            this.button_搜尋.Size = new System.Drawing.Size(120, 82);
            this.button_搜尋.TabIndex = 1;
            this.button_搜尋.Text = "搜尋";
            this.button_搜尋.UseVisualStyleBackColor = true;
            this.button_搜尋.Click += new System.EventHandler(this.button_搜尋_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_保管人,
            this.Column_電腦名稱,
            this.Column_機關,
            this.Column_部門,
            this.Column_財產編號,
            this.Column_cpu,
            this.Column_作業系統,
            this.Column_記憶體,
            this.Column_硬碟,
            this.Column_ip位置,
            this.Column_主機板製造商,
            this.Column_主機版品牌名稱,
            this.Column_主機版序號,
            this.Column_製造商,
            this.Column_品牌名稱,
            this.Column_品牌序號,
            this.Column_品牌型號,
            this.Column_主機板資產標籤,
            this.Column_系統UUID,
            this.Column_記憶體說明,
            this.Column_MAC位址,
            this.Column_更新日期,
            this.Column_建立時間});
            this.dataGridView1.Location = new System.Drawing.Point(4, 343);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1173, 74);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.TabStop = false;
            this.dataGridView1.VirtualMode = true;
            // 
            // Column_保管人
            // 
            this.Column_保管人.HeaderText = "保管人";
            this.Column_保管人.Name = "Column_保管人";
            this.Column_保管人.ReadOnly = true;
            // 
            // Column_電腦名稱
            // 
            this.Column_電腦名稱.HeaderText = "電腦名稱";
            this.Column_電腦名稱.Name = "Column_電腦名稱";
            this.Column_電腦名稱.ReadOnly = true;
            // 
            // Column_機關
            // 
            this.Column_機關.HeaderText = "機關";
            this.Column_機關.Name = "Column_機關";
            this.Column_機關.ReadOnly = true;
            // 
            // Column_部門
            // 
            this.Column_部門.HeaderText = "部門";
            this.Column_部門.Name = "Column_部門";
            this.Column_部門.ReadOnly = true;
            // 
            // Column_財產編號
            // 
            this.Column_財產編號.HeaderText = "財產編號";
            this.Column_財產編號.Name = "Column_財產編號";
            this.Column_財產編號.ReadOnly = true;
            // 
            // Column_cpu
            // 
            this.Column_cpu.HeaderText = "cpu";
            this.Column_cpu.Name = "Column_cpu";
            this.Column_cpu.ReadOnly = true;
            // 
            // Column_作業系統
            // 
            this.Column_作業系統.HeaderText = "作業系統";
            this.Column_作業系統.Name = "Column_作業系統";
            this.Column_作業系統.ReadOnly = true;
            // 
            // Column_記憶體
            // 
            this.Column_記憶體.HeaderText = "記憶體";
            this.Column_記憶體.Name = "Column_記憶體";
            this.Column_記憶體.ReadOnly = true;
            // 
            // Column_硬碟
            // 
            this.Column_硬碟.HeaderText = "硬碟";
            this.Column_硬碟.Name = "Column_硬碟";
            this.Column_硬碟.ReadOnly = true;
            // 
            // Column_ip位置
            // 
            this.Column_ip位置.HeaderText = "ip位置";
            this.Column_ip位置.Name = "Column_ip位置";
            this.Column_ip位置.ReadOnly = true;
            // 
            // Column_主機板製造商
            // 
            this.Column_主機板製造商.HeaderText = "主機板製造商";
            this.Column_主機板製造商.Name = "Column_主機板製造商";
            this.Column_主機板製造商.ReadOnly = true;
            // 
            // Column_主機版品牌名稱
            // 
            this.Column_主機版品牌名稱.HeaderText = "主機版品牌名稱";
            this.Column_主機版品牌名稱.Name = "Column_主機版品牌名稱";
            this.Column_主機版品牌名稱.ReadOnly = true;
            // 
            // Column_主機版序號
            // 
            this.Column_主機版序號.HeaderText = "主機版序號";
            this.Column_主機版序號.Name = "Column_主機版序號";
            this.Column_主機版序號.ReadOnly = true;
            // 
            // Column_製造商
            // 
            this.Column_製造商.HeaderText = "製造商";
            this.Column_製造商.Name = "Column_製造商";
            this.Column_製造商.ReadOnly = true;
            // 
            // Column_品牌名稱
            // 
            this.Column_品牌名稱.HeaderText = "品牌名稱";
            this.Column_品牌名稱.Name = "Column_品牌名稱";
            this.Column_品牌名稱.ReadOnly = true;
            // 
            // Column_品牌序號
            // 
            this.Column_品牌序號.HeaderText = "品牌序號";
            this.Column_品牌序號.Name = "Column_品牌序號";
            this.Column_品牌序號.ReadOnly = true;
            // 
            // Column_品牌型號
            // 
            this.Column_品牌型號.HeaderText = "品牌型號";
            this.Column_品牌型號.Name = "Column_品牌型號";
            this.Column_品牌型號.ReadOnly = true;
            // 
            // Column_主機板資產標籤
            // 
            this.Column_主機板資產標籤.HeaderText = "主機板資產標籤";
            this.Column_主機板資產標籤.Name = "Column_主機板資產標籤";
            this.Column_主機板資產標籤.ReadOnly = true;
            // 
            // Column_系統UUID
            // 
            this.Column_系統UUID.HeaderText = "系統UUID";
            this.Column_系統UUID.Name = "Column_系統UUID";
            this.Column_系統UUID.ReadOnly = true;
            // 
            // Column_記憶體說明
            // 
            this.Column_記憶體說明.HeaderText = "記憶體說明";
            this.Column_記憶體說明.Name = "Column_記憶體說明";
            this.Column_記憶體說明.ReadOnly = true;
            // 
            // Column_MAC位址
            // 
            this.Column_MAC位址.HeaderText = "MAC位址";
            this.Column_MAC位址.Name = "Column_MAC位址";
            this.Column_MAC位址.ReadOnly = true;
            // 
            // Column_更新日期
            // 
            this.Column_更新日期.HeaderText = "更新日期";
            this.Column_更新日期.Name = "Column_更新日期";
            this.Column_更新日期.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column_建立時間
            // 
            this.Column_建立時間.HeaderText = "建立時間";
            this.Column_建立時間.Name = "Column_建立時間";
            this.Column_建立時間.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.關於ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1181, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 關於ToolStripMenuItem
            // 
            this.關於ToolStripMenuItem.Name = "關於ToolStripMenuItem";
            this.關於ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.關於ToolStripMenuItem.Text = "關於";
            this.關於ToolStripMenuItem.Click += new System.EventHandler(this.關於ToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "職編搜尋 :";
            // 
            // textBox_職編搜尋
            // 
            this.textBox_職編搜尋.AllowDrop = true;
            this.textBox_職編搜尋.Location = new System.Drawing.Point(77, 50);
            this.textBox_職編搜尋.Name = "textBox_職編搜尋";
            this.textBox_職編搜尋.Size = new System.Drawing.Size(159, 22);
            this.textBox_職編搜尋.TabIndex = 6;
            // 
            // textBox_故障情形
            // 
            this.textBox_故障情形.AllowDrop = true;
            this.textBox_故障情形.Location = new System.Drawing.Point(77, 78);
            this.textBox_故障情形.Multiline = true;
            this.textBox_故障情形.Name = "textBox_故障情形";
            this.textBox_故障情形.Size = new System.Drawing.Size(316, 65);
            this.textBox_故障情形.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "故障情形:";
            // 
            // comboBox_工程師
            // 
            this.comboBox_工程師.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_工程師.FormattingEnabled = true;
            this.comboBox_工程師.Location = new System.Drawing.Point(565, 48);
            this.comboBox_工程師.Name = "comboBox_工程師";
            this.comboBox_工程師.Size = new System.Drawing.Size(113, 20);
            this.comboBox_工程師.TabIndex = 9;
            this.comboBox_工程師.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(491, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 12);
            this.label3.TabIndex = 10;
            this.label3.Text = "維修工程師:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(940, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 12);
            this.label5.TabIndex = 14;
            this.label5.Text = "到達時間日期:";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToOrderColumns = true;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_報修序號,
            this.Column5,
            this.Column9,
            this.Column_維護廠商,
            this.Column_叫修電話,
            this.Column_故障情形,
            this.Column_通報人,
            this.Column_職編,
            this.Column_通報單位,
            this.Column_職稱,
            this.Column_分機號碼,
            this.Column_資訊室叫修人員,
            this.Column_1,
            this.Column_輸入故障情形,
            this.Column_輸入通報人員,
            this.Column_輸入職編,
            this.Column_輸入通報單位,
            this.Column_輸入職稱,
            this.Column_叫修人員,
            this.Column8,
            this.Column11,
            this.Column12,
            this.Column13,
            this.Column14});
            this.dataGridView2.Location = new System.Drawing.Point(4, 237);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(1173, 58);
            this.dataGridView2.TabIndex = 15;
            // 
            // Column_報修序號
            // 
            this.Column_報修序號.HeaderText = "報修序號";
            this.Column_報修序號.Name = "Column_報修序號";
            this.Column_報修序號.Width = 80;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "日期時間";
            this.Column5.Name = "Column5";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "";
            this.Column9.Name = "Column9";
            this.Column9.Visible = false;
            // 
            // Column_維護廠商
            // 
            this.Column_維護廠商.HeaderText = "維護廠商";
            this.Column_維護廠商.Name = "Column_維護廠商";
            // 
            // Column_叫修電話
            // 
            this.Column_叫修電話.HeaderText = "叫修電話";
            this.Column_叫修電話.Name = "Column_叫修電話";
            // 
            // Column_故障情形
            // 
            this.Column_故障情形.HeaderText = "故障情形                         (有跳行把空白砍掉)";
            this.Column_故障情形.Name = "Column_故障情形";
            this.Column_故障情形.Width = 150;
            // 
            // Column_通報人
            // 
            this.Column_通報人.HeaderText = "通報人";
            this.Column_通報人.Name = "Column_通報人";
            // 
            // Column_職編
            // 
            this.Column_職編.HeaderText = "職編";
            this.Column_職編.Name = "Column_職編";
            // 
            // Column_通報單位
            // 
            this.Column_通報單位.HeaderText = "通報單位";
            this.Column_通報單位.Name = "Column_通報單位";
            // 
            // Column_職稱
            // 
            this.Column_職稱.HeaderText = "職稱";
            this.Column_職稱.Name = "Column_職稱";
            // 
            // Column_分機號碼
            // 
            this.Column_分機號碼.HeaderText = "分機號碼";
            this.Column_分機號碼.Name = "Column_分機號碼";
            // 
            // Column_資訊室叫修人員
            // 
            this.Column_資訊室叫修人員.HeaderText = "資訊室叫修人員";
            this.Column_資訊室叫修人員.Name = "Column_資訊室叫修人員";
            // 
            // Column_1
            // 
            this.Column_1.HeaderText = "";
            this.Column_1.Name = "Column_1";
            this.Column_1.Visible = false;
            // 
            // Column_輸入故障情形
            // 
            this.Column_輸入故障情形.HeaderText = "";
            this.Column_輸入故障情形.Name = "Column_輸入故障情形";
            this.Column_輸入故障情形.Visible = false;
            this.Column_輸入故障情形.Width = 99;
            // 
            // Column_輸入通報人員
            // 
            this.Column_輸入通報人員.HeaderText = "";
            this.Column_輸入通報人員.Name = "Column_輸入通報人員";
            this.Column_輸入通報人員.Visible = false;
            // 
            // Column_輸入職編
            // 
            this.Column_輸入職編.HeaderText = "";
            this.Column_輸入職編.Name = "Column_輸入職編";
            this.Column_輸入職編.Visible = false;
            // 
            // Column_輸入通報單位
            // 
            this.Column_輸入通報單位.HeaderText = "";
            this.Column_輸入通報單位.Name = "Column_輸入通報單位";
            this.Column_輸入通報單位.Visible = false;
            // 
            // Column_輸入職稱
            // 
            this.Column_輸入職稱.HeaderText = "";
            this.Column_輸入職稱.Name = "Column_輸入職稱";
            this.Column_輸入職稱.Visible = false;
            // 
            // Column_叫修人員
            // 
            this.Column_叫修人員.HeaderText = "";
            this.Column_叫修人員.Name = "Column_叫修人員";
            this.Column_叫修人員.Visible = false;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "";
            this.Column8.Name = "Column8";
            this.Column8.Visible = false;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "";
            this.Column11.Name = "Column11";
            this.Column11.Visible = false;
            // 
            // Column12
            // 
            this.Column12.HeaderText = "";
            this.Column12.Name = "Column12";
            this.Column12.Visible = false;
            // 
            // Column13
            // 
            this.Column13.HeaderText = "";
            this.Column13.Name = "Column13";
            this.Column13.Visible = false;
            // 
            // Column14
            // 
            this.Column14.HeaderText = "";
            this.Column14.Name = "Column14";
            this.Column14.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 12);
            this.label6.TabIndex = 16;
            this.label6.Text = "輸入資料:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(254, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 12);
            this.label4.TabIndex = 12;
            this.label4.Text = "報修序號:";
            // 
            // textBox_報修序號
            // 
            this.textBox_報修序號.AllowDrop = true;
            this.textBox_報修序號.Location = new System.Drawing.Point(316, 48);
            this.textBox_報修序號.Name = "textBox_報修序號";
            this.textBox_報修序號.Size = new System.Drawing.Size(159, 22);
            this.textBox_報修序號.TabIndex = 11;
            // 
            // comboBox_維護廠商
            // 
            this.comboBox_維護廠商.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_維護廠商.FormattingEnabled = true;
            this.comboBox_維護廠商.Location = new System.Drawing.Point(758, 50);
            this.comboBox_維護廠商.Name = "comboBox_維護廠商";
            this.comboBox_維護廠商.Size = new System.Drawing.Size(176, 20);
            this.comboBox_維護廠商.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(696, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 12);
            this.label7.TabIndex = 18;
            this.label7.Text = "維護廠商:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(2, 222);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(256, 12);
            this.label8.TabIndex = 19;
            this.label8.Text = "輸入資料(請先選取要搜尋的關鍵字後再按搜尋):";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(2, 328);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 12);
            this.label9.TabIndex = 20;
            this.label9.Text = "搜尋資料:";
            // 
            // button_清空
            // 
            this.button_清空.Location = new System.Drawing.Point(923, 129);
            this.button_清空.Name = "button_清空";
            this.button_清空.Size = new System.Drawing.Size(120, 82);
            this.button_清空.TabIndex = 21;
            this.button_清空.Text = "清空";
            this.button_清空.UseVisualStyleBackColor = true;
            this.button_清空.Click += new System.EventHandler(this.button_清空_Click);
            // 
            // button_關閉
            // 
            this.button_關閉.Location = new System.Drawing.Point(1050, 418);
            this.button_關閉.Name = "button_關閉";
            this.button_關閉.Size = new System.Drawing.Size(127, 29);
            this.button_關閉.TabIndex = 22;
            this.button_關閉.Text = "關閉";
            this.button_關閉.UseVisualStyleBackColor = true;
            this.button_關閉.Click += new System.EventHandler(this.button_關閉_Click);
            // 
            // textBox_部門
            // 
            this.textBox_部門.AllowDrop = true;
            this.textBox_部門.Location = new System.Drawing.Point(451, 121);
            this.textBox_部門.Multiline = true;
            this.textBox_部門.Name = "textBox_部門";
            this.textBox_部門.Size = new System.Drawing.Size(227, 22);
            this.textBox_部門.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(413, 124);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 12);
            this.label10.TabIndex = 24;
            this.label10.Text = "部門:";
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            this.printDocument1.DocumentName = " ";
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // button_預覽
            // 
            this.button_預覽.Location = new System.Drawing.Point(1049, 129);
            this.button_預覽.Name = "button_預覽";
            this.button_預覽.Size = new System.Drawing.Size(128, 82);
            this.button_預覽.TabIndex = 25;
            this.button_預覽.Text = "列印";
            this.button_預覽.UseVisualStyleBackColor = true;
            this.button_預覽.Click += new System.EventHandler(this.button_預覽_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(650, 650);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "報修單";
            this.printPreviewDialog1.Visible = false;
            // 
            // label1_版本
            // 
            this.label1_版本.AutoSize = true;
            this.label1_版本.Location = new System.Drawing.Point(2, 420);
            this.label1_版本.Name = "label1_版本";
            this.label1_版本.Size = new System.Drawing.Size(99, 12);
            this.label1_版本.TabIndex = 26;
            this.label1_版本.Text = "(資料庫更新日期: ";
            // 
            // label1_資料庫日期
            // 
            this.label1_資料庫日期.AutoSize = true;
            this.label1_資料庫日期.Location = new System.Drawing.Point(99, 420);
            this.label1_資料庫日期.Name = "label1_資料庫日期";
            this.label1_資料庫日期.Size = new System.Drawing.Size(0, 12);
            this.label1_資料庫日期.TabIndex = 27;
            // 
            // timer_時間
            // 
            this.timer_時間.Enabled = true;
            this.timer_時間.Interval = 1000;
            this.timer_時間.Tick += new System.EventHandler(this.timer_時間_Tick);
            // 
            // label1_時間
            // 
            this.label1_時間.AutoSize = true;
            this.label1_時間.Font = new System.Drawing.Font("標楷體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1_時間.Location = new System.Drawing.Point(942, 72);
            this.label1_時間.Name = "label1_時間";
            this.label1_時間.Size = new System.Drawing.Size(0, 13);
            this.label1_時間.TabIndex = 28;
            // 
            // label1_分機
            // 
            this.label1_分機.AutoSize = true;
            this.label1_分機.Location = new System.Drawing.Point(413, 93);
            this.label1_分機.Name = "label1_分機";
            this.label1_分機.Size = new System.Drawing.Size(32, 12);
            this.label1_分機.TabIndex = 29;
            this.label1_分機.Text = "分機:";
            // 
            // textBox_分機
            // 
            this.textBox_分機.AllowDrop = true;
            this.textBox_分機.Location = new System.Drawing.Point(451, 90);
            this.textBox_分機.Multiline = true;
            this.textBox_分機.Name = "textBox_分機";
            this.textBox_分機.Size = new System.Drawing.Size(77, 22);
            this.textBox_分機.TabIndex = 30;
            // 
            // Form_維修單
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1181, 448);
            this.Controls.Add(this.textBox_分機);
            this.Controls.Add(this.label1_分機);
            this.Controls.Add(this.label1_時間);
            this.Controls.Add(this.label1_資料庫日期);
            this.Controls.Add(this.label1_版本);
            this.Controls.Add(this.button_預覽);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox_部門);
            this.Controls.Add(this.button_關閉);
            this.Controls.Add(this.button_清空);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBox_維護廠商);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_報修序號);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox_工程師);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_故障情形);
            this.Controls.Add(this.textBox_職編搜尋);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_搜尋);
            this.Controls.Add(this.textBox_輸入資料);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form_維修單";
            this.Text = "報修維修單系統";
            this.Load += new System.EventHandler(this.Form_維修單_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_搜尋;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 關於ToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_職編搜尋;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_報修序號;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button_清空;
        public System.Windows.Forms.ComboBox comboBox_工程師;
        public System.Windows.Forms.TextBox textBox_輸入資料;
        public System.Windows.Forms.TextBox textBox_故障情形;
        private System.Windows.Forms.Button button_關閉;
        public System.Windows.Forms.ComboBox comboBox_維護廠商;
        public System.Windows.Forms.TextBox textBox_部門;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_保管人;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_電腦名稱;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_機關;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_部門;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_財產編號;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_cpu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_作業系統;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_記憶體;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_硬碟;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_ip位置;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_主機板製造商;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_主機版品牌名稱;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_主機版序號;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_製造商;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_品牌名稱;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_品牌序號;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_品牌型號;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_主機板資產標籤;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_系統UUID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_記憶體說明;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_MAC位址;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_更新日期;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_建立時間;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.Button button_預覽;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        public System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Label label1_版本;
        private System.Windows.Forms.Label label1_資料庫日期;
        private System.Windows.Forms.Timer timer_時間;
        private System.Windows.Forms.Label label1_時間;
        private System.Windows.Forms.Label label1_分機;
        public System.Windows.Forms.TextBox textBox_分機;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_報修序號;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_維護廠商;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_叫修電話;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_故障情形;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_通報人;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_職編;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_通報單位;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_職稱;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_分機號碼;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_資訊室叫修人員;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_輸入故障情形;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_輸入通報人員;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_輸入職編;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_輸入通報單位;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_輸入職稱;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_叫修人員;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

