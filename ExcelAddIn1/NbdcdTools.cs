using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools;
using Microsoft.Office.Tools.Ribbon;

namespace ExcelAddIn1
{
    public partial class NbdcdTools
    {
        private UC_DbfExport ucDbfExport;
        private CustomTaskPane ucDbfCustomTaskPane;
        private void NbdcdTools_Load(object sender, RibbonUIEventArgs e)
        {

        }

        private void open_DbfExportTaskPane(object sender, RibbonControlEventArgs e)
        {
            if (ucDbfExport == null)
            {
                ucDbfExport = new UC_DbfExport();
            }

            if (ucDbfCustomTaskPane == null)
            {
                ucDbfCustomTaskPane = Globals.ThisAddIn.CustomTaskPanes.Add(ucDbfExport, "DBF导出任务");
                ucDbfCustomTaskPane.Width = 300;
            }

            ucDbfCustomTaskPane.Visible = !ucDbfCustomTaskPane.Visible;
        }
    }
}
