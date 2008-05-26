using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using Commerce.DAO;
using Commerce.Service;
using Commerce.Metier;

/// <summary>
/// Description résumée de Client
/// </summary>
/// 

namespace Commerce.Metier.Entite
{
    public class Client
    {
        public Client()
        {
            //
            // Constructeur vide
            //
        }

        public Client(string login, string password)
        {
            this.Login = login;
            this.Password = password;
        }

        public Client(string nom, string prenom, string login, string password, string adresseF, string adresseL, string codepostal, string ville, string telephone, string mail)
        {
            this.Nom = nom;
            this.Prenom = prenom;
            this.Login = login;
            this.Password = password;
            this.AdresseF = adresseF;
            this.AdresseL = adresseL;
            this.Codepostal = codepostal;
            this.Ville = ville;
            this.Telephone = telephone;
            this.Mail = mail;
        }

        private string nom;

        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }
        private string prenom;

        public string Prenom
        {
            get { return prenom; }
            set { prenom = value; }
        }
        private string login;

        public string Login
        {
            get { return login; }
            set { login = value; }
        }
        private string password;

        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        private string adresseF;

        public string AdresseF
        {
            get { return adresseF; }
            set { adresseF = value; }
        }
        private string adresseL;

        public string AdresseL
        {
            get { return adresseL; }
            set { adresseL = value; }
        }

        private string codepostal;

        public string Codepostal
        {
            get { return codepostal; }
            set { codepostal = value; }
        }
        private string ville;

        public string Ville
        {
            get { return ville; }
            set { ville = value; }
        }
        private string telephone;

        public string Telephone
        {
            get { return telephone; }
            set { telephone = value; }
        }

        private string mail;

        public string Mail
        {
            get { return mail; }
            set { mail = value; }
        }
    }
}