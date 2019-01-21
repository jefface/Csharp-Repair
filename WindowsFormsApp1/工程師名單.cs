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
   
    public partial class Form_工程師名單 : Form
    {
        private Form_維修單 form;
        public Form_工程師名單(Form_維修單 form_維修單)
        {
            form = form_維修單;
            InitializeComponent();
        }

        private void button_加入_Click(object sender, EventArgs e)
        {
            if (textBox_姓名.Text.Length >= 1)
            {
                listBox_工程師名單.Items.Add(textBox_姓名.Text);
                textBox_姓名.Text = "";
            }
            else
            {
                MessageBox.Show("未打名字");
            }
           
        }

        private void button_移除_Click(object sender, EventArgs e)
        {

            if (listBox_工程師名單.SelectedIndex >= 0)
            {
                listBox_工程師名單.Items.RemoveAt(listBox_工程師名單.SelectedIndex);
            }
            else
            {
                MessageBox.Show("未選取刪除項目");
            }
            
        }

        private void button_確認_Click(object sender, EventArgs e)
        {
            string[] ar =new string[listBox_工程師名單.Items.Count];
            form.comboBox_工程師.Items.Clear();
            listBox_工程師名單.Items.CopyTo(ar, 0);
            form.comboBox_工程師.Items.AddRange(ar);
            if (listBox_工程師名單.Items.Count >= 0)
            {
                Form_工程師名單.ActiveForm.Close();
            }
            else
            {
                MessageBox.Show("名單至少一個名子");
            }
            
        }

        private void button_取消_Click(object sender, EventArgs e)
        {
            Form_工程師名單.ActiveForm.Close();
        }
    }
}
