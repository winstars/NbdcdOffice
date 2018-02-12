namespace ExcelAddIn1
{
    partial class UC_DbfExport
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.fileChooseBtn = new System.Windows.Forms.Button();
            this.dbfExportActionBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(21, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(212, 21);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // fileChooseBtn
            // 
            this.fileChooseBtn.Location = new System.Drawing.Point(21, 69);
            this.fileChooseBtn.Name = "fileChooseBtn";
            this.fileChooseBtn.Size = new System.Drawing.Size(100, 23);
            this.fileChooseBtn.TabIndex = 1;
            this.fileChooseBtn.Text = "文件选择";
            this.fileChooseBtn.UseVisualStyleBackColor = true;
            this.fileChooseBtn.Click += new System.EventHandler(this.fileChooseBtn_Click);
            // 
            // dbfExportActionBtn
            // 
            this.dbfExportActionBtn.Location = new System.Drawing.Point(138, 69);
            this.dbfExportActionBtn.Name = "dbfExportActionBtn";
            this.dbfExportActionBtn.Size = new System.Drawing.Size(95, 23);
            this.dbfExportActionBtn.TabIndex = 2;
            this.dbfExportActionBtn.Text = "开始导出";
            this.dbfExportActionBtn.UseVisualStyleBackColor = true;
            this.dbfExportActionBtn.Click += new System.EventHandler(this.dbfExportActionBtn_Click);
            // 
            // UC_DbfExport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dbfExportActionBtn);
            this.Controls.Add(this.fileChooseBtn);
            this.Controls.Add(this.textBox1);
            this.Name = "UC_DbfExport";
            this.Size = new System.Drawing.Size(246, 550);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button fileChooseBtn;
        private System.Windows.Forms.Button dbfExportActionBtn;
    }
}
