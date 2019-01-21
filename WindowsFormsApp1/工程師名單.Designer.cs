namespace WindowsFormsApp1
{
    partial class Form_工程師名單
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_加入 = new System.Windows.Forms.Button();
            this.button_移除 = new System.Windows.Forms.Button();
            this.button_確認 = new System.Windows.Forms.Button();
            this.button_取消 = new System.Windows.Forms.Button();
            this.listBox_工程師名單 = new System.Windows.Forms.ListBox();
            this.textBox_姓名 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_加入
            // 
            this.button_加入.Location = new System.Drawing.Point(233, 113);
            this.button_加入.Name = "button_加入";
            this.button_加入.Size = new System.Drawing.Size(84, 59);
            this.button_加入.TabIndex = 1;
            this.button_加入.Text = "加入";
            this.button_加入.UseVisualStyleBackColor = true;
            this.button_加入.Click += new System.EventHandler(this.button_加入_Click);
            // 
            // button_移除
            // 
            this.button_移除.Location = new System.Drawing.Point(233, 187);
            this.button_移除.Name = "button_移除";
            this.button_移除.Size = new System.Drawing.Size(84, 62);
            this.button_移除.TabIndex = 2;
            this.button_移除.Text = "移除";
            this.button_移除.UseVisualStyleBackColor = true;
            this.button_移除.Click += new System.EventHandler(this.button_移除_Click);
            // 
            // button_確認
            // 
            this.button_確認.Location = new System.Drawing.Point(233, 282);
            this.button_確認.Name = "button_確認";
            this.button_確認.Size = new System.Drawing.Size(84, 32);
            this.button_確認.TabIndex = 3;
            this.button_確認.Text = "確認";
            this.button_確認.UseVisualStyleBackColor = true;
            this.button_確認.Click += new System.EventHandler(this.button_確認_Click);
            // 
            // button_取消
            // 
            this.button_取消.Location = new System.Drawing.Point(233, 320);
            this.button_取消.Name = "button_取消";
            this.button_取消.Size = new System.Drawing.Size(84, 32);
            this.button_取消.TabIndex = 4;
            this.button_取消.Text = "取消";
            this.button_取消.UseVisualStyleBackColor = true;
            this.button_取消.Click += new System.EventHandler(this.button_取消_Click);
            // 
            // listBox_工程師名單
            // 
            this.listBox_工程師名單.FormattingEnabled = true;
            this.listBox_工程師名單.ItemHeight = 12;
            this.listBox_工程師名單.Location = new System.Drawing.Point(13, 13);
            this.listBox_工程師名單.Name = "listBox_工程師名單";
            this.listBox_工程師名單.Size = new System.Drawing.Size(189, 364);
            this.listBox_工程師名單.TabIndex = 5;
            // 
            // textBox_姓名
            // 
            this.textBox_姓名.AllowDrop = true;
            this.textBox_姓名.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_姓名.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox_姓名.Location = new System.Drawing.Point(208, 38);
            this.textBox_姓名.Name = "textBox_姓名";
            this.textBox_姓名.Size = new System.Drawing.Size(123, 33);
            this.textBox_姓名.TabIndex = 6;
            this.textBox_姓名.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(208, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "姓名:";
            // 
            // Form_工程師名單
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 395);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_姓名);
            this.Controls.Add(this.listBox_工程師名單);
            this.Controls.Add(this.button_取消);
            this.Controls.Add(this.button_確認);
            this.Controls.Add(this.button_移除);
            this.Controls.Add(this.button_加入);
            this.Name = "Form_工程師名單";
            this.Text = "工程師名單";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_加入;
        private System.Windows.Forms.Button button_移除;
        private System.Windows.Forms.Button button_確認;
        private System.Windows.Forms.Button button_取消;
        public System.Windows.Forms.ListBox listBox_工程師名單;
        private System.Windows.Forms.TextBox textBox_姓名;
        private System.Windows.Forms.Label label1;
    }
}