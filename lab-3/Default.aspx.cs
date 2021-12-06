using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {}

    protected void Btn_calc_Click(object sender, EventArgs e)
    {
        float weight = float.Parse(tb_weight.Text);
        float result = weight * 1.35f * 0.7f;
        Lb_result1.Text = "Cognac " + Math.Round(result / 0.4f) + "   gr.   " ;
        float hour = weight * 0.15f * 0.7f;
        Lb_result1.Text += "<i>" + Math.Round(hour / 0.4F) + "  gr./h. " + "</i>";
        Lb_result2.Text = "Port wine " + Math.Round(result / 0.19f) + "   gr.   ";
        Lb_result2.Text += "<i>" + Math.Round(hour / 0.19F) + "  gr./h. " + "</i>";
        Lb_result3.Text = "Dry wine " + Math.Round(result / 0.12f) + "   gr.   ";
        Lb_result3.Text += "<i>" + Math.Round(hour / 0.12F) + "  gr./h. " + "</i>";
        Lb_result4.Text = "Beer " + Math.Round(result / 0.06f) + "   gr.   ";
        Lb_result4.Text += "<i>" + Math.Round(hour / 0.06F) + "  gr./h. " + "</i>";
    }
}