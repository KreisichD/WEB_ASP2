using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Objects : System.Web.UI.Page
{
	protected void Page_Load(object sender, EventArgs e)
	{
		DataClassesDataContext dtContext = new DataClassesDataContext();
		GridView1.DataSource = LinqDataSource1;

		GridView1.DataBind();
	}

	protected void LinqDataSource1_Selecting(object sender, LinqDataSourceSelectEventArgs e)
	{

	}

	protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
	{

	}
}