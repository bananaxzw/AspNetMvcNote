using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace WebApplication1
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string s="";
            if (IsPostBack)
            {
                TextReader reader = new StreamReader(Request.InputStream);
                while (reader.Read()>=0)
                {
                  s+=reader.ReadLine();
                }
            }
            Response.Write(s);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}
