using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class WindowCalculator : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnCalculate_Click(object sender, EventArgs e)
    {
        // cm -> m
        float w = float.Parse(txtWidth.Text) / 100;
        float h = float.Parse(txtHeight.Text) / 100;
        float b = float.Parse(txtBorderWidth.Text) / 100;

        txtArea.Text = CalcArea(w, h).ToString();
        txtCirc.Text = CalcBorderCirc(w, h, b).ToString();
        txtPrice.Text = CalcPrice(w, h, b).ToString();
    }

    private float CalcArea(float w, float h)
    {
        return w * h;
    }

    private float CalcBorderCirc(float w, float h, float b)
    {
        //return 2 * (w + 2 * b) + 2 * (h + 2 * b);
        //return 2 * w + 4 * b + 2 * h + 4 * b;
        //return 2 * w + 2 * h + 8 * b;
        return 2 * (w + h + 4 * b);
    }

    private float CalcPrice(float w, float h, float b)
    {
        //(1 + kate%) x ((IkkunanPintaAla x LasinNeliohinta) + (KarminPiiri x AlumiiniKarminJuoksumetriHinta) + (Työmenekki))

        float squarePrice = float.Parse(ConfigurationManager.AppSettings["squarePrice"]);
        float borderPrice = float.Parse(ConfigurationManager.AppSettings["borderPrice"]);
        float work = float.Parse(ConfigurationManager.AppSettings["work"]);
        float profit = float.Parse(ConfigurationManager.AppSettings["profit"]);

        float windowCost = CalcArea(w, h) * squarePrice;
        float borderCost = CalcBorderCirc(w, h, b) * borderPrice;

        return (1.0f + profit) * (windowCost + borderCost + work);
    }
}