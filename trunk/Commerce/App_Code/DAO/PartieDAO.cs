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
using Jeudedames.service;
/// <summary>
/// Description résumée de PartieDAO
/// </summary>
/// 
namespace Jeudedames.DAO
{
    public class PartieDAO
    {
        public PartieDAO()
        {
            //
            // TODO : ajoutez ici la logique du constructeur
            //
        }
        public void setPartie(int id_vainqueur, int id_perdant, string niveau)
        {

            SqlConnection cnx = new SqlConnection();
            cnx.ConnectionString = "Data Source = localhost; Initial Catalog = jeudedames; User Id = sa; Password = systemadmin;";
            try
            {
                cnx.Open();
                SqlCommand cmd = cnx.CreateCommand();
                cmd.CommandText = "INSERT INTO partie (niveau, id_vainqueur, id_perdant ) "
                + "VALUES('" + niveau + "','" + 0 + "','" + 0 + "','" 
                + ")";
                //Exectiton d'un insert et pas d'une select
                cmd.ExecuteNonQuery();
                //SqlDataReader dr = cmd.ExecuteReader(); //Select en mode connecté
                //return (dr.HasRows) ? new Joueur(login, password, nom, prenom, age, sexe, niveau) : null;
            }
            finally { cnx.Close(); }
        }

        public void closePartie(int id_partie, int id_vainqueur, int id_perdant)
        {

            SqlConnection cnx = new SqlConnection();
            cnx.ConnectionString = "Data Source = localhost; Initial Catalog = jeudedames; User Id = sa; Password = systemadmin;";
            try
            {
                cnx.Open();
                SqlCommand cmd = cnx.CreateCommand();
                cmd.CommandText = "UPDATE partie "
                + "SET id_vainqueur =" + id_vainqueur+ ", id_perdant = "+ id_perdant
                + "WHERE id_partie = " +id_partie
                + ")";

                cmd.ExecuteNonQuery();
            }
            finally { cnx.Close(); }
        }
    }
}