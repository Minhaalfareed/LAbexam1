using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

namespace LAbexam1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\MINAHIIL FAREED\source\repos\LAbexam1\App_Data\Database1.mdf';Integrated Security=True");

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                disp_data();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Table1 (StudentName, CourseName, PhoneNumber, Comments) VALUES (@StudentName, @CourseName, @PhoneNumber, @Comments)", Con);
            cmd.Parameters.AddWithValue("@StudentName", txtFirstName.Text);
            cmd.Parameters.AddWithValue("@CourseName", txtCourseName.Text);
            cmd.Parameters.AddWithValue("@PhoneNumber", txtPhoneNumber.Text);
            cmd.Parameters.AddWithValue("@Comments", txtComments.Text);
            cmd.ExecuteNonQuery();
            Con.Close();

            ClearFields();
            disp_data();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            disp_data();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM Table1 WHERE PhoneNumber = @PhoneNumber", Con);
            cmd.Parameters.AddWithValue("@PhoneNumber", txtPhoneNumber.Text);
            cmd.ExecuteNonQuery();
            Con.Close();

            ClearFields();
            disp_data();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE Table1 SET StudentName = @StudentName, CourseName = @CourseName, Comments = @Comments WHERE PhoneNumber = @PhoneNumber", Con);
            cmd.Parameters.AddWithValue("@StudentName", txtFirstName.Text);
            cmd.Parameters.AddWithValue("@CourseName", txtCourseName.Text);
            cmd.Parameters.AddWithValue("@PhoneNumber", txtPhoneNumber.Text);
            cmd.Parameters.AddWithValue("@Comments", txtComments.Text);
            cmd.ExecuteNonQuery();
            Con.Close();

            ClearFields();
            disp_data();
        }

        public void disp_data()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Table1", Con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
            Con.Close();
        }

        private void ClearFields()
        {
            txtFirstName.Text = "";
            txtCourseName.Text = "";
            txtPhoneNumber.Text = "";
            txtComments.Text = "";
        }
    }
}
