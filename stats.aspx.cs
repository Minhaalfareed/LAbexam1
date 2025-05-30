using System;

namespace LAbexam1
{
    public partial class Stats : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int total = Application["TotalSubmissions"] != null ? (int)Application["TotalSubmissions"] : 0;
            lblTotalSubmissions.Text = "Total Feedback Submissions: " + total;

            if (Session["LastEmail"] != null)
                lblLastEmail.Text = "Last Email Used in This Session: " + Session["LastEmail"].ToString();
            else
                lblLastEmail.Text = "No email stored in session.";
        }
    }
}
