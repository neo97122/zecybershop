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
using Commerce.Metier.Entite;
/// <summary>
/// Description résumée de LoginService
/// </summary>
namespace Commerce.Metier.Service
{
    public class LoginService
    {
        public Client login(string login, string password)
        {
            ClientDAO clientDao = new ClientDAO();
            return clientDao.getClient(login, password);

        }

		public Client create(string Nom, string Prenom, string Login, string Password, string AdresseF, string AdresseL, string Codepostal, string Ville, string Telephone, string Mail)
        {
            ClientDAO client = new ClientDAO();
			return client.setClient(Nom, Prenom, Login, Password, AdresseF, AdresseL, Codepostal, Ville, Telephone, Mail);

        }
        public LoginService()
        {
            //
            // TODO : ajoutez ici la logique du constructeur
            //
        }
    }
}
