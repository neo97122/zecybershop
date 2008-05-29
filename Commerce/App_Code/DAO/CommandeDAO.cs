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
/// Description résumée de CommandeDAO
/// </summary>
/// 
namespace Commerce.DAO
{

    public class CommandeDal : AdoDaoSupport, ICommandeDao
    {
        #region ICommandeDao Membres

        public Commande GetById(int id)
        {
            string query = "SELECT * FROM COMMANDES WHERE idCommande = @id";

            IDbParameters parameters = CreateDbParameters();
            parameters.Add("idClient", DbType.String).Value = id;

            return AdoTemplate.QueryForObject<Commande>(System.Data.CommandType.Text, query,
                new CommandeRowMapper(), parameters);
        }

        #endregion
    }
}