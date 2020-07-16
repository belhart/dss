using System;
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
            foreach (string row in csvData.Split('\n'))
            {
                if (!string.IsNullOrEmpty(row))
                {
                    System.Diagnostics.Debug.WriteLine(row);
                    Folyamat folyamat = new Folyamat();
                    Megrendeles megrendelesTeszt = new Megrendeles(row.Split(','));
                    if (megrendelesTeszt.MegrendelesTipus == 0) {folyamat.GYB(megrendelesTeszt.MegrendelesSzam); folyamat.Kiir(); break; }
                    if (megrendelesTeszt.MegrendelesTipus == 1) {folyamat.GYB(megrendelesTeszt.MegrendelesSzam); folyamat.Kiir(); break; }
                    else {folyamat.GYB(megrendelesTeszt.MegrendelesSzam); folyamat.Kiir(); break; }

                }
                break;
            }

            //Bind the DataTable.
        }

    }
}