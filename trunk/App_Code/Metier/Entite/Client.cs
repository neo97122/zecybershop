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

        public Client(string Login, string Password)
        {
            Login = _login;
            Password = _password;
        }

        public Client(string Nom, string Prenom, string Login, string Password, string AdresseF, string AdresseL, string Codepostal, string Ville, string Telephone, string Mail)
        {
            Nom = _nom;
            Prenom = _prenom;
            Login = _login;
            Password = _password;
            AdresseF = _adresseF;
            AdresseL = _adresseL;
            Codepostal = _codepostal;
            Ville = _ville;
            Telephone = _telephone;
            Mail = _mail;
        }

        private string _nom;

        public string Nom
        {
            get { return _nom; }
            set { _nom = value; }
        }
        private string _prenom;

        public string Prenom
        {
            get { return _prenom; }
            set { _prenom = value; }
        }
        private string _login;

        public string Login
        {
            get { return _login; }
            set { _login = value; }
        }
        private string _password;

        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }
        private string _adresseF;

        public string AdresseF
        {
            get { return _adresseF; }
            set { _adresseF = value; }
        }
        private string _adresseL;

        public string AdresseL
        {
            get { return _adresseL; }
            set { _adresseL = value; }
        }

        private string _codepostal;

        public string Codepostal
        {
            get { return _codepostal; }
            set { _codepostal = value; }
        }
        private string _ville;

        public string Ville
        {
            get { return _ville; }
            set { _ville = value; }
        }
        private string _telephone;

        public string Telephone
        {
            get { return _telephone; }
            set { _telephone = value; }
        }

        private string _mail;

        public string Mail
        {
            get { return _mail; }
            set { _mail = value; }
        }
    }
}