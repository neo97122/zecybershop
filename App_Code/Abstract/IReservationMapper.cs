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
/// Description résumée de IReservationMapper
/// </summary>
/// 
namespace Commerce.Abstract
{
    interface IReservationMapper
    {
        Reservation GetById(string id);
        Reservation GetByLogin(string login);
        int GetCount();

    }
}
