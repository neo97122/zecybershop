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
/// Description résumée de Partie
/// </summary>

namespace Jeudedames.metier
{
    public class Partie
    {
        private int _id_joueur1;
        private int _id_joueur2;
        private string _niveau;

        public int Id_joueur1
        {
            get { return _id_joueur1; }
            set { _id_joueur1 = value; }
        }

                public int Id_joueur2
        {
            get { return _id_joueur2; }
            set { _id_joueur2 = value; }
        }

        public string Niveau
        {
            get { return _niveau; }
            set { _niveau = value; }
        } 

        public Partie(int Id_joueur1, int Id_joueur2, string Niveau)
        {
            Id_joueur1 = _id_joueur1;
            Id_joueur2 = _id_joueur2;
            Niveau = _niveau;
        }
    }
}