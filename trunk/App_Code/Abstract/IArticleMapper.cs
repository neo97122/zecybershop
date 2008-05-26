using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Collections.Generic;
using System.Text;

using Commerce.Metier.Entite;
/// <summary>
/// Description résumée de IArticleMapper
/// </summary>
/// 
namespace Commerce.Abstract
{
    interface IArticleMapper
    {
        Article GetById(string id);
        Article GetByCategorie(string categorie);
        int GetCount();

    }
}
