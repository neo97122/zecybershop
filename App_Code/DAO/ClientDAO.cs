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
using  Commerce.Service;
using  Commerce.Metier.Entite;


/// <summary>
/// Description résumée de ClientDAO
/// </summary>
/// 

namespace Commerce.DAO
{
    public class ClientDAO
    {
        public ClientDAO()
        {
            //
            // TODO : ajoutez ici la logique du constructeur
            //
        }

        public Client getClient(string login, string password)
        {
            SqlConnection cnx = new SqlConnection();
            cnx.ConnectionString = "Data Source = localhost; Initial Catalog = COMMERCE; User Id = sa; Password = ;";
            try
            {
                cnx.Open();
                SqlCommand cmd = cnx.CreateCommand();
                cmd.CommandText = "SELECT * FROM CLIENT WHERE Login ='" + login + "' AND mdp ='" + password + "'";
                SqlDataReader dr = cmd.ExecuteReader(); //Select en mode connecté
                return (dr.HasRows) ? new Client(login, password) : null;
            }
            finally { cnx.Close(); }
        }

        public Client setClient(string nom, string prenom, string login, string password, string adresseF, string adresseL, string codepostal, string ville, string telephone, string mail)
        {
            SqlConnection cnx = new SqlConnection();
            cnx.ConnectionString = "Data Source = localhost; Initial Catalog = COMMERCE; User Id = sa; Password = ;";
            try
            {
                cnx.Open();
                SqlCommand cmd = cnx.CreateCommand();
                cmd.CommandText = "INSERT INTO CLIENT (Nom, Prenom, Login, mdp, Telephone, Email, Mobile) "
                + "VALUES('" + nom + "','" + prenom + "','" + login + "','" + password + "',"
                + telephone + ",'" + mail +"'" 
                + ")";
                //Exectiton d'un insert et pas d'une select
                cmd.ExecuteNonQuery();
                //SqlDataReader dr = cmd.ExecuteReader(); //Select en mode connecté

                cmd.CommandText = "INSERT INTO ADDRESS (Address1, Address2, PostalCode) "
                + "VALUES('" + adresseF + "','" + adresseL + "','" + codepostal + "'"
                + ")";
                //Exectiton d'un insert et pas d'une select
                cmd.ExecuteNonQuery();
                return new Client(nom, prenom, login, password, adresseF, adresseL, codepostal, ville, telephone, mail);
            }
            finally { cnx.Close(); }
        }
        public Client Authentifier(string login, string password)
        {

        }
    }
}