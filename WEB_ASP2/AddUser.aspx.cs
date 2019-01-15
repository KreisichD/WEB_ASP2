using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class _AddUser : System.Web.UI.Page
{

	protected void Page_Load(object sender, EventArgs e)
	{
		if (Session["logged"] == null)
		{
			Response.Redirect("./Index.aspx");
		}

		
		
	}

	protected void Button1_Click(object sender, EventArgs e)
	{
		DataClassesDataContext db = new DataClassesDataContext();
		uzytkownik user = new uzytkownik();
		user.Id = Int32.Parse(IdBox.Text);
		user.FirstName = FirstNameBox.Text;
		user.LastName = LastNameBox.Text;
		user.Password = PasswordBox.Text;
		user.Phone = PhoneBox.Text;
		user.Email = EmailBox.Text;
		user.DateOfBirth = BirthDateBox.SelectedDate;
		db.uzytkownik.InsertOnSubmit(user);

		db.SubmitChanges();
		Response.Redirect("ProtectedForm.aspx");
	}

	protected void TextBox6_TextChanged(object sender, EventArgs e)
	{

	}
}