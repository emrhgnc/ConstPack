using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataLayer;
using EntityLayer;

namespace ConstPack
{
    public partial class MainMaster : System.Web.UI.MasterPage
    {
        KullaniciData kd = new KullaniciData();
        ProjeData pd = new ProjeData();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}