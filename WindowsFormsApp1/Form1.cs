using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;
using System.Windows;
using System.Drawing.Printing;
using System.Resources;
namespace WindowsFormsApp1
{
    public partial class Form_維修單 : Form
    {
        string[] timedate = new string[20];               //暫存資料textbox輸入資料
        string[] codate = new string[100];                                 //搜尋到的用戶分割資料存放陣列
        int I_搜尋索引 = 0, A_取得行數, A_暫存一維陣列整理 = 0, B_暫存一維陣列整理 = 0;
        string[] userdate;
        private DataGridView songsDataGridView = new DataGridView();
        string temp_text = "";
        public Form_維修單()
        {
            InitializeComponent();
        }
        private void 輸出資料()
        {
            
            Column_電腦名稱.DefaultCellStyle.NullValue = codate[1];
            Column_保管人.DefaultCellStyle.NullValue = codate[4];
            Column_機關.DefaultCellStyle.NullValue = codate[2];
            Column_部門.DefaultCellStyle.NullValue = codate[3];
            Column_財產編號.DefaultCellStyle.NullValue = codate[5];
            Column_cpu.DefaultCellStyle.NullValue = codate[6];
            Column_作業系統.DefaultCellStyle.NullValue = codate[7];
            Column_記憶體.DefaultCellStyle.NullValue = codate[8];
            Column_硬碟.DefaultCellStyle.NullValue = codate[9];
            Column_ip位置.DefaultCellStyle.NullValue = codate[10];
            Column_主機板製造商.DefaultCellStyle.NullValue = codate[11];
            Column_主機版品牌名稱.DefaultCellStyle.NullValue = codate[12];
            Column_主機版序號.DefaultCellStyle.NullValue = codate[14];
            Column_製造商.DefaultCellStyle.NullValue = codate[15];
            Column_品牌名稱.DefaultCellStyle.NullValue = codate[16];
            Column_品牌序號.DefaultCellStyle.NullValue = codate[17];
            Column_品牌型號.DefaultCellStyle.NullValue = codate[18];
            Column_主機板資產標籤.DefaultCellStyle.NullValue = codate[19];
            Column_系統UUID.DefaultCellStyle.NullValue = codate[20];
            Column_記憶體說明.DefaultCellStyle.NullValue = codate[21];
            Column_MAC位址.DefaultCellStyle.NullValue = codate[22];
            Column_更新日期.DefaultCellStyle.NullValue = codate[23];
            Column_建立時間.DefaultCellStyle.NullValue = codate[24];
        }
        private void 整理暫存陣列()
        {
            int  a = 0,b = 0;
            b = Array.IndexOf(timedate, null);
            A_暫存一維陣列整理 = Array.IndexOf(timedate, "");
            B_暫存一維陣列整理 = Array.LastIndexOf(timedate, "");
            if (B_暫存一維陣列整理 >= 0)
            {
               timedate[B_暫存一維陣列整理] = null;
            }            
            a = timedate.GetUpperBound(0);
            if (A_暫存一維陣列整理 >= 0)
            {
                if (A_暫存一維陣列整理 >= 0)
                {
                    for (int i = A_暫存一維陣列整理; i < a; i++)
                    {
                        timedate[i] = timedate[i + 1];
                    }
                }
                A_暫存一維陣列整理 = Array.IndexOf(timedate, "");
                
            }
            if ( A_暫存一維陣列整理 >= 0)
            {
                整理暫存陣列();
            }
        }
        private void 填補暫存陣列()
        {
            int A_填補暫存陣列;
            A_填補暫存陣列 = Array.IndexOf(timedate, null);
            if (A_填補暫存陣列 >= 0)
            {
                for (int i = A_填補暫存陣列; i != -1; i = A_填補暫存陣列)
                {
                    A_填補暫存陣列 = Array.IndexOf(timedate, null);
                    timedate[i] = " ";
                }
            }
            
        }
        private void 搜尋資料()
        {
            int X = 0;
            dataGridView1.Rows.Clear();
            for (int i = 0; i < userdate.Length; i++)
            {
                string Temp = userdate[i].ToString();
                X = Temp.IndexOf(temp_text);
                I_搜尋索引 = i;
                if (X >= 0)
                {
                    break;
                }
            }
            if (X == -1)
            {
                textBox_故障情形.Text = timedate[5].ToString();
                textBox_部門.Text = timedate[8].ToString();
                textBox_報修序號.Text = timedate[0].ToString();
                textBox_分機.Text = timedate[10].ToString();
                MessageBox.Show("搜尋不到此人，請善用職編搜尋");
            }
            else
            {
                string TEMP = userdate[I_搜尋索引].ToString();
                codate = TEMP.Split();
                輸出資料();
            }
        }


