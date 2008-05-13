using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

/// <summary>
/// Description résumée de Plateau
/// </summary>
public class Plateau
{
    private Image[,] plateauDeJeu;


	public Plateau()
	{
        plateauDeJeu = new Image[11, 11];
	}

    public void ajoutePion(Image pion, int row, int cell)
    {
        plateauDeJeu[row, cell] = pion;
    }

    public Image getImage(int row, int cell)
    {
        return plateauDeJeu[row, cell];
    }

    public void movePion(string idPion, string idCase)
    {
        int row = Convert.ToInt32(idCase.Substring(1, 1));
        int cell = Convert.ToInt32(idCase.Substring(3, 1));

        for (int i = 0; i < 10; ++i)
            for (int j = 0; j < 10; ++j)
                if (null != plateauDeJeu[i, j])
                    if (plateauDeJeu[i, j].ID == idPion)
                    {
                        Image tmpImg = plateauDeJeu[i, j];
                        plateauDeJeu[i, j] = null;
                        plateauDeJeu[row, cell] = tmpImg;
                    }
    }
}
