﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;
using _Excel = Microsoft.Office.Interop.Excel;

namespace Advent
{
    class Excel
    {
        string path = "";
        _Application excel = new _Excel.Application();
        Workbook wb;
        Worksheet ws;
        public Excel(string path, int sheet)
        {
            this.path = path;
            wb = excel.Workbooks.Open(path);
            ws = wb.Worksheets[sheet];
        }

        public string ReadCell(int i, int j)
        {
            i++;
            j++;
            var values = new List<string>();
            
            if (ws.Cells[i, j].Value2 != null)
            {
                values.Add(Convert.ToString(ws.Cells[i,j].Value2));
                //return ws.Cells[i, j].Value2;
            }

            var u = values.FirstOrDefault();

            return u;
            /*else
                return "";*/
        }
    }
}
