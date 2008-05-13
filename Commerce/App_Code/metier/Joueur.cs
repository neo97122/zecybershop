using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using Jeudedames.DAO;
using Jeudedames.service;
/// <summary>
/// Description résumée de Joueur
/// </summary>
/// 
namespace Jeudedames.metier 
{
    public class Joueur
    {
        private string _login;
        private string _password;
        private string _nom;
        private string _prenom;
        private string _niveau;
        private int _age;
        private string _sexe;


        public string Login
        {
            get { return _login; }
            set { _login = value; }
        }

        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }
        
        public string Nom
        {
            get { return _nom; }
            set { _nom = value; }
        }

        public string Prenom
        {
            get { return _prenom; }
            set { _prenom = value; }
        }
        
        public string Niveau
        {
            get { return _niveau; }
            set { _niveau = value; }
        }
        
        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public string Sexe
        {
            get { return _sexe; }
            set { _sexe = value; }
        }
        

	    public Joueur(string Login, string Password, string Nom, string Prenom, int Age, string Sexe, string Niveau)
	    {
            Login = _login;
            Password = _password;
            Nom = _nom;
            Prenom = _prenom;
            Niveau = _niveau;
            Age = _age;
            Sexe = _sexe;
	    }

        public Joueur()
        {

        }

        public Joueur(string Login, string Password)
        {
            Login = _login;
            Password = _password;
        }
    }
}
