using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PatilesmeDernegi.ManagerPanel
{
    public partial class ManagerLogin : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Manager"] !=null)
            {
                Manager m = (Manager)Session["Manager"];
                lbl_kullanici.Text = m.Name + "(" + m.ID + ")"; 
            }
          
        }


        protected void lbtn_cikis_Click(object sender, EventArgs e)
        {
            Session["manager"] = null;
            Response.Redirect("ManagerLogin.aspx");
        }

       
    }
}