        private void button_搜尋_Click(object sender, EventArgs e)
        {
            try
            {
                int A_橫 = 0, A_直 = 0, X = 0;
                Int32 selectedCellCount = dataGridView2.GetCellCount(DataGridViewElementStates.Selected);
                if (textBox_職編搜尋.Text.Length >= 5)        //先用職編搜尋
                {
                    if ((Column_輸入故障情形 != null) || (textBox_故障情形.Text.Length >= 10))
                    {
                        if (textBox_報修序號.Text.Length >= 4)
                        {
                            if (comboBox_維護廠商.Text.Length != 0)
                            {
                                temp_text = textBox_職編搜尋.Text;
                                dataGridView1.Rows.Clear();
                                for (int i = 0; i < userdate.Length; i++)
                                {
                                    string Temp = userdate[i].ToString();
                                    X = Temp.IndexOf(temp_text);
                                    I_搜尋索引 = i;
                                    if (X >= 0)
                                    {
                                        break;
                                    }
                                }
                                if (X == -1)
                                {
                                    MessageBox.Show("無此人資料");
                                }
                                else
                                {
                                    string TEMP = userdate[I_搜尋索引].ToString();
                                    codate = TEMP.Split();
                                    輸出資料();
                                }
                                textBox_職編搜尋.Text = "";
                            }
                            else
                            {
                                MessageBox.Show("未選擇維護廠商");
                            }
                        }
                        else
                        {
                            MessageBox.Show("未輸入報修序號");
                        }
                    }
                    else
                    {
                        MessageBox.Show("未輸入故障情形");
                    }

                }
                else
                {
                    textBox_職編搜尋.Text = "";
                    if (textBox_輸入資料.Text.Length > 0)
                    {
                        if (selectedCellCount > 0)
                        {
                            for (int i = 0; i < selectedCellCount; i++)
                            {
                                A_直 = Convert.ToUInt16(dataGridView2.SelectedCells[i].RowIndex);
                                A_橫 = Convert.ToUInt16(dataGridView2.SelectedCells[i].ColumnIndex);
                            }
                            temp_text = dataGridView2[A_橫, A_直].Value.ToString();
                            搜尋資料();
                        }
                        else
                        {
                            MessageBox.Show("未選取所搜尋的對象");
                        }
                       
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("ㄌㄩㄝ~~_(┐「﹃ﾟ｡)_");
            }
        }

        private void textBox_輸入資料_TextChanged(object sender, EventArgs e)
       {
            try
            {
                timedate = new string[20];
                dataGridView2.Rows.Clear();
                int Z = 0;
                timedate = textBox_輸入資料.Text.Split();
                整理暫存陣列();           //
               
            foreach (string item in timedate)
            {
                dataGridView2[Z, 0].Value = item;
                Z++;
                    if (Z == 12)
                    {
                        break;
                    }
            }
                if (dataGridView2[2,0].Value != null)
              {
                   dataGridView2[1,0].Value=dataGridView2[1, 0].Value.ToString() + dataGridView2[2, 0].Value.ToString();
              }
                
            }
            catch (Exception)
            {
                MessageBox.Show("資料過長");
            }
        }

        private void button_清空_Click(object sender, EventArgs e)
        {
            textBox_故障情形.Text = "";
            textBox_報修序號.Text = "";
            textBox_職編搜尋.Text = "";
            textBox_輸入資料.Text = "";
            textBox_部門.Text = "";
            textBox_分機.Text = "";
            dataGridView1.Rows.Clear();
            dataGridView2.Rows.Clear();
        }
        private void button_關閉_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        int A_頁數 = 0;
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {
                Font my_font = new Font("標楷體", 14);
                Font my_font1 = new Font("標楷體", 12);
                Font my_font3 = new Font("標楷體", 10);
                Font my_font4 = new Font("標楷體", 15);
                Font topefont = new Font("標楷體", 20, FontStyle.Bold);
                StringFormat sf = new StringFormat(); //置中
                sf.Alignment = StringAlignment.Center;
                sf.LineAlignment = StringAlignment.Center;
                StringFormat S_設備所在地 = new StringFormat();
                S_設備所在地.Alignment = StringAlignment.Center;
                S_設備所在地.LineAlignment = StringAlignment.Center;
                RectangleF A_維修處理情形 = new RectangleF(107, 673, 96, 205);
                RectangleF A_設備所在地 = new RectangleF(110, 331, 143, 45);
                RectangleF A_報修單位 = new RectangleF(203, 193, 183, 41);
                SolidBrush my_solidvrush = new SolidBrush(Color.FromArgb(255, 0, 0, 0));
                Pen pen = new Pen(Color.FromArgb(255, 0, 0, 0), 1);
                PrintDocument print = new PrintDocument();
                Graphics grap = e.Graphics;
                e.Graphics.PageUnit = GraphicsUnit.Display;
                Font A_A = new Font("標楷體", 20);

                Brush brush = Brushes.Black;

                if (A_頁數 == 0 && e.HasMorePages != true)
                {
                    grap.DrawString("基隆關電腦設備維修紀錄單", topefont, my_solidvrush, 213, 90);
                    grap.DrawString("維修紀錄單編號 :", my_font, my_solidvrush, 475, 167);
                    grap.DrawString(timedate[0].ToString(), my_font, my_solidvrush, 641, 167);
                    grap.DrawString("資訊叫修人員:", my_font, my_solidvrush, 550, 40);
                    grap.DrawString(timedate[11].ToString(), my_font, my_solidvrush, 685, 40);//資訊叫修人員
                    grap.DrawString("報修單位", my_font, my_solidvrush, 110, 205);
                    grap.DrawString(timedate[8].ToString(), my_font, my_solidvrush, A_報修單位, sf);//報修單位
                    grap.DrawString("報修日期", my_font1, my_solidvrush, 384, 195);
                    grap.DrawString("報修時間", my_font1, my_solidvrush, 384, 213);
                    grap.DrawString(dataGridView2[1, 0].Value.ToString(), my_font1, my_solidvrush, 462, 205);//報修日期
                    grap.DrawString("報修人", my_font, my_solidvrush, 123, 239);
                    grap.DrawString("海關編號", my_font1, my_solidvrush, 117, 269);
                    grap.DrawString(timedate[6].ToString(), my_font4, my_solidvrush, 230, 249);//海關
                    grap.DrawString(timedate[7].ToString(), my_font, my_solidvrush, 220, 269);//海關編號
                    RectangleF A_職稱 = new RectangleF(386, 233, 304, 63);
                    grap.DrawString("職稱", my_font, my_solidvrush, 329, 254);
                    grap.DrawString(timedate[9].ToString(), my_font, my_solidvrush, A_職稱, sf);//職稱
                    grap.DrawString("連絡電話", my_font, my_solidvrush, 110, 312);
                    grap.DrawString("2420-2951", my_font, my_solidvrush, 250, 312);//連絡電話
                    grap.DrawString("分機", my_font, my_solidvrush, 395, 312);
                    grap.DrawString(timedate[10].ToString(), my_font, my_solidvrush, 550, 312);//分機
                    grap.DrawString("故障類別", my_font, my_solidvrush, 110, 382);
                    grap.DrawString("硬體", my_font, my_solidvrush, 210, 360);
                    RectangleF A_硬體 = new RectangleF(262, 349, 194, 43);
                    grap.DrawString("Personal Computer", my_font, my_solidvrush, A_硬體, sf);//硬體
                    grap.DrawString("型號", my_font, my_solidvrush, 210, 402);
                    RectangleF A_型號 = new RectangleF(262, 392, 194, 43);
                    grap.DrawString(Column_品牌型號.DefaultCellStyle.NullValue.ToString(), my_font, my_solidvrush, A_型號, sf);//型號
                    grap.DrawString("廠牌", my_font, my_solidvrush, 463, 360);
                    RectangleF A_廠牌 = new RectangleF(515, 349, 175, 43);
                    grap.DrawString(Column_品牌序號.DefaultCellStyle.NullValue.ToString(), my_font, my_solidvrush, A_廠牌, sf);//廠牌
                    grap.DrawString("系統", my_font, my_solidvrush, 463, 402);
                    RectangleF A_系統 = new RectangleF(515, 392, 175, 43);
                    grap.DrawString(Column_作業系統.DefaultCellStyle.NullValue.ToString(), my_font3, my_solidvrush, A_系統, sf);// 系統
                    grap.DrawString("故障情形", my_font, my_solidvrush, 110, 525);
                    RectangleF A_故障情形 = new RectangleF(203, 435, 487, 195);
                    if (textBox_故障情形.Text.Length >= 1)
                    {
                        grap.DrawString(textBox_故障情形.Text, my_font, my_solidvrush, A_故障情形, sf);//故障情形
                    }
                    else
                    {
                        grap.DrawString(dataGridView2[5, 0].Value.ToString(), my_font, my_solidvrush, A_故障情形, sf);//故障情形
                    }
                    grap.DrawString("維修廠商", my_font, my_solidvrush, 110, 640);
                    RectangleF A_維修廠商 = new RectangleF(203, 630, 183, 43);
                    grap.DrawString(comboBox_維護廠商.Text, my_font1, my_solidvrush, A_維修廠商, sf);//維修廠商
                    grap.DrawString("維修工程師簽章", my_font, my_solidvrush, 395, 640);
                    Font f_維修工程師簽章 = new Font("標楷體", 24, FontStyle.Bold);
                    RectangleF A_維修工程師簽章 = new RectangleF(547, 630, 143, 43);
                    grap.DrawString(comboBox_工程師.Text, f_維修工程師簽章, my_solidvrush, A_維修工程師簽章, sf);//維修工程師簽章
                    grap.DrawString("維修處理情形", my_font, my_solidvrush, A_維修處理情形, sf);
                    grap.DrawString("到達", my_font, my_solidvrush, 130, 880);
                    DateTimeKind local = new DateTimeKind();
                    string datatime = local.ToString();
                    grap.DrawString("日期時間", my_font, my_solidvrush, 110, 900);
                    RectangleF A_到達日期 = new RectangleF(203, 878, 183, 43);
                    grap.DrawString(時間盒子, my_font1, my_solidvrush, A_到達日期, sf);//到達
                    grap.DrawString("修復", my_font, my_solidvrush, 410, 880);
                    grap.DrawString("日期時間", my_font, my_solidvrush, 389, 900);
                    grap.DrawString("報修人", my_font, my_solidvrush, 120, 970);
                    grap.DrawString("簽章", my_font, my_solidvrush, 130, 990);
                    grap.DrawString("資訊室", my_font, my_solidvrush, 310, 970);
                    grap.DrawString("人員", my_font, my_solidvrush, 320, 990);
                    grap.DrawString("資訊室", my_font, my_solidvrush, 480, 970);
                    grap.DrawString("股長", my_font, my_solidvrush, 490, 990);
                    e.Graphics.DrawLine(pen, 105, 190, 692, 190);//上外
                    e.Graphics.DrawLine(pen, 107, 192, 690, 192);//上內
                    e.Graphics.DrawLine(pen, 105, 190, 105, 1057);//左外
                    e.Graphics.DrawLine(pen, 107, 192, 107, 1055);//左內
                    e.Graphics.DrawLine(pen, 105, 1057, 692, 1057);//下外
                    e.Graphics.DrawLine(pen, 107, 1055, 690, 1055);//下內
                    e.Graphics.DrawLine(pen, 692, 1057, 692, 190);//右外
                    e.Graphics.DrawLine(pen, 690, 1055, 690, 192);//右內
                    e.Graphics.DrawLine(pen, 107, 233, 690, 233);//-1
                    e.Graphics.DrawLine(pen, 107, 296, 690, 296);//-2
                    e.Graphics.DrawLine(pen, 107, 349, 690, 349);//-3
                    e.Graphics.DrawLine(pen, 107, 435, 690, 435);//-4
                    e.Graphics.DrawLine(pen, 107, 630, 690, 630);//-5
                    e.Graphics.DrawLine(pen, 107, 673, 690, 673);//-6
                    e.Graphics.DrawLine(pen, 107, 878, 690, 878);//-7
                    e.Graphics.DrawLine(pen, 107, 921, 690, 921);//-8
                    e.Graphics.DrawLine(pen, 203, 192, 203, 1055);//|
                    e.Graphics.DrawLine(pen, 386, 192, 386, 349);//| 報休日期+職稱+分機
                    e.Graphics.DrawLine(pen, 456, 192, 456, 233);//報修日期 |
                    e.Graphics.DrawLine(pen, 456, 296, 456, 349);//|分機
                    e.Graphics.DrawLine(pen, 316, 233, 316, 296);//| 職稱
                    e.Graphics.DrawLine(pen, 203, 392, 690, 392);//硬體下____
                    e.Graphics.DrawLine(pen, 456, 349, 456, 435);// | 廠牌+系統
                    e.Graphics.DrawLine(pen, 262, 349, 262, 435);//硬體+型號 |
                    e.Graphics.DrawLine(pen, 515, 349, 515, 435);//廠牌+系統 |
                    e.Graphics.DrawLine(pen, 386, 630, 386, 673);// | 維修工程師
                    e.Graphics.DrawLine(pen, 547, 630, 547, 673);//維修工程師 |
                    e.Graphics.DrawLine(pen, 386, 878, 386, 921);//| 修復日期時間
                    e.Graphics.DrawLine(pen, 476, 878, 476, 921);//|
                    e.Graphics.DrawLine(pen, 301, 921, 301, 1055);//|
                    e.Graphics.DrawLine(pen, 379, 921, 379, 1055);//|
                    e.Graphics.DrawLine(pen, 476, 921, 476, 1055);//|
                    e.Graphics.DrawLine(pen, 555, 921, 555, 1055);//|
                    e.HasMorePages = true;
                    A_頁數++;
                }
                else
                {
                    grap.DrawString("資訊叫修人員:", my_font, my_solidvrush, 550, 40);
                    grap.DrawString(timedate[11].ToString(), my_font, my_solidvrush, 685, 40);//資訊叫修人員
                    grap.DrawString("電  腦  名  稱", my_font1, my_solidvrush, 119, 125);
                    grap.DrawString("財  產  編  號", my_font1, my_solidvrush, 119, 175);
                    grap.DrawString("使用人及海關編號", my_font1, my_solidvrush, 110, 219);
                    grap.DrawString("設 備 所 在 地", my_font1, my_solidvrush, 119, 265);
                    grap.DrawString(Column_電腦名稱.DefaultCellStyle.NullValue.ToString(), my_font, my_solidvrush, 259, 125);
                    grap.DrawString(Column_財產編號.DefaultCellStyle.NullValue.ToString(), my_font, my_solidvrush, 259, 175);
                    grap.DrawString((dataGridView2[6, 0].Value.ToString() + dataGridView2[7, 0].Value.ToString()), my_font, my_solidvrush, 259, 219);
                    grap.DrawString(dataGridView2[8, 0].Value.ToString(), my_font, my_solidvrush, 259, 265);
                    e.Graphics.DrawLine(pen, 105, 110, 692, 110);//上外
                    e.Graphics.DrawLine(pen, 107, 112, 690, 112);//上內
                    e.Graphics.DrawLine(pen, 105, 110, 105, 298);//左外
                    e.Graphics.DrawLine(pen, 107, 112, 107, 296);//左內
                    e.Graphics.DrawLine(pen, 105, 298, 692, 298);//下外
                    e.Graphics.DrawLine(pen, 107, 296, 690, 296);//下內
                    e.Graphics.DrawLine(pen, 692, 298, 692, 110);//右外
                    e.Graphics.DrawLine(pen, 690, 296, 690, 112);//右內
                    e.Graphics.DrawLine(pen, 107, 157, 690, 157);//--
                    e.Graphics.DrawLine(pen, 107, 204, 690, 204);//--
                    e.Graphics.DrawLine(pen, 107, 251, 690, 251);//--
                    e.Graphics.DrawLine(pen, 251, 112, 251, 296);//|
                    e.HasMorePages = false;
                    A_頁數 = 0;

                }
            }
            catch
            {
                MessageBox.Show("ERROR");
            }
        }
        private void printPreviewButton_Click(object sender, EventArgs e)  //選印表機
        {
            PrintDialog print_dialog = new PrintDialog();
            print_dialog.Document = printDocument1;

            if (print_dialog.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
            else
            {
            }
        }
        private ToolStripButton C_列印 = new ToolStripButton();
       
        private void button_預覽_Click(object sender, EventArgs e)
        {
            
            if (timedate.Length >=11)
            {
                填補暫存陣列();
                if (timedate[11] != "")
            {
                if (comboBox_工程師.Text.Length >= 2)
                {
                    if (comboBox_維護廠商.Text.Length >= 2)
                    {
                         
                        C_列印.Text = "  列印";
                            C_列印.Click -= printPreviewButton_Click;
                            C_列印.Click += printPreviewButton_Click;
                            ((ToolStrip)printPreviewDialog1.Controls[1]).Items[0].Visible = false;
                        ((ToolStrip)printPreviewDialog1.Controls[1]).Items.Insert(1, C_列印);
                        PrintDialog open_print = new PrintDialog();
                        open_print.AllowCurrentPage = true;
                        open_print.AllowSelection = true;
                        printDocument1.DefaultPageSettings.PaperSize = new PaperSize("1", 826, 1169);
                        printDocument1.DefaultPageSettings.Margins = new Margins(1, 1, 1, 1);
                        printPreviewDialog1.Document = printDocument1;
                        printPreviewDialog1.PrintPreviewControl.Zoom = 0.8;
                        printPreviewDialog1.MouseWheel += PrintPreviewDialog1_MouseWheel;
                        printPreviewDialog1.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("未選擇維護廠商");
                    }
                }
                else
                {
                    MessageBox.Show("未選擇工程師");
                }
               
            }
            else
            {
                MessageBox.Show("資料有誤");
            }
         }
         else
         {
                MessageBox.Show("資料有缺");
            }
        }
        private void PrintPreviewDialog1_MouseWheel(object sender, MouseEventArgs e)
        {                                                                               //控制滑鼠滾輪上下頁
            int x = 0,y = 0;
            if (e.Delta < 0)
            {
                y++;
                printPreviewDialog1.PrintPreviewControl.StartPage = y;
            }
            else
            {
                if (printPreviewDialog1.PrintPreviewControl.StartPage != 0)
                {
                    printPreviewDialog1.PrintPreviewControl.StartPage = x - y;
                }
            }
        }
        string 時間盒子;
        private void timer_時間_Tick(object sender, EventArgs e)
         {
            時間盒子 =(DateTimeOffset.Now.Month.ToString())+ "/"+(DateTimeOffset.Now.Day.ToString())+" "+(DateTime.Now.ToShortTimeString().ToString());
            label1_時間.Text = DateTime.Now.ToString();
        }


        private void 關於ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("注意!!!工程師自用請物外流!!");
        }
        private void A_取得行數獨立()
        {
            string temp = "";
            StringReader stringReader = new StringReader(報修單程式.Properties.Resources.資料);
            do
            {
                temp = stringReader.ReadLine();
                A_取得行數++;
            } while (temp != null);
            stringReader.Dispose();
            stringReader.Close();
            Array.Resize(ref userdate, A_取得行數 - 1);
        }
        private void Form_維修單_Load(object sender, EventArgs e)
        {
            
            try
            {
                string str_維護廠商text = "";
                StringReader str_維護廠商 = new StringReader(報修單程式.Properties.Resources.維護廠商);
                do
                {
                    str_維護廠商text = str_維護廠商.ReadLine();
                    if (str_維護廠商text == null)
                    {
                        break;
                    }
                    comboBox_維護廠商.Items.Add(str_維護廠商text);
                } while (str_維護廠商text != null);
                str_維護廠商.Dispose();
                str_維護廠商.Close();
                //----------------------------以下為工程師名單讀取--------------------
                string str_工程師名單text = "";
                StringReader str_工程師名單 = new StringReader(報修單程式.Properties.Resources.工程師名單);
                do
                {
                    str_工程師名單text = str_工程師名單.ReadLine();
                    if (str_工程師名單text == null)
                    {
                        break;
                    }
                    comboBox_工程師.Items.Add(str_工程師名單text);
                } while (str_工程師名單text != null);
                str_工程師名單.Dispose();
                str_工程師名單.Close();
                //-------------------------以下為讀取TXT文件當做資料庫-----------------------------------------
                int X = 0;
                string rex = "";
                A_取得行數獨立();   //讀取資料!!!
                StringReader stringReader = new StringReader(報修單程式.Properties.Resources.資料);
                do
                {
                    rex = stringReader.ReadLine();
                    if (rex == null)
                    {
                        break;
                    }
                    userdate[X] = rex.ToString();
                    X++;
                } while (rex != null);
                
               int xxx= userdate.GetUpperBound(0);
                label1_資料庫日期.Text = userdate[xxx].ToString()+")";
                stringReader.Dispose();
                stringReader.Close();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
