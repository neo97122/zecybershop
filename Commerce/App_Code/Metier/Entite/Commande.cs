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
/// Description résumée de Commande
/// </summary>
/// 
namespace Commerce.Metier.Entite
{
    public class Commande
    {
        public Commande(int id, int idClientCommande, DateTime dateCommande, float montantTotal, bool isVente, DateTime dateVente)
        {
            this.Id = id;
            this.IdClientCommande = idClientCommande;
            this.DateCommande = dateCommande;
            this.MontantTotal = montantTotal;
            this.IsVente = IsVente;
            this.DateVente = dateVente;
        }


    

        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private int idClientCommande;

        public int IdClientCommande
        {
            get { return idClientCommande; }
            set { idClientCommande = value; }
        }
        private DateTime dateCommande;

        public DateTime DateCommande
        {
            get { return dateCommande; }
            set { dateCommande = value; }
        }
        private float montantTotal;

        public float MontantTotal
        {
            get { return montantTotal; }
            set { montantTotal = value; }
        }
        private bool isVente;

        public bool IsVente
        {
            get { return isVente; }
            set { isVente = value; }
        }
        private DateTime dateVente;

        public DateTime DateVente
        {
            get { return dateVente; }
            set { dateVente = value; }
        }


    }
}