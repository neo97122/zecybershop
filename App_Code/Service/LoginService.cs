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
using Commerce.Metier;
/// <summary>
/// Description résumée de LoginService
/// </summary>
public class LoginService
{
    public class LoginService
    {
        public Client login(string login, string password)
        {
            ClientDAO clientDao = new ClientDAO();
            return clientDao.getClient(login, password);

        }

        public Client create(string login, string nom, string prenom, int age, string password, string sexe, string niveau, int nbvictoires, int nbdefaites, int nbparties)
        {
            ClientDAO client = new ClientDAO();
            return client.setClient(login, nom, prenom, age, password, sexe, niveau, nbvictoires, nbdefaites, nbparties);

        }
        public LoginService()
        {
            //
            // TODO : ajoutez ici la logique du constructeur
            //
        }
    }
}
