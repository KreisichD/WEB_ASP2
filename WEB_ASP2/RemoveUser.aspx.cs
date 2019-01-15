using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _RemoveUser : System.Web.UI.Page
{
	protected void Page_Load(object sender, EventArgs e)
	{
		if (Session["logged"] == null)
		{
			Response.Redirect("Index.aspx");
		}


	}

	protected void Button1_Click(object sender, EventArgs e)
	{
		DataClassesDataContext db = new DataClassesDataContext();

		Int32 id = Int32.Parse(TextBox1.Text);
		uzytkownik user = db.uzytkownik.SingleOrDefault(us => us.Id == id);

		db.uzytkownik.DeleteOnSubmit(user);
		db.SubmitChanges();


		Response.Redirect("ProtectedForm.aspx");
	}
}