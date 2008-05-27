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

using Spring.Data.Generic;
using Commerce.Metier.Entite;

/// <summary>
/// Description résumée de AdresseRowData
/// </summary>
/// 
namespace Commerce.Dal.Mapper
{
    public class AdresseRowData : IRowMapper<Article>
    {
        #region IRowMapper Membres

        public Article MapRow(IDataReader reader, int rowNum)
        {
            Article article = new Article();
            article.Reference = (string)reader["REFERENCE"];
            article.PrixUnitaire = (int)reader["PU"];
            article.QuantiteStock = (int)reader["QTESTOCK"];
            return article;
        }

        #endregion
    }
}