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

/// <summary>
/// Description résumée de CommandeCritere
/// </summary>
/// 
namespace Commerce.Metier.Critere
{
    public class CommandeCritere
    {
        private string referenceCommande;

        public string ReferenceCommande
        {
            get { return referenceCommande; }
            set { referenceCommande = value; }
        }
        private string referenceArticle;

        public string ReferenceArticle
        {
            get { return referenceArticle; }
            set { referenceArticle = value; }
        }
        private string nomClient;

        public string NomClient
        {
            get { return nomClient; }
            set { nomClient = value; }
        }
    }
}