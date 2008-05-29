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
/// Description résumée de Avis
/// </summary>
/// 
namespace Commerce.Metier.Entite
{
    public class Avis
    {
        public Avis(int id, string avisLibelle, int note, DateTime dateAvis, int idArticleAvis, int idClientAvis)
        {
            this.Id = id;
            this.AvisLibelle = avisLibelle;
            this.Note = note;
            this.DateAvis = dateAvis;
            this.IdArticleAvis = idArticleAvis;
            this.IdClientAvis = idClientAvis;
        }


    
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private string avisLibelle;

        public string AvisLibelle
        {
            get { return avisLibelle; }
            set { avisLibelle = value; }
        }
        private int note;

        public int Note
        {
            get { return note; }
            set { note = value; }
        }
        private DateTime dateAvis;

        public DateTime DateAvis
        {
            get { return dateAvis; }
            set { dateAvis = value; }
        }
        private int idArticleAvis;

        public int IdArticleAvis
        {
            get { return idArticleAvis; }
            set { idArticleAvis = value; }
        }
        private int idClientAvis;

        public int IdClientAvis
        {
            get { return idClientAvis; }
            set { idClientAvis = value; }
        }


    }
}