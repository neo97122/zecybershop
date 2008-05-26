﻿using System;
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
/// <summary>
/// Description résumée de IClientMapper
/// </summary>
/// 
namespace Commerce.Abstract
{
    interface IClientMapper
    {
        Client GetById(string id);
        Client GetByLogin(string login);
        int GetCount();

    }
}
