using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

using Commerce.Metier.Critere;
using Commerce.Metier.Entite;

/// <summary>
/// Description résumée de ICommandeService
/// </summary>
/// 
namespace Commerce.Abstract.Metier.Service
{
public class IAvisService
    {
        public interface IAvisService
        {
            IList<Commande> GetByCritere(CommandeCritere critere);

            void Save(Commande commande);
        }
    }
}