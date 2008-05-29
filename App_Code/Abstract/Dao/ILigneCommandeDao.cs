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
/// Description résumée de ILigneCommandeDao
/// </summary>
/// 
namespace Commerce.Abstract.Dao
{
    public interface ILigneCommandeDao
    {
        IList<LigneCommande> GetByReference(string reference);
        LigneCommande GetByReference(string reference, int numeroLigne);

        void Save(LigneCommande ligneCommande);
    }
}