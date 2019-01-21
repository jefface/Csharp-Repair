namespace WindowsFormsApp1
{
    partial class Form_維護廠商
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
            this.listBox_維護廠商名單 = new System.Windows.Forms.ListBox();
            this.button_加入 = new System.Windows.Forms.Button();
            this.button_移除 = new System.Windows.Forms.Button();
            this.button_確認 = new System.Windows.Forms.Button();
            this.button_取消 = new System.Windows.Forms.Button();
            this.textBox_維護廠商輸入 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listBox_維護廠商名單
            // 
            this.listBox_維護廠商名單.FormattingEnabled = true;
            this.listBox_維護廠商名單.ItemHeight = 12;
            this.listBox_維護廠商名單.Location = new System.Drawing.Point(6, 7);
            this.listBox_維護廠商名單.Name = "listBox_維護廠商名單";
            this.listBox_維護廠商名單.Size = new System.Drawing.Size(522, 184);
            this.listBox_維護廠商名單.TabIndex = 0;
            // 
            // button_加入
            // 
            this.button_加入.Location = new System.Drawing.Point(6, 307);
            this.button_加入.Name = "button_加入";
            this.button_加入.Size = new System.Drawing.Size(105, 59);
            this.button_加入.TabIndex = 1;
            this.button_加入.Text = "加入";
            this.button_加入.UseVisualStyleBackColor = true;
            this.button_加入.Click += new System.EventHandler(this.button_加入_Click);
            // 
            // button_移除
            // 
            this.button_移除.Location = new System.Drawing.Point(145, 307);
            this.button_移除.Name = "button_移除";
            this.button_移除.Size = new System.Drawing.Size(105, 59);
            this.button_移除.TabIndex = 2;
            this.button_移除.Text = "移除";
            this.button_移除.UseVisualStyleBackColor = true;
            this.button_移除.Click += new System.EventHandler(this.button_移除_Click);
            // 
            // button_確認
            // 
            this.button_確認.Location = new System.Drawing.Point(289, 381);
            this.button_確認.Name = "button_確認";
            this.button_確認.Size = new System.Drawing.Size(105, 59);
            this.button_確認.TabIndex = 3;
            this.button_確認.Text = "確認";
            this.button_確認.UseVisualStyleBackColor = true;
            this.button_確認.Click += new System.EventHandler(this.button_確認_Click);
            // 
            // button_取消
            // 
            this.button_取消.Location = new System.Drawing.Point(400, 381);
            this.button_取消.Name = "button_取消";
            this.button_取消.Size = new System.Drawing.Size(105, 59);
            this.button_取消.TabIndex = 4;
            this.button_取消.Text = "取消";
            this.button_取消.UseVisualStyleBackColor = true;
            this.button_取消.Click += new System.EventHandler(this.button_取消_Click);
            // 
            // textBox_維護廠商輸入
            // 
            this.textBox_維護廠商輸入.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox_維護廠商輸入.Location = new System.Drawing.Point(12, 204);
            this.textBox_維護廠商輸入.Name = "textBox_維護廠商輸入";
            this.textBox_維護廠商輸入.Size = new System.Drawing.Size(515, 27);
            this.textBox_維護廠商輸入.TabIndex = 5;
            // 
            // Form_維護廠商
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 452);
            this.Controls.Add(this.textBox_維護廠商輸入);
            this.Controls.Add(this.button_取消);
            this.Controls.Add(this.button_確認);
            this.Controls.Add(this.button_移除);
            this.Controls.Add(this.button_加入);
            this.Controls.Add(this.listBox_維護廠商名單);
            this.Name = "Form_維護廠商";
            this.Text = "維護廠商";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_加入;
        private System.Windows.Forms.Button button_移除;
        private System.Windows.Forms.Button button_確認;
        private System.Windows.Forms.Button button_取消;
        public System.Windows.Forms.ListBox listBox_維護廠商名單;
        private System.Windows.Forms.TextBox textBox_維護廠商輸入;
    }
}