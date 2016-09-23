using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DayCalculator : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            calMyCalendar.VisibleDate = DateTime.Today;
        }
    }

    protected void btnBack_Click(object sender, EventArgs e)
    {
        calMyCalendar.VisibleDate = calMyCalendar.VisibleDate.AddYears(-1);
    }

    protected void btnForward_Click(object sender, EventArgs e)
    {
        calMyCalendar.VisibleDate = calMyCalendar.VisibleDate.AddYears(1);
    }

    protected void calMyCalendar_SelectionChanged(object sender, EventArgs e)
    {
        selectedDate.InnerHtml = calMyCalendar.SelectedDate.ToShortDateString();
        TimeSpan dif = DateTime.Today - calMyCalendar.SelectedDate;
        DateTime refDate = new DateTime(1, 1, 1);
        int y = (refDate + dif).Year - refDate.Year;
        int m = (refDate + dif).Month - refDate.Month;
        int d = (refDate + dif).Day - refDate.Day;
        dateDifference.InnerHtml = string.Format("years: {0}, months: {1}, days: {2}", y, m, d);
    }
}