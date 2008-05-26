using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

using System.Collections.Generic;
using System.Text;

using Commerce.Metier.Entite;
using System.Data;
using Spring.Data.Core;

using Commerce.Abstract;
using Commerce.Metier.Entite;
using Commerce.Dal.Mapper;


/// <summary>
/// Description résumée de AvisDal
/// </summary>
/// 
namespace Commerce.Dal
{
    public class ClientDal : AdoDaoSupport, IClientMapper
    {
	    public ClientDal()
	    {
		    //
		    // TODO : ajoutez ici la logique du constructeur
		    //
	    }
        

    }
}