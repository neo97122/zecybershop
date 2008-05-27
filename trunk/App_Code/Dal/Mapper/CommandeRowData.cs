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
using Spring.Data.Generic;

/// <summary>
/// Description résumée de CommandeRowData
/// </summary>
/// 
namespace Commerce.Dal.Mapper
{
    public class CommandeRowData : IRowMapper<Commande>
    {
        #region IRowMapper Membres

        public Commande MapRow(System.Data.IDataReader reader, int rowNum)
        {
            Commande commande = new Commande();
            commande.Reference = (string)reader["REFERENCE"];
            commande.NomClient = (string)reader["NOMCLIENT"];

            return commande;
        }
    }
}