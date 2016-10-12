using System;

namespace MHG.AspNet.CustomErrorPage
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            throw new Exception("500 hatası oluşturmak için exception oluşturuluyor.");
        }
    }
}