namespace ExcelAddIn1
{
    partial class NbdcdTools : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public NbdcdTools()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

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
            this.NbdcdToolTab = this.Factory.CreateRibbonTab();
            this.exportGrp = this.Factory.CreateRibbonGroup();
            this.dbfExport = this.Factory.CreateRibbonButton();
            this.NbdcdToolTab.SuspendLayout();
            this.exportGrp.SuspendLayout();
            this.SuspendLayout();
            // 
            // NbdcdToolTab
            // 
            this.NbdcdToolTab.Groups.Add(this.exportGrp);
            this.NbdcdToolTab.Label = "宁波调查队";
            this.NbdcdToolTab.Name = "NbdcdToolTab";
            // 
            // exportGrp
            // 
            this.exportGrp.Items.Add(this.dbfExport);
            this.exportGrp.Label = "导出";
            this.exportGrp.Name = "exportGrp";
            // 
            // dbfExport
            // 
            this.dbfExport.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.dbfExport.Image = global::ExcelAddIn1.Properties.Resources.dbf_black;
            this.dbfExport.Label = "导出DBF";
            this.dbfExport.Name = "dbfExport";
            this.dbfExport.ShowImage = true;
            this.dbfExport.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.open_DbfExportTaskPane);
            // 
            // NbdcdTools
            // 
            this.Name = "NbdcdTools";
            this.RibbonType = "Microsoft.Excel.Workbook";
            this.Tabs.Add(this.NbdcdToolTab);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.NbdcdTools_Load);
            this.NbdcdToolTab.ResumeLayout(false);
            this.NbdcdToolTab.PerformLayout();
            this.exportGrp.ResumeLayout(false);
            this.exportGrp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup exportGrp;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton dbfExport;
        internal Microsoft.Office.Tools.Ribbon.RibbonTab NbdcdToolTab;
    }

    partial class ThisRibbonCollection
    {
        internal NbdcdTools NbdcdTools
        {
            get { return this.GetRibbon<NbdcdTools>(); }
        }
    }
}
