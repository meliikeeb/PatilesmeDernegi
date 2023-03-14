using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace PatilesmeDernegi.ManagerPanel
{
    public partial class PublicationAdd : System.Web.UI.Page
    {
        DataModel dm = new DataModel();
        //Publication p = new Publication();
       
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ddl_AnimalKategory.DataValueField = "ID";
                ddl_AnimalKategory.DataTextField = "Name";
                ddl_AnimalKategory.DataSource = dm.ListAnimalKategory();
                ddl_AnimalKategory.DataBind();
            }
        }
       

        protected void lbtn_ekle_Click(object sender, EventArgs e)
        {

            if (Convert.ToInt32(ddl_AnimalKategory.SelectedItem.Value) != 0)
            {
                Publication p = new Publication();
                p.Title = tb_title.Text;
                p.Content = tb_content.Text;
                p.AnimalKategory_ID =Convert.ToInt32(ddl_AnimalKategory.SelectedItem.Value);
                p.Date = DateTime.Now;
                if (fu_resim.HasFile)
                {
                    FileInfo fi = new FileInfo(fu_resim.FileName);
                    if (fi.Extension == ".jpg" || fi.Extension == ".png")
                    {
                        string uzanti = fi.Extension;
                        string isim = Guid.NewGuid().ToString();
                        p.Images = isim + uzanti;
                        fu_resim.SaveAs(Server.MapPath("~/ManagerPanel/Assets/Images/" + isim + uzanti));
                        if (dm.PublicationAdd(p))
                        {
                            pnl_basarisiz.Visible = false;
                            pnl_basarili.Visible = true;
                            tb_title.Text = tb_content.Text;
                            ddl_AnimalKategory.SelectedValue = "1";
                        }
                        else
                        {
                            pnl_basarisiz.Visible = true;
                            pnl_basarili.Visible = false;
                            lbl_mesaj.Text = "İlan Ekleme Başarısız";
                        }
                    }
                    else
                    {
                        pnl_basarisiz.Visible = true;
                        pnl_basarili.Visible = false;
                        lbl_mesaj.Text = "Resim uzantısı sadece .jpg veya .png olmalıdır";
                    }
                }
                else
                {
                    p.Images = "none.png";
                    if (dm.PublicationAdd(p))
                    {

                        pnl_basarisiz.Visible = false;
                        pnl_basarili.Visible = true;
                        tb_title.Text = tb_content.Text;
                        ddl_AnimalKategory.SelectedValue="0";  
                    }
                    else
                    {
                        pnl_basarisiz.Visible = true;
                        pnl_basarili.Visible = false;
                        lbl_mesaj.Text = "İlan Ekleme Başarısız";
                    }
                }
            }
            else
            {
                pnl_basarisiz.Visible = true;
                pnl_basarili.Visible = false;
                lbl_mesaj.Text = "İlan seçimi yapmalısınız";
            }
        }
    }
}