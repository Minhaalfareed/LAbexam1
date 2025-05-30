using System;
using System.Data;
using System.Data.SqlClient;

namespace LAbexam1
{
    public partial class helpFeedback : System.Web.UI.Page
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\MINAHIIL FAREED\source\repos\LAbexam1\App_Data\Database1.mdf';Integrated Security=True");

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadFeedbackData();
            }
        }

        private void LoadFeedbackData()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Table1", Con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }
    }
}
