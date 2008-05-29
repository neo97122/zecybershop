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
using Commerce.Metier.Critere;

/// <summary>
/// Description résumée de ICommandeDao
/// </summary>
/// 
namespace Commerce.Abstract.Dao
{
    public interface ICommandeDao
    {

        Commande GetByReference(string reference);
        IList<Commande> GetByCritere(CommandeCritere critere);
        int GetCount();

        void Save(Commande commande);
    }

}