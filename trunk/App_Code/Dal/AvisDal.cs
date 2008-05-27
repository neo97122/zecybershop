using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

using Commerce.Abstract.Dao;
using Commerce.Dal.Mapper;
using Commerce.Metier.Entite;
using Spring.Data.Generic;
using Spring.Data.Common;
using System.Data;

/// <summary>
/// Description résumée de AvisDal
/// </summary>
/// 
namespace Commerce.Dal 
{
    public class AvisDal : AdoDaoSupport, IAvisDao
    {
        #region IAvisDao Membres

        public Avis GetByNote(int note)
        {
            string query = "SELECT * FROM AVIS WHERE note = @note";

            IDbParameters parameters = CreateDbParameters();
            parameters.Add("note", DbType.String).Value = note;

            return AdoTemplate.QueryForObject<Avis>(System.Data.CommandType.Text, query,
                new AvisRowMapper(), parameters);
        }

        #endregion
    }
}