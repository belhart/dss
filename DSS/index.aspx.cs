using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.IO;
using System.Data;

namespace DSS
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void ImportCSV(object sender, EventArgs e)
        {
            string csvPath = Server.MapPath("~/Files/") + Path.GetFileName(FileUpload1.PostedFile.FileName);
            FileUpload1.SaveAs(csvPath);
            string csvData = File.ReadAllText(csvPath);
            Processor folyamat = new Processor();
            foreach (string row in csvData.Split('\n'))
            {
                if (!string.IsNullOrEmpty(row))
                {
                    Debug.WriteLine(row);
                    folyamat.orders.Add(new Order(row.Split(',')));
                }
            }
            Debug.WriteLine(folyamat.orders);
            //rendezés sorrendbe


            //Bind the DataTable.
        }

    }
}