using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class _Login : System.Web.UI.Page
{
	SqlCommand cmd = new SqlCommand();
	SqlConnection con = new SqlConnection();
	SqlDataAdapter sda = new SqlDataAdapter();
	System.Data.DataSet ds = new System.Data.DataSet();

	protected void Page_Load(object sender, EventArgs e)
	{
		if (Session["logged"] != null)
		{
			Label1.Text = "Logged out";
			Session.Remove("logged");
		}

		DataClassesDataContext db = new DataClassesDataContext();
		con.ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=DataBase;Integrated Security=True";
		con.Open();
	}


	protected void Button1_Click1(object sender, EventArgs e)
	{
		cmd.CommandText = "select * from uzytkownik where Email = '" + TextBox2.Text + "' and Password = '" + TextBox1.Text + "'";
		cmd.Connection = con;
		sda.SelectCommand = cmd;
		sda.Fill(ds, "reg");
		if (ds.Tables[0].Rows.Count > 0)
		{
			Session.Add("logged", true);
			Response.Redirect("Index.aspx");
		}
		else
		{
			Label1.Text = "Login failed";
		}
	}

	protected void TextBox1_TextChanged(object sender, EventArgs e)
	{

	}

	protected void TextBox2_TextChanged(object sender, EventArgs e)
	{

	}
}