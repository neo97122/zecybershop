using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using Jeudedames.metier;
using Jeudedames.DAO;
using Jeudedames.service;

/// <summary>
/// Description résumée de JoueurDAO
/// </summary>

namespace Jeudedames.DAO
{
    public class JoueurDAO
    {
        /*
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
        private string _passwordVerif;

        public string PasswordVerif
        {
            get { return _passwordVerif; }
            set { _passwordVerif = value; }
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
        private int _age;

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }
        private string _niveau;

        public string Niveau
        {
            get { return _niveau; }
            set { _niveau = value; }
        }
        private string _sexe;

        public string Sexe
        {
            get { return _sexe; }
            set { _sexe = value; }
        }
        */
        public JoueurDAO()
        {
            //
            // TODO : ajoutez ici la logique du constructeur
            //
        }

        public Joueur getJoueur(string login, string password)
        {

            SqlConnection cnx = new SqlConnection();
            cnx.ConnectionString = "Data Source = localhost; Initial Catalog = jeudedames; User Id = sa; Password = systemadmin;";
            try
            {
                cnx.Open();
                SqlCommand cmd = cnx.CreateCommand();
                cmd.CommandText = "SELECT * FROM joueur WHERE login ='" + login + "' AND password ='" + password + "'";
                SqlDataReader dr = cmd.ExecuteReader(); //Select en mode connecté
                return (dr.HasRows) ? new Joueur(login, password) : null;
            }
            finally { cnx.Close(); }
        }

        public Joueur setJoueur(string login, string nom, string prenom, int age, string password, string sexe, string niveau, int nbvictoires, int nbdefaites, int nbparties)
        {

            SqlConnection cnx = new SqlConnection();
            cnx.ConnectionString = "Data Source = localhost; Initial Catalog = jeudedames; User Id = sa; Password = systemadmin;";
            try
            {
                cnx.Open();
                SqlCommand cmd = cnx.CreateCommand();
                cmd.CommandText = "INSERT INTO joueur (login, nom, prenom, password, age, sexe, niveau, nbvictoires, nbdefaites, nbparties) "
                + "VALUES('" + login + "','" + nom + "','" + prenom + "','" + password + "',"
                + age + ",'" + sexe +"','" + niveau + "'," + 0 + "," + 0 + "," + 0
                + ")";
                //Exectiton d'un insert et pas d'une select
                cmd.ExecuteNonQuery();
                //SqlDataReader dr = cmd.ExecuteReader(); //Select en mode connecté
                return new Joueur(login, password, nom, prenom, age, sexe, niveau);
            }
            finally { cnx.Close(); }
        }

        private bool Authentifier(string strUtilisateur, string strMotDePasse)
        {
            bool bOk = false;
            // Cryptage du mot de passe
            strMotDePasse = FormsAuthentication.HashPasswordForStoringInConfigFile(strMotDePasse, "MD5");
            // Création d'une connexion SGBD
            SqlConnection oConnexion = new SqlConnection("user id=sa;password=;initial catalog=pubs;data source=pttravail");
            // Définition de la requête à exécuter
            SqlCommand oCommand = new SqlCommand("SELECT * FROM joueur WHERE nom='" + strUtilisateur + "'", oConnexion);
            try
            {
                // Ouverture de la connexion et exécution de la requête
                oConnexion.Open();
                SqlDataReader drUtilisateur = oCommand.ExecuteReader();
                // Parcours de la liste des utilisateurs
                while (drUtilisateur.Read())
                {
                    if (drUtilisateur["password"].ToString() == strMotDePasse)
                    {
                        bOk = true; break;
                    }
                }
            }
            catch
            {
                bOk = false;
            }
            oConnexion.Close();
            return bOk;
        }
    }    
}

