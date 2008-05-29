using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

/// <summary>
/// Description résumée de ArticleDAO
/// </summary>
/// 

namespace Commerce.DAO
{

    public class ArticleDal : AdoDaoSupport, IArticleDao
    {
        #region IArticleDao Membres


        //recupere article par reference
        public Article GetByReference(string reference)
        {
            string query = "SELECT * FROM articles WHERE REFERENCE = @reference";

            IDbParameters parameters = CreateDbParameters();
            parameters.Add("reference", DbType.String).Value = reference;

            return AdoTemplate.QueryForObject<Article>(System.Data.CommandType.Text, query,
                new ArticleRowMapper(), parameters);
        }


        //liste d article par categorie

        public IList<Article> GetByCategorie(string categorie)
        {
            string query = "SELECT * FROM articles WHERE categorie = @categorie";

            IDbParameters parameters = CreateDbParameters();
            parameters.Add("categorie", DbType.String).Value = categorie;

            return AdoTemplate.QueryWithRowMapper<Article>(System.Data.CommandType.Text, query,
                new ArticleRowData(), parameters);
        }

        //list article par marque

        public IList<Article> GetByMarque(string marque)
        {
            string query = "SELECT * FROM articles WHERE marque = @marque";

            IDbParameters parameters = CreateDbParameters();
            parameters.Add("marque", DbType.String).Value = marque;

            return AdoTemplate.QueryWithRowMapper<Article>(System.Data.CommandType.Text, query,
                new ArticleRowData(), parameters);
        }



















        #endregion
    }
}