using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Office.Interop.Excel;

namespace RandomGenerator
{
    public class Export
    {
        dynamic excel = null;

        public Export()
        {
            this.excel = new Application { Visible = false };
        }
        
        public Export(ICollection<object> excelSheet)
        {

        }


        public void CreateBlankExcel()
        {
            var blankExcel = this.excel.Worksheets.Add();
            blankExcel.Activate();
        }
    }
}
