using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using localhost;
public partial class index : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["pseudo"] != null && Session["password"] != null)
        {
            lblLogged.Text = "Bienvenue: " + Session["pseudo"].ToString();
            linkIndex.Visible = false;
            linklogin.Visible = false;
            lblLog.Text = "<a href=\"logout.aspx\">Deconnexion</a>";
            //lblLog.Text = "<asp:HyperLink ID=\"linklogin\" NavigateUrl=\"logout.aspx\" ToolTip=\"AccessKey: l\" accesskey=\"l\" runat=\"server\">Connexion</asp:HyperLink>";
        }
            
        else
        {
            //lblLogged.Text +="<br/> Identifiez-vous" ;
            linkIndex.Visible = true;
            linklogin.Visible = true;
            lblLog.Text = "<a href=\"login.aspx\">Connexion</a>";
            //lblLog.Text = "<asp:HyperLink ID=\"linklogin\" NavigateUrl=\"login.aspx\" ToolTip=\"AccessKey: l\" accesskey=\"l\" runat=\"server\">Connexion</asp:HyperLink>";
                
        }

    }
}
