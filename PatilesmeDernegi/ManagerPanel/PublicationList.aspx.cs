using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PatilesmeDernegi.ManagerPanel
{
    public partial class PublicationList : System.Web.UI.Page
    {
        DataModel dm = new DataModel();
        protected void Page_Load(object sender, EventArgs e)
        {
            lv_publist.DataSource = dm.PublicationList();
            lv_publist.DataBind();

        }

      
      
    }
}