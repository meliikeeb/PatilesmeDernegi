using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Security.Policy;
using DataAccessLayer;

namespace PatilesmeDernegi.ManagerPanel
{
    public partial class ManagerLogin1 : System.Web.UI.Page
    {
        DataModel dm = new DataModel();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void lbtn_giris_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tb_mail.Text) && !string.IsNullOrEmpty(tb_password.Text))
            {
                Manager m = dm.ManagerLogin(tb_mail.Text, tb_password.Text);
                if (m != null)
                {
                    if (m.Status)
                    {
                        Session["manager"] = m;
                        Response.Redirect("Default.aspx");

                    }
                    else
                    {
                        pnl_hata.Visible = true;
                        lbl_hata.Text = "Kullanıcı Hesabınız Aktif değil";
                    }
                }
                else
                {
                    pnl_hata.Visible = true;
                    lbl_hata.Text = "Kullanıcı Bulunamadı";
                }
            }
            else
            {
                pnl_hata.Visible = true;
                lbl_hata.Text = "Kullanıcı Adı ve Şifre Boş olamaz";
            }
        }
    }
}