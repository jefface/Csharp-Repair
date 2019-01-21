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
    public partial class Form_維護廠商 : Form
    {
        private Form_維修單 sr;
        public Form_維護廠商(Form_維修單 form_維修單)
        {
            sr = form_維修單;
            InitializeComponent();
        }

        private void button_加入_Click(object sender, EventArgs e)
        {
            if (textBox_維護廠商輸入.Text.Length >= 1)
            {
                listBox_維護廠商名單.Items.Add(textBox_維護廠商輸入.Text);
                textBox_維護廠商輸入.Text = "";
            }
            else
            {
                MessageBox.Show("無輸入維護廠商訊息");
            }
            
        }

        private void button_移除_Click(object sender, EventArgs e)
        {
            
            if (listBox_維護廠商名單.SelectedIndex >= 0)
            {
                listBox_維護廠商名單.Items.RemoveAt(listBox_維護廠商名單.SelectedIndex);
            }
            else
            {
                MessageBox.Show("未選取刪除項目");
            }
        }

        private void button_確認_Click(object sender, EventArgs e)
        {
            string[] date = new string[listBox_維護廠商名單.Items.Count];
            sr.comboBox_維護廠商.Items.Clear();
            listBox_維護廠商名單.Items.CopyTo(date, 0);
            sr.comboBox_維護廠商.Items.AddRange(date);
            if (listBox_維護廠商名單.Items.Count >= 0)
            {
                Form_維護廠商.ActiveForm.Close();
            }
            else
            {
                MessageBox.Show("維護廠商名單至少留一位");
            }
            
        }

        private void button_取消_Click(object sender, EventArgs e)
        {
            Form_維護廠商.ActiveForm.Close();
        }
    }
}
