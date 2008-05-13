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
using Jeudedames.metier;
/// <summary>
/// Description résumée de LoginService
/// </summary>

namespace Jeudedames.service
{
    public class LoginService
    {
        public Joueur login(string login, string password)
        {
            JoueurDAO joueurDao = new JoueurDAO();
            return joueurDao.getJoueur(login, password);
    
        }

        public Joueur create(string login, string nom, string prenom, int age, string password, string sexe, string niveau, int nbvictoires, int nbdefaites, int nbparties)
        {
            JoueurDAO joueur = new JoueurDAO();
            return joueur.setJoueur(login, nom, prenom, age, password, sexe, niveau, nbvictoires, nbdefaites, nbparties);

        }
        public LoginService()
        {
            //
            // TODO : ajoutez ici la logique du constructeur
            //
        }
    }
}