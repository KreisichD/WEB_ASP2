using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class SecretFolder_ProtectedForm : System.Web.UI.Page
{
	protected void Page_Load(object sender, EventArgs e)
	{
		if(Session["logged"] == null)
		{
			Response.Redirect("Index.aspx");
		}
	}

	protected void Button1_Click(object sender, EventArgs e)
	{
		Response.Redirect("AddUser.aspx");
	}

	protected void Button2_Click(object sender, EventArgs e)
	{
		Response.Redirect("RemoveUser.aspx");
	}
}