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

using Commerce.Abstract.Dao;
using Commerce.Dal.Mapper;
using Commerce.Metier.Entite;
using Spring.Data.Generic;
using Spring.Data.Common;
using System.Data;

/// <summary>
/// Description résumée de AdresseDal
/// </summary>
/// 
namespace Commerce.Dal
{
    public class AdresseDal : AdoDaoSupport, IAdresseDao
    {
        #region IArticleDao Membres

        public Article GetByReference(string reference)
        {
            string query = "SELECT * FROM ARTICLE WHERE REFERENCE = @reference";

            IDbParameters parameters = CreateDbParameters();
            parameters.Add("reference", DbType.String).Value = reference;

            return AdoTemplate.QueryForObject<Article>(System.Data.CommandType.Text, query,
                new ArticleRowMapper(), parameters);
        }

        #endregion
    }
}