using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CodeSite : System.Web.UI.Page
{
    private CheckBoxList[] checkBoxLists;

    protected void Page_Load(object sender, EventArgs e)
    {
        Initialize();

        for (int i = 0; i < categoriesRBL.Items.Count; i++)
        {
            if (categoriesRBL.Items[i].Selected)
            {
                foreach (CheckBoxList check in checkBoxLists)
                    check.Visible = false;
                checkBoxLists[i].Visible = true;
            }
        }

        if (Session["selected"] != null)
            cartLabel.Text = "Cart: " + Session["selected"];
        else cartLabel.Text = "Cart";
    }

    protected void AddBtn_Click(object sender, EventArgs e)
    {
        if (Session["cartItems"] == null)
            Session.Add("cartItems", new HashSet<CartItem>());

        for (int i = 0; i < categoriesRBL.Items.Count; i++)
        {
            if (categoriesRBL.Items[i].Selected)
            {
                for (int j = 0; j < checkBoxLists[i].Items.Count; j++)
                {
                    if (checkBoxLists[i].Items[j].Selected)
                    {
                        ((HashSet<CartItem>)Session["cartItems"]).Add(DataSingleton.getInstance().CartItems[i][j]);
                    }
                }
            }
        }

        int n = ((HashSet<CartItem>)Session["cartItems"]).Count;

        if (n > 0)
            Session.Add("selected", n);
        else Session.Add("selected", null);
        Response.Redirect(Request.RawUrl);
    }

    private void Initialize()
    {
        Title = "Code Site";
        CheckBoxList[] tmp = { jsCBL, pyCBL, javaCBL, csCBL };

        for (int i = 0; i < tmp.Length; i++)
        {
            CartItem[] items = DataSingleton.getInstance().CartItems[i];

            for (int j = 0; j < items.Length; j++)
            {
                tmp[i].Items[j].Text = items[j].getInfo();
            }
        }

        checkBoxLists = tmp;
    }
}