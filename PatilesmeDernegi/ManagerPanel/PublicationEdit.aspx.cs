using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PatilesmeDernegi.ManagerPanel
{

    public partial class PublicationEdit : System.Web.UI.Page
    {
        DataModel dm = new DataModel();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString.Count != 0)
            {
                if (!IsPostBack)
                {
                    int id = Convert.ToInt32(Request.QueryString["pid"]);
                    ddl_Publication.DataTextField = "Title";
                    ddl_Publication.DataValueField = "ID";
                    ddl_Publication.DataSource = dm.PublicationList();
                    ddl_Publication.DataBind();

                    Publication p = dm.PublicationBring(id);

                    ddl_Publication.SelectedValue = p.AnimalKategory_ID.ToString();
                    tb_title.Text = p.Title;
                    tb_content.Text = p.Content;


                }
            }
            else
            {
                Response.Redirect("PublicationList.aspx");
            }
        }

        protected void lbtn_duzenle_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["pid"]);
            Publication p = dm.PublicationBring(id);
            p.AnimalKategory_ID = Convert.ToInt32(ddl_Publication.SelectedItem.Value);
            p.Title = tb_title.Text;
            p.Content= tb_content.Text ;
            if (fu_resim.HasFile)
            {
                FileInfo fi = new FileInfo(fu_resim.FileName);
                if (fi.Extension == ".jpg" || fi.Extension == ".png")
                {
                    string uzanti = fi.Extension;
                    string isim = Guid.NewGuid().ToString();
                    p.Images = isim + uzanti;
                    fu_resim.SaveAs(Server.MapPath("../ManagerPanel/Assets/Images/" + isim + uzanti));
                }
                else
                {
                    pnl_basarisiz.Visible = true;
                    pnl_basarili.Visible = false;
                    lbl_mesaj.Text = "Resim uzantısı sadece .jpg veya .png olmalıdır";
                }
            }
            if (dm.PublicationEdit(p))
            {
                pnl_basarisiz.Visible = false;
                pnl_basarili.Visible = true;
                tb_title.Text = tb_content.Text = "";
                ddl_Publication.SelectedValue = "0";
            }
            else
            {
                pnl_basarisiz.Visible = true;
                pnl_basarili.Visible = false;
                lbl_mesaj.Text = "İlan Düzenleme Başarısız";
            }

        }
    }
}