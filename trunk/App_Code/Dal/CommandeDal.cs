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
/// Description résumée de CommandeDal
/// </summary>
/// 
namespace Commerce.Dal
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