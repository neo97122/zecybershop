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
/// Description résumée de Adresse
/// </summary>
/// 
namespace Commerce.Metier.Entite
{
    public class Adresse
    {
        public Adresse(int id, string typeAdresse, string codepostal, string libelleAdresse, int idClientAdresse, string ville)
        {
            this.Id = id;
            this.TypeAdresse = typeAdresse;
            this.Codepostal = codepostal;
            this.LibelleAdresse = libelleAdresse;
            this.IdClientAdresse = idClientAdresse;
            this.Ville = ville;
        }


        private string ville;

        public string Ville
        {
            get { return ville; }
            set { ville = value; }
        }


        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private string typeAdresse;

        public string TypeAdresse
        {
            get { return typeAdresse; }
            set { typeAdresse = value; }
        }
        private string codepostal;

        public string Codepostal
        {
            get { return codepostal; }
            set { codepostal = value; }
        }
        private string libelleAdresse;

        public string LibelleAdresse
        {
            get { return libelleAdresse; }
            set { libelleAdresse = value; }
        }

        private int idClientAdresse;

        public int IdClientAdresse
        {
            get { return idClientAdresse; }
            set { idClientAdresse = value; }
        }

    }
}