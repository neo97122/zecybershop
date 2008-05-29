using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

using Commerce.Metier.Entite;

/// <summary>
/// Description résumée de IArticleDao
/// </summary>
/// 
namespace Commerce.Abstract.Dao
{
    public interface IArticleDao
    {
        Article GetByReference(string reference);
    }
}