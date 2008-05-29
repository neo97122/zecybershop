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
/// Description résumée de ligneCommande
/// </summary>
/// 
namespace Commerce.Metier.Entite
{
    public class LigneCommande
    {
        public LigneCommande(int id, int idArticleLigneCommande, int idComLigneCommande, int quantite)
        {
            this.Id = id;
            this.IdArticleLigneCommande = idArticleLigneCommande;
            this.IdComLigneCommande = idComLigneCommande;
            this.Quantite = quantite;
        }


    
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        // Cle etrangere vers article
        private int idArticleLigneCommande;

        public int IdArticleLigneCommande
        {
            get { return idArticleLigneCommande; }
            set { idArticleLigneCommande = value; }
        }
        // Cle etrangere vers commande
        private int idComLigneCommande;

        public int IdComLigneCommande
        {
            get { return idComLigneCommande; }
            set { idComLigneCommande = value; }
        }
        private int quantite;

        public int Quantite
        {
            get { return quantite; }
            set { quantite = value; }
        }
    }
}