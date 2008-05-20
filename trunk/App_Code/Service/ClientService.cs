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
using Commerce.Service;

/// <summary>
/// Description résumée de ClientService
/// </summary>
/// 

namespace Commerce.Service
{
    public class ClientService
    {
        public ClientService()
        {
            //
            // TODO : ajoutez ici la logique du constructeur
            //
        }

        public Client login(string login, string password)
        {
            ClientDAO clientDao = new clientDAO();
            return clientDao.getClient(login, password);

        }

        public Client create(string nom, string prenom, string login, string password, string adresseF, string adresseL, string codepostal, string ville, string telephone, string mail)
        {
            ClientDAO client = new ClientDAO();
            return client.setClient(nom, prenom, login, password, adresseF, adresseL, codepostal, ville, telephone, mail);

        }
    }
}