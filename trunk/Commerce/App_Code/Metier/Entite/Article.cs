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
/// Description résumée de Article
/// </summary>
/// 
namespace Commerce.Metier.Entite
{
    public class Article
    {
        public Article(int id, string reference, string marque, string categorie, float prixUnitaire, string descCourt, string descLong,int qteStock)
        {
            this.Id = id;
            this.Reference = reference;
            this.Marque = marque;
            this.Categorie = categorie;
            this.PrixUnitaire = prixUnitaire;
            this.DescCourt = descCourt;
            this.DescLong = descLong;
            this.QteStock = qteStock;
        }




        private int qteStock;

        public int QteStock
        {
            get { return qteStock; }
            set { qteStock = value; }
        }

      

        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private string reference;

        public string Reference
        {
            get { return reference; }
            set { reference = value; }
        }
        private string marque;

        public string Marque
        {
            get { return marque; }
            set { marque = value; }
        }
        private string categorie;

        public string Categorie
        {
            get { return categorie; }
            set { categorie = value; }
        }
        private float prixUnitaire;

        public float PrixUnitaire
        {
            get { return prixUnitaire; }
            set { prixUnitaire = value; }
        }
        private string descCourt;

        public string DescCourt
        {
            get { return descCourt; }
            set { descCourt = value; }
        }
        private string descLong;

        public string DescLong
        {
            get { return descLong; }
            set { descLong = value; }
        }
        private int idArticleStock;

        public int IdArticleStock
        {
            get { return idArticleStock; }
            set { idArticleStock = value; }
        }

    }
